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
using Air_Tany_Lib;


/* pour acheter des actions */

namespace Air_Tany_App
{
    public partial class BuyAction : Form // la classe buyaction herite de la classe form 
    {
        string _isin;
        float _price;
        public BuyAction(string isin, float price) // constructeur de la classe buyaction 
        {
            InitializeComponent();
            _isin = isin; // parametre
            _price = price; //parametre 

        }

        private void btnOk_Click(object sender, EventArgs e) // bouton ok / valide 
        {
            int quantity = (int)nudBuy.Value;
            float totalPrice = quantity * _price;
            DialogResult dr = MessageBox.Show($"valider l'achat de {totalPrice}€ ",
                   "Message de confirmation",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                UserInfo user = Common.GetUserInfo(Program.connection ,Program.sessionToken);
                float budget = Common.GetBudget(user.id, Program.connection);
                if (budget < totalPrice) // budget insuffisant 
                {
                    MessageBox.Show("budget insuffisant",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                else // budget suffisant 
                {
                    float newBudget = budget - totalPrice; // calcul nouveau budget 
                    MySqlTransaction transaction = Program.connection.Connection.BeginTransaction(); // plusieurs requetes sql a la suite et si une plane, ça les annule toutes 
                   // exemple banque transferer argent d'un compte a un autre 
                    MySqlCommand cmd = Program.connection.Connection.CreateCommand();
                    cmd.Transaction = transaction;

                    try
                    {
                        // ajouter operation dans table operation
                        Console.WriteLine(_isin);
                        Console.WriteLine(_price);
                        string sql1 = $"INSERT INTO `operation` (`op_date`, `op_quantity`, `stf_id`, `act_id`, `op_price`) SELECT NOW(), '{Convert.ToSingle(quantity)}', '{user.id}', `act_id`, '{Convert.ToSingle(_price)}' FROM `action` WHERE `action`.`act_isin` = '{_isin}'";

                        cmd.CommandText = sql1;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql1 ok");

                        // mettre une date de fin aux anciens dugets du trader 
                        string sql2 = $"UPDATE `trader` SET `trader`.`trd_end_date` = NOW() WHERE `trader`.`stf_id` = '{user.id}' AND `trader`.`trd_end_date` IS NULL";

                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql2 ok");

                        //ajout du nouveau budget
                        string sql3 = $"INSERT INTO `trader` (`trd_start_date`, `trd_budget`, `stf_id`) VALUES (NOW(), '{Convert.ToSingle(newBudget)}', '{user.id}')";

                        cmd.CommandText = sql3;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql3 ok");

                        //on va chercher dans portfoliostock la quantité d'action déjà possédé par le trader 
                        string sql4 = $"SELECT COALESCE(SUM(`portfolio_stock`.`prt_quantity`), 0) FROM `portfolio_stock` JOIN `action` ON `action`.`act_isin` = '{_isin}' WHERE `portfolio_stock`.`stf_id` = '{user.id}' AND `portfolio_stock`.`act_id` = `action`.`act_id`";

                        cmd.CommandText = sql4;
                        string res = cmd.ExecuteScalar().ToString();
                        Console.WriteLine(res);
                        int oldQuantity = int.Parse(res);
                        Console.WriteLine(oldQuantity);

                        //supprime ancienne quantité d'action
                        string sql5 = $"DELETE `portfolio_stock` FROM `portfolio_stock` JOIN `action` ON `action`.`act_isin` = '{_isin}' WHERE `portfolio_stock`.`stf_id` = '{user.id}' AND `portfolio_stock`.`act_id` = `action`.`act_id`";

                        cmd.CommandText = sql5;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql5 ok");

                        //ajout de la nouvelle quantité 
                        string sql6 = $"INSERT INTO `portfolio_stock` (`stf_id`, `act_id`, `prt_quantity`) SELECT '{user.id}', `act_id`, '{Convert.ToSingle(oldQuantity + quantity)}' FROM `action` WHERE `action`.`act_isin` = '{_isin}'";

                        cmd.CommandText = sql6;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql6 ok");

                        transaction.Commit(); // valider la transaction
                    }
                    catch(Exception ex) // au cas ou il y a une erreur dans une des requetes sql 
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback(); // revenir à l'tat avant la transaction 
                    }


                }
                Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e) // bouton retour - quitte le formulaire
        {
            Close();
        }

        private void BuyAction_Load(object sender, EventArgs e)
        {

        }
    }
}
