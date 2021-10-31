using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenWeatherClient.Model.Weather.Forecast
{
    [Serializable]
    public class WeatherForecast
    {
        [JsonProperty("city")]
        public WeatherForecastCity City { get; set; }

        [JsonProperty("cnt")]
        public string ForecastedDays { get; set; }

        [JsonProperty("list")]
        public List<WeatherForecastItem> Days { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

    }
}
