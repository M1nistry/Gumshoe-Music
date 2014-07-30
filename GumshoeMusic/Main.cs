using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SharpShell;

namespace GumshoeMusic
{
    public partial class Main : Form
    {
        private static bool _gigabytes;
        private string _devicePath;
        private Settings _settings;
        private static Main _mainSingleton;

        public Main()
        {
            InitializeComponent();
            if (_mainSingleton == null)  _mainSingleton = this;

            PopulateDrives();
        }

        public static Main GetSingleton()
        {
            return _mainSingleton;
        }

        public void AddSync()
        {
            MessageBox.Show(@"We can reference!");
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
            var musicFolder = Properties.Settings.Default.folderName;
            if (!Directory.Exists(_devicePath + musicFolder)) return;
            var musicList = new List<olvMusic>();
            foreach (var dir in Directory.EnumerateDirectories(_devicePath + musicFolder))
            {
                foreach (var file in Directory.EnumerateFiles(dir))
                {
                    if (!IsMediaFile(file)) continue;
                    var tagFile = TagLib.File.Create(file);
                    var item = new olvMusic(tagFile.Tag.Title, tagFile.Tag.FirstAlbumArtist, tagFile.Tag.Album);
                    if (item.Title != null) musicList.Add(item);
                }
            }
            musicObjectListView.SetObjects(musicList);
            musicObjectListView.Sort(olvAlbum);
        }

        private static bool IsMediaFile(string path)
        {
            string[] mediaExtensions ={ ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".FLAC" };
            var fileExtension = Path.GetExtension(path);
            return fileExtension != null && mediaExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase);
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

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_settings != null && _settings.Visible)
            {
                _settings.Focus();
                System.Media.SystemSounds.Hand.Play();
            }
            else
            {
                _settings = new Settings();
                _settings.FormClosed += (o, ea) => _settings = null;
                _settings.Show();

            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
