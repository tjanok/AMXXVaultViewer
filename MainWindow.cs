using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using DarkUI.Forms;
using DarkUI.Controls;

namespace AMXXVaultViewer
{
    public partial class frmMain : DarkForm
    {
        private String activeFileName;
        DarkListItem selectedListItem;
        private VaultFile vaultFile = new VaultFile();

        // UI Sounds
        SoundPlayer sndSuccess = new SoundPlayer( Properties.Resources.bell1 );

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
                //OpenVaultFile( openFileDialog.FileName );
                vaultFile.Save( openFileDialog.FileName );
            };
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
        }
        private void BtnAbout_Click( object sender, EventArgs e )
        {
            DarkMessageBox.ShowInformation( $"{System.AppDomain.CurrentDomain.FriendlyName}\nwww.github.com/tjanok", "About" );
        }

        private void BtnEntryUpdate_Click( object sender, EventArgs e )
        {
            // update the selected enteries details
            vaultFile.SelectedEntry.key = txtKey.Text;
            vaultFile.SetValue( txtValue.Text );

            // update listview with modified key
            selectedListItem.Text = txtKey.Text;

            sndSuccess.Play();
        }
        private void BtnEntryExit_Click( object sender, EventArgs e )
        {
            // TODO
            // Ask to save changes??
            Application.Exit();
        }
        private void BtnAddEntry_Click( object sender, EventArgs e )
        {
            VaultEntry vaultEntry = new VaultEntry();
            int indexNum = GetNextFreeIndex();

            vaultEntry.key = $"new_key-{indexNum}";
            vaultEntry.timestamp = 0;

            vaultFile.AddEntry( vaultEntry, "" );

            DarkListItem item = new DarkListItem( vaultEntry.key );
            item.Tag = vaultEntry;

            lvEntries.Items.Add( item );
            lvEntries.SelectItem( lvEntries.Items.Count - 1 );

        }
        #endregion

        private void ToggleButtons( bool makeVisible = false )
        {
            btnAbout.Visible            = makeVisible;
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

        private int GetNextFreeIndex()
        {
            return lvEntries.Items.Count + 1;
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

                if( itemEntry.timestamp != 0 )
                    txtTimestamp.Text = VaultFile.ConvertFromUnixTime( itemEntry.timestamp ).ToString();
                else
                    txtTimestamp.Text = "Permanent";
            }
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
