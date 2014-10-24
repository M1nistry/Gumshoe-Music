using System;
using System.Net;
using System.Windows.Forms;

namespace GumshoeMusic
{
    public partial class Settings : Form
    {
        private readonly Main _main;
        public Settings()
        {
            InitializeComponent();
            _main = Main.GetSingleton();
            PopulateDevices();

            folderNameTextBox.Text = Properties.Settings.Default.folderName;
        }

        private void PopulateDevices()
        {
            //var deviceDictionary = _main.ReadDevices();
            //foreach (var entry in deviceDictionary) defaultComboBox.Items.Add(String.Format("{0} ({1})", entry.Key, entry.Value));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (folderNameTextBox.Text != "") Properties.Settings.Default.folderName = folderNameTextBox.Text;
            if (textDeviceName.Text != "") Properties.Settings.Default.deviceName = textDeviceName.Text;
            Properties.Settings.Default.Save();
            Dispose(true);
        }

        private void textAddress_Leave(object sender, EventArgs e)
        {
            Console.WriteLine(Dns.GetHostEntry(textAddress.Text).HostName);
        }
    }
}
