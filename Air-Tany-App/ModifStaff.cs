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
            MySqlCommand cmd = new MySqlCommand($"Select job_name FROM job where job_id = {idStaff}", Program.connection.Connection);
            cbxJob.Text =   cmd.ExecuteScalar().ToString();


        }

        private void Sup_Click(object sender, EventArgs e)
        {
           

        }

        private void Modify_Click(object sender, EventArgs e)
        {

                DialogResult dr = MessageBox.Show("Etes vous sur des modifications ? ", "message de confirmation", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                        string job = cbxJob.Text;
                        string test = idStaff.ToString();
                        MySqlCommand cmd = new MySqlCommand($"UPDATE `job` SET `job_name`='{job}' WHERE job_id = {test}", Program.connection.Connection);
                }
            

        }
    }
}
