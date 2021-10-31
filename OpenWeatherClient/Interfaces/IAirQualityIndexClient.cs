using OpenWeatherClient.Model.AirPollution;

namespace OpenWeatherClient.Interfaces
{
    public interface IAirQualityIndexClient
    {
        AirPollutionData GetCurrentAirPollutionData(string latitude, string longitude);
        string GetAirQualityIndex(string latitude, string longitude);
    }
}
