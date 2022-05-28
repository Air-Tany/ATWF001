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

//afficher tous les employés qui sont inscrits 

namespace Air_Tany_App
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        private void btnDisplay_Click(object sender, EventArgs e) // bouton affichage 
        {
            //recuperer tous les employés avec leur job actuel 
            MySqlDataAdapter req = new MySqlDataAdapter($"SELECT `staff`.`stf_id` AS `Id`, " +
                "`staff`.`stf_lastname` AS `Nom de famille`, " +
                "`staff`.`stf_firstname` AS `Prénom`, `staff`.`stf_username`" +
                " AS `Nom d'utilisateur`, `staff`.`stf_email` AS `Adresse e-mail`," +
                " `job`.`job_name` AS `Rôle`, `job`.`job_start_date` AS `Depuis le`" +
                " FROM `job` LEFT JOIN `staff` ON `staff`.`stf_id` = `job`.`stf_id`" +
                " WHERE" +
                " `job`.`job_start_date` <= NOW() AND ( `job`.`job_end_date` >= NOW() OR" +
                " `job`.`job_end_date` IS NULL ) GROUP BY `job`.`stf_id`" +
                " ORDER BY" +
                " job.job_name ASC," +
                " `staff`.`stf_lastname` ASC, `staff`.`stf_firstname` ASC", Program.connection.Connection);
            DataTable dt = new DataTable();
            req.Fill(dt); 
            dgvPersonnel.DataSource = dt;

            
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void dgvPersonnel_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //quand on double clique qur ligne qu'on souhaite modifier / ouvre le formulaire modif staf avec id de l'employé qur lequel on a cliqué 
        {
            int id = int.Parse(dgvPersonnel.Rows[e.RowIndex].Cells[0].Value.ToString());//converti en entier
            ModifStaff staff = new ModifStaff(id);
            staff.ShowDialog();
            staff.Dispose();
        }

        private void dgvPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}