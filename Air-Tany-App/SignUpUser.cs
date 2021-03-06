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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string lastname = txbName.Text;
            string firstname = txbFirstname.Text;
            string username = txbUsername.Text;
            string mail = txbMail.Text;
            string job = cbxJob.Text;
            DateTime start_date = dtpStartDate.Value;
            DateTime end_date = dtpEndDate.Value;
            string password = Common.rdmString(16, "0123456789abcdefghijklmnopqrstuvwxyz");
            MySqlCommand signup = new MySqlCommand($"INSERT INTO staff (`stf_lastname`, `stf_firstname`, `stf_username`, `stf_email`, `stf_password`) VALUES ('{lastname}', '{firstname}', '{username}', '{mail}', '{Common.SHA512(password)}'); SELECT LAST_INSERT_ID()", Program.connection.Connection);
            int res = (int)(UInt64)signup.ExecuteScalar();
            if (res != -1)
            {
                MySqlCommand q = new MySqlCommand($"INSERT INTO job (`job_name`, `job_start_date`, `job_end_date`, `stf_id`) VALUES ('{job}', '{start_date.ToString("s")}', {(cbxEndDate.Checked ? $"'{end_date.ToString("s")}'" : "NULL")}, '{res}')", Program.connection.Connection);
                q.ExecuteNonQuery();
                MessageBox.Show(password);
            }
            Close();
        }
    }
}
