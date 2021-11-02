using Data.Entity;
using Data.Interface;
using MySql.Data.MySqlClient;
using System;

namespace Data.Repository
{
    public class ApiAccessRepository : DbConnection, IApiAccessRepository
    {
        public ApiAccessRepository() : base() { }

        public ApiAccess GetByApiSlug(string apiSlug)
        {
            using(var con = base.GetConnection())
            {
                try
                {
                    MySqlCommand query = new MySqlCommand("SELECT * FROM apiAccess WHERE apiSlug = @apiSlug", con);
                    query.Parameters.AddWithValue("@apiSlug", apiSlug);

                    MySqlDataReader rdr = query.ExecuteReader();
                    rdr.Read();

                    var result = new ApiAccess(Convert.ToInt32(rdr["id"]), rdr["apiSlug"].ToString(), rdr["apiHost"].ToString(), rdr["token"].ToString());
                    return result;
                }
                catch(Exception ex)
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
