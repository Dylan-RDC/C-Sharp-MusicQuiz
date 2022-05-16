using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_PRG281_Project
{
    class Player: IComparable
    {
        string username;
        string password;
        int score;
        int questions;

        public Player() { }

        public Player(string username, string password) 
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Score { get => score; set => score = value; }
        public int Questions { get => questions; set => questions = value; }

        public int CheckCredentials(string username, string password)
        {
            if (this.Username == username)
            {
                if (this.Password == password)
                {
                    return 1;//1 means the user has entered the correct details and exists
                }
                else return 0;//0 means the user exists but entered the wrong password
            }
            else return -1;//means the user does not exist

        }

        public int CompareTo(object obj)
        {
            Player compare = obj as Player;
            if (this.Score < compare.Score)
            {
                return 1;
            }
            if (this.Score == compare.Score)
            {
                return 0;
            }
            else return -1;


        }
    }
}
