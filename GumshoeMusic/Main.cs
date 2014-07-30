using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            var syncDictionary = ReadDictionary();

            WriteDictionary(syncDictionary);
        }

        public bool WriteDictionary(Dictionary<string, string> dictionary)
        {
            using (var fileStream = File.OpenWrite(@"SyncDictionary"))
            using (var writer = new BinaryWriter(fileStream))
            {
                writer.Write(dictionary.Count);

                foreach (var pair in dictionary)
                {
                    writer.Write(pair.Key);
                    writer.Write(pair.Value);
                }
                return true;
            }
        }

        public Dictionary<string, string> ReadDictionary()
        {
            var syncDictionary = new Dictionary<string, string>();

            using (var fileStream = File.OpenRead(@"SyncDictionary"))
            using (var reader = new BinaryReader(fileStream))
            {
                var count = reader.ReadInt32();
                syncStatus.Text = String.Format(syncStatus.Text, count);

                for (var i = 0; i < count; i++)
                {
                    var key = reader.ReadString();
                    var value = reader.ReadString();
                    syncDictionary[key] = value;
                }
            }
            return syncDictionary;
        }

        /// <summary> Populates the detected portable devices and converts their free space accordingly </summary>
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

        /// <summary> Populates the music into the OLV and sorts/groups by album </summary>
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

        /// <summary> Checks if a file is of the accepted file extension </summary>
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

        /// <summary> Detects drives where their type is Removable </summary>
        /// <returns> Enumerable of DriveInfo</returns>
        private static IEnumerable<DriveInfo> DetectDrives()
        {
            return DriveInfo.GetDrives().Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable);
        }

        private void refreshDevice_Click(object sender, EventArgs e)
        {
            deviceComboBox.Items.Clear();
            PopulateDrives();
        }

        /// <summary> Parses the root path of a device from the string </summary>
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
    }
}
