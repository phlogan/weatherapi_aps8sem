using Data.Interface;
using Microsoft.AspNetCore.Mvc;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model.AirPollution;

namespace API.Controllers
{
    [Route("api/airQuality")]
    [ApiController]
    public class AirPollutionController : BaseController
    {
        protected IApiClient _openWeatherApiClient;
        public AirPollutionController(IApiClient openWeatherApiClient, ILogRepository logRepository) : base(logRepository)
        {
            _openWeatherApiClient = openWeatherApiClient;
        }

        [HttpGet]
        [Route("getData")]
        public AirPollutionData GetAirPollutionData(string latitude, string longitude)
        {
            var data = _openWeatherApiClient.AirQualityIndexClient.GetCurrentAirPollutionData(latitude, longitude);
            return data;
        }

        [HttpGet]
        [Route("index")]
        public string GetAirQualityIndex(string latitude, string longitude)
        {
            var index = _openWeatherApiClient.AirQualityIndexClient.GetAirQualityIndex(latitude, longitude);
            return index;
        }

        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    var ip = HttpContext.Connection.RemoteIpAddress.ToString();
        //    _logRepository.RegisterLog(new Data.Entity.ApiLog(ip,
        //        "api",
        //        string.Join(':', filterContext.ActionDescriptor.DisplayName.Split('.').Skip(2)),
        //        DateTime.UtcNow
        //        ));
        //}

    }
}
