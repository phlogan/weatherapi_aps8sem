using Data.Entity;
using System.Collections.Generic;

namespace Data.Interface
{
    public interface ILogRepository
    {
        void RegisterLog(ApiLog log);
        List<ApiLog> GetLogs(string logSecurityKey);
    }
}
