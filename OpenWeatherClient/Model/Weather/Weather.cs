using Newtonsoft.Json;
using System;

namespace OpenWeatherClient.Model.Weather
{
    [Serializable]
    public class Weather
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string IconCode { get; set; }
    }
}
