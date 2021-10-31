using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenWeatherClient.Model.AirPollution
{
    [Serializable]
    public class AirPollutionData
    {
        [JsonProperty("coord")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("list")]
        public List<AirQualityIndexData> Data { get; set; }
    }
}