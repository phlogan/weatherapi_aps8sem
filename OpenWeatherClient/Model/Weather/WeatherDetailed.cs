using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherClient.Model.Weather
{
    [Serializable]
    public class WeatherDetailed
    {
        [JsonProperty("temp")]
        public string Temperature { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("temp_min")]
        public string MinTemperature { get; set; }

        [JsonProperty("temp_max")]
        public string MaxTemperature { get; set; }
    }
}
