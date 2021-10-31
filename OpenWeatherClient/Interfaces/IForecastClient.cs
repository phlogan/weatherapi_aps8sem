using OpenWeatherClient.Model.Weather.Forecast;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherClient.Interfaces
{
    public interface IForecastClient
    {
        WeatherForecast GetForecast(string latitude, string longitude, int daysToForecast);
    }
}
