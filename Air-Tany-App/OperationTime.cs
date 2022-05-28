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
using MySql.Data.MySqlClient;

// voir les actions disponibles et le portfeuille du trader - faire des opérations (achats ou ventes d'actions)
namespace Air_Tany_App
{
    public partial class OperationTime : Form // la classe operationtime se base sur la classe form auquelle on rajoute des attributs et methodes 
    {

        [DataContract] // modele de données - objet dans lequel on définit les propriétés qu'il doit contenir 
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
        public OperationTime() // constructeur du formulaire / lui qui est appelé quand on créé le formulaire
        {
            InitializeComponent(); //preparer ses composants 
            Refresh(); // actualiser les données à afficher (actions et portfeuille)
        }

        public void Refresh() //fonction actualise les données à afficher
        {
            GetAction(); // recuperer actions
            GetPortfolio(); //recuperer portfeuille du trader 
        }

        public void GetAction() // recuperer les actions 
        {
            string token = ConfigurationManager.ConnectionStrings["stockAPItoken"].ConnectionString; // recupere le token de l'api stocké dans app.config (parametre appli)
            string baseUrl = ConfigurationManager.ConnectionStrings["stockAPIurl"].ConnectionString; //racine de l'adresse de l'api (adresse ip + port) stocké dans app.config
            string url = @baseUrl + @"/stocks"; //adresse complete de la requete 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url); // cree une requete http a cette adresse
            request.Method = "GET"; // la requete sera de la methode get 
            request.Headers.Add("Authorization", $"Bearer {token}"); // dans les entetes de la requete on ajoute le toker d'autorisation de l'api
            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); // cree une repose contenant la reponse 
            string responseContent = new StreamReader(response.GetResponseStream()).ReadToEnd(); // lit le contenu de la reponse 
            Console.WriteLine(responseContent);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Result)); // objet qui va transformer la reponse json en datacontract créé plus haut 
            MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(responseContent)); // creation de flux de données(facon de transmettre des données d'un processus a l'autre) a partir de la reponse 
            Result result = (Result)serializer.ReadObject(memoryStream); // passe ce flux de données dans l'objet serializer 

            DataTable dt = new DataTable(); // cree un tableau virtuel de données 
            dt.Columns.Add("Action");
            dt.Columns.Add("ISIN");
            dt.Columns.Add("Ticker"); 
            dt.Columns.Add("Cours"); 
            dt.Columns.Add("Monnaie"); 
            foreach (StockData stock in result.stocks) // dans le resultat pour chaque action de la liste on repete ce qu'il y a dans la boucle
            {
                DataRow dataRow = dt.NewRow(); // création d'une nouvelle ligne dans le tableau
                dataRow["Action"] = stock.name; 
                dataRow["ISIN"] = stock.isin; 
                dataRow["Ticker"] = stock.ticker; 
                dataRow["Cours"] = stock.lastPrice; 
                dataRow["Monnaie"] = stock.lastPriceCurrency; 

                dt.Rows.Add(dataRow); // la ligne créée on la rajoute au tableau
            }
            dtgTitre.DataSource = dt; // datagridview recupere les données du tableau 
        }


        public void GetPortfolio() // recuperer le portfeuille du trader
        {
            UserInfo user = Common.GetUserInfo(Program.connection, Program.sessionToken); // recupere les infos de l'utilisateur a partir du jeton de session
            budgetTotal.Text = Common.GetBudget(user.id, Program.connection).ToString(); //budget 0 remplacé par le budget du trader 

            MySqlDataAdapter req = new MySqlDataAdapter($"SELECT `action`.`act_name` AS `Action`, `action`.`act_isin` AS `ISIN`, `action`.`act_ticker` AS `Ticker`, SUM(`portfolio_stock`.`prt_quantity`) AS `Quantité possédée` " +
                $"FROM `portfolio_stock` JOIN `action` ON `portfolio_stock`.`act_id` = `action`.`act_id` WHERE `portfolio_stock`.`stf_id` = '{user.id}' " +
                $"GROUP BY `portfolio_stock`.`act_id`", Program.connection.Connection); //recupere le portefeuille d'actions du trader 
            DataTable dt = new DataTable(); // on cree un nouveau tableau virtuel
            req.Fill(dt); //on remplit le tableau avec le resultat de la requete 
            dtgOperation.DataSource = dt; // datagridview recupere les données du tableau 
        }

        private void dtgTitre_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) // double clic ligne d'une action 
        {
            string isin = dtgTitre.Rows[e.RowIndex].Cells[1].Value.ToString(); //recupere le numero isin a partir de la ligne sur laquelle on a cliqué 
            float price = float.Parse(dtgTitre.Rows[e.RowIndex].Cells[3].Value.ToString()); // recupere le prix a partir de la ligne sur laquelle on a cliqué 
            BuyAction form = new BuyAction(isin, price); //cree un formulaire et passe en parametre isin et prix 
            form.ShowDialog(); //affiche le formulaire 
            form.Dispose(); //quand formulaire fermé, vider la memoire 
            Refresh(); //actualise les données affichées 
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
