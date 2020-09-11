namespace AMXXVaultViewer
{
    partial class SearchBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxSearchString = new DarkUI.Controls.DarkTextBox();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.SuspendLayout();
            // 
            // tboxSearchString
            // 
            this.tboxSearchString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.tboxSearchString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxSearchString.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tboxSearchString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.tboxSearchString.Location = new System.Drawing.Point(5, 24);
            this.tboxSearchString.Name = "tboxSearchString";
            this.tboxSearchString.Size = new System.Drawing.Size(419, 23);
            this.tboxSearchString.TabIndex = 0;
            this.tboxSearchString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TboxSearchString_KeyDown);
            // 
            // darkTitle1
            // 
            this.darkTitle1.AutoSize = true;
            this.darkTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkTitle1.Location = new System.Drawing.Point(5, 5);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(45, 15);
            this.darkTitle1.TabIndex = 1;
            this.darkTitle1.Text = "Search:";
            // 
            // formSearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 52);
            this.ControlBox = false;
            this.Controls.Add(this.darkTitle1);
            this.Controls.Add(this.tboxSearchString);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSearchBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "formSearchBox";
            this.Load += new System.EventHandler(this.FormSearchBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox tboxSearchString;
        private DarkUI.Controls.DarkTitle darkTitle1;
    }
}