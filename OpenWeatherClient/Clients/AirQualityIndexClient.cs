using Newtonsoft.Json;
using OpenWeatherClient.Clients;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model.AirPollution;
using System.Collections.Generic;
using System.Net.Http;

namespace OpenWeatherClient.Clients
{
    public class AirQualityIndexClient : BaseApi, IAirQualityIndexClient
    {
        #region :: Constantes
        //private const string PARAMS = "http://api.openweathermap.org/data/2.5/air_pollution?";
        #endregion
        public string Path { get; set; }
        public AirQualityIndexClient() : base()
        {
            Path = "air_pollution";
        }

        public AirPollutionData GetCurrentAirPollutionData(string latitude, string longitude)
        {
            using (var httpClient = new HttpClient())
            {
                var parameters = new List<KeyValuePair<string, string>>();
                parameters.Add(new KeyValuePair<string, string>("lat", latitude));
                parameters.Add(new KeyValuePair<string, string>("lon", longitude));

                return Call<AirPollutionData>(parameters.ToArray());
            }
        }

        #region :: Métodos privados
        private TModel Call<TModel>(params KeyValuePair<string, string>[] parameters)
        {
            using(var client = new HttpClient())
            {
                var requestUrl = string.Format("{0}/{1}?", Host, Path);
                foreach(var param in parameters)
                    requestUrl += string.Format("{0}={1}&", param.Key, param.Value);

                requestUrl += string.Format("appid={0}", Token);
                
                var responseContent = client.GetAsync(requestUrl).Result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TModel>(responseContent.Result);
            }
        }
        #endregion
    }
}
