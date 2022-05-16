using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_PRG281_Project
{
    class CurrentPlayer : Player
    {

        int currentscore;


        public CurrentPlayer() { }

        public CurrentPlayer(string username, string password,int currentscore) :base(username,password)
        {
            this.Currentscore = currentscore;
        }

        public int Currentscore { get => currentscore; set => currentscore = value; }


       /* public List<string> Play()
        {

        }

        public string GetQuestion()
        {

        }*/
    }
}
