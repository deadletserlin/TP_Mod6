using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400028
{
    class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Random random = new Random();
            id = random.Next(10000, 99999);
            this.title = title;
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}