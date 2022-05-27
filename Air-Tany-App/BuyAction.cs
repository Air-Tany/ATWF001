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

namespace Air_Tany_App
{
    public partial class BuyAction : Form
    {
        string _isin;
        float _price;
        public BuyAction(string isin, float price)
        {
            InitializeComponent();
            _isin = isin;
            _price = price;

        }

        private void btnOk_Click(object sender, EventArgs e)
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
                if (budget < totalPrice)
                {
                    MessageBox.Show("budget insuffisant",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                else
                {
                    float newBudget = budget - totalPrice;  
                    MySqlTransaction transaction = Program.connection.Connection.BeginTransaction();
                   
                    MySqlCommand cmd = Program.connection.Connection.CreateCommand();
                    cmd.Transaction = transaction;

                    try
                    {
                        Console.WriteLine(_isin);
                        Console.WriteLine(_price);
                        string sql1 = $"INSERT INTO `operation` (`op_date`, `op_quantity`, `stf_id`, `act_id`, `op_price`) SELECT NOW(), '{Convert.ToSingle(quantity)}', '{user.id}', `act_id`, '{_price}' FROM `action` WHERE `action`.`act_isin` = '{_isin}'";

                        cmd.CommandText = sql1;
                        cmd.ExecuteNonQuery();


                        string sql2 = $"UPDATE `trader` SET `trader`.`trd_end_date` = NOW() WHERE `trader`.`stf_id` = '{user.id}' AND `trader`.`trd_end_date` IS NULL";

                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();

                        string sql3 = $"INSERT INTO `trader` (`trd_start_date`, `trd_budget`, `stf_id`) VALUES (NOW(), '{Convert.ToSingle(newBudget)}', '{user.id}')";

                        cmd.CommandText = sql3;
                        cmd.ExecuteNonQuery();

                        string sql4 = $"SELECT SUM(`portfolio_stock`.`prt_quantity`) FROM `portfolio_stock` JOIN `action` ON `action`.`act_isin` = '{_isin}' WHERE `portfolio_stock`.`stf_id` = '{user.id}' AND `portfolio_stock`.`act_id` = `action`.`act_id`";

                        cmd.CommandText = sql4;
                        int oldQuantity = (int)cmd.ExecuteScalar();

                        string sql5 = $"DELETE `portfolio_stock` FROM `portfolio_stock` JOIN `action` ON `action`.`act_isin` = '{_isin}' WHERE `portfolio_stock`.`stf_id` = '{user.id}' AND `portfolio_stock`.`act_id` = `action`.`act_id`";

                        cmd.CommandText = sql5;
                        cmd.ExecuteNonQuery();

                        string sql6 = $"INSERT INTO `portfolio_stock` (`stf_id`, `act_id`, `prt_quantity`) SELECT '{user.id}', `act_id`, '{Convert.ToSingle(oldQuantity + quantity)}' FROM `action` WHERE `action`.`act_isin` = '{_isin}'";

                        cmd.CommandText = sql6;
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        transaction.Rollback();
                    }


                }
                Close();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
