namespace OpenWeatherClient.Interfaces
{
    public interface IApiClient
    {
        IAirQualityIndexClient AirQualityIndexClient { get; set; }
    }
}
