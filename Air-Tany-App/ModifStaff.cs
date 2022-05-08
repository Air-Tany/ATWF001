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
    public partial class ModifStaff : Form
    {
        int idStaff;
        public ModifStaff( int id)
        {
            InitializeComponent();
            idStaff = id;
            Text = "Modification de l'id " + id;
            cbxJob.Text = Common.GetJob(idStaff, Program.connection);


        }

        private void Sup_Click(object sender, EventArgs e)
        {
           

        }

        private void Modify_Click(object sender, EventArgs e)
        {

                DialogResult dr = MessageBox.Show("Etes vous sur des modifications ? ",
                   "Message de confirmation", 
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                string job = cbxJob.Text;
                string id = idStaff.ToString();
                MySqlCommand updadeCMD = new MySqlCommand($"UPDATE `job` SET `job_end_date`=NOW() WHERE stf_id='{id}'", Program.connection.Connection);
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `job`(`job_name`, `job_start_date`," +
                    $"`stf_id`) VALUES ('{job}',NOW(),'{id}')", Program.connection.Connection);
                updadeCMD.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                Close();

                }
        }
    }
}
