using System.Runtime.InteropServices;
using System.Windows.Forms;
using GumshoeMusic.Properties;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;

namespace GumshoeMusic
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.Directory)]
    [COMServerAssociation(AssociationType.ClassOfExtension, ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".FLAC")]

    public class Sync : SharpContextMenu
    {
        private Main _main = Main.GetSingleton();
        protected override bool CanShowMenu()
        {
            return true;
        }

        protected override ContextMenuStrip CreateMenu()
        {
            _main = Main.GetSingleton();
            var menu = new ContextMenuStrip();
            var syncItem = new ToolStripMenuItem
            {
                Text = "Add to sync",
                Image = Resources.Gumshoe.ToBitmap()
            };

            syncItem.Click += (sender, args) => _main.AddSync();
            menu.Items.Add(syncItem);
            return menu;
        }
    }
}
