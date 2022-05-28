using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Air_Tany_Lib;

//formulaire de connexion utilisateur

namespace Air_Tany_App
{
    public partial class LogIn : Form
    {
        //propriétés privés de la classe login (pas accessibles en dehors de cette classe)
        private string _userName;
        private string _passwordHash;
        private bool _stayLogIn;

        public LogIn()
        {
         
            InitializeComponent();
        }
        // pour y avoir acces quand meme - creation d'accesseurs (methode retourne valeur de la propriete)
        public string UserName
        {
            get => _userName;
        }

        public string PasswordHash
        {
            get => _passwordHash;
        }

        public bool StayLogIn
        {
            get => _stayLogIn;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e) // clique sur le bouton connexion - appelle la fonction submitform
        {
            submitForm();
        }

        private void LogIn_Load_1(object sender, EventArgs e)
        {

        }
        public void submitForm() // valider le formulaire 
        {
            _userName = txbUsername.Text; // recupere valeur saisie dans le champs
            _passwordHash = Common.SHA512(txbPassword.Text); // recuper valeur saisie dans le champs - hachage direct 
            _stayLogIn = cbxStayLogIn.Checked; // case coché rester connecté 

            int? uid = Common.checkUserCredentials(_userName, _passwordHash, Program.connection); // verifie si username et psw sont valides
            if (uid.HasValue) // si ça existe
            {
                string TK = Common.createSessionToken(uid, Program.connection); // cree jeton de session
                if (TK != null) // si jeton créé 
                {
                    Program.sessionToken = TK; // stock le jeton dans program pour le rendre accessible partout dans l'appli

                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) //fermer formulaire 
        {
            Close();
        }
    }
}
