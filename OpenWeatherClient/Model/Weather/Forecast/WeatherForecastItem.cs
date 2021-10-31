using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenWeatherClient.Model.Weather.Forecast
{
    [Serializable]
    public class WeatherForecastItem
    {
        [JsonProperty("dt")]
        public string Date { get; set; }

        [JsonProperty("main")]
        public WeatherForecastItemMain Main { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("dt_txt")]
        public string DateText { get; set; }
    }
}
