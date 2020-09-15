using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using DarkUI.Forms;
using DarkUI.Controls;
using System.Drawing;

namespace AMXXVaultViewer
{
    public partial class MainWindow : DarkForm
    {
        #region PRIVATE VARS
        String selectedFileName;
        DarkListItem selectedListItem;
        VaultFile vaultFile;

        // Searching
        DarkListItem searchListItem;
        String previousSearch;

        // UI Sounds
        SoundPlayer sndSuccess = new SoundPlayer( Properties.Resources.bell1 );
        SoundPlayer sndFailed = new SoundPlayer( Properties.Resources.button2 );
        #endregion

        public static MainWindow mainWindow;

        public MainWindow()
        {
            mainWindow = this;
            InitializeComponent();
        }

        private void FrmMain_Load( object sender, EventArgs e )
        {
            // Setup default visiblity on controls
            ToggleButtons();
        }

        #region PUBLIC METHODS
        public void PruneEntries( DateTime start, DateTime end )
        {
            // make sure we are selecting a positive date range
            // or if we are pruning todays date
            if( end.Subtract( start ).TotalSeconds > 1 || ( start.Date == DateTime.Now.Date && end.Date == DateTime.Now.Date ) )
            {
                int pruned = vaultFile.PruneEntries( start, end );
                DarkMessageBox.ShowInformation( $"Pruned {pruned} total entieries from the vault", "Pruning" );
            }
        }
        #endregion

        #region BUTTON CLICKS
        private void BtnOpen_Click( object sender, EventArgs e )
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string AppPath = Path.GetDirectoryName( Application.ExecutablePath );
            openFileDialog.InitialDirectory = AppPath;

