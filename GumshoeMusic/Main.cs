using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GumshoeMusic
{
    public partial class Main : Form
    {
        private static bool _gigabytes;
        private string _devicePath;
        public Main()
        {
            InitializeComponent();
            PopulateDrives();
        }

        private void PopulateDrives()
        {
            foreach (var drive in DetectDrives())
            {
                var freeSpace = BytesToMegabytes(drive.AvailableFreeSpace) > 1024 ? MegabytesToGigabytes(BytesToMegabytes(drive.AvailableFreeSpace)) : BytesToMegabytes(drive.AvailableFreeSpace);
                var driveSize = " MB";
                if (_gigabytes) driveSize = " GB";
                deviceComboBox.Items.Add(String.Format("{0} ({1}) {2}", drive.VolumeLabel, drive.Name, freeSpace + driveSize));
            }
        }

        private void PopulateMusic()
        {
            var ttrue = true;
            if (!Directory.Exists(_devicePath + "MUSIC")) return;
            musicObjectListView.SetObjects(olvMusic.GetMusic());
            //foreach (var dir in Directory.EnumerateDirectories(_devicePath + "MUSIC"))
            //{
                
            //    //foreach (var file in Directory.EnumerateFiles(dir))
            //    //{
            //    //    if (ttrue)musicObjectListView.Items.Add(dir, file, dir);
            //    //    ttrue = false;
            //    //}
            //}
        }

        static Int32 BytesToMegabytes(long bytes)
        {
            return (int) ((bytes / 1024f) / 1024f);
        }

        static Double MegabytesToGigabytes(Int32 megabytes)
        {
            _gigabytes = true;
            return Math.Round(megabytes/1024f, 2);
        }

        private static IEnumerable<DriveInfo> DetectDrives()
        {
            return DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);
        }

        private void refreshDevice_Click(object sender, EventArgs e)
        {
            PopulateDrives();
        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _devicePath = deviceComboBox.Text.Split(new[] { '(', ')' })[1];
            PopulateMusic();
        }
    }
}
