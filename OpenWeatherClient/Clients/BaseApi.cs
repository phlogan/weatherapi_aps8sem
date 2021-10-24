using Data.Interface;
using Newtonsoft.Json.Linq;
using OpenWeatherClient.Interfaces;
using System.IO;

namespace OpenWeatherClient.Clients
{
    public class BaseApi : IBaseApi
    {
        public BaseApi(IApiAccessRepository tokenRepository)
        {
            JObject jObject = JObject.Parse(File.ReadAllText(Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "OpenWeatherClient\\apiconnection.json")));

            var apiAccess = tokenRepository.GetByApiSlug(jObject["api"]["slug"].ToString());
            Host = apiAccess.ApiHost;
            Token = apiAccess.Token;
        }

        #region :: Propriedades
        protected string Host { get; private set; }
        protected string Token { get; private set; }
        #endregion
    }
}
