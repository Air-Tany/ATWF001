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

namespace Air_Tany_App
{
    public partial class MainLayout : Form
    {
        public MainLayout()
        {
            InitializeComponent();
        }

        private void OptExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OptConnect_Click(object sender, EventArgs e)
        {
            LogIn connectionForm = new LogIn();
            connectionForm.ShowDialog();
            if (!string.IsNullOrEmpty(Program.sessionToken))
            {
                UserInfo userInfo = Common.GetUserInfo(Program.connection, Program.sessionToken);
                tsslLogIn.Text = $"Bonjour {userInfo.firstname} {userInfo.lastname}";
            }
        }
        public bool CreateConnection()
        {
            string host = ConfigurationManager.ConnectionStrings["DBHost"].ConnectionString;
            string port = ConfigurationManager.ConnectionStrings["DBPort"].ConnectionString;
            string dataBase = ConfigurationManager.ConnectionStrings["DBDatabase"].ConnectionString;
            string userName = ConfigurationManager.ConnectionStrings["DBUsername"].ConnectionString;
            string pwd = ConfigurationManager.ConnectionStrings["DBPassword"].ConnectionString;
            Program.connection = new DBConn(port, host, dataBase, userName, pwd); // insère la connexion au Program.con...
            return Program.connection.Open();

        }

        private void MainLayout_Load(object sender, EventArgs e)
        {
            if (!CreateConnection())
            {
                MessageBox.Show("La connexion a échoué. Réessayer ultérieurement");
                Close();
            }
        }

        private void créerUnUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUpUser form = new SignUpUser();
            form.ShowDialog();
        }
    }
}
