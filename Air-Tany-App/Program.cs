using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Air_Tany_Lib;

/* fichier principal, celui qui est appelé quand on lance le projet - 
 * définit ce qui se passe à l'ouverture */

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
            CultureInfo culture = CultureInfo.GetCultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            /* forcé l'application a utilisé les formats anglophones */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainLayout()); // appelle le formulaire principal qui est mainlayout
        }
        static public string sessionToken; // jeton de session de l'utilisateur connecté
        static public DBConn connection; // connexion base de données
        static public string execPath = Application.ExecutablePath; // chemin de l'executable
        static private IEnumerable<string> _tmp = execPath.Split('\\').Take(execPath.Length - 2); // dossier parent du dossier parent de l'executable
        static public string appPath = string.Join("\\", _tmp.Skip(1)); // chemin d'execution de l'appli
        /* variables qu'on veut rendre accessibles dans toutes les fenêtres de l'application, 
         on peut donc les appeler depuis n'importe où */
    }
}       
