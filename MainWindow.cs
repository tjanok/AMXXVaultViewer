using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DarkUI.Forms;
using DarkUI.Controls;

namespace AMXXVaultViewer
{
    public partial class frmMain : DarkForm
    {
        private String activeFileName;
        DarkListItem selectedListItem;
        private VaultFile vaultFile = new VaultFile();

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load( object sender, EventArgs e )
        {
            // Setup default visiblity on controls
            ToggleButtons();
        }

        private void OpenVaultFile( String fileName )
        {
            if( File.Exists( fileName ) )
            {
                if( !vaultFile.Open( fileName ) )
                {
                    DarkMessageBox.ShowError( "Invalid nVault file opened\nMake sure the vault file is not currently opened on a running server.", "Error" );
                    return;
                }

                // Update UI
                ToggleButtons( true );

                pnlMainContainer.SectionHeader = Path.GetFileName( activeFileName );
                lblEntryCount.Text = "Total Entries: " + vaultFile.NumberOfEntries();

                // Populate listview
                lvEntries.Items.Clear();
                vaultFile.PopulateListView( lvEntries );
                SelectFirstKey();
            }
        }

        #region BUTTON CLICKS
        private void BtnOpen_Click( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string AppPath = Path.GetDirectoryName( Application.ExecutablePath );
            openFileDialog.InitialDirectory = AppPath;

            openFileDialog.Filter = "nVault File|*.vault";
            openFileDialog.FileOk += ( ofdSender, ofdE ) =>
            {
                activeFileName = openFileDialog.FileName;
                OpenVaultFile( openFileDialog.FileName );
            };
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
        }

        private void BtnEntryUpdate_Click( object sender, EventArgs e )
        {
            // update the selected enteries details
            vaultFile.SelectedEntry.key = txtKey.Text;
            vaultFile.SelectedEntry.timestamp = Convert.ToDateTime( txtTimestamp.Text );
            vaultFile.SetValue( txtValue.Text );

            // update listview with modified key
            selectedListItem.Text = txtKey.Text;
        }
        private void BtnEntryExit_Click( object sender, EventArgs e )
        {
            // TODO
            // Ask to save changes??
            Application.Exit();
        }
        #endregion

        private void ToggleButtons( bool makeVisible = false )
        {
            btnClose.Visible            = makeVisible;
            btnReload.Visible           = makeVisible;
            grpEntryInfo.Visible        = makeVisible;
            grpKeys.Visible             = makeVisible;
            lblEntryCount.Visible       = makeVisible;
        }

        private bool ValidateEntryInfo()
        {
            return true;
        }

        private void SelectFirstKey()
        {
            if( lvEntries.Items.Count > 0 )
                lvEntries.SelectItem( 0 );
        }
        private void LblEntryCount_Click( object sender, EventArgs e )
        {

        }

        private void BtnReload_Click( object sender, EventArgs e )
        {
            ToggleButtons();

            vaultFile = new VaultFile();
            lvEntries.Items.Clear();

            OpenVaultFile( activeFileName );
        }

        private void LvEntries_SelectedIndicesChanged( object sender, EventArgs e )
        {
            if( lvEntries.Items.Count > 0 )
            {
                List<int> item = lvEntries.SelectedIndices;
                DarkListItem dItem = lvEntries.Items[item[0]];

                selectedListItem = dItem;

                VaultEntry itemEntry = (VaultEntry)dItem.Tag;
                vaultFile.SelectedEntry = itemEntry;

                this.txtKey.Text = itemEntry.key;
                this.txtValue.Text = vaultFile.GetValue();

                DateTime timestamp = itemEntry.timestamp;
                this.txtTimestamp.Text = timestamp.ToString();

                Console.WriteLine( VaultFile.ConvertFromDateTime( timestamp ) );
            }
        }

        private void BtnClose_Click( object sender, EventArgs e )
        {
            pnlMainContainer.SectionHeader = "No File Loaded";
            ToggleButtons();
            vaultFile = new VaultFile();
            lvEntries.Items.Clear();
        }

        private void GrpEntryInfo_Enter( object sender, EventArgs e )
        {

        }

        private void DarkButton2_Click( object sender, EventArgs e )
        {

        }

        private void BtnFindKey_Click( object sender, EventArgs e )
        {
            StringBuilder sb = new StringBuilder();
            SearchBox searchBox = new SearchBox( sb );

            searchBox.StartPosition = FormStartPosition.Manual;
            searchBox.SetDesktopLocation( Cursor.Position.X, Cursor.Position.Y );
            searchBox.ShowDialog();

            Console.WriteLine( "S: " + sb.ToString() );

            foreach( DarkListItem item in this.lvEntries.Items )
            {
                if( item.Text == sb.ToString() )
                {
                    this.lvEntries.SelectItem( this.lvEntries.Items.IndexOf( item ) );
                }
            }
        }

        private void BtnEntryTimeUpdate_Click( object sender, EventArgs e )
        {
        }

    }
}
