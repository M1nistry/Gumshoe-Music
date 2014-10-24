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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.deviceLabel = new System.Windows.Forms.Label();
            this.deviceComboBox = new System.Windows.Forms.ComboBox();
            this.musicObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.olvTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvArtist = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvAlbum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.musicTabPage = new System.Windows.Forms.TabPage();
            this.syncTabPage = new System.Windows.Forms.TabPage();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.syncStatus = new System.Windows.Forms.Label();
            this.tagTabPage = new System.Windows.Forms.TabPage();
            this.formatLabel = new System.Windows.Forms.Label();
            this.formatTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDevice = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populateBGW = new System.ComponentModel.BackgroundWorker();
            this.textDeviceInfo = new System.Windows.Forms.TextBox();
            this.extendedStatusStrip = new GumshoeMusic.ExtendedStatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.musicObjectListView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.musicTabPage.SuspendLayout();
            this.syncTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.tagTabPage.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.notifyContextMenu.SuspendLayout();
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
            this.deviceComboBox.Location = new System.Drawing.Point(315, 25);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.Size = new System.Drawing.Size(10, 21);
            this.deviceComboBox.TabIndex = 1;
            this.deviceComboBox.Visible = false;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // musicObjectListView
            // 
            this.musicObjectListView.AllColumns.Add(this.olvTitle);
            this.musicObjectListView.AllColumns.Add(this.olvArtist);
            this.musicObjectListView.AllColumns.Add(this.olvAlbum);
            this.musicObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTitle,
            this.olvArtist,
            this.olvAlbum});
            this.musicObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicObjectListView.Location = new System.Drawing.Point(3, 3);
            this.musicObjectListView.Name = "musicObjectListView";
            this.musicObjectListView.Size = new System.Drawing.Size(288, 409);
            this.musicObjectListView.TabIndex = 2;
            this.musicObjectListView.UseCompatibleStateImageBehavior = false;
            this.musicObjectListView.View = System.Windows.Forms.View.Details;
            // 
            // olvTitle
            // 
            this.olvTitle.AspectName = "Title";
            this.olvTitle.CellPadding = null;
            this.olvTitle.FillsFreeSpace = true;
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
            // olvAlbum
            // 
            this.olvAlbum.AspectName = "Album";
            this.olvAlbum.CellPadding = null;
            this.olvAlbum.MaximumWidth = 0;
            this.olvAlbum.MinimumWidth = 0;
            this.olvAlbum.Text = "Album";
            this.olvAlbum.Width = 0;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.musicTabPage);
            this.tabControl.Controls.Add(this.syncTabPage);
            this.tabControl.Controls.Add(this.tagTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(302, 441);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // musicTabPage
            // 
            this.musicTabPage.Controls.Add(this.musicObjectListView);
            this.musicTabPage.Location = new System.Drawing.Point(4, 22);
            this.musicTabPage.Name = "musicTabPage";
            this.musicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.musicTabPage.Size = new System.Drawing.Size(294, 415);
            this.musicTabPage.TabIndex = 0;
            this.musicTabPage.Text = "Music";
            this.musicTabPage.UseVisualStyleBackColor = true;
            // 
            // syncTabPage
            // 
            this.syncTabPage.Controls.Add(this.objectListView1);
            this.syncTabPage.Controls.Add(this.syncStatus);
            this.syncTabPage.Location = new System.Drawing.Point(4, 22);
            this.syncTabPage.Name = "syncTabPage";
            this.syncTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.syncTabPage.Size = new System.Drawing.Size(294, 405);
            this.syncTabPage.TabIndex = 1;
            this.syncTabPage.Text = "Sync";
            this.syncTabPage.UseVisualStyleBackColor = true;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.olvColumn1);
            this.objectListView1.AllColumns.Add(this.olvColumn2);
            this.objectListView1.AllColumns.Add(this.olvColumn3);
            this.objectListView1.CheckBoxes = true;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.objectListView1.Location = new System.Drawing.Point(0, 35);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(294, 260);
            this.objectListView1.TabIndex = 3;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Title";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Text = "Title";
            this.olvColumn1.Width = 150;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Artist";
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Artist";
            this.olvColumn2.Width = 130;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Album";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.MaximumWidth = 0;
            this.olvColumn3.MinimumWidth = 0;
            this.olvColumn3.Text = "Album";
            this.olvColumn3.Width = 0;
            // 
            // syncStatus
            // 
            this.syncStatus.AutoSize = true;
            this.syncStatus.Location = new System.Drawing.Point(47, 16);
            this.syncStatus.Name = "syncStatus";
            this.syncStatus.Size = new System.Drawing.Size(191, 13);
            this.syncStatus.TabIndex = 0;
            this.syncStatus.Text = "There are {0} files waiting to be synced";
            // 
            // tagTabPage
            // 
            this.tagTabPage.Controls.Add(this.formatLabel);
            this.tagTabPage.Controls.Add(this.formatTextBox);
            this.tagTabPage.Location = new System.Drawing.Point(4, 22);
            this.tagTabPage.Name = "tagTabPage";
            this.tagTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tagTabPage.Size = new System.Drawing.Size(294, 405);
            this.tagTabPage.TabIndex = 2;
            this.tagTabPage.Text = "Tags";
            this.tagTabPage.UseVisualStyleBackColor = true;
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(6, 285);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(42, 13);
            this.formatLabel.TabIndex = 1;
            this.formatLabel.Text = "Format:";
            // 
            // formatTextBox
            // 
            this.formatTextBox.Location = new System.Drawing.Point(49, 282);
            this.formatTextBox.Name = "formatTextBox";
            this.formatTextBox.Size = new System.Drawing.Size(146, 20);
            this.formatTextBox.TabIndex = 0;
            this.formatTextBox.Text = "#. <artist> - <title>";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripTools});
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
            // toolStripTools
            // 
            this.toolStripTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolStripTools.Name = "toolStripTools";
            this.toolStripTools.Size = new System.Drawing.Size(48, 20);
            this.toolStripTools.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // refreshDevice
            // 
            this.refreshDevice.Location = new System.Drawing.Point(285, 25);
            this.refreshDevice.Name = "refreshDevice";
            this.refreshDevice.Size = new System.Drawing.Size(24, 21);
            this.refreshDevice.TabIndex = 6;
            this.refreshDevice.Text = "↻";
            this.refreshDevice.UseVisualStyleBackColor = true;
            this.refreshDevice.Visible = false;
            this.refreshDevice.Click += new System.EventHandler(this.refreshDevice_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Gumshoe Music";
            this.notifyIcon.Visible = true;
            // 
            // notifyContextMenu
            // 
            this.notifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.notifyContextMenu.Name = "notifyContextMenu";
            this.notifyContextMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // populateBGW
            // 
            this.populateBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.populateBGW_DoWork);
            this.populateBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.populateBGW_RunWorkerCompleted);
            // 
            // textDeviceInfo
            // 
            this.textDeviceInfo.Location = new System.Drawing.Point(59, 26);
            this.textDeviceInfo.Name = "textDeviceInfo";
            this.textDeviceInfo.ReadOnly = true;
            this.textDeviceInfo.Size = new System.Drawing.Size(220, 20);
            this.textDeviceInfo.TabIndex = 7;
            // 
            // extendedStatusStrip
            // 
            this.extendedStatusStrip.BackColor = System.Drawing.Color.Transparent;
            this.extendedStatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.extendedStatusStrip.Location = new System.Drawing.Point(0, 499);
            this.extendedStatusStrip.Name = "extendedStatusStrip";
            this.extendedStatusStrip.Size = new System.Drawing.Size(326, 22);
            this.extendedStatusStrip.TabIndex = 8;
            this.extendedStatusStrip.Timestamps = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 521);
            this.Controls.Add(this.extendedStatusStrip);
            this.Controls.Add(this.textDeviceInfo);
            this.Controls.Add(this.refreshDevice);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.deviceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Gumshoe Music | 0.1";
            ((System.ComponentModel.ISupportInitialize)(this.musicObjectListView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.musicTabPage.ResumeLayout(false);
            this.syncTabPage.ResumeLayout(false);
            this.syncTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.tagTabPage.ResumeLayout(false);
            this.tagTabPage.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.notifyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.ComboBox deviceComboBox;
        private BrightIdeasSoftware.ObjectListView musicObjectListView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage musicTabPage;
        private System.Windows.Forms.TabPage syncTabPage;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button refreshDevice;
        private BrightIdeasSoftware.OLVColumn olvTitle;
        private BrightIdeasSoftware.OLVColumn olvArtist;
        private BrightIdeasSoftware.OLVColumn olvAlbum;
        private System.Windows.Forms.ToolStripMenuItem toolStripTools;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label syncStatus;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tagTabPage;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.TextBox formatTextBox;
        private System.ComponentModel.BackgroundWorker populateBGW;
        private System.Windows.Forms.TextBox textDeviceInfo;
        private ExtendedStatusStrip extendedStatusStrip;
    }
}

