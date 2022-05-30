using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Air_Tany_App
{
    public partial class Stock : Form
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

        public Stock()
        {
            InitializeComponent();
        }

        public void GetData()
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
            
            Console.WriteLine(result.stocks.ToString());
            

            DataTable dt = new DataTable();
            dt.Columns.Add("Action");
            dt.Columns.Add("ISIN");
            dt.Columns.Add("Ticker");
            dt.Columns.Add("Cours");
            dt.Columns.Add("Monnaie");
            dt.Columns.Add("Date");
            foreach (StockData stock in result.stocks)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Action"] = stock.name;
                dataRow["ISIN"] = stock.isin;
                dataRow["Ticker"] = stock.ticker;
                dataRow["Cours"] = stock.lastPrice;
                dataRow["Monnaie"] = stock.lastPriceCurrency;
                dataRow["Date"] = stock.lastPriceDate;

                dt.Rows.Add(dataRow);
            }
            dataGridView1.DataSource = dt;

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
