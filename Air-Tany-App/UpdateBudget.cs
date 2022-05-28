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

//mettre a jour le budget d'un trader

namespace Air_Tany_App
{
    public partial class UpdateBudget : Form 
    {
        int idStaff; //variable qui va contenir id utilisateur
        public UpdateBudget(int id) //passe id en parametre
        {
            InitializeComponent();
            idStaff = id;
            txbBudget.Text = Common.GetBudget(idStaff, Program.connection).ToString(); //affiché le budget actuel du trader
        }

        private void Modif_Click(object sender, EventArgs e) //valide 
        {

            DialogResult dr = MessageBox.Show("Etes vous sur des modifications ? ", //afficher message de confirmation
               "Message de confirmation",
               MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information);

            if (dr == DialogResult.Yes) //si cliqué oui au message de confirmation
            {
                float budget  = float.Parse(txbBudget.Text); //recuperer le budget saisi dans champs 
                string id = idStaff.ToString(); //id qu'on a passé au formulaire on le convertit en string 
                MySqlCommand updadeCMD = new MySqlCommand($"UPDATE `trader` SET `trd_end_date` = NOW() WHERE stf_id='{id}'", Program.connection.Connection); //maj les anciens budgets en mettant la date de fin a la date et h actuelle 
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `trader`(`trd_budget`, `trd_start_date`," +
                    $"`stf_id`) VALUES ('{budget}',NOW(),'{id}')", Program.connection.Connection); // ajouter le nouveau budget
                updadeCMD.ExecuteNonQuery(); // executer la requete update
                cmd.ExecuteNonQuery(); //requete insert 
                Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e) //bouton retour annuler
        {
            Close();

        }
    }
}
