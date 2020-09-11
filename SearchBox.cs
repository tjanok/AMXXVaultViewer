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

        public SearchBox( StringBuilder searchString )
        {
            this.searchString = searchString;
            InitializeComponent();
        }

        private void FormSearchBox_Load( object sender, EventArgs e )
        {

        }

        private void TboxSearchString_KeyDown( object sender, KeyEventArgs e )
        {
            if( e.KeyCode == Keys.Enter )
            {
                searchString.Append( this.tboxSearchString.Text );
                this.Close();
            }
        }
    }
}
