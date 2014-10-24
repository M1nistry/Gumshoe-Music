using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GumshoeMusic
{
    public partial class Main : Form
    {
        private string _devicePath;
        private Settings _settings;
        private static Main _mainSingleton;
        private SqliteWrapper _sql;
        private Ftp _ftp;

        public Main()
        {
            InitializeComponent();
            if (_mainSingleton == null)  _mainSingleton = this;
            _sql = new SqliteWrapper();
            CreateDirectories();
            textDeviceInfo.Text = Properties.Settings.Default.deviceName + @" (" + Properties.Settings.Default.deviceAddress + @")";
            //PopulateDrives();
            _ftp = new Ftp("ftp://" + Properties.Settings.Default.deviceAddress +"/", "", "");
            if (_ftp != null) PopulateFtp();
            
        }

        private void CreateDirectories()
        {
            var appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(appData + @"\GumshoeMusic"))
            {
                Directory.CreateDirectory(appData + @"\GumshoeMusic");
            }
            if (!File.Exists(appData + @"\GumshoeMusic\MusicDB"))
            {
                _sql.Setup();
            }
        }

        private void PopulateFtp()
        {
            foreach (var directory in _ftp.directoryListSimple("Music"))
            {
                var directoryId = _sql.FetchDirectory(directory);
                if (directoryId < 1) directoryId = _sql.CreateDirectory(directory);
                foreach (var item in _ftp.directoryListSimple("Music/" + directory, true))
                {
                    Console.WriteLine("ID: " + directoryId + " Song: " + item);
                    //TODO: First run: Scan through all current music, download it, TagLib it into SQLite and then delete it. TagLib files before uploading them so we have avaliable data.
                }
            }
        }

        public static Main GetSingleton()
        {
            return _mainSingleton;
        }

        public void AddSync()
        {
            MessageBox.Show(@"Hello World");
        }

        /// <summary> Populates the detected portable devices and converts their free space accordingly </summary>
        private void PopulateDrives()
        {
            //var devices = new WindowsPortableDeviceNet.Utility().Get();
            //foreach (var drive in devices)
            //{
            //    drive.Connect();
            //    Console.WriteLine(drive.SerialNumber.Value);
            //}

            //foreach (var drive in DetectDrives())
            //{
            //    deviceComboBox.Items.Add(drive.FriendlyName.Value);

            //}

            //foreach (var drive in DetectDrives())
            //{
            //    var freeSpace = BytesToMegabytes(drive.AvailableFreeSpace) > 1024 ? MegabytesToGigabytes(BytesToMegabytes(drive.AvailableFreeSpace)) : BytesToMegabytes(drive.AvailableFreeSpace);
            //    var driveSize = " MB";
            //    if (_gigabytes) driveSize = " GB";
            //    deviceComboBox.Items.Add(String.Format("{0} ({1}) {2}", drive.VolumeLabel, drive.RootDirectory, freeSpace + driveSize));
            //    _sql.InsertDevice(GetDriveSerial(drive.RootDirectory.ToString().Replace("\\", "")));
            //}

            //var collection = new PortableDeviceCollection();
            //collection.Refresh();

            //foreach (var device in collection)
            //{
            //    device.Connect();
            //    deviceComboBox.Items.Add(device.FriendlyName);
            //    device.Disconnect();
            //    //foreach (var folder in device.GetContents().Files)
            //    //{
            //    //    Console.WriteLine(folder.Name);
            //    //}
            //    //s10001
            //    //device.TransferContentToDevice(@"C:\The Space MIx Vol1.m4a", "s10001");
            //}
        }

        /// <summary> Populates the music into the OLV and sorts/groups by album </summary>
        private void PopulateMusic()
        {
            populateBGW.RunWorkerAsync();
        }

        /// <summary> Checks if a file is of the accepted file extension </summary>
        public bool IsMediaFile(string path)
        {
            string[] mediaExtensions ={ ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".FLAC", ".M4A" };
            var fileExtension = Path.GetExtension(path);
            return fileExtension != null && mediaExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase);
        }

        static Int32 BytesToMegabytes(long bytes)
        {
            return (int) ((bytes / 1024f) / 1024f);
        }

        //static Double MegabytesToGigabytes(Int32 megabytes)
        //{
        //    _gigabytes = true;
        //    return Math.Round(megabytes/1024f, 2);
        //}

        /// <summary> Detects drives where their type is Removable </summary>
        /// <returns> Enumerable of DriveInfo</returns>
        //private static IEnumerable<Device> DetectDrives()
        //{
        //    //var devices = new WindowsPortableDeviceNet.Utility().Get();

        //    //return devices.ToList();
        //}

        //static List<USBDeviceInfo> GetUSBDevices()
        //{
        //    List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

        //    ManagementObjectCollection collection;
        //    using (var searcher = new ManagementObjectSearcher(@"Select Name, Status from Win32_PnPEntity"))
        //    {
        //        collection = searcher.Get();

        //        if (collection != null)
        //            // Enumerate the devices
        //            foreach (ManagementObject device in searcher.Get())
        //            {
        //                // To make the example more simple,
        //                string name = device.GetPropertyValue("Name").ToString();
        //                string status = device.GetPropertyValue("Status").ToString();
        //                Console.WriteLine(name + status);
        //            }
                

        //        collection.Dispose();
        //    }
        //    return devices;
        //}

        private void refreshDevice_Click(object sender, EventArgs e)
        {
            deviceComboBox.Items.Clear();
            PopulateDrives();
        }

        /// <summary> Parses the root path of a device from the string </summary>
        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_devicePath = deviceComboBox.Text.Split(new[] { '(', ')' })[1];
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void populateBGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
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
            e.Result = musicList;
        }

        private void populateBGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            musicObjectListView.SetObjects((List<olvMusic>)e.Result);
            musicObjectListView.Sort(olvAlbum);
        }

        private void bgwPing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var item in (List<string>) e.Result)
            {
                deviceComboBox.Items.Add(item);
            }
        }


    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            DeviceID = deviceID;
            PnpDeviceID = pnpDeviceID;
            Description = description;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
    }
}
