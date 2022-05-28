using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

/*classe, fonctions/méthodes utilisées dans l'appli */

namespace Air_Tany_Lib
{
    static public class Common
    {
        static public string rdmString(int length = 16, string charList = "0123456789abcdefghijklmnopqrstuvwxyz")
            /* métode permettant de générer une chaîne de caractères aléatoire, de longueur et incluant les caractères 
             * passés en paramètre*/
        {
            char[] result = new char[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                int pos = rand.Next(charList.Length);
                result[i] = charList[pos];
            }
            return new String(result);
            /* créé une liste de caractères de longueur "lenght" 
            créé un objet "random" permettant de générer des éléménets aléatoires 
            boucle, création d'une variable i égale à 0, boucle se répéte allant de 0 à la longueur -1, rajoutant 1 à i
            création d'une variable pos qui appelle la méthode next de l'objet rand, méthode renvoie un nb entier aléatoire
            entre 0 et le nb passé en paramètre 
            dans la liste result à la position i, on attribue le caractère de la liste charlist se trouvant à la position pos
            retourne liste result en string
            */

        }

        static public int? checkUserCredentials(string UserName, string PasswordHash, DBConn Conn) // le ? peut etre nul 
        /* méthode permettant de vérifier qu'un compte correspond au username et au password passés en paramètre */
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
           /*métode permettant de créer jeton de connexion lié à l'id de l'utilisateur passé en paramètre */
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
            /*méthode permettant de hacher le message passé en paramètre avec la fonction SHA512*/
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
            /* A partir du token/jeton de session passé en paramètre, la mèthode retourne les infos de l'utilisateur
             relié au jeton*/
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
            /* cette méthode retourne le job actuel de l'utilisateur à partir de son id passé en paramètre */
        {
            MySqlCommand req = new MySqlCommand($"SELECT `job_name` FROM `job` WHERE `job`.`stf_id` = '{id}' AND " +
                $"(`job`.`job_start_date` <= NOW()) AND (`job`.`job_end_date` >= NOW() OR `job`.`job_end_date` IS NULL) " +
                $"ORDER BY `job`.`job_start_date` DESC LIMIT 1", Conn.Connection);
            string res = (string)req.ExecuteScalar();
            
            Console.WriteLine("common");
            Console.WriteLine(res);
            if (!string.IsNullOrEmpty(res))
            {
                return res;
            }
            else
            {
                return null;
            }
        }

        public static float GetBudget(int id, DBConn Conn)
            /* méthode permettant de récuperer le budget du trader à partir de son id passé en paramètre */
        {
            MySqlCommand req = new MySqlCommand($"SELECT `trd_budget` FROM `trader` WHERE `trader`.`stf_id` = '{id}' AND " +
                $"(`trader`.`trd_start_date` <= NOW()) AND (`trader`.`trd_end_date` >= NOW() OR `trader`.`trd_end_date` IS NULL) " +
                $"ORDER BY `trader`.`trd_start_date` DESC LIMIT 1", Conn.Connection);
            float res = (float)req.ExecuteScalar();
            return res;
        }




    }
}
