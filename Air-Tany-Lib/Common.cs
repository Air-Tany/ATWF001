using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Air_Tany_Lib
{
    static public class Common
    {
        static public string rdmString(int length = 16, string charList = "0123456789abcdefghijklmnopqrstuvwxyz")
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

        static public int? checkUserCredentials(string UserName, string PasswordHash, DBConn Conn) // le ? peut etre nul 
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT `stf_id` FROM `staff` WHERE `stf_username` = '{UserName}' AND `stf_password` = '{PasswordHash}'", Conn.Connection);
            try
            {
                int? Uid = (int?)cmd.ExecuteScalar();
                return Uid;
            }
            catch
            {
                return null;
            }
        }

        static public string createSessionToken(int? Uid, DBConn Conn)
        {

            if (Uid != null)
            {
                string rdmToken = rdmString(255, "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `session_token`( `stk_token`, `stk_creation_date`, " +
                    $"`stf_id`) VALUES ('{rdmToken}',NOW(),'{Uid}'); SELECT LAST_INSERT_ID();", Conn.Connection);
                int res = (int)(UInt64) cmd.ExecuteScalar();
                if (res != -1)
                {
                    return rdmToken;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

        public static UserInfo GetUserInfo(DBConn Conn, string TK)
        {
            MySqlCommand cmd = new MySqlCommand($"SELECT `stf_id`, `stf_lastname`, `stf_firstname`, " +
                $"`stf_username`, `stf_email` FROM `session_token` NATURAL JOIN `staff` WHERE session_token.stk_token = '{TK}'", Conn.Connection);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    return new UserInfo((int)reader["stf_id"], reader["stf_lastname"].ToString(), reader["stf_firstname"].ToString(), 
                        reader["stf_username"].ToString(), reader["stf_email"].ToString());
                }
                return null;
            }
        }

        public static string GetJob(int id, DBConn Conn)
        {
            MySqlCommand req = new MySqlCommand($"SELECT `job_name` FROM `job` WHERE `job`.`stf_id` = '{id}' AND " +
                $"(`job`.`job_start_date` <= NOW()) AND (`job`.`job_end_date` >= NOW() OR `job`.`job_end_date` IS NULL) " +
                $"ORDER BY `job`.`job_start_date` DESC LIMIT 1", Conn.Connection);
            string res = (string)req.ExecuteScalar();
            if (!string.IsNullOrEmpty(res))
            {
                return res;
            }
            else
            {
                return null;
            }
        }

        public static float? GetBudget(int id, DBConn Conn)
        {
            MySqlCommand req = new MySqlCommand($"SELECT `trd_budget` FROM `trader` WHERE `trader`.`stf_id` = '{id}' AND " +
                $"(`trader`.`trd_start_date` <= NOW()) AND (`trader`.`trd_end_date` >= NOW() OR `trader`.`trd_end_date` IS NULL) " +
                $"ORDER BY `trader`.`trd_start_date` DESC LIMIT 1", Conn.Connection);
            float res = (float)req.ExecuteScalar();
            return res;
        }




    }
}
