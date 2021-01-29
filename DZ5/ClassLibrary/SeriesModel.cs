using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class showsModel
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public string OfficialSite { get; private set; }
        public string[] Genres { get; private set; }
        public string Status { get; private set; }
        public List<SeasonModel> Seasons { get; private set; }
        public RatingModel Rating { get; private set; }
        public string Summary { get; private set; }
        public string Type { get; private set; }
        public ImageModel Image { get; private set; }
        public NetworkModel Network { get; private set; }

        public showsModel(string name, int id, string officialSite, string[] genres, string status, int runtime, RatingModel rating, string summary, string type, ImageModel image, NetworkModel network)
        {
            Name = name;
            Id = id;
            OfficialSite = officialSite;
            Genres = genres;
            Status = status;
            Rating = rating;
            Summary = summary;
            Type = type;
            Image = image;
            Network = network;
        }

        public void SetSeasons(List<SeasonModel> seasons)
        {
            Seasons = new List<SeasonModel>();

            foreach (SeasonModel season in seasons)
            {
                Seasons.Add(season);
            }
        }

    }
}
