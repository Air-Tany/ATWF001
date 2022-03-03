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

namespace Air_Tany_App
{
    public partial class LogIn : Form
    {
        private string _userName;
        private string _passwordHash;
        private bool _stayLogIn;

        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
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
            _userName = txbUsername.Text;
            _passwordHash = SHA512(txbPassword.Text);
            _stayLogIn = cbxStayLogIn.Checked;



            this.Close();
        }
    }
}
