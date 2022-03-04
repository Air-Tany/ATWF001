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

namespace Air_Tany_App
{
    public partial class LogIn : Form
    {
        private string _userName;
        private string _passwordHash;
        private bool _stayLogIn;

        public LogIn()
        {
         
            InitializeComponent();
        }
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
         
        }

        private void LogIn_Load_1(object sender, EventArgs e)
        {

        }
        public void submitForm()
        {
            _userName = txbUsername.Text;
            _passwordHash = Common.SHA512(txbPassword.Text);
            _stayLogIn = cbxStayLogIn.Checked;

            int? uid = Common.checkUserCredentials(_userName, _passwordHash, Program.connection);
            if (uid.HasValue)
            {
                string TK = Common.createSessionToken(uid, Program.connection);
                if (TK != null)
                {
                    Program.sessionToken = TK;

                }
            }
            Close();
        }
    }
}
