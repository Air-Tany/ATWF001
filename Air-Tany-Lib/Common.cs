﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            MySqlCommand cmd = new MySqlCommand($"SELECT `stf_id` FROM `staff` WHERE `stf_username` = {UserName} AND `stf_password` = {PasswordHash}", Conn.Connection);
            object result = cmd.ExecuteScalar();
            int? Uid = null;
            if (result.GetType() != typeof(DBNull))
            {
                Uid = (int?)result;
            }
            return Uid;
        }

        static public string createSessionToken(int? Uid, DBConn Conn)
        {

            if (Uid != null)
            {
                string rdmToken = rdmString(255, "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `session_token`( `stk_token`, `stk_creation_date`, `stf_id`) VALUES ('{rdmToken}',NOW(),'{Uid}'); SELECT LAST_INSERT_ID();", Conn.Connection);
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
            
            
            
            }
}
