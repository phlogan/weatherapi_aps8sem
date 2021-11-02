using System;

namespace Data.Entity
{
    public class ApiLog
    {
        public ApiLog() { }
        
        public ApiLog(int id, string ip, string appId, string action, DateTime date)
        {
            Id = id;
            Ip = ip;
            AppId = appId;
            Action = action;
            Date = date;
        }

        public ApiLog(string ip, string appId, string action, DateTime date) : this(0, ip, appId, action, date) { }
        public int Id { get; set; }
        public string Ip { get; set; }
        public string AppId { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
    }
}
