using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_PRG281_Project
{
    public partial class frmPlayerSelect : Form
    {
       
        public frmPlayerSelect()
        {
            InitializeComponent();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            frmGameChoice choicescreen = new frmGameChoice();

            choicescreen.Show();
            this.Hide();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            frmLogIn LogInScreen = new frmLogIn();
            Variables.PlayerCount = 2;
            this.Hide();
            LogInScreen.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
