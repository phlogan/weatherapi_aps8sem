using Data.Interface;
using Newtonsoft.Json;
using OpenWeatherClient.Clients;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model;
using OpenWeatherClient.Model.AirPollution;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace OpenWeatherClient.Clients
{
    public class AirQualityIndexClient : BaseApi, IAirQualityIndexClient
    {
        #region :: Constantes
        //private const string PARAMS = "http://api.openweathermap.org/data/2.5/air_pollution?";
        #endregion
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
