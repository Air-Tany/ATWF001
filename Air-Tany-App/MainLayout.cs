using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Air_Tany_Lib;
using System.Configuration;
using System.Globalization;
using System.IO;

/* formulaire principal, affiche le menu de base permettant d'accéder aux autres formulaires  */

namespace Air_Tany_App
{
    public partial class MainLayout : Form
    {

        public MainLayout()
            /* quand le formulaire mainlayout s'ouvre, la fonction showadminmnu = verifie *
              le role de l'utilisateur et affiche les menus qui correpondent */
        {
            InitializeComponent();
            ShowAdminMnu();
        }

        private void OptExit_Click(object sender, EventArgs e) //option quitter du menu fichier 
        {
            Close();
        }

        private void OptConnect_Click(object sender, EventArgs e) //option connexion du menu fichier
        {
            LogIn connectionForm = new LogIn(); // appelle formulaire de connexion login
            connectionForm.ShowDialog(); // afficher le formulaire 
            connectionForm.Dispose(); // une fois fermé vider memoire 
            if (!string.IsNullOrEmpty(Program.sessionToken)) // si la connexion a réussi 
            {
                UserInfo userInfo = Common.GetUserInfo(Program.connection, Program.sessionToken);
                tsslLogIn.Text = $"Bonjour {userInfo.firstname} {userInfo.lastname}";
                ShowAdminMnu();
                /* récupere infos de l'utilisateur qui vient de se co, 
                 affiche son nom et recalcule les menus qui doivent être affiché*/
            }
        }
        public bool CreateConnection() // cree connexion à la base de données 
        {
            /* appelle les parametres qui sont dans app.config*/
            string host = ConfigurationManager.ConnectionStrings["DBHost"].ConnectionString;
            string port = ConfigurationManager.ConnectionStrings["DBPort"].ConnectionString;
            string dataBase = ConfigurationManager.ConnectionStrings["DBDatabase"].ConnectionString;
            string userName = ConfigurationManager.ConnectionStrings["DBUsername"].ConnectionString;
            string pwd = ConfigurationManager.ConnectionStrings["DBPassword"].ConnectionString;
            Program.connection = new DBConn(port, host, dataBase, userName, pwd); /* on stock la 
            connexion à la bdd dans le program ce qui permet d'y accéder depuis n'importe où dans l'application */
            return Program.connection.Open(); // retourne si l'ouverture de la connexion à fonctionné 

        }

        private void OptDeconnect_Click(object sender, EventArgs e) // option deconnexion du fichier
        {
            Program.sessionToken = null;
            tsslLogIn.Text = "";
            ShowAdminMnu();
        }

        private void MainLayout_Load(object sender, EventArgs e) // evenement appellé quand le formulaire est ouvert/chargé
        {
            if (!CreateConnection())
            {
                MessageBox.Show("La connexion a échoué. Réessayer ultérieurement");
                Close();
            }
        }
        public void ShowAdminMnu() //selon role et personne co quel menu faut afficher
        {
            if (!string.IsNullOrEmpty(Program.sessionToken))
            {
                UserInfo user = Common.GetUserInfo(Program.connection, Program.sessionToken);
                string job = Common.GetJob(user.id, Program.connection);
                Console.WriteLine(job);
                switch (job)
                {
                    case "Administrateur":
                        MnuAdmin.Visible = true;
                        MnuStaff.Visible = true;
                        MnuOperations.Visible = false;
                        break;

                    case "Trader":
                        MnuOperations.Visible= true;
                        MnuAdmin.Visible = false;
                        MnuStaff.Visible = false;
                        break;

                        
                    default:
                        MnuAdmin.Visible = false;
                        MnuStaff.Visible = false;
                        MnuOperations.Visible=false;
                        break;
                }
            }
            else
            {
                MnuAdmin.Visible = false;
                MnuStaff.Visible = false;
                MnuOperations.Visible = false;
            }
        }
       

        private void créerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e) // option creer un utilisateur du menu admin
        {
            SignUpUser form = new SignUpUser();
            form.ShowDialog();
            form.Dispose();
        }

        private void MnuStaff_Click(object sender, EventArgs e) // menu personnel - afficher personnel
        {
            Employees form = new Employees();
            form.ShowDialog();
            form.Dispose();
        }

        private void Cours_Click(object sender, EventArgs e) // option cours du menu produit 
        {
            Stock form =new Stock();
            form.ShowDialog();
            form.Dispose();
        }

        private void OptFillTables_Click(object sender, EventArgs e) // option remplir table du menu administaration
        {
            Console.WriteLine(Program.appPath);
            csvDB.CSV(Path.Combine(Program.appPath, @"\res\csv\libelles.csv"));
        }

        private void budgetTraderToolStripMenuItem_Click(object sender, EventArgs e) 
        {
        }

        private void budgetTrds(object sender, EventArgs e) // option budget trader du menu admin
        {
            BudgetTrd form = new BudgetTrd();
            form.ShowDialog();
            form.Dispose();
        }

        private void MnuDocuments_Click(object sender, EventArgs e)
        {
        
        }

        private void MnuAdmin_Click(object sender, EventArgs e)
        {

        }

        private void MnuOperations_Click(object sender, EventArgs e) // menu operation - affiche action et portfeuille trader
        {
            OperationTime form = new OperationTime();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
