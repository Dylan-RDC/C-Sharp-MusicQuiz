using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Group1_PRG281_Project
{
    public partial class frmSongGame : Form
    {
        public delegate void MyEventHandler();
        //public event MyEventHandler UpdateQuestion;

        public frmSongGame()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSongGame_Load(object sender, EventArgs e)
        {
            Variables.Artists = Variables.RandomizeArtist(Variables.Artists);//randomize order of the artists
            Variables.GameType = "Song";
            MyTimer.end = false;
            btnAristGuess.Text = "Begin";

        }

        private void btnAristGuess_Click(object sender, EventArgs e)
        {
            //rbArtist1.Text = ;

            //random number object
            Random RandomArtistNo = new Random();

            List<string> randomOrderList = new List<string>();
            List<string> templist = new List<string>();
            MyTimer timer = new MyTimer(this, lblSongTimer, btnAristGuess);

            Thread countDownTask = new Thread(() => timer.CountDown(60));
            //string question = "";
            int selectedIndex;
            //int i = 0;
            //string answer;

            //user input
            selectedIndex = GetInput();
            

           


            if (Variables.counter == 0)
            {
                countDownTask.Start();

                UpdateDisplay();

                btnAristGuess.Text = "Submit";


            }
            else
            {
                if (Variables.counter < Variables.Artists.Count())
                {

                    if (selectedIndex == Variables.AnsIndex)
                    {
                        Variables.points++;

                        
                        UpdateDisplay();
                    }
                    else
                    {
                        UpdateDisplay();

                      
                    }
                }
                else
                {
                    if (selectedIndex == Variables.AnsIndex)
                    {

                        Variables.points++;
                        Variables.ChangeLabel(string.Format("Score: {0}", Variables.points), lblSongScore);
                        
                    }
                    MessageBox.Show(string.Format("Well done you managed to complete all possibles questions"));
                    MyTimer.end = true;
                    
                }


            }
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

        private void btnAristGuess_EnabledChanged(object sender, EventArgs e)
        {
            btnContinue.Visible = true;
            Thread.Sleep(100);//fixes delay
            btnContinue.Enabled = true;
            
        }

        public int GetInput()//gets the players answer
        {
            if (rbArtist1.Checked == true) { return  0; };
            if (rbArtist2.Checked == true) { return  1; };
            if (rbArtist3.Checked == true) { return  2; };
            if (rbArtist4.Checked == true) { return  3; };
            return 0;
        }

        public void UpdateDisplay()//update and generate questions 
        {
            Variables.ChangeLabel(string.Format("Score: {0}", Variables.points), lblSongScore) ;

            //Variables

            Random RandomArtistNo = new Random();

            List<string> randomOrderList = new List<string>();
            List<string> templist = new List<string>();
            string question = Variables.Artists[Variables.counter].RandomSong();
            string answer = Variables.Artists[Variables.counter].Stagename;
            int i = 0;
            ////
            ///

            templist.Add(answer);
            List<string> used = new List<string>() { answer };

            //get random songs from all songs
            while (i < 3)
            {
                int randomnum = RandomArtistNo.Next(Variables.Artists.Count());

                if (used.Contains(Variables.Artists[randomnum].Stagename) == false)
                {
                    templist.Add(Variables.Artists[randomnum].Stagename);
                    used.Add(Variables.Artists[randomnum].Stagename);
                    i++;
                }
            }
            ///////////////////////////

            int n = templist.Count();
            while (n > 0)
            {
                int randomNum = RandomArtistNo.Next(n);
                randomOrderList.Add(templist[randomNum]);

                templist.Remove(templist[randomNum]);
                n--;

            }

            Variables.AnsIndex = randomOrderList.IndexOf(answer);



            //update options
            this.ReturnOption(randomOrderList);



            Variables.ChangeLabel(string.Format("{0}", question), lblSongName);//change label text

            btnAristGuess.Text = "Submit";

            Variables.counter++;



        }

        public void ReturnOption(List<string> list)
        {
            rbArtist1.Text = list[0];
            rbArtist2.Text = list[1];
            rbArtist3.Text = list[2];
            rbArtist4.Text = list[3];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void rbArtist1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
