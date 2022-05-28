using Air_Tany_Lib;
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

namespace Air_Tany_App
{
    public partial class SendAction : Form
    {
        string _isin;
        
        public SendAction(string isin)
        {
            InitializeComponent();
            _isin = isin;
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int price = 20;
            int quantity = (int)nudSend.Value;
            Console.WriteLine("isin =");
            Console.WriteLine(_isin);
            UserInfo user = Common.GetUserInfo(Program.connection, Program.sessionToken);
            int _qte = Common.GetQuantity(user.id, _isin, Program.connection);
            int newQuantity = _qte - quantity ;
            DialogResult dr = MessageBox.Show($"Voulez-vous valider la vente de {quantity} action ? ",
                   "Message de confirmation",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                
                
                if (_qte < quantity)
                {
                    MessageBox.Show($"vous ne possedez que {_qte} action",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                else
                {
                    float budget = Common.GetBudget(user.id, Program.connection);
                    float newBudget = quantity * price + budget;
                    MySqlTransaction transaction = Program.connection.Connection.BeginTransaction();

                    MySqlCommand cmd = Program.connection.Connection.CreateCommand();
                    cmd.Transaction = transaction;

                    try
                    {
                        
                        string sql1 = $"INSERT INTO `operation` (`op_date`, `op_quantity`, `stf_id`, `act_id`, `op_price`) SELECT NOW(), '-{Convert.ToSingle(quantity)}', '{user.id}', `act_id`, '{price}' FROM `action` WHERE `action`.`act_isin` = '{_isin}'";

                        cmd.CommandText = sql1;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql1 ok");

                        string sql2 = $"UPDATE `trader` SET `trader`.`trd_end_date` = NOW() WHERE `trader`.`stf_id` = '{user.id}' AND `trader`.`trd_end_date` IS NULL";

                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql2 ok");

                        string sql3 = $"INSERT INTO `trader` (`trd_start_date`, `trd_budget`, `stf_id`) VALUES (NOW(), '{Convert.ToSingle(newBudget)}', '{user.id}')";

                        cmd.CommandText = sql3;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql3 ok");

                        string sql4 = $"SELECT COALESCE(SUM(`portfolio_stock`.`prt_quantity`), 0) FROM `portfolio_stock` JOIN `action` ON `action`.`act_isin` = '{_isin}' WHERE `portfolio_stock`.`stf_id` = '{user.id}' AND `portfolio_stock`.`act_id` = `action`.`act_id`";

                        cmd.CommandText = sql4;
                        string res = cmd.ExecuteScalar().ToString();
                        Console.WriteLine(res);
                        int oldQuantity = int.Parse(res);
                        Console.WriteLine(oldQuantity);

                        string sql5 = $"DELETE `portfolio_stock` FROM `portfolio_stock` JOIN `action` ON `action`.`act_isin` = '{_isin}' WHERE `portfolio_stock`.`stf_id` = '{user.id}' AND `portfolio_stock`.`act_id` = `action`.`act_id`";

                        cmd.CommandText = sql5;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql5 ok");

                        string sql6 = $"INSERT INTO `portfolio_stock` (`stf_id`, `act_id`, `prt_quantity`) SELECT '{user.id}', `act_id`, '{Convert.ToSingle(newQuantity)}' FROM `action` WHERE `action`.`act_isin` = '{_isin}'";

                        cmd.CommandText = sql6;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql6 ok");

                        string sql7 = $"DELETE FROM `portfolio_stock` WHERE portfolio_stock.prt_quantity <= '0'";

                        cmd.CommandText = sql7;
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("sql7 ok");

                        transaction.Commit();
                    }
                    catch (Exception ex)
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
