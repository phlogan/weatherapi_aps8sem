using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenWeatherClient.Interfaces;

namespace API.Controllers
{
    [Route("api/airpollution")]
    [ApiController]
    public class AirPollutionController : Controller
    {
        public IApiClient OpenWeatherApiClient { get; set; }
        public AirPollutionController(IApiClient openWeatherApiClient)
        {
            OpenWeatherApiClient = openWeatherApiClient;
        }
        [HttpGet]
        public string Get()
        {
            var airPollutionData = OpenWeatherApiClient.AirQualityIndexClient.GetCurrentAirPollutionData("10", "10");
            return JsonConvert.SerializeObject(airPollutionData);
        }
    }
}
