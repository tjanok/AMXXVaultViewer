namespace AMXXVaultViewer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new DarkUI.Controls.DarkButton();
            this.btnReload = new DarkUI.Controls.DarkButton();
            this.btnOpen = new DarkUI.Controls.DarkButton();
            this.pnlMainContainer = new DarkUI.Controls.DarkSectionPanel();
            this.grpKeys = new DarkUI.Controls.DarkGroupBox();
            this.lvEntries = new DarkUI.Controls.DarkListView();
            this.lblEntryCount = new DarkUI.Controls.DarkLabel();
            this.grpEntryInfo = new DarkUI.Controls.DarkGroupBox();
            this.txtTimestamp = new DarkUI.Controls.DarkTextBox();
            this.darkTitle2 = new DarkUI.Controls.DarkTitle();
            this.txtValue = new DarkUI.Controls.DarkTextBox();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.txtKey = new DarkUI.Controls.DarkTextBox();
            this.lblKey = new DarkUI.Controls.DarkTitle();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkButton4 = new DarkUI.Controls.DarkButton();
            this.darkButton5 = new DarkUI.Controls.DarkButton();
            this.btnFindKey = new DarkUI.Controls.DarkButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.grpKeys.SuspendLayout();
            this.grpEntryInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReload, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpen, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 475);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(426, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(287, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(6);
            this.btnClose.Size = new System.Drawing.Size(136, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(145, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Padding = new System.Windows.Forms.Padding(6);
            this.btnReload.Size = new System.Drawing.Size(136, 29);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(3, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(6);
            this.btnOpen.Size = new System.Drawing.Size(136, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainContainer.Controls.Add(this.grpKeys);
            this.pnlMainContainer.Controls.Add(this.lblEntryCount);
            this.pnlMainContainer.Controls.Add(this.grpEntryInfo);
            this.pnlMainContainer.Location = new System.Drawing.Point(5, 5);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.SectionHeader = "No File Loaded";
            this.pnlMainContainer.Size = new System.Drawing.Size(435, 464);
            this.pnlMainContainer.TabIndex = 5;
            // 
            // grpKeys
            // 
            this.grpKeys.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grpKeys.Controls.Add(this.tableLayoutPanel2);
            this.grpKeys.Controls.Add(this.lvEntries);
            this.grpKeys.Location = new System.Drawing.Point(4, 32);
            this.grpKeys.Name = "grpKeys";
            this.grpKeys.Padding = new System.Windows.Forms.Padding(1);
            this.grpKeys.Size = new System.Drawing.Size(196, 395);
            this.grpKeys.TabIndex = 11;
            this.grpKeys.TabStop = false;
            this.grpKeys.Text = "Keys";
            // 
            // lvEntries
            // 
            this.lvEntries.Location = new System.Drawing.Point(3, 20);
            this.lvEntries.Name = "lvEntries";
            this.lvEntries.Size = new System.Drawing.Size(184, 322);
            this.lvEntries.TabIndex = 1;
            this.lvEntries.Text = "darkListView1";
            this.lvEntries.SelectedIndicesChanged += new System.EventHandler(this.LvEntries_SelectedIndicesChanged);
            // 
            // lblEntryCount
            // 
            this.lblEntryCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntryCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lblEntryCount.Location = new System.Drawing.Point(6, 430);
            this.lblEntryCount.Name = "lblEntryCount";
            this.lblEntryCount.Size = new System.Drawing.Size(186, 20);
            this.lblEntryCount.TabIndex = 10;
            this.lblEntryCount.Text = "Total: 1337";
            this.lblEntryCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEntryCount.Click += new System.EventHandler(this.LblEntryCount_Click);
            // 
            // grpEntryInfo
            // 
            this.grpEntryInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grpEntryInfo.Controls.Add(this.tableLayoutPanel3);
            this.grpEntryInfo.Controls.Add(this.txtTimestamp);
            this.grpEntryInfo.Controls.Add(this.darkTitle2);
            this.grpEntryInfo.Controls.Add(this.txtValue);
            this.grpEntryInfo.Controls.Add(this.darkTitle1);
            this.grpEntryInfo.Controls.Add(this.txtKey);
            this.grpEntryInfo.Controls.Add(this.lblKey);
            this.grpEntryInfo.Location = new System.Drawing.Point(206, 32);
            this.grpEntryInfo.Name = "grpEntryInfo";
            this.grpEntryInfo.Size = new System.Drawing.Size(225, 395);
            this.grpEntryInfo.TabIndex = 3;
            this.grpEntryInfo.TabStop = false;
            this.grpEntryInfo.Text = "Entry";
            this.grpEntryInfo.Enter += new System.EventHandler(this.GrpEntryInfo_Enter);
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtTimestamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTimestamp.Location = new System.Drawing.Point(7, 130);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(204, 23);
            this.txtTimestamp.TabIndex = 8;
            // 
            // darkTitle2
            // 
            this.darkTitle2.AutoSize = true;
            this.darkTitle2.Location = new System.Drawing.Point(7, 112);
            this.darkTitle2.Name = "darkTitle2";
            this.darkTitle2.Size = new System.Drawing.Size(69, 15);
            this.darkTitle2.TabIndex = 7;
            this.darkTitle2.Text = "Timestamp:";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtValue.Location = new System.Drawing.Point(7, 85);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(204, 23);
            this.txtValue.TabIndex = 6;
            // 
            // darkTitle1
            // 
            this.darkTitle1.AutoSize = true;
            this.darkTitle1.Location = new System.Drawing.Point(7, 67);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(38, 15);
            this.darkTitle1.TabIndex = 5;
            this.darkTitle1.Text = "Value:";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtKey.Location = new System.Drawing.Point(7, 38);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(204, 23);
            this.txtKey.TabIndex = 4;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(7, 20);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(29, 15);
            this.lblKey.TabIndex = 3;
            this.lblKey.Text = "Key:";
            // 
            // darkButton1
            // 
            this.darkButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.darkButton1.Image = ((System.Drawing.Image)(resources.GetObject("darkButton1.Image")));
            this.darkButton1.Location = new System.Drawing.Point(3, 3);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(88, 37);
            this.darkButton1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnFindKey, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.darkButton1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 348);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 43);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.darkButton4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.darkButton3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.darkButton2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.darkButton5, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 159);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(204, 230);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // darkButton2
            // 
            this.darkButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton2.Location = new System.Drawing.Point(3, 60);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(198, 51);
            this.darkButton2.TabIndex = 0;
            this.darkButton2.Text = "Delete";
            this.darkButton2.Click += new System.EventHandler(this.DarkButton2_Click);
            // 
            // darkButton3
            // 
            this.darkButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton3.Location = new System.Drawing.Point(3, 174);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(198, 53);
            this.darkButton3.TabIndex = 1;
            this.darkButton3.Text = "Exit";
            // 
            // darkButton4
            // 
            this.darkButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton4.Location = new System.Drawing.Point(3, 117);
            this.darkButton4.Name = "darkButton4";
            this.darkButton4.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton4.Size = new System.Drawing.Size(198, 51);
            this.darkButton4.TabIndex = 2;
            this.darkButton4.Text = "Delete";
            // 
            // darkButton5
            // 
            this.darkButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkButton5.Location = new System.Drawing.Point(3, 3);
            this.darkButton5.Name = "darkButton5";
            this.darkButton5.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton5.Size = new System.Drawing.Size(198, 51);
            this.darkButton5.TabIndex = 3;
            this.darkButton5.Text = "Update";
            // 
            // btnFindKey
            // 
            this.btnFindKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFindKey.Image = ((System.Drawing.Image)(resources.GetObject("btnFindKey.Image")));
            this.btnFindKey.Location = new System.Drawing.Point(97, 3);
            this.btnFindKey.Name = "btnFindKey";
            this.btnFindKey.Padding = new System.Windows.Forms.Padding(5);
            this.btnFindKey.Size = new System.Drawing.Size(89, 37);
            this.btnFindKey.TabIndex = 13;
            this.btnFindKey.Click += new System.EventHandler(this.BtnFindKey_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 522);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlMainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "AMXX nVault Viewer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMainContainer.ResumeLayout(false);
            this.grpKeys.ResumeLayout(false);
            this.grpEntryInfo.ResumeLayout(false);
            this.grpEntryInfo.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DarkUI.Controls.DarkButton btnClose;
        private DarkUI.Controls.DarkButton btnReload;
        private DarkUI.Controls.DarkButton btnOpen;
        private DarkUI.Controls.DarkSectionPanel pnlMainContainer;
        private DarkUI.Controls.DarkListView lvEntries;
        private DarkUI.Controls.DarkGroupBox grpEntryInfo;
        private DarkUI.Controls.DarkTextBox txtTimestamp;
        private DarkUI.Controls.DarkTitle darkTitle2;
        private DarkUI.Controls.DarkTextBox txtValue;
        private DarkUI.Controls.DarkTitle darkTitle1;
        private DarkUI.Controls.DarkTextBox txtKey;
        private DarkUI.Controls.DarkTitle lblKey;
        private DarkUI.Controls.DarkLabel lblEntryCount;
        private DarkUI.Controls.DarkGroupBox grpKeys;
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DarkUI.Controls.DarkButton darkButton3;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkButton darkButton4;
        private DarkUI.Controls.DarkButton darkButton5;
        private DarkUI.Controls.DarkButton btnFindKey;
    }
}

