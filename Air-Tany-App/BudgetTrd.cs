using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* formulaire permet de gerer les budgets des traders */

namespace Air_Tany_App
{
    public partial class BudgetTrd : Form
    {
        public BudgetTrd()
        {
            InitializeComponent();
        }

        private void BudgetTrd_Load(object sender, EventArgs e)
        {
            listUser();
        }
        public void listUser()
        {
           /* récuperer les traders avec leeur dernier budget */

            MySqlDataAdapter req = new MySqlDataAdapter($"SELECT staff.stf_id AS ID ,stf_lastname AS Prénom, " +
                $"stf_firstname AS Nom, stf_username AS Username, " +
                $"trd.trd_budget AS Budget FROM staff " +
                $"LEFT JOIN job ON `staff`.`stf_id` = `job`.`stf_id` " +
                $"LEFT JOIN trader AS trd ON `staff`.`stf_id` = `trd`.`stf_id` " +
                $"WHERE `job`.`job_start_date` <= NOW() " +
                $"AND ( `job`.`job_end_date` >= NOW() " +
                $"OR `job`.`job_end_date` IS NULL) " +
                $"AND job.job_name = 'Trader' " +
                $"AND trd.trd_start_date <= NOW() " +
                $"AND( `trd`.`trd_end_date` >= NOW() " +
                $"OR `trd`.`trd_end_date` IS NULL) " +
                $"GROUP BY job.stf_id ORDER BY `staff`.`stf_lastname` ASC, `staff`.`stf_firstname` ASC", Program.connection.Connection);
            DataTable dt = new DataTable();
            req.Fill(dt);
            DtgBudget.DataSource = dt;
        }

        private void DtgBudget_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddBudget(object sender, DataGridViewCellMouseEventArgs e) // modifier bidget trader, ouvre le formulaire update budget permattant de le modifer
        {
            int id = int.Parse(DtgBudget.Rows[e.RowIndex].Cells[0].Value.ToString());//converti en entier
            UpdateBudget form = new UpdateBudget(id);
            form.ShowDialog();
            form.Dispose();
            System.Threading.Thread.Sleep(1000);
            listUser();
        }
    }
}
