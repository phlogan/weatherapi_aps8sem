using Newtonsoft.Json;

namespace OpenWeatherClient.Model.AirPollution
{
    public class AirPollutionComponents
    {
        [JsonProperty("co")]
        public string CarbonMonoxide { get; set; }

        [JsonProperty("no")]
        public string NitrogenMonoxide { get; set; }

        [JsonProperty("no2")]
        public string NitrogenDioxide { get; set; }

        [JsonProperty("o3")]
        public string Ozone { get; set; }

        [JsonProperty("so2")]
        public string SulphurDioxide { get; set; }

        [JsonProperty("pm2_5")]
        public string FineParticleMatter { get; set; }

        [JsonProperty("pm10")]
        public string CoarseParticleMatter { get; set; }

        [JsonProperty("nh3")]
        public string Ammonia { get; set; }
    }
}
