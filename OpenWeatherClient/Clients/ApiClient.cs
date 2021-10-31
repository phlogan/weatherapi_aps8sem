using OpenWeatherClient.Interfaces;

namespace OpenWeatherClient.Clients
{
    public class ApiClient : IApiClient
    {
        public ApiClient(
            IAirQualityIndexClient airQualityIndexClient,
            IWeatherClient weatherClient,
            IForecastClient forecastClient)
        {
            AirQualityIndexClient = airQualityIndexClient;
            WeatherClient = weatherClient;
            ForecastClient = forecastClient;
        }

        #region :: Propriedades
        public IAirQualityIndexClient AirQualityIndexClient { get; set; }
        public IWeatherClient WeatherClient { get; set; }
        public IForecastClient ForecastClient { get; set; }
        #endregion
    }
}
