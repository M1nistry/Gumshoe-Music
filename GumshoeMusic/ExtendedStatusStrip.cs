﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GumshoeMusic
{
    public partial class ExtendedStatusStrip : UserControl
    {
        public bool Timestamps { get; set; }

        public ExtendedStatusStrip()
        {
            InitializeComponent();
        }

        public void AddStatus(string status)
        {
            toolStripStatusValue.Text = status;
            if (Timestamps) status = status.Insert(0, @" [" + DateTime.Now.ToShortTimeString() + @"] ");
            listStatusBox.Items.Add(@" " + status);
        }

        private void toolStripExpandButton_ButtonClick(object sender, EventArgs e)
        {
            switch (listStatusBox.Visible)
            {
                case (true):
                    Height = 22;
                    listStatusBox.Visible = false;
                    toolStripExpandButton.Text = @"↑";
                    break;

                case (false):
                    Height = 115;
                    listStatusBox.Size = new Size(Width, 100);
                    listStatusBox.Location = new Point(0, 0);
                    listStatusBox.Visible = true;
                    toolStripExpandButton.Text = @"↓";
                    break;
                    
            }            
        }

        private void listStatusBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(sender is ListBox)) return;
            var listBox = (ListBox)sender;
            var point = new Point(e.X, e.Y);
            var hoverIndex = listBox.IndexFromPoint(point);
            if (hoverIndex >= 0 && hoverIndex < listBox.Items.Count &&
                toolTip.GetToolTip(listBox) != listBox.Items[hoverIndex].ToString())
            {
                toolTip.SetToolTip(listBox, listBox.Items[hoverIndex].ToString());
            }
        }

        private void ExtendedStatusStrip_Resize(object sender, EventArgs e)
        {
           
        }
    }
}
