using Data.Entity;
using Data.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    public class LogController : Controller
    {
        protected ILogRepository _logRepository;
        public LogController(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        [HttpGet]
        [Route("getAll/{securityKey}")]
        public List<ApiLog> GetAllLogs(string securityKey)
        {
            return _logRepository.GetLogs(securityKey);
        }
    }
}
