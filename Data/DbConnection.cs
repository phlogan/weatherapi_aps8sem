using MySql.Data.MySqlClient;
using System;

namespace Data
{
    public class DbConnection
    {
        public DbConnection()
        {
            Server = "192.168.1.35";
            Database = "aps8sem";
            UID = "logan";
            Password = "123mudar";
            Port = "3306";
            Connection = new MySqlConnection(ConnectionString);
        }
        public string Server { get; private set; }
        public string Port { get; private set; }
        public string Database { get; private set; }
        public string UID { get; private set; }
        public string Password { get; private set; }
        public string ConnectionString
        {
            get
            {
                return string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};",
                    Server, Port, Database, UID, Password);
            }
        }

        private MySqlConnection Connection { get; set; }

        /// <summary>
        /// Abre a conexão e a retorna
        /// </summary>
        public MySqlConnection GetConnection()
        {
            Connection.Open();
            return Connection;
        }
    }
}
