using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Air_Tany_Lib
{

    public class DBConn
    {
        private MySqlConnection _connection;

        public DBConn(string port, string host, string dataBase, string userName, string pwd)
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();

            connBuilder.Port = uint.Parse(port);
            connBuilder.Server = host;
            connBuilder.Database = dataBase;
            connBuilder.UserID = userName;
            connBuilder.Password = pwd;
            connBuilder.OldGuids = true;

            _connection = new MySqlConnection(connBuilder.ConnectionString);
        }
        public MySqlConnection Connection
        {
            get => _connection;
        }

        public bool Open()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                return false;
            }
        }
    }
}
