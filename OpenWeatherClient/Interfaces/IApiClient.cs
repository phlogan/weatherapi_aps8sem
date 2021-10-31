namespace OpenWeatherClient.Interfaces
{
    public interface IApiClient
    {
        IAirQualityIndexClient AirQualityIndexClient { get; set; }
        IWeatherClient WeatherClient { get; set; }
        IForecastClient ForecastClient { get; set; }
    }
}
