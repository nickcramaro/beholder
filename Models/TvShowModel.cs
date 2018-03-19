using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace Beholder.Models
{
    public class TvShowModel
    {
        [JsonProperty(PropertyName = "backdrop_path")]
        public string BackdropImagePath;

        [JsonProperty(PropertyName = "id")]
        public int Id;

        [JsonProperty(PropertyName = "episode_run_time")]
        public IEnumerable<int> EpisodeRunTime;

        [JsonProperty(PropertyName = "first_air_date")]
        public string FirstAirDate;

        [JsonProperty(PropertyName = "in_production")]
        public bool InProduction;

        [JsonProperty(PropertyName = "languages")]
        public IEnumerable<string> Languages;

        [JsonProperty(PropertyName = "last_air_date")]
        public string LastAirDate;

        [JsonProperty(PropertyName = "name")]
        public string Name;

        [JsonProperty(PropertyName = "number_of_episodes")]
        public int NumberOfEpisodes;

        [JsonProperty(PropertyName = "number_of_seasons")]
        public int NumberOfSeasons;

        [JsonProperty(PropertyName = "origin_country")]
        public IEnumerable<string> OriginCountry;

        [JsonProperty(PropertyName = "original_language")]
        public string OriginalLanguage;

        [JsonProperty(PropertyName = "original_name")]
        public string OriginalName;

        [JsonProperty(PropertyName = "overview")]
        public string Overview;

        [JsonProperty(PropertyName = "popularity")]
        public int Popularity;

        [JsonProperty(PropertyName = "poster_path")]
        public string PosterImagePath;

        [JsonProperty(PropertyName = "status")]
        public string Status;

        [JsonProperty(PropertyName = "type")]
        public string Type;

        [JsonProperty(PropertyName = "vote_average")]
        public int VoteAverage;

        [JsonProperty(PropertyName = "vote_count")]
        public int VoteCount;
    }
}
