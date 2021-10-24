using Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/teste")]
    [ApiController]
    public class TesteController : Controller
    {
        protected IApiAccessRepository _tokenRepository;
        public TesteController(IApiAccessRepository tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }

        [HttpGet]
        public string Index()
        {
            return "Works";
        }

        [Route("gettoken")]
        [HttpGet]
        public string GetTokenAccess()
        {
            var a = _tokenRepository.GetByApiSlug("open-weather");
            return a.Token;
        }
    }
}
