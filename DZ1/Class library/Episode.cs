using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Class_library
{
    public class Episode
    {
        public int viewerCount = 0;
        public double maxScore { get; set; }
        public double viewerScoreSum { get; set; }

        public Episode() {
            viewerScoreSum = 0;
            maxScore = 0;          
        }

        public Episode(int viewercount, double viewerscoresum, double maxscore)
        {
            viewerCount = viewercount;
            viewerScoreSum = viewerscoresum;
            maxScore = maxscore;
        }

        public int GetViewerCount() { return viewerCount; }
        public double GetAverageScore() { return viewerScoreSum / viewerCount; }
        public double GetMaxScore() { return maxScore; }

         public void AddView(double score)
        {
            viewerCount++;
            viewerScoreSum += score;

            if (score > maxScore)
            {
                maxScore = score;
            }
        }

    }
}
