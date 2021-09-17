using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenWeatherClient.Interfaces;

namespace API.Controllers
{
    [Route("api/airpollution")]
    [ApiController]
    public class AirPollutionController : ControllerBase
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

        //// GET api/<AirPollutionController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<AirPollutionController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<AirPollutionController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<AirPollutionController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
