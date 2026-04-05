using System;

namespace TP_MOD6_103022400002
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        private static Random rand = new Random();

        public SayaMusicTrack(string title)
        {
            this.title = title;
            this.id = rand.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}