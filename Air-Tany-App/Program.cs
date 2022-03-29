using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Air_Tany_Lib;


namespace Air_Tany_App
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainLayout());
        }
        static public string sessionToken;
        static public DBConn connection;
        static public string execPath = Application.ExecutablePath;
        static private IEnumerable<string> _tmp = execPath.Split('\\').Take(execPath.Length - 2);
        static public string appPath = string.Join("\\", _tmp.Skip(1));
    }
}       
