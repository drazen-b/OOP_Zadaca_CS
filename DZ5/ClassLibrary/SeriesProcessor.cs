using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class showsProcessor
    {
        public static async Task<showsModel> Loadshows(string showsName = "")
        {

            string url_shows = $"http://api.tvmaze.com/singlesearch/shows?q={ showsName }";



            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url_shows))
            {
                if (response.IsSuccessStatusCode)
                {
                    showsModel shows = await response.Content.ReadAsAsync<showsModel>();

                    shows.SetSeasons(await LoadSeasons(shows.Id));

                    return shows;
                }

                else throw new Exception(response.ReasonPhrase);
            }
        }

        public static async Task<List<SeasonModel>> LoadSeasons(int seasonId = 1)
        {

            string url_seasons = $"http://api.tvmaze.com/shows/{ seasonId }/seasons";



            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url_seasons))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<SeasonModel> seasons = new List<SeasonModel>(await response.Content.ReadAsAsync<SeasonModel[]>());



                    foreach (SeasonModel season in seasons)
                    {
                        season.SetEpisodes(await LoadEpisodes(season.Id));
                    }


                    return seasons;
                }

                else throw new Exception(response.ReasonPhrase);
            }
        }
        public static async Task<List<EpisodeModel>> LoadEpisodes(int seasonNumber = 1)
        {

            string url_episodes = $"http://api.tvmaze.com/seasons/{ seasonNumber }/episodes";



            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url_episodes))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<EpisodeModel> episodes = new List<EpisodeModel>(await response.Content.ReadAsAsync<EpisodeModel[]>());


                    return episodes;
                }

                else throw new Exception(response.ReasonPhrase);
            }
        }

    }
}
