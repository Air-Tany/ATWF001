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
            MySqlDataAdapter req = new MySqlDataAdapter("SELECT	job_id AS ID, `stf`.`stf_lastname` AS `Nom`," +
                "`stf`.`stf_firstname` AS `Prenom`,"+
                
                "`stf`.`stf_username` AS `NonUtilisateur`," +
                " `stf`.`stf_email` AS `Mail`," +
                " `job_name` AS ROLE " +
                "FROM job NATURAL JOIN staff AS stf" +
                " where" +
                " `job`.`job_start_date` <= NOW() AND (`job_end_date` >= NOW()" +
                " OR `job_end_date` IS NULL)" +
                " ORDER BY " +
                "`job`.`stf_id` ASC," +
                "`job_start_date` DESC", Program.connection.Connection);
            DataTable dt = new DataTable();
            req.Fill(dt); 
            dgvPersonnel.DataSource = dt;

            
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void dgvPersonnel_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dgvPersonnel.Rows[e.RowIndex].Cells[0].Value.ToString());//converti en entier
            ModifStaff staff = new ModifStaff(id);
            staff.ShowDialog();
            staff.Dispose();
        }
    }
}
