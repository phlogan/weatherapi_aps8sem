using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenWeatherClient.Model
{
    public class ApiRequestData
    {
        public ApiRequestData(params string[] pathing)
        {
            Pathing = "";
            foreach (var p in pathing ?? new string[0])
                Pathing += "/" + p;

            QueryParameters = new Dictionary<string, string>();
        }

        public string Pathing { get; set; }
        public IDictionary<string, string> QueryParameters { get; private set; }
        public void AddQueryParameter(string key, string value) => QueryParameters.Add(key, value);
    }
}
