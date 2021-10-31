using OpenWeatherClient.Model.Weather;
using OpenWeatherClient.Model.Weather.Forecast;

namespace OpenWeatherClient.Interfaces
{
    public interface IWeatherClient
    {
        CurrentWeatherData GetCurrentWeatherData(string cityName);
        CurrentWeatherData GetCurrentWeatherData(string latitude, string longitude);
    }
}
