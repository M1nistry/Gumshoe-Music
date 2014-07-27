namespace GumshoeMusic
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.musicObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.musicTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDevice = new System.Windows.Forms.Button();
            this.olvTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvArtist = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.musicObjectListView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.musicTabPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(9, 28);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(44, 13);
            this.deviceLabel.TabIndex = 0;
            this.deviceLabel.Text = "Device:";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.Location = new System.Drawing.Point(59, 25);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(220, 21);
            this.deviceComboBox.TabIndex = 1;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // musicObjectListView
            // 
            this.musicObjectListView.AllColumns.Add(this.olvTitle);
            this.musicObjectListView.AllColumns.Add(this.olvArtist);
            this.musicObjectListView.CheckBoxes = true;
            this.musicObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTitle,
            this.olvArtist});
            this.musicObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicObjectListView.Location = new System.Drawing.Point(3, 3);
            this.musicObjectListView.Name = "musicObjectListView";
            this.musicObjectListView.Size = new System.Drawing.Size(288, 388);
            this.musicObjectListView.TabIndex = 2;
            this.musicObjectListView.UseCompatibleStateImageBehavior = false;
            this.musicObjectListView.View = System.Windows.Forms.View.Details;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.musicTabPage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(302, 420);
            this.tabControl.TabIndex = 3;
            // 
            // musicTabPage
            // 
            this.musicTabPage.Controls.Add(this.musicObjectListView);
            this.musicTabPage.Location = new System.Drawing.Point(4, 22);
            this.musicTabPage.Name = "musicTabPage";
            this.musicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.musicTabPage.Size = new System.Drawing.Size(294, 394);
            this.musicTabPage.TabIndex = 0;
            this.musicTabPage.Text = "Music";
            this.musicTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripSpacer,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Status:";
            // 
            // toolStripSpacer
            // 
            this.toolStripSpacer.Name = "toolStripSpacer";
            this.toolStripSpacer.Size = new System.Drawing.Size(167, 17);
            this.toolStripSpacer.Spring = true;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(326, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshDevice
            // 
            this.refreshDevice.Location = new System.Drawing.Point(285, 25);
            this.refreshDevice.Name = "refreshDevice";
            this.refreshDevice.Size = new System.Drawing.Size(24, 21);
            this.refreshDevice.TabIndex = 6;
            this.refreshDevice.Text = "↻";
            this.refreshDevice.UseVisualStyleBackColor = true;
            this.refreshDevice.Click += new System.EventHandler(this.refreshDevice_Click);
            // 
            // olvTitle
            // 
            this.olvTitle.AspectName = "Title";
            this.olvTitle.CellPadding = null;
            this.olvTitle.Text = "Title";
            this.olvTitle.Width = 150;
            // 
            // olvArtist
            // 
            this.olvArtist.AspectName = "Artist";
            this.olvArtist.CellPadding = null;
            this.olvArtist.Text = "Artist";
            this.olvArtist.Width = 130;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 521);
            this.Controls.Add(this.refreshDevice);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.deviceLabel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Gumshoe Music";
            ((System.ComponentModel.ISupportInitialize)(this.musicObjectListView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.musicTabPage.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private BrightIdeasSoftware.ObjectListView musicObjectListView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage musicTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button refreshDevice;
        private BrightIdeasSoftware.OLVColumn olvTitle;
        private BrightIdeasSoftware.OLVColumn olvArtist;
    }
}

