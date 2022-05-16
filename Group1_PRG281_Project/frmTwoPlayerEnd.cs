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
    public partial class frm2PlayerScore : Form
    {
        public frm2PlayerScore()
        {
            InitializeComponent();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            this.Close();

            Variables.ResetAll();

            frmLogIn login = new frmLogIn();
            login.Show();
        }

        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            this.Close();
            Variables.ResetPoints();
            Variables.playernumber = 2;
            if (Variables.GameType == "Genre")
            {
                frmGenreGame gameScreen = new frmGenreGame();
                gameScreen.Show();
            }
            if (Variables.GameType == "Song")
            {
                frmSongGame gameScreen = new frmSongGame();
                gameScreen.Show();
            }
             
        }

        private void frm2PlayerScore_Load(object sender, EventArgs e)
        {
            if (Variables.playernumber == 1)
            {
                btnExit.Visible = false;
                btnExit.Enabled = false;

                btnReplay.Visible = false;
                btnReplay.Enabled = false;

                
                btnPlayer2.Visible = true;
                btnPlayer2.Enabled = true;

                Variables.CurrentPlayers[0].Score = Variables.points;
                Variables.CurrentPlayers[0].Questions = Variables.counter;
                Variables.ResetPoints();

                Methods.ChangeLabel(string.Format("{0}:", Variables.CurrentPlayers[0].Username), lblP1Name);
                Methods.ChangeLabel(Variables.CurrentPlayers[0].Score.ToString(), lblP1Correct);
                Methods.ChangeLabel(Variables.CurrentPlayers[0].Questions.ToString(), lblP1Quesiton);

              
            }
            else
            {
                btnExit.Visible = true;
                btnExit.Enabled = true;

                btnReplay.Visible = true;
                btnReplay.Enabled = true;


                btnPlayer2.Visible = false;
                btnPlayer2.Enabled = false;

                Variables.CurrentPlayers[1].Score = Variables.points;
                Variables.CurrentPlayers[1].Questions = Variables.counter;


                Methods.ChangeLabel(string.Format("{0}:", Variables.CurrentPlayers[1].Username),lblP2Name);
                Methods.ChangeLabel(Variables.CurrentPlayers[1].Score.ToString(), lblP2Correct);
                Methods.ChangeLabel(Variables.CurrentPlayers[1].Questions.ToString(), lblP2Question);

                Methods.ChangeLabel(string.Format("{0}:", Variables.CurrentPlayers[0].Username), lblP1Name);
                Methods.ChangeLabel(Variables.CurrentPlayers[0].Score.ToString(), lblP1Correct);
                Methods.ChangeLabel(Variables.CurrentPlayers[0].Questions.ToString(), lblP1Quesiton);

                
            }

            Variables.CurrentPlayers.Sort();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void leaderBtn_Click(object sender, EventArgs e)
        {
            var leaderboardFrm = new frmLeaderboard();
            leaderboardFrm.Show();
        }
    }
}
