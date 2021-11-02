using Data.Interface;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model;
using OpenWeatherClient.Model.AirPollution;
using System.Linq;

namespace OpenWeatherClient.Clients
{
    public class AirQualityIndexClient : BaseApi, IAirQualityIndexClient
    {
        public AirQualityIndexClient(IApiAccessRepository apiAccessRepository) : base(apiAccessRepository)
        {
            MainPath = "air_pollution";
        }

        public AirPollutionData GetCurrentAirPollutionData(string latitude, string longitude)
        {
            var request = new ApiRequestData();
            request.AddQueryParameter("lat", latitude);
            request.AddQueryParameter("lon", longitude);

            return Call<AirPollutionData>(request);
        }

        public string GetAirQualityIndex(string latitude, string longitude)
        {
            var result = GetCurrentAirPollutionData(latitude, longitude);
            return result.Data?.FirstOrDefault()?.AQI?.Value;
        }

    }
}
