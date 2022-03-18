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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            MySqlCommand req = new MySqlCommand("SELECT * FROM staff");
            req.Connection = Program.connection.Connection;
            MySqlDataReader reader = req.ExecuteReader();

            while (reader.Read())
            {
                lstDisplay.Items.Add(reader.GetValue(2));
            }
        }
    }
}
