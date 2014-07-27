using System.Windows.Forms;

namespace GumshoeMusic
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            folderNameTextBox.Text = Properties.Settings.Default.folderName;
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (folderNameTextBox.Text != "")Properties.Settings.Default.folderName = folderNameTextBox.Text;
            Dispose(true);
        }
    }
}
