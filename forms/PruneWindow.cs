using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarkUI.Forms;

namespace AMXXVaultViewer
{
    public partial class PruneWindow : DarkForm
    {
        public PruneWindow()
        {
            InitializeComponent();
        }

        private void PruneWindow_Load( object sender, EventArgs e )
        {
            this.CenterToScreen();
        }

        private void BtnQuit_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void PruneWindow_KeyDown( object sender, KeyEventArgs e )
        {
            if( e.KeyCode == Keys.Escape )
                this.Close();
        }

        private void BtnPrune_Click( object sender, EventArgs e )
        {
            if( DarkMessageBox.ShowWarning( "Are you sure you wish to prune the selected date range?", "Continue", DarkDialogButton.YesNo ) == DialogResult.Yes )
            {
                MainWindow.mainWindow.PruneEntries(
                    Convert.ToDateTime( monthStart.SelectionStart.ToShortDateString() ),
                    Convert.ToDateTime( monthEnd.SelectionStart.ToShortDateString() )
                );

                this.Close();
            }
        }
    }
}
