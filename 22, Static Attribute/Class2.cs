using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22__Static_Attribute
{
    internal class Songs
    {
        public string Title;
        public string Artist;
        public int Duration;

        public static int songcount = 0;
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            this.Title =aTitle;
            this.Artist= aArtist;
            this.Duration = aDuration;
            songcount++;



        }
    }
}
