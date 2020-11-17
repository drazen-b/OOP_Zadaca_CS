using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Class_Library
{
    public static class TvUtilities
    {
        public static double GenerateRandomScore()
        {
            Random generator = new Random();
            return (generator.NextDouble() * 10);
        }

        public static void Sort(Episode[] episodes)
        {
            for(int i = 0; i < episodes.Length-2; i++)
            {
                for(int j = 0; j<episodes.Length-2;j++)
                {
                    if(episodes[i] < episodes[i+1])
                    {
                        Episode temp = episodes[i+1];
                        episodes[i+1] = episodes[i];
                        episodes[i] = temp; 
                    }
                }
            }
        }

        public static Episode Parse(string name)
        {
            Description desc = new Description(int.Parse(name.Split(',')[3]), TimeSpan.Parse(name.Split(',')[4]), name.Split(',')[5]);
            return new Episode(int.Parse(name.Split(',')[0]), double.Parse(name.Split(',')[1]), double.Parse(name.Split(',')[2]), desc);
        }

    }
}

