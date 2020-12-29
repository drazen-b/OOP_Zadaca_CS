using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Season : IEnumerable<Episode>
    {
        public List<Episode> episodes { get; private set; }
        public int SeasonNum { get; private set; }

        public Season(int SeasonNum, List<Episode> episodes)
        {
            this.SeasonNum = SeasonNum;
            this.episodes = episodes;
        }

        
        public Episode this[int WordIndex]
        {
            get { return episodes[WordIndex]; }
            set { episodes[WordIndex] = value; }
        }


        public Season(Season other)
        {
            this.episodes = new List<Episode>();

            foreach(var ep in other)
            {
                episodes.Add(new Episode(ep));
            }

            this.SeasonNum = other.SeasonNum;
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
                Text += $"{episode.ToString()}\n";
            }

            Text += "Report:\n"
                + "=================================================\n"
                + $"Total viewers: {GetTotalViewers()}\n"
                + $"Total duration: {GetTotalDuration()}\n"
                + "=================================================\n";

            return $"{Text}";
        }


        public void Add(Episode ep)
        {
            episodes.Add(ep);
        }

        public void Remove(string epName) 
        {

            int num = -1;
            num = episodes.FindIndex(x => x.Description.EpName == epName);
            if (num == -1) throw new TvException(epName, "No such episode found");

            episodes.RemoveAt(num);
        }



        public IEnumerator<Episode> GetEnumerator()
        {
            return ((IEnumerable<Episode>)episodes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Episode>)episodes).GetEnumerator();

        }

    }
}
