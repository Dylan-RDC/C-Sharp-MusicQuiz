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
    public partial class frmLeaderboard : Form
    {
        public frmLeaderboard()
        {
            InitializeComponent();
        }

        private void frmLeaderboard_Load(object sender, EventArgs e)
        {

            List<Player> sortedLeaderboard = new List<Player>();
            sortedLeaderboard = Variables.CurrentPlayers;
            sortedLeaderboard.Sort();

            Methods.ChangeLabel(sortedLeaderboard[0].Username.ToString(), lblWinnerLb);
            Methods.ChangeLabel(sortedLeaderboard[0].Username.ToString(), winnerNameLbl);
            Methods.ChangeLabel(sortedLeaderboard[0].Score.ToString(), winnerScoreLbl);
            Methods.ChangeLabel(sortedLeaderboard[1].Username.ToString(), loserNameLbl);
            Methods.ChangeLabel(sortedLeaderboard[1].Score.ToString(), loserScoreLbl);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
