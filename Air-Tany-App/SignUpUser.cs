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
    public partial class SignUpUser : Form
    {
        public SignUpUser()
        {
            InitializeComponent();
        }

        private void cbxEnableEndDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEndDate.CalendarForeColor = Color.Black;
            dtpEndDate.CalendarMonthBackground = Color.White;
        }

        private void SignUpUser_Load(object sender, EventArgs e)
        {
            dtpEndDate.Visible = !dtpEndDate.Visible;
        }
    }
}
