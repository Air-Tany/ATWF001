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

//affichage cours des actions 

namespace Air_Tany_App
{
    public partial class Stock : Form
    {
        [DataContract] //modele de données - objet dans lequel on définit les propriétés qu'il doit contenir 
        internal class StockData // stockdata contient :
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
        internal class Result // Result contient :
        {
            [DataMember]
            internal List<StockData> stocks;

        }

        public Stock()
        {
            InitializeComponent();
        }

        public void GetData() //recuperer les actions 
        {
            string token = ConfigurationManager.ConnectionStrings["stockAPItoken"].ConnectionString; // recupere le token de l'api stocké dans app.config (parametre appli)
            string baseUrl = ConfigurationManager.ConnectionStrings["stockAPIurl"].ConnectionString; //racine de l'adresse de l'api (adresse ip + port) stocké dans app.config
            string url = @baseUrl + @"/stocks"; //adresse complete de la requete
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); //cree une requete http a cette adresse
            request.Method = "GET"; //la requete sera de la methode get 
            request.Headers.Add("Authorization", $"Bearer {token}"); // dans les entetes de la requete on ajoute le toker d'autorisation de l'api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); //cree une repose contenant la reponse 
            string responseContent = new StreamReader(response.GetResponseStream()).ReadToEnd(); //lit le contenu de la reponse
            Console.WriteLine(responseContent); //
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Result)); //objet qui va transformer la reponse json en datacontract créé plus haut 
            MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(responseContent)); //creation de flux de données(facon de transmettre des données d'un processus a l'autre) a partir de la reponse 
            Result result = (Result)serializer.ReadObject(memoryStream); //passe ce flux de données dans l'objet serializer 

            Console.WriteLine(result.stocks.ToString()); //cree un tableau virtuel de données 

            DataTable dt = new DataTable(); //dans le resultat pour chaque action de la liste on repete ce qu'il y a dans la boucle
            dt.Columns.Add("Action");
            dt.Columns.Add("ISIN");
            dt.Columns.Add("Ticker");
            dt.Columns.Add("Cours");
            dt.Columns.Add("Monnaie");
            dt.Columns.Add("Date");
            foreach (StockData stock in result.stocks) // dans le resultat pour chaque action de la liste on repete ce qu'il y a dans la boucle
            {
                DataRow dataRow = dt.NewRow(); // création d'une nouvelle ligne dans le tableau
                dataRow["Action"] = stock.name;
                dataRow["ISIN"] = stock.isin;
                dataRow["Ticker"] = stock.ticker;
                dataRow["Cours"] = stock.lastPrice;
                dataRow["Monnaie"] = stock.lastPriceCurrency;
                dataRow["Date"] = stock.lastPriceDate;

                dt.Rows.Add(dataRow); // datagridview recupere les données du tableau
            }
            dataGridView1.DataSource = dt;

        }

        private void Stock_Load(object sender, EventArgs e) // quand formuler chargé, affiche les données 
        {
            GetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