            openFileDialog.Filter = "nVault File|*.vault";
            openFileDialog.FileOk += ( ofdSender, ofdE ) =>
            {
                selectedFileName = openFileDialog.FileName;
                OpenVaultFile( openFileDialog.FileName );
            };
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
        }
        private void BtnAbout_Click( object sender, EventArgs e )
        {
            DarkMessageBox.ShowInformation( $"{System.AppDomain.CurrentDomain.FriendlyName}\nVersion: {Properties.Settings.Default.Version}\nwww.github.com/tjanok", "About" );
        }
        private void BtnPruneEntries_Click( object sender, EventArgs e )
        {
            PruneWindow pruneWindow = new PruneWindow();
            pruneWindow.Show();
        }
        private void BtnEntryUpdate_Click( object sender, EventArgs e )
        {
            if( !ValidateEntryInfo() )
            {
                sndFailed.Play();
                return;
            }
            // update the selected enteries details
            vaultFile.SelectedEntry.key = txtKey.Text;
            vaultFile.SetValue( txtValue.Text );

            // update listview with modified key
            selectedListItem.Text = txtKey.Text;

            // fiddle sticks
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

        private void BtnReload_Click( object sender, EventArgs e )
        {
            ToggleButtons();

            vaultFile = new VaultFile();
            lvEntries.Items.Clear();

            OpenVaultFile( selectedFileName );
        }

        private void BtnFindKey_Click( object sender, EventArgs e )
        {
            Search();

        }

        private void BtnEntryTimeUpdate_Click( object sender, EventArgs e )
        {
            vaultFile.SelectedEntry.timestamp = VaultFile.ConvertFromDateTime( DateTime.Now );
            UpdateTimestamp( vaultFile.SelectedEntry );
        }

        private void BtnEntrySave_Click( object sender, EventArgs e )
        {
            if( selectedFileName.Length == 0 )
                return;

            if( vaultFile.Save( selectedFileName ) )
                sndSuccess.Play();
            else
            {
                sndFailed.Play();
                DarkMessageBox.ShowError( "Failed to save vault file", "Error" );
            }
        }
        private void BtnEntryDelete_Click( object sender, EventArgs e )
        {
            if( vaultFile.SelectedEntry != null )
            {
                if( DarkMessageBox.ShowInformation( "Are you sure you wish to delete this entry?", "Continue", DarkDialogButton.YesNo ) == DialogResult.Yes )
                {
                    vaultFile.DeleteEntry( vaultFile.SelectedEntry );
                    lvEntries.Items.Remove( selectedListItem );
                    SelectFirstKey();
                }
            }
        }
        #endregion

        #region EVENTS
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

                UpdateTimestamp( itemEntry );
            }
        }
        private void MainWindow_KeyDown( object sender, KeyEventArgs e )
        {
            if( ( e.Control && e.KeyCode == Keys.F ) || ( e.Control && e.KeyCode == Keys.S ) )
            {
                if( selectedFileName != null && vaultFile != null )
                    Search();
            }
        }
        #endregion

        #region PRIVATE FUNCTIONS
        private void Search()
        {
            StringBuilder sb = new StringBuilder();
            SearchBox searchBox = new SearchBox( sb, previousSearch );

            searchBox.StartPosition = FormStartPosition.Manual;
            searchBox.SetDesktopLocation( Cursor.Position.X, Cursor.Position.Y );
            searchBox.ShowDialog();

            bool found = false;
            int startIndex = 0;
            String searchValue = sb.ToString();

            if( searchListItem != null )
                startIndex = lvEntries.Items.IndexOf( searchListItem );

            for( int i = startIndex + 1; i < lvEntries.Items.Count; i++ )
            {
                if( lvEntries.Items[i].Text.Contains( searchValue ) )
                {
                    searchListItem = lvEntries.Items[i];
                    lvEntries.SelectItem( i );
                    previousSearch = searchValue;
                    found = true;
                    break;
                }
            }

            if( !found )
                sndFailed.Play();
        }
        private void OpenVaultFile( String fileName )
        {
            if( File.Exists( fileName ) )
            {
                vaultFile = new VaultFile();

                if( !vaultFile.Open( fileName ) )
                {
                    DarkMessageBox.ShowError( "Invalid nVault file opened\nMake sure the vault file is not currently opened on a running server.", "Error" );
                    return;
                }

                // Update UI
                ToggleButtons( true );
                lvEntries.Items.Clear();

                pnlMainContainer.SectionHeader = Path.GetFileName( selectedFileName );
                lblEntryCount.Text = "Total Entries: " + vaultFile.NumberOfEntries();

                // Populate listview
                vaultFile.PopulateListView( lvEntries );
                SelectFirstKey();
            }
        }

        private void UpdateTimestamp( VaultEntry itemEntry )
        {
            if( itemEntry.timestamp != 0 )
                txtTimestamp.Text = $"{itemEntry.timestamp.ToString()} ({VaultFile.ConvertFromUnixTime( itemEntry.timestamp ).ToString( "MMM dd, yyyy" )})";
            else
                txtTimestamp.Text = "Permanent";
        }
        private bool ValidateEntryInfo()
        {
            if( vaultFile.SelectedEntry == null )
                return false;

            if( RemoveWhiteSpace( txtKey.Text ).Length == 0 )
            {
                txtKey.Focus();
                return false;
            }

            if( RemoveWhiteSpace( txtValue.Text ).Length == 0 )
            {
                txtValue.Focus();
                return false;
            }

            return true;
        }

        private String RemoveWhiteSpace( String value )
        {
            return new String( value.ToCharArray().Where( c => !Char.IsWhiteSpace( c ) ).ToArray() );
        }
        private void SelectFirstKey()
        {
            if( lvEntries.Items.Count > 0 )
                lvEntries.SelectItem( 0 );
        }

        private int GetNextFreeIndex()
        {
            int index = 0;

            for( int i = 0; i < lvEntries.Items.Count; i++ )
            {
                if( lvEntries.Items[i].Text.Contains( "-" ) )
                {
                    int found = lvEntries.Items[i].Text.IndexOf( '-' );
                    if( found > 0 )
                    {
                        int newIndex = Convert.ToInt16( lvEntries.Items[i].Text.Substring( found + 1 ) );
                        if( newIndex > index )
                            index = newIndex;
                    }

                }
            }

            return index + 1;
        }
        private void ToggleButtons( bool makeVisible = false )
        {
            btnAbout.Visible = makeVisible;
            btnReload.Visible = makeVisible;
            grpEntryInfo.Visible = makeVisible;
            grpKeys.Visible = makeVisible;
            lblEntryCount.Visible = makeVisible;
        }
        #endregion
    }
}
