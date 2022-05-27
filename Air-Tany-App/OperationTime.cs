using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Configuration;
using System.IO;
using Air_Tany_Lib;

namespace Air_Tany_App
{
    public partial class OperationTime : Form
    {

        [DataContract]
        internal class StockData
        {
            [DataMember]
            internal string name;
            [DataMember]
            internal string isin;
            [DataMember]
            internal string ticker;
            [DataMember]
            internal float lastPrice;
            [DataMember]
            internal string lastPriceCurrency;
            [DataMember]
            internal string lastPriceDate;

        }

        [DataContract]
        internal class Result
        {
            [DataMember]
            internal List<StockData> stocks;

        }
        public OperationTime()
        {
            InitializeComponent();
            GetAction();
            GetPortfolio();
        }

        public void GetAction()
        {
            string token = ConfigurationManager.ConnectionStrings["stockAPItoken"].ConnectionString;
            string baseUrl = ConfigurationManager.ConnectionStrings["stockAPIurl"].ConnectionString;
            string url = @baseUrl + @"/stocks";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("Authorization", $"Bearer {token}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseContent = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine(responseContent);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Result));
            MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(responseContent));
            Result result = (Result)serializer.ReadObject(memoryStream);

            DataTable dt = new DataTable();
            dt.Columns.Add("Action");
            dt.Columns.Add("ISIN");
            dt.Columns.Add("Ticker");
            dt.Columns.Add("Cours");
            dt.Columns.Add("Monnaie");
            foreach (StockData stock in result.stocks)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Action"] = stock.name;
                dataRow["ISIN"] = stock.isin;
                dataRow["Ticker"] = stock.ticker;
                dataRow["Cours"] = stock.lastPrice;
                dataRow["Monnaie"] = stock.lastPriceCurrency;

                dt.Rows.Add(dataRow);
            }
            dtgTitre.DataSource = dt;
        }


        public void GetPortfolio()
        {
            UserInfo user = Common.GetUserInfo(Program.connection, Program.sessionToken);
            budgetTotal.Text = Common.GetBudget(user.id, Program.connection).ToString();
        }

        private void dtgTitre_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ticker = dtgTitre.Rows[e.RowIndex].Cells[2].Value.ToString();
            string isin = dtgTitre.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            float price = float.Parse(dtgTitre.Rows[e.RowIndex].Cells[3].Value.ToString());
            BuyAction form = new BuyAction(isin, price);
            form.ShowDialog();
            form.Dispose();
        }

        private void dtgTitre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void budgetTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void OperationTime_Load(object sender, EventArgs e)
        {
           
        }
    }
}
