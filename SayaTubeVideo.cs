using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_1302210001
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(int id, string tite, int playCount)
        {
            this.id = id;
            this.title = tite;
            this.playCount = playCount;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount > 300 && playCount < 0, "Input Penambahan Playlist 100 Per Panggilan Method Nya");

        }

        public void PrintVIdeoDetails()
        {
            Console.WriteLine("id :" + this.id);
            Console.WriteLine("title :" + this.title);
            Console.WriteLine("playCount :" +this.playCount);
        }

        public int getPlayCount()
        {
            return this.playCount;
        }

        public String getTitle()
        {
            return this.title;
        }

       
    }
}
