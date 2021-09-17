using Newtonsoft.Json;
using System;

namespace OpenWeatherClient.Model.AirPollution
{
    [Serializable]
    public class AirQualityIndexData
    {
        [JsonProperty("dt")]
        public string DateTimeStamp { get; set; }

        [JsonProperty("main")]
        public AirQualityIndex AQI { get; set; }

        [JsonProperty("components")]
        public AirPollutionComponents Components { get; set; }
    }

    public class AirQualityIndex
    {
        [JsonProperty("aqi")]
        public string Value { get; set; }
    }
}
