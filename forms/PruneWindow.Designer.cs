namespace AMXXVaultViewer
{
    partial class PruneWindow
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
            this.monthStart = new System.Windows.Forms.MonthCalendar();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.monthEnd = new System.Windows.Forms.MonthCalendar();
            this.btnPrune = new DarkUI.Controls.DarkButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuit = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthStart
            // 
            this.monthStart.Location = new System.Drawing.Point(11, 35);
            this.monthStart.Margin = new System.Windows.Forms.Padding(10);
            this.monthStart.Name = "monthStart";
            this.monthStart.TabIndex = 0;
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.monthStart);
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Start Date";
            this.darkSectionPanel1.Size = new System.Drawing.Size(250, 213);
            this.darkSectionPanel1.TabIndex = 1;
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkSectionPanel2.Controls.Add(this.monthEnd);
            this.darkSectionPanel2.Location = new System.Drawing.Point(269, 12);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "End Date";
            this.darkSectionPanel2.Size = new System.Drawing.Size(250, 213);
            this.darkSectionPanel2.TabIndex = 2;
            // 
            // monthEnd
            // 
            this.monthEnd.Location = new System.Drawing.Point(11, 35);
            this.monthEnd.Margin = new System.Windows.Forms.Padding(10);
            this.monthEnd.Name = "monthEnd";
            this.monthEnd.TabIndex = 0;
            // 
            // btnPrune
            // 
            this.btnPrune.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrune.Location = new System.Drawing.Point(3, 3);
            this.btnPrune.Name = "btnPrune";
            this.btnPrune.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrune.Size = new System.Drawing.Size(504, 44);
            this.btnPrune.TabIndex = 3;
            this.btnPrune.Text = "Prune";
            this.btnPrune.Click += new System.EventHandler(this.BtnPrune_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnQuit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrune, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 230);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnQuit
            // 
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuit.Location = new System.Drawing.Point(3, 53);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(5);
            this.btnQuit.Size = new System.Drawing.Size(504, 44);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // PruneWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 342);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "PruneWindow";
            this.Text = "Prune Entries";
            this.Load += new System.EventHandler(this.PruneWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PruneWindow_KeyDown);
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthStart;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private System.Windows.Forms.MonthCalendar monthEnd;
        private DarkUI.Controls.DarkButton btnPrune;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DarkUI.Controls.DarkButton btnQuit;
    }
}