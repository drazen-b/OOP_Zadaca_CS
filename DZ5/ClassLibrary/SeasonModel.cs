using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class SeasonModel
    {
        public int Id { get;  private set; }
        public string Name { get; private set; } 
        public int Season { get; private set; }
        public int Number { get; private set; }

        public List<EpisodeModel> Episodes { get; private set;}

        public SeasonModel(int id, string name, int season, int number)
        {
            Id = id;
            Name = name;
            Season = season;
            Number = number;
        }


        public void SetEpisodes (List<EpisodeModel> episodes)
        {
            Episodes = new List<EpisodeModel>();

            foreach (EpisodeModel ep in episodes)
            {
                Episodes.Add(ep);
            }
        }

    }
}
