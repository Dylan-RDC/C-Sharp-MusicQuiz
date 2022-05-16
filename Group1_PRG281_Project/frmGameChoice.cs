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
    public partial class frmGameChoice : Form
    {
        public frmGameChoice()
        {
            InitializeComponent();
        }

        private void btnArtistGame_Click(object sender, EventArgs e)
        {
           
            frmGenreGame GenreGameScreen = new frmGenreGame();
            this.Close();
            GenreGameScreen.Show();

            
          

        }

        private void btnGenreGame_Click(object sender, EventArgs e)
        {
            frmSongGame SongeGameScreen = new frmSongGame();
            this.Close();
            SongeGameScreen.Show();
        }

        private void frmGameChoice_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
