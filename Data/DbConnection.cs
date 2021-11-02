using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Data
{
    public class DbConnection
    {
        public DbConnection()
        {
            JObject jObject = JObject.Parse(File.ReadAllText(System.IO.Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName, "Data\\appsettings.json")));

            Server = jObject["ConnectionStrings"]["server"].ToString();
            Database = jObject["ConnectionStrings"]["database"].ToString();
            UID = jObject["ConnectionStrings"]["uid"].ToString();
            Password = jObject["ConnectionStrings"]["password"].ToString();
            Port = jObject["ConnectionStrings"]["port"].ToString();

            LogSecurityKey = jObject["Logs"]["SecurityKey"].ToString();

            Connection = new MySqlConnection(ConnectionString);
        }

        public string Server { get; private set; }
        public string Port { get; private set; }
        public string Database { get; private set; }
        public string UID { get; private set; }
        public string Password { get; private set; }
        public string LogSecurityKey { get; private set; }
        public string ConnectionString
        {
            get
            {
                return string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};convert zero datetime=True",
                    Server, Port, Database, UID, Password);
            }
        }

        private MySqlConnection Connection { get; set; }

        /// <summary>
        /// Abre a conexão e a retorna
        /// </summary>
        public MySqlConnection GetConnection()
        {
            try
            {
                Connection.Open();
                return Connection;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
