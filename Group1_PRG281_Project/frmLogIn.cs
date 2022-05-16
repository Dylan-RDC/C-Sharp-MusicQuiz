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
    public partial class frmLogIn : Form
    {
        public Form mainform;
       
        public frmLogIn()
        {
            InitializeComponent();
            mainform = this;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(29, 177, 136);
            btnLogIn.ForeColor = Color.White;
           
            string username = edtUsername.Text;
            string password = edtPassword.Text;
            int i = 0;
            bool found = false;
            List<Player> users = Variables.AllUsers;
            frmPlayerSelect selectscreen = new frmPlayerSelect();
            frmGameChoice GameChoiceScreen = new frmGameChoice();

            try
            {
                foreach (var item in Variables.CurrentPlayers)
                {
                    if (item.Username==username)
                    {
                        throw new LogInException("User already log in");
                    }
                }
                
                {
                    while (i < users.Count() && found == false)//checks the credentials created a method in player class to be used here
                    {
                        if (users[i].CheckCredentials(username, password) == 1)
                        {
                            found = true;
                            Variables.CurrentPlayers.Add(users[i]);
                            if (Variables.PlayerCount > 1)
                            {
                                this.Hide();
                                GameChoiceScreen.Show();
                               
                            }
                            else
                            {
                                this.Hide();
                                selectscreen.Show();
                                
                                
                            }
                        }
                        if (users[i].CheckCredentials(username, password) == 0)
                        {
                            MessageBox.Show("Incorrect Password");
                            found = true;
                        }

                        i++;
                    }
                    if (found == false)
                    {
                        throw new LogInException("User does not exist");

                    }
                }
            }
            catch (LogInException error)
            {
                MessageBox.Show(error.Message);

            }
            }



        private void frmLogIn_Shown(object sender, EventArgs e)
        {
            edtPassword.Text = "";
            edtUsername.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void edtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayerLogIn_Click(object sender, EventArgs e)
        {

        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
    }

