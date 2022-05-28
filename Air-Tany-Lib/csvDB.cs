using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

/* lire des données à partir d'un fichier csv(tabler qu'on lire en code) */

namespace Air_Tany_Lib
{
    public class csvDB
    {
        public static void CSV(string Path)
        {
            MySqlCommand cmd;

            var reader = new StreamReader(File.OpenRead(Path));
            var pointA = "";
            string pointB = "";
            string pointC = "";
            float money = 0;
            Random num = new Random();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                var values = line.Split(';');

                pointA = values[0];
                pointB = values[1];
                pointC = values[2];
                money = (float)num.NextDouble();


                cmd = new MySqlCommand($"INSERT INTO `action`(`act_name`, `act_isin`, `act_ticker`) VALUES ('{pointB}','{pointA}','{pointC}')");
                int res = (int)(UInt64)cmd.ExecuteScalar();
                if (res != -1)
                {
                    cmd = new MySqlCommand($"INSERT INTO `price`(`prc_price`, `prc_date`, `act_id`) VALUES ('{money}','NOW()','[value-4]')");
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
