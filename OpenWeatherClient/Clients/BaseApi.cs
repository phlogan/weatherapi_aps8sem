using Newtonsoft.Json.Linq;
using OpenWeatherClient.Interfaces;
using System.IO;

namespace OpenWeatherClient.Clients
{
    public class BaseApi : IBaseApi
    {
        public BaseApi()
        {
            JObject jObject = JObject.Parse(File.ReadAllText(Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "OpenWeatherClient\\apiconnection.json")));
            Host = jObject["api"]["host"].ToString();
            Token = jObject["api"]["token"].ToString();
        }
        #region :: Propriedades
        protected string Host { get; private set; }
        protected string Token { get; private set; }
        #endregion
    }
}
