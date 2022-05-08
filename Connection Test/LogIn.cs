using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Air_Tany_Lib;

namespace Connection_Test
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        DBConn conn;
        private string _userName;
        private string _passwordHash;
        private bool _stayLogIn;
        string token;

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

        public void submitForm()
        {
            _userName = txbUsername.Text;
            _passwordHash = Common.SHA512(txbPassword.Text);
            _stayLogIn = cbxStayLogIn.Checked;

            int? uid = Common.checkUserCredentials(_userName, _passwordHash, conn);
            if (uid.HasValue)
            {
                string TK = Common.createSessionToken(uid, conn);
                if (TK != null)
                {
                    token = TK;
                    Debug.Assert(token != null);
                }
            }
            Close();
        }
    }
}
