namespace GumshoeMusic
{
    partial class Settings
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
            this.folderLabel = new System.Windows.Forms.Label();
            this.folderNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.labelIp = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.textDeviceName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(21, 20);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(70, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Music Folder:";
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(97, 17);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.folderNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(122, 95);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(34, 72);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(57, 13);
            this.labelIp.TabIndex = 5;
            this.labelIp.Text = "Device IP:";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(97, 69);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 6;
            this.textAddress.Text = "192.168.1.11";
            this.textAddress.Leave += new System.EventHandler(this.textAddress_Leave);
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(21, 46);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(75, 13);
            this.labelDeviceName.TabIndex = 7;
            this.labelDeviceName.Text = "Device Name:";
            // 
            // textDeviceName
            // 
            this.textDeviceName.Location = new System.Drawing.Point(97, 43);
            this.textDeviceName.Name = "textDeviceName";
            this.textDeviceName.Size = new System.Drawing.Size(100, 20);
            this.textDeviceName.TabIndex = 8;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 130);
            this.Controls.Add(this.textDeviceName);
            this.Controls.Add(this.labelDeviceName);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.folderNameTextBox);
            this.Controls.Add(this.folderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.TextBox textDeviceName;
    }
}