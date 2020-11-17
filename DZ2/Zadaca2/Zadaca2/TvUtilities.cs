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
            int min;
            for (int i = 0; i < episodes.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < episodes.Length; j++)
                {
                    if (episodes[j] > episodes[min])
                    {
                        min = j;
                    }
                }
                Episode temp = episodes[i];
                episodes[i] = episodes[min];
                episodes[min] = temp;
            }
        }

        public static Episode Parse(string name)
        {
            Description desc = new Description(int.Parse(name.Split(',')[3]), TimeSpan.Parse(name.Split(',')[4]), name.Split(',')[5]);
            return new Episode(int.Parse(name.Split(',')[0]), double.Parse(name.Split(',')[1]), double.Parse(name.Split(',')[2]), desc);
        }

    }
}

