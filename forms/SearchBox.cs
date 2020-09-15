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
    public partial class SearchBox : DarkForm
    {
        private StringBuilder searchString;

        public SearchBox( StringBuilder searchString, String defaultSearch = "" )
        {
            this.searchString = searchString;
            InitializeComponent();

            if( defaultSearch != null )
                tboxSearchString.Text = defaultSearch;
        }

        private void TboxSearchString_KeyDown( object sender, KeyEventArgs e )
        {
            if( e.KeyCode == Keys.Enter )
            {
                searchString.Append( this.tboxSearchString.Text );
                Close();
            }
            else if( e.KeyCode == Keys.Escape )
            {
                Close();
            }
        }
    }
}
