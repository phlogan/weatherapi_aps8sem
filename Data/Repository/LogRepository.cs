using Data.Entity;
using Data.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Data.Repository
{
    public class LogRepository : DbConnection, ILogRepository
    {
        public void RegisterLog(ApiLog log)
        {
            using (var con = base.GetConnection())
            {
                try
                {
                    MySqlCommand comm = con.CreateCommand();
                    comm.CommandText = "INSERT INTO apiLog(ip, appId, action, date) VALUES(@ip, @appId, @action, @date)";
                    comm.Parameters.AddWithValue("@ip", log.Ip);
                    comm.Parameters.AddWithValue("@appId", log.AppId);
                    comm.Parameters.AddWithValue("@action", log.Action);
                    comm.Parameters.AddWithValue("@date", log.Date);
                    comm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    con.Close();
                    throw ex;
                }
            }
        }

        public List<ApiLog> GetLogs(string logSecurityKey)
        {
            var result = new List<ApiLog>();
            if (logSecurityKey != base.LogSecurityKey)
                return result;

            using (var con = base.GetConnection())
            {
                try
                {
                    MySqlCommand query = new MySqlCommand("SELECT * FROM apiLog", con);

                    MySqlDataReader rdr = query.ExecuteReader();
                    while (rdr.Read())
                    {
                        DateTime.TryParse(rdr["date"].ToString(), out DateTime date);
                        result.Add(new ApiLog(
                            Convert.ToInt32(rdr["id"]),
                            rdr["ip"].ToString(),
                            rdr["appId"].ToString(),
                            rdr["action"].ToString(),
                            date
                            ));
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
