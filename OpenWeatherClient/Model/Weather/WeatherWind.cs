using Newtonsoft.Json;
using System;

namespace OpenWeatherClient.Model.Weather
{
    [Serializable]
    public class WeatherWind
    {
        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("deg")]
        public string Degrees { get; set; }
    }
}
