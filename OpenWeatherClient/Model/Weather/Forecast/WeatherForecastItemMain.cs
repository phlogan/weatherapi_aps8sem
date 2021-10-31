using Newtonsoft.Json;
using System;

namespace OpenWeatherClient.Model.Weather.Forecast
{
    [Serializable]
    public class WeatherForecastItemMain
    {
        [JsonProperty("temp")]
        public string Temperature { get; set; }

        [JsonProperty("temp_min")]
        public string MinTemperature { get; set; }

        [JsonProperty("temp_max")]
        public string MaxTemperature { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("sea_level")]
        public string SeaLevel { get; set; }

        [JsonProperty("grnd_level")]
        public string GroundLevel { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }
    }
}
