namespace AMXXVaultViewer
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAbout = new DarkUI.Controls.DarkButton();
            this.btnReload = new DarkUI.Controls.DarkButton();
            this.btnOpen = new DarkUI.Controls.DarkButton();
            this.pnlMainContainer = new DarkUI.Controls.DarkSectionPanel();
            this.grpKeys = new DarkUI.Controls.DarkGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPruneEntries = new DarkUI.Controls.DarkButton();
            this.btnFindKey = new DarkUI.Controls.DarkButton();
            this.btnAddEntry = new DarkUI.Controls.DarkButton();
            this.lvEntries = new DarkUI.Controls.DarkListView();
            this.lblEntryCount = new DarkUI.Controls.DarkLabel();
            this.grpEntryInfo = new DarkUI.Controls.DarkGroupBox();
            this.btnEntryTimeUpdate = new DarkUI.Controls.DarkButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEntrySave = new DarkUI.Controls.DarkButton();
            this.btnEntryExit = new DarkUI.Controls.DarkButton();
            this.btnEntryDelete = new DarkUI.Controls.DarkButton();
            this.btnEntryUpdate = new DarkUI.Controls.DarkButton();
            this.txtTimestamp = new DarkUI.Controls.DarkTextBox();
            this.darkTitle2 = new DarkUI.Controls.DarkTitle();
            this.txtValue = new DarkUI.Controls.DarkTextBox();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.txtKey = new DarkUI.Controls.DarkTextBox();
            this.lblKey = new DarkUI.Controls.DarkTitle();
            this.ttEntryTips = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.grpKeys.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpEntryInfo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnAbout, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReload, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOpen, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 475);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 35);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(290, 3);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(6);
            this.btnAbout.Size = new System.Drawing.Size(145, 29);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(148, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Padding = new System.Windows.Forms.Padding(6);
            this.btnReload.Size = new System.Drawing.Size(139, 29);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(0, 3);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Padding = new System.Windows.Forms.Padding(6);
            this.btnOpen.Size = new System.Drawing.Size(145, 29);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnPruneEntries, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFindKey, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddEntry, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 348);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 43);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnPruneEntries
            // 
            this.btnPruneEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPruneEntries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPruneEntries.Image = ((System.Drawing.Image)(resources.GetObject("btnPruneEntries.Image")));
            this.btnPruneEntries.Location = new System.Drawing.Point(66, 3);
            this.btnPruneEntries.Name = "btnPruneEntries";
            this.btnPruneEntries.Padding = new System.Windows.Forms.Padding(5);
            this.btnPruneEntries.Size = new System.Drawing.Size(57, 37);
            this.btnPruneEntries.TabIndex = 14;
            this.ttEntryTips.SetToolTip(this.btnPruneEntries, "Prune all entries from a date range");
            this.btnPruneEntries.Click += new System.EventHandler(this.BtnPruneEntries_Click);
            // 
            // btnFindKey
            // 
            this.btnFindKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFindKey.Image = ((System.Drawing.Image)(resources.GetObject("btnFindKey.Image")));
            this.btnFindKey.Location = new System.Drawing.Point(129, 3);
            this.btnFindKey.Name = "btnFindKey";
            this.btnFindKey.Padding = new System.Windows.Forms.Padding(5);
            this.btnFindKey.Size = new System.Drawing.Size(57, 37);
            this.btnFindKey.TabIndex = 13;
            this.ttEntryTips.SetToolTip(this.btnFindKey, "Search all keys for a string");
            this.btnFindKey.Click += new System.EventHandler(this.BtnFindKey_Click);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEntry.Image")));
            this.btnAddEntry.Location = new System.Drawing.Point(3, 3);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddEntry.Size = new System.Drawing.Size(57, 37);
            this.btnAddEntry.TabIndex = 12;
            this.ttEntryTips.SetToolTip(this.btnAddEntry, "Add a new vault entry");
            this.btnAddEntry.Click += new System.EventHandler(this.BtnAddEntry_Click);
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
            // 
            // grpEntryInfo
            // 
            this.grpEntryInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.grpEntryInfo.Controls.Add(this.btnEntryTimeUpdate);
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
            // 
            // btnEntryTimeUpdate
            // 
            this.btnEntryTimeUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntryTimeUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntryTimeUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEntryTimeUpdate.Image")));
            this.btnEntryTimeUpdate.Location = new System.Drawing.Point(180, 130);
            this.btnEntryTimeUpdate.Name = "btnEntryTimeUpdate";
            this.btnEntryTimeUpdate.Padding = new System.Windows.Forms.Padding(5);
            this.btnEntryTimeUpdate.Size = new System.Drawing.Size(28, 23);
            this.btnEntryTimeUpdate.TabIndex = 14;
            this.ttEntryTips.SetToolTip(this.btnEntryTimeUpdate, "Update timestamp to the current date and time");
            this.btnEntryTimeUpdate.Click += new System.EventHandler(this.BtnEntryTimeUpdate_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnEntrySave, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnEntryExit, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnEntryDelete, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEntryUpdate, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 159);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
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
            // btnEntrySave
            // 
            this.btnEntrySave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrySave.Location = new System.Drawing.Point(0, 119);
            this.btnEntrySave.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnEntrySave.Name = "btnEntrySave";
            this.btnEntrySave.Padding = new System.Windows.Forms.Padding(5);
            this.btnEntrySave.Size = new System.Drawing.Size(204, 47);
            this.btnEntrySave.TabIndex = 2;
            this.btnEntrySave.Text = "Save";
            this.ttEntryTips.SetToolTip(this.btnEntrySave, "Save all changes to this vault");
            this.btnEntrySave.Click += new System.EventHandler(this.BtnEntrySave_Click);
            // 
            // btnEntryExit
            // 
            this.btnEntryExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntryExit.Location = new System.Drawing.Point(0, 176);
            this.btnEntryExit.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnEntryExit.Name = "btnEntryExit";
            this.btnEntryExit.Padding = new System.Windows.Forms.Padding(5);
            this.btnEntryExit.Size = new System.Drawing.Size(204, 49);
            this.btnEntryExit.TabIndex = 1;
            this.btnEntryExit.Text = "Exit";
            this.btnEntryExit.Click += new System.EventHandler(this.BtnEntryExit_Click);
            // 
            // btnEntryDelete
            // 
            this.btnEntryDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntryDelete.Location = new System.Drawing.Point(0, 62);
            this.btnEntryDelete.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnEntryDelete.Name = "btnEntryDelete";
            this.btnEntryDelete.Padding = new System.Windows.Forms.Padding(5);
            this.btnEntryDelete.Size = new System.Drawing.Size(204, 47);
            this.btnEntryDelete.TabIndex = 0;
            this.btnEntryDelete.Text = "Delete";
            this.ttEntryTips.SetToolTip(this.btnEntryDelete, "Delete this entry");
            this.btnEntryDelete.Click += new System.EventHandler(this.BtnEntryDelete_Click);
            // 
            // btnEntryUpdate
            // 
            this.btnEntryUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntryUpdate.Location = new System.Drawing.Point(0, 5);
            this.btnEntryUpdate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnEntryUpdate.Name = "btnEntryUpdate";
            this.btnEntryUpdate.Padding = new System.Windows.Forms.Padding(5);
            this.btnEntryUpdate.Size = new System.Drawing.Size(204, 47);
            this.btnEntryUpdate.TabIndex = 3;
            this.btnEntryUpdate.Text = "Update";
            this.ttEntryTips.SetToolTip(this.btnEntryUpdate, "Update this entry");
            this.btnEntryUpdate.Click += new System.EventHandler(this.BtnEntryUpdate_Click);
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtTimestamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimestamp.Enabled = false;
            this.txtTimestamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTimestamp.Location = new System.Drawing.Point(7, 130);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(167, 23);
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
            // MainWindow
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "AMXX nVault Viewer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMainContainer.ResumeLayout(false);
            this.grpKeys.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpEntryInfo.ResumeLayout(false);
            this.grpEntryInfo.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DarkUI.Controls.DarkButton btnAbout;
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
        private DarkUI.Controls.DarkButton btnAddEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DarkUI.Controls.DarkButton btnEntryExit;
        private DarkUI.Controls.DarkButton btnEntryDelete;
        private DarkUI.Controls.DarkButton btnEntrySave;
        private DarkUI.Controls.DarkButton btnEntryUpdate;
        private DarkUI.Controls.DarkButton btnFindKey;
        private DarkUI.Controls.DarkButton btnEntryTimeUpdate;
        private System.Windows.Forms.ToolTip ttEntryTips;
        private DarkUI.Controls.DarkButton btnPruneEntries;
    }
}

