using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model.Weather;
using OpenWeatherClient.Model.Weather.Forecast;

namespace API.Controllers
{
    [Route("api/weather")]
    [ApiController]
    public class WeatherController : Controller
    {
        public IApiClient OpenWeatherApiClient { get; set; }
        public WeatherController(IApiClient openWeatherApiClient)
        {
            OpenWeatherApiClient = openWeatherApiClient;
        }
        [HttpGet]
        [Route("currentWeather/{cityName}")]
        public CurrentWeatherData GetCurrentWeatherData(string cityName)
        {
            var weatherData = OpenWeatherApiClient.WeatherClient.GetCurrentWeatherData(cityName);

            return weatherData;
        }

        [HttpGet]
        [Route("currentWeather")]
        public CurrentWeatherData GetCurrentWeatherData(string latitude, string longitude)
        {
            var weatherData = OpenWeatherApiClient.WeatherClient.GetCurrentWeatherData(latitude, longitude);

            return weatherData;
        }

        [HttpGet]
        [Route("forecast")]
        public WeatherForecast GetForecast(string latitude, string longitude, int daysToForecast)
        {
            var weatherData = OpenWeatherApiClient.ForecastClient.GetForecast(latitude, longitude, daysToForecast);

            return weatherData;
        }

    }
}
