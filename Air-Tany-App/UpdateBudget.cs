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
    public partial class UpdateBudget : Form
    {
        int idStaff;
        public UpdateBudget(int id)
        {
            InitializeComponent();
            idStaff = id;
            txbBudget.Text = Common.GetBudget(idStaff, Program.connection).ToString();
        }

        private void Modif_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Etes vous sur des modifications ? ",
               "Message de confirmation",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                float budget  = float.Parse(txbBudget.Text);
                string id = idStaff.ToString();
                MySqlCommand updadeCMD = new MySqlCommand($"UPDATE `trader` SET `trd_end_date` = NOW() WHERE stf_id='{id}'", Program.connection.Connection);
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `trader`(`trd_budget`, `trd_start_date`," +
                    $"`stf_id`) VALUES ('{budget}',NOW(),'{id}')", Program.connection.Connection);
                updadeCMD.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
