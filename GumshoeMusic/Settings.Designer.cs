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
            this.SuspendLayout();
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(12, 20);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(70, 13);
            this.folderLabel.TabIndex = 0;
            this.folderLabel.Text = "Music Folder:";
            // 
            // folderNameTextBox
            // 
            this.folderNameTextBox.Location = new System.Drawing.Point(88, 17);
            this.folderNameTextBox.Name = "folderNameTextBox";
            this.folderNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.folderNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(152, 103);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 138);
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
    }
}