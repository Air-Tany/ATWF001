using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/* classe qui contient la connexion à la base de données mysql*/

namespace Air_Tany_Lib
{

    public class DBConn
    {
        private MySqlConnection _connection;

        public DBConn(string port, string host, string dataBase, string userName, string pwd)
            /* constructeur(créé une instance(une version de la classe avec des propriétés différentes) de la classe) 
             de la class DBConn, les infos de connexion sont passés en paramètre  */
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
            /*cette classe permet de créer une string de connexion à partir des infos qu'on lui donne */

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
