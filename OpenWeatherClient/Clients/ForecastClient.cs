using Data.Interface;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model;
using OpenWeatherClient.Model.Weather.Forecast;

namespace OpenWeatherClient.Clients
{
    public class ForecastClient : BaseApi, IForecastClient
    {
        public ForecastClient(IApiAccessRepository apiAccessRepository) : base(apiAccessRepository)
        {
            MainPath = "forecast";
        }
        public WeatherForecast GetForecast(string latitude, string longitude, int daysToForecast)
        {
            var request = new ApiRequestData();
            request.AddQueryParameter("lat", latitude);
            request.AddQueryParameter("lon", longitude);
            request.AddQueryParameter("cnt", daysToForecast > 5 ? 5.ToString() : daysToForecast.ToString());
            request.AddQueryParameter("lang", "pt");
            request.AddQueryParameter("units", "metric");

            return Call<WeatherForecast>(request);
        }
    }
}
