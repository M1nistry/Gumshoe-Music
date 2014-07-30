﻿namespace GumshoeMusic
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.musicTabPage = new System.Windows.Forms.TabPage();
            this.syncTabPage = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDevice = new System.Windows.Forms.Button();
            this.olvTitle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvArtist = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvAlbum = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncStatus = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.musicObjectListView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.musicTabPage.SuspendLayout();
            this.syncTabPage.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.musicObjectListView.AllColumns.Add(this.olvAlbum);
            this.musicObjectListView.CheckBoxes = true;
            this.musicObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvTitle,
            this.olvArtist,
            this.olvAlbum});
            this.musicObjectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicObjectListView.Location = new System.Drawing.Point(3, 3);
            this.musicObjectListView.Name = "musicObjectListView";
            this.musicObjectListView.Size = new System.Drawing.Size(288, 399);
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
            this.tabControl.Controls.Add(this.syncTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(302, 431);
            this.tabControl.TabIndex = 3;
            // 
            // musicTabPage
            // 
            this.musicTabPage.Controls.Add(this.musicObjectListView);
            this.musicTabPage.Location = new System.Drawing.Point(4, 22);
            this.musicTabPage.Name = "musicTabPage";
            this.musicTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.musicTabPage.Size = new System.Drawing.Size(294, 405);
            this.musicTabPage.TabIndex = 0;
            this.musicTabPage.Text = "Music";
            this.musicTabPage.UseVisualStyleBackColor = true;
            // 
            // syncTabPage
            // 
            this.syncTabPage.Controls.Add(this.syncStatus);
            this.syncTabPage.Location = new System.Drawing.Point(4, 22);
            this.syncTabPage.Name = "syncTabPage";
            this.syncTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.syncTabPage.Size = new System.Drawing.Size(294, 405);
            this.syncTabPage.TabIndex = 1;
            this.syncTabPage.Text = "Sync";
            this.syncTabPage.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripSpacer,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 499);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(326, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
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
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 521);
            this.Controls.Add(this.refreshDevice);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.deviceLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Gumshoe Music";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.musicObjectListView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.musicTabPage.ResumeLayout(false);
            this.syncTabPage.ResumeLayout(false);
            this.syncTabPage.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
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
    }
}

