using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenWeatherClient.Model.Weather
{
    [Serializable]
    public class CurrentWeatherData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("main")]
        public WeatherDetailed Detail { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("wind")]
        public WeatherWind Wind { get; set; }

        [JsonProperty("clouds.all")]
        public string Clouds { get; set; }

        //"dt": 1485789600,
        //"sys": {
        //  "type": 1,
        //  "id": 5091,
        //  "message": 0.0103,
        //  "country": "GB",
        //  "sunrise": 1485762037,
        //  "sunset": 1485794875
        //},
        //"id": 2643743,
        //"name": "London",
        //"cod": 200
        //}
    }
}
