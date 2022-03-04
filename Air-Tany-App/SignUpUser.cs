using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Air_Tany_Lib;

namespace Air_Tany_App
{
    public partial class SignUpUser : Form
    {
        public SignUpUser()
        {
            InitializeComponent();
        }

        private void cbxEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.Enabled = !dtpEndDate.Enabled;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string lastname = txbName.Text;
            string firstname = txbFirstname.Text;
            string username = txbUsername.Text;
            string mail = txbMail.Text;
            string password = Common.SHA512(Common.rdmString(16, "0123456789abcdefghijklmnopqrstuvwxyz"));
            MySqlCommand signup = new MySqlCommand($"ISERT INTO staff (`stf_lastname`, `stf_firstname`, `stf_username`, `stf_email`, `stf_password`) VALUES ('{lastname}', '{firstname}', '{username}', '{mail}', '{password}')", Program.connection.Connection);
            try
            {
                signup.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Erreur d'exécution");
            }

        }
    }
}
