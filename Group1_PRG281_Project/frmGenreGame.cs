using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace Group1_PRG281_Project
{
    public partial class frmGenreGame : Form
    {
        public Form GenreForm;
        public  List<string> PossibleAnswer = new List<string>();
        public frmGenreGame()
        {
            InitializeComponent();
            GenreForm = this;
        }

        private void btnGenreAnswer_Click(object sender, EventArgs e)
        {

            bool found = false; //used for seeing if there was a match for the users answer
            
            MyTimer timer = new MyTimer(GenreForm,lblTimer, btnGenreAnswer);

            Thread countDownTask = new Thread(() => timer.CountDown(60));
            string question = "";
            
           
            string playerSelection = cmbGenre.Text;

            if (Variables.counter == 0)
            {
                
                countDownTask.Start();
                cmbGenre.Enabled = true;


                question = Variables.Artists[Variables.counter].Stagename;
                PossibleAnswer = Variables.Artists[Variables.counter].Genre;

                Variables.ChangeLabel(string.Format("{0}", question), lblGenreQ);//change label text

                btnGenreAnswer.Text = "Submit";

                Variables.counter++;
            }
            else
            {
                if (Variables.counter < Variables.Artists.Count())
                {
                   
                    foreach (var item in PossibleAnswer)
                    {
                        
                        if (playerSelection.ToUpper() == item.ToUpper())
                        {
                            found = true;
                            Variables.points++;

                            Variables.ChangeLabel(string.Format("Score: {0}", Variables.points), lblGScore);

                            question = Variables.Artists[Variables.counter].Stagename;
                            PossibleAnswer = Variables.Artists[Variables.counter].Genre;

                            Variables.counter++;

                           
                            Variables.ChangeLabel(string.Format("{0}", question), lblGenreQ);

                        }
                        
                    }
                    if (found==false)
                    {
                        question = Variables.Artists[Variables.counter].Stagename;
                        PossibleAnswer = Variables.Artists[Variables.counter].Genre;


                        Variables.ChangeLabel(string.Format("{0}", question), lblGenreQ);
                        Variables.counter++;


                    }
                }
                else
                {
                    foreach (var item in PossibleAnswer)
                    {
                        if (playerSelection == item)
                        {
                            Variables.points++;
                            Variables.ChangeLabel(string.Format("Score: {0}", Variables.points), lblGScore);
                        }
                    }
                    MessageBox.Show(string.Format("Well done you managed to complete all possibles questions"));

                 

                    MyTimer.end = true;
                }
            }
            
       




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGenreGame_Load(object sender, EventArgs e)
        {
            btnGenreAnswer.Focus();
            Variables.Artists = Variables.RandomizeArtist(Variables.Artists);//randomize order of the artists
            Variables.GameType = "Genre";
            MyTimer.end = false;
        }

        private void btnGenreAnswer_VisibleChanged(object sender, EventArgs e)
        {
          
        }

        private void btnGenreAnswer_EnabledChanged(object sender, EventArgs e)
        {
            btnContinue.Visible = true;
            Thread.Sleep(100);//fixes delay
            btnContinue.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
           

            if (Variables.PlayerCount == 1)//if only 1 player playing
            {
                frmSinglePlayerEnd songScreen = new frmSinglePlayerEnd();
                this.Close();
                songScreen.Show();
            }
            else // if 2 players are playing
            {
                frm2PlayerScore songScreen = new frm2PlayerScore();
                this.Close();
                songScreen.Show();
            }

        
        }
    }
}
