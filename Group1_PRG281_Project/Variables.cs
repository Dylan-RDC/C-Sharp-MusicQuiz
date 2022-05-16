using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_PRG281_Project
{
  static class Variables
    {

        public static int PlayerCount = 1;
        public static List<Player> AllUsers = new List<Player>();
        public static List<Player> CurrentPlayers = new List<Player>();


        public static int AnsIndex = 0;
        public static int counter = 0;
        public static int points = 0;
        public static string GameType;
        public static int playernumber = 1;

        public static List<Artist> Artists = new List<Artist>();

        public static List<Artist> RandomizeArtist(List<Artist> MyList )
        {
            List<Artist> temp = new List<Artist>(MyList) ; //declared to prevent altering main list
            List<int> UsedIndexes = new List<int>();
            Random num = new Random();
            List<Artist> RandomizedList = new List<Artist>();


            int n = temp.Count();
            while (n > 0)
            {
                int randomNum = num.Next(n);
                RandomizedList.Add(temp[randomNum]);
                temp.Remove(temp[randomNum]);
                n--;

            }


           
            return RandomizedList;
        }

        public static void ChangeLabel(string msg, Label label)
        {
            label.Text = msg;
            label.Refresh();
        }

        public static void ResetAll()
        {
            PlayerCount = 1;
            playernumber = 1;
            CurrentPlayers = new List<Player>();
            counter = 0;
            points = 0;
            GameType = "";
        }

        public static void ResetPoints()
        {
            counter = 0;
            points = 0;
        }
    }
}
