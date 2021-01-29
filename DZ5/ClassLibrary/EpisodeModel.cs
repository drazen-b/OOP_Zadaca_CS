using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class EpisodeModel
    {
        public int Id { get; private set; }
        public int  Season { get; private set; }
        public string Name { get; private set; }


        public EpisodeModel(int id, int season, string name)
        {
            Id = id;
            Season = season;
            Name = name;

        }
    }
}
