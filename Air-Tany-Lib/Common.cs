using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Air_Tany_Lib
{
    class Common
    {
        public string rdmString(int length = 16, string charList = "0123456789abcdefghijklmnopqrstuvwxyz")
        {
            char[] result = new char[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                int pos = rand.Next(charList.Length);
                result[i] = charList[pos];
            }
            return new String(result);
            

        }

        public int? checkUserCredentials(string UserName, string PasswordHash, DBConn Conn)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT `stf_id` FROM `staff` WHERE `stf_username` = {UserName} AND `stf_password` = {PasswordHash}", Conn.Connection);
            object result = cmd.ExecuteScalar();
            int? Uid = null;
            if (result.GetType() != typeof(DBNull))
            {
                Uid = (int?)result;
            }
            return Uid;
        }

        public string createSessionToken(int? Uid)
        {

            if (Uid != null)
            {
                string rdmToken = rdmString(255, "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ")
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `session_token`( `stk_token`, `stk_creation_date`, `stk_expiration_date`, `stf_id`) VALUES ('[value-2]','[value-3]','[value-4]','[value-5]')  "
            }
        }
            
            
            
            }
}
