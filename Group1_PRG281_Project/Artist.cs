using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Group1_PRG281_Project
{
    class Artist
    {
        string name;
        string surname;
        string stagename;
        int age;
        List<string> songs;
        List<string> genre;

        public Artist() { }

        
        public Artist(string name, string surname, string stagename, int age, List<string> songs, List<string> genre)
        {
            this.Name = name;
            this.Surname = surname;
            this.Stagename = stagename;
            this.Age = age;
            Songs = songs;
            Genre = genre;
        }

        public Artist(string stagename)
        {
            this.stagename = stagename;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Stagename { get => stagename; set => stagename = value; }
        public int Age { get => age; set => age = value; }
        public List<string> Songs { get => songs; set => songs = value; }
        public List<string> Genre { get => genre; set => genre = value; }

        public string RandomSong()
        {

            Random num = new Random();
            int num1 = num.Next(Songs.Count());

            
            return Songs[num1];

        }

        public override bool Equals(object obj)
        {
            Artist aObj = obj as Artist;
            if (aObj!=null && aObj.Stagename == this.Stagename)
            {
                return true;
            }
            return false;
        }
    }
}