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

        DBConn connection;
        private void OptExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OptConnect_Click(object sender, EventArgs e)
        {
            LogIn connection = new LogIn();
            connection.ShowDialog();
        }
        public bool CreateConnection()
        {
            string host = ConfigurationManager.ConnectionStrings["DBHost"].ConnectionString;
            string port = ConfigurationManager.ConnectionStrings["DBPort"].ConnectionString;
            string dataBase = ConfigurationManager.ConnectionStrings["DBDatabase"].ConnectionString;
            string userName = ConfigurationManager.ConnectionStrings["DBUsername"].ConnectionString;
            string pwd = ConfigurationManager.ConnectionStrings["DBPassword"].ConnectionString;
            connection = new DBConn(port, host, dataBase, userName, pwd);
            return connection.Open();

        }

        private void MainLayout_Load(object sender, EventArgs e)
        {
            if (!CreateConnection())
            {
                MessageBox.Show("La connexion a échoué. Réessayer ultérieurement");
                Close();
            }
        }
    }
}
