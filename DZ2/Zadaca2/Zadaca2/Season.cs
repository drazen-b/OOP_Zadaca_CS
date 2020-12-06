using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Season
    {
        public Episode[] episodes { get; private set; }
        public int SeasonNum { get; private set; }
        public int Length { get; private set; }

        public Season(int SeasonNum, Episode[] episodes)
        {
            this.SeasonNum = SeasonNum;
            this.episodes = episodes;
            Length = episodes.Length;
        }

        public Episode this[int WordIndex]
        {
            get { return episodes[WordIndex]; }
            set { episodes[WordIndex] = value; }
        }

        public int GetTotalViewers()
        {
            int Total = 0;
            foreach(Episode episode in episodes)
            {
                Total += episode.GetViewerCount();
            }
            return Total;
        }

        public TimeSpan GetTotalDuration()
        {
            TimeSpan Total =    new TimeSpan(0);
            foreach (Episode episode in episodes)
            {
                Total += episode.Description.EpDuration;
            }
            return Total;
        }

        public override string ToString()
        {
            string Text = "";
            Text +=
                $"Season {SeasonNum}:\n" +
                "=================================================\n";

            foreach(Episode episode in episodes)
            {
                Text += $"{episode}\n";
            }

            Text += "Report:\n"
                + "=================================================\n"
                + $"Total viewers: {GetTotalViewers()}\n"
                + $"Total duration: {GetTotalDuration()}\n"
                + "=================================================\n";

            return $"{Text}";
        }
    }
}
