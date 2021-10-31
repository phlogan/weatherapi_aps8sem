using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model.AirPollution;

namespace API.Controllers
{
    [Route("api/airQuality")]
    [ApiController]
    public class AirPollutionController : Controller
    {
        public IApiClient OpenWeatherApiClient { get; set; }
        public AirPollutionController(IApiClient openWeatherApiClient)
        {
            OpenWeatherApiClient = openWeatherApiClient;
        }
        //[HttpGet]
        //public string Get()
        //{
        //    var airPollutionData = OpenWeatherApiClient.AirQualityIndexClient.GetCurrentAirPollutionData("10", "10");
        //    return JsonConvert.SerializeObject(airPollutionData);
        //}

        //[HttpGet]
        //[Route("getByLatLon")]
        //public string GetByLatLon(string latitude, string longitude)
        //{
        //    var airPollutionData = OpenWeatherApiClient.AirQualityIndexClient.GetCurrentAirPollutionData(latitude, longitude);
        //    return JsonConvert.SerializeObject(airPollutionData);
        //}

        [HttpGet]
        [Route("getData")]
        public AirPollutionData GetAirPollutionData(string latitude, string longitude)
        {
            var data = OpenWeatherApiClient.AirQualityIndexClient.GetCurrentAirPollutionData(latitude, longitude);
            return data;
        }

        [HttpGet]
        [Route("index")]
        public string GetAirQualityIndex(string latitude, string longitude)
        {
            var index = OpenWeatherApiClient.AirQualityIndexClient.GetAirQualityIndex(latitude, longitude);
            return index;
        }
    }
}
