using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Episode
    {
        public double AverageScore { get; private set; }
        public int ViewerCount { get; private set; }
        public double MaxScore { get; private set; }
        public Description Description { get; private set; }

        public Episode()
        {
            AverageScore = 0;
            ViewerCount = 0;
            MaxScore = 0;
        }

        public Episode(int ViewerCount, double AverageScore, double MaxScore)
        {
            this.MaxScore = MaxScore;
            this.AverageScore = AverageScore;
            this.ViewerCount = ViewerCount;
        }

        public Episode(int ViewerCount, double AverageScore, double MaxScore, Description Description)
        {
            this.MaxScore = MaxScore;
            this.AverageScore = AverageScore;
            this.ViewerCount = ViewerCount;
            this.Description = Description;
        }

        public void AddView(double Score)
        {
            ViewerCount++;
            if (MaxScore < Score) { this.MaxScore = Score; }
            this.AverageScore += Score;
        }

        public double GetAverageScore()
        {
            return AverageScore/ViewerCount;
        }

        public double GetMaxScore()
        {
            return this.MaxScore;
        }

        public int GetViewerCount()
        {
            return ViewerCount;
        }

        public override string ToString()
        {
            return $"{ViewerCount},{AverageScore},{MaxScore},{this.Description}";
        }

        public static bool operator <(Episode ep1, Episode ep2)
        {
            return (ep1.GetAverageScore()) < (ep2.GetAverageScore());
        }

        public static bool operator >(Episode ep1, Episode ep2)
        {
            return !(ep1 < ep2);
        }

        public static bool operator <=(Episode ep1, Episode ep2)
        {
            return (ep1.GetAverageScore()) <= (ep2.GetAverageScore());
        }

        public static bool operator >=(Episode ep1, Episode ep2)
        {
            return !(ep1 <= ep2);
        }
    }
}
