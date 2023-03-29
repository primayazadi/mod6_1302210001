using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_1302210001
{
    internal class SayaTubeUser
    {
        private int id;
        private String username;
        public List<SayaTubeVideo> uploadedVideos;
        public SayaTubeUser(String username)
        {
            this.username = username;
        }

        public int getTotalVideoPlayCount()
        {
            int total = 0;
            foreach(var video in uploadedVideos)
            {
                total = total + video.getPlayCount();
                
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video) 
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("user :" + this.username);
            foreach (var video in uploadedVideos)
            {
                Console.WriteLine("Judul video :" + video.getTitle);
            }

        }
    }
}
