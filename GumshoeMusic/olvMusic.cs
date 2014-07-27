using System.Collections.Generic;

namespace GumshoeMusic
{
    public class olvMusic
    {
        public olvMusic(string title, string artist, string album)
        {
            Title = title;
            Artist = artist;
            Album = album;
        }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
    }
}
