using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenWeatherClient.Model.AirPollution
{
    [Serializable]
    public class AirPollutionData
    {
        //[DataMember(Required=)]
        [JsonProperty("coord")]
        public Coord Coordinates { get; set; }
        
        [JsonProperty("list")]
        public List<AirQualityIndexData> Data { get; set; }

    }

    public class Coord
    {
        [JsonProperty("lon")]
        public string Longitude { get; set; }

        [JsonProperty("lat")]
        public string Latitude { get; set; }
    }
}