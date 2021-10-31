using Data.Interface;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model;
using OpenWeatherClient.Model.Weather;
using OpenWeatherClient.Model.Weather.Forecast;
using System.Collections.Generic;

namespace OpenWeatherClient.Clients
{
    public class WeatherClient : BaseApi, IWeatherClient
    {
        public WeatherClient(IApiAccessRepository apiAccessRepository) : base(apiAccessRepository)
        {
            MainPath = "weather";
        }
        public CurrentWeatherData GetCurrentWeatherData(string cityName)
        {
            var request = new ApiRequestData();
            request.AddQueryParameter("q", cityName);
            request.AddQueryParameter("units", "metric");
            request.AddQueryParameter("lang", "pt");

            return Call<CurrentWeatherData>(request);
        }

        public CurrentWeatherData GetCurrentWeatherData(string latitude, string longitude)
        {
            var request = new ApiRequestData();
            request.AddQueryParameter("lat", latitude);
            request.AddQueryParameter("lon", longitude);
            request.AddQueryParameter("units", "metric");
            request.AddQueryParameter("lang", "pt");

            return Call<CurrentWeatherData>(request);
        }
    }
}
