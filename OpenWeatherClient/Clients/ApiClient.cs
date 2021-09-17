using OpenWeatherClient.Interfaces;

namespace OpenWeatherClient.Clients
{
    public class ApiClient : IApiClient
    {
        ///TODO: definir aqui a conexão pra API
        ///criar um método "CallApi" genérico pra fazer as buscas padronizadamente?
        public ApiClient(
            IAirQualityIndexClient airQualityIndexClient)
        {
            AirQualityIndexClient = airQualityIndexClient;
        }

        #region :: Propriedades
        public IAirQualityIndexClient AirQualityIndexClient { get; set; }
        #endregion
    }
}
