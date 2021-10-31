using Newtonsoft.Json;
using System;

namespace OpenWeatherClient.Model
{
    [Serializable]
    public class Coordinates
    {
        [JsonProperty("lon")]
        public string Longitude { get; set; }

        [JsonProperty("lat")]
        public string Latitude { get; set; }
    }
}
