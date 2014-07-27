using System.Collections.Generic;

namespace GumshoeMusic
{
    public class olvMusic
    {
        public olvMusic(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public string Title { get; set; }

        public string Artist { get; set; }

        static internal List<olvMusic> GetMusic()
        {
            var item = new olvMusic();
            var x = new List<olvMusic> {item};
            return x;
        }
    }
}
