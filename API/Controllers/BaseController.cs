using Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace API.Controllers
{
    public class BaseController : Controller
    {
        protected ILogRepository _logRepository;
        public BaseController(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();
            _logRepository.RegisterLog(new Data.Entity.ApiLog(ip,
                "api",
                string.Join(':', filterContext.ActionDescriptor.DisplayName.Split('.').Skip(2)),
                DateTime.UtcNow
                ));
        }
    }
}
