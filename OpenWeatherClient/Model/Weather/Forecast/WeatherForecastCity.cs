using Newtonsoft.Json;
using System;

namespace OpenWeatherClient.Model.Weather.Forecast
{
    [Serializable]
    public class WeatherForecastCity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }
    }
}
