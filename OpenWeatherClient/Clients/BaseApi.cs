﻿using Data.Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenWeatherClient.Interfaces;
using OpenWeatherClient.Model;
using System.IO;
using System.Net.Http;

namespace OpenWeatherClient.Clients
{
    public class BaseApi : IBaseApi
    {
        public BaseApi(IApiAccessRepository tokenRepository)
        {
            JObject jObject = JObject.Parse(File.ReadAllText(System.IO.Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "OpenWeatherClient\\apiconnection.json")));

            var apiAccess = tokenRepository.GetByApiSlug(jObject["api"]["slug"].ToString());
            Host = apiAccess.ApiHost;
            Token = apiAccess.Token;
        }

        #region :: Propriedades
        protected string Host { get; private set; }
        public string MainPath { get; set; }
        protected string Token { get; private set; }
        #endregion

        public TModel Call<TModel>(ApiRequestData requestData)
        {
            using (var client = new HttpClient())
            {
                var requestUrl = string.Format("{0}/{1}{2}?", Host, MainPath,
                    !string.IsNullOrWhiteSpace(requestData.Pathing)
                    ? requestData.Pathing.Trim().Trim('/')
                    : "");
                foreach (var param in requestData.QueryParameters)
                    requestUrl += string.Format("{0}={1}&", param.Key, param.Value);

                requestUrl += string.Format("appid={0}", Token);

                var responseContent = client.GetAsync(requestUrl).Result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TModel>(responseContent.Result);
            }
        }
    }
}
