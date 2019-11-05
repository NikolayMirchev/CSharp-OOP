using _01.StreamProgress.Core;
using _01.StreamProgress.Models;
using System;

namespace _01.StreamProgress
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File("ABBA", 125, 10);
            Music music = new Music("Queen", "The Game", 1000, 220);

            StreamProgressInfo firstStreamProgressInfo = new StreamProgressInfo(file);
            StreamProgressInfo secondStreamProgressInfo = new StreamProgressInfo(music);

            Console.WriteLine(firstStreamProgressInfo.CalculateCurrentPercent());
            Console.WriteLine(secondStreamProgressInfo.CalculateCurrentPercent());
        }
    }
}
