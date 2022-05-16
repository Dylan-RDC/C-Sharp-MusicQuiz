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
    public partial class frmSinglePlayerEnd : Form
    {
        public frmSinglePlayerEnd()
        {
            InitializeComponent();
        }

        private void frmSinglePlayerEnd_Load(object sender, EventArgs e)
        {
            lblP1Quesiton.Text = Variables.counter.ToString();
            lblP1Correct.Text = Variables.points.ToString();
            lblSingleEndHeader.Text = string.Format("{0}", Variables.CurrentPlayers[0].Username);
            Variables.CurrentPlayers[0].Score = Variables.points;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Close();

            Variables.ResetAll();

            frmLogIn login = new frmLogIn();
            login.Show();
        }
    }
}
