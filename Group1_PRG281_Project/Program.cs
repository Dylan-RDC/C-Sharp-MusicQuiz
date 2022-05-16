using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_PRG281_Project
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Variables.AllUsers.Add(new Player("Jonathan","576754"));
            Variables.AllUsers.Add(new Player("Dylan", "576864"));
            Variables.AllUsers.Add(new Player("Josias", "576755"));
            Variables.AllUsers.Add(new Player("Francois", "576734"));
            Variables.AllUsers.Add(new Player("Itumaleng", "576915"));
            Variables.AllUsers.Add(new Player("Themba", "Mpofu"));
            Variables.AllUsers.Add(new Player("Raven", "12"));



            Variables.Artists.Add(new Artist("Bruno","Mars","Bruno Mars",35,new List<string>() { "Grenade","Locked Out of Heaven","The Lazy Song","24K Magic","Just the Way You Are"}, new List<string>() { "Pop" }));
            Variables.Artists.Add(new Artist("Tim", "Berling", "Avicii", 28, new List<string>() { "The Days", "The Nights", "Wake Me Up", "Waiting For Love" }, new List<string>() { "EDM","House" }));
            Variables.Artists.Add(new Artist("Kenny", "Rogers", "Kenny Rogers", 81, new List<string>() { "The Gambler","We've Got Tonight","Island In The Stream" }, new List<string>() { "Country" }));
            Variables.Artists.Add(new Artist("Jahseh", "Dwayne", "XXXTentacion", 20, new List<string>() { "SAD!","NUMB","changes","Moonlight","Look at Me!" }, new List<string>() { "Rap","Pop" }));
            Variables.Artists.Add(new Artist("Wolfgang", "Mozart", "Mozart", 35, new List<string>() { "Requiem","Eine kleine Nachtmusik","The Magic Flute","Don Giovanni" }, new List<string>() { "Classical" }));
            Variables.Artists.Add(new Artist("", "", "Linkin Park",0,new List<string>() { "In the End","Numb","New Divide","Castle of Glass","Somewhere I Belong"}, new List<string>() { "Rock" }));
            Variables.Artists.Add(new Artist("", "", "AC/DC", 0, new List<string>() { "Highway To Hell","Back In Black","Thunderstruck","Shoot to Thrill","T.N.T" }, new List<string>() { "Rock" }));
            Variables.Artists.Add(new Artist("", "", "Green Day", 0, new List<string>() { "Boulevard of Broken Dreams","21 Guns","Wake Me Up When September Ends","Basket Case","When I Come Around" }, new List<string>() { "Rock" }));
            Variables.Artists.Add(new Artist("", "", "Nirvana", 0, new List<string>() { "Smells Like Teen Spirit","Drain You","Come as You Are","Lithium","On A Plane" }, new List<string>() { "Rock" }));
            Variables.Artists.Add(new Artist("", "", "Bach", 0, new List<string>() { "Toccata and Fugue in D minor" }, new List<string>() { "Classical" }));
            Variables.Artists.Add(new Artist("", "", "Tchaikovsky", 0, new List<string>() { "Swan Lake","Romeo and Juliet","The Seasons","1812 Overture" }, new List<string>() { "Classical" }));
            Variables.Artists.Add(new Artist("", "", "Eminem", 0, new List<string>() { "The Real Slim Shady","Rap God","Without Me","Venom","Not Afraid" }, new List<string>() { "Rap" }));
            Variables.Artists.Add(new Artist("", "", "The Weeknd", 0, new List<string>() { "Blinding Lights", "The Hills", "Can't Feel My Face", "Starboy", "I Feel It Coming" }, new List<string>() { "Dubstep" }));
            Variables.Artists.Add(new Artist("", "", "Maroon 5", 0, new List<string>() { "Payphone", "Animals", "Sugar", "Maps", "Misery" }, new List<string>() { "Rock","Techno" }));
            Variables.Artists.Add(new Artist("", "", "Backstreet Boys", 0, new List<string>() { "I Want It That Way", "As Long as You Love Me", "Straight Through My Heart", "Larger Than Life", "Everybody" }, new List<string>() { "Pop" }));
            Variables.Artists.Add(new Artist("", "", "Marshmello", 0, new List<string>() { "Alone", "Keep It Mello", "Wolves", "Happier" }, new List<string>() { "EDM", "Hip Hop" }));
            Variables.Artists.Add(new Artist("", "", "David Guetta", 0, new List<string>() { "Titanium", "Memories", "Shot me Down", "Where Them Girls At" }, new List<string>() { "EDM","Dubstep" }));
            Variables.Artists.Add(new Artist("", "", "Martin Garrix", 0, new List<string>() { "Ocean", "There for You" }, new List<string>() { "House" }));
            Variables.Artists.Add(new Artist("", "", "Calvin Harris", 0, new List<string>() { "Outside", "How Deep Is Your Love", "Feels", "Promises" }, new List<string>() { "EDM" }));
            Variables.Artists.Add(new Artist("", "", "Bee Gees", 0, new List<string>() { "Stayin' Alive","You Should Be Dancing","More Than a Woman" }, new List<string>() { "Disco","Pop" }));
            Variables.Artists.Add(new Artist("", "", "ABBA", 0, new List<string>() { "Gimme! Gimme! Gimme!","Money, Money, Money","The Winner Takes It All","Super Trouper" }, new List<string>() { "Disco","Pop" }));
            Variables.Artists.Add(new Artist("", "", "B.B. King", 0, new List<string>() { "The Thrill Is Gone","3 O' Clock Blues","Sweet Little Angel" }, new List<string>() { "Blues" }));
            Variables.Artists.Add(new Artist("", "", "Billy Ray Cyrus", 0, new List<string>() { "Achy Breaky Heart" }, new List<string>() { "Country" }));
            Variables.Artists.Add(new Artist("", "", "Prince", 0, new List<string>() { "Little Red Corvette","U Got the Look" }, new List<string>() { "Funk" }));
            Variables.Artists.Add(new Artist("", "", "Snoop Dogg", 0, new List<string>() { "Drop It Like It's Hot","Young, Wild & Free" }, new List<string>() { "Reggae","Hip Hop","Rap" }));
            Variables.Artists.Add(new Artist("", "", "Iron Maiden", 0, new List<string>() { "Bring Your Daughter... to the Slaughter", "Hallowed Be Thy Name","" }, new List<string>() { "Heavy Metal" }));
            Variables.Artists.Add(new Artist("", "", "Guns N' Roses", 0, new List<string>() { "Sweet Child O' Mine","November Rain"}, new List<string>() { "Heavy Metal","Rock" }));
            Variables.Artists.Add(new Artist("", "", "Miles Davis", 0, new List<string>() { "So What","Miles Runs the Voodoo Down" }, new List<string>() { "Jazz" }));
            Variables.Artists.Add(new Artist("", "", "Marvin Gaye", 0, new List<string>() { "Ain't No Mountain High Enough","Mercy Mercy Me" }, new List<string>() { "Soul" }));
            Variables.Artists.Add(new Artist("", "", "Queen", 0, new List<string>() { "Bohemian Rhapsody","We Will Rock You","I Want to Break Free","Radio Ga Ga" }, new List<string>() { "Rock" }));
            Variables.Artists.Add(new Artist("", "", "Taylor Swift", 0, new List<string>() { "Look What You Made Me Do","Shake it Off","I Knew You Were Trouble" }, new List<string>() { "Country","Pop" }));
            Variables.Artists.Add(new Artist("Kabelo", "Motha", "Kabza de Small", 28, new List<string>() { "Nana thula" }, new List<string>() { "House Amapiano" }));
            Variables.Artists.Add(new Artist("Yamikani", "Banda", "Lady Zamar" ,34, new List<string>() { "Sunshine" }, new List<string>() { "Dance" }));
            Variables.Artists.Add(new Artist("Jabulani", "Radebe", "S'Java", 38, new List<string>() { "Amafu" }, new List<string>() { "Hip Hop" }));
            Variables.Artists.Add(new Artist("Shekinah", "Donnell", "Shekinah", 26, new List<string>() { "Please Mr" }, new List<string>() { "Blues" }));
            Variables.Artists.Add(new Artist("Eric", "Nkovani", "penny Penny", 59, new List<string>() { "Ingani" }, new List<string>() { "Tsonga Disco" }));
            Variables.Artists.Add(new Artist("Lucky", "Dube", "Luck Dube", 43, new List<string>() { "It's not easy" }, new List<string>() { "Reggae" }));
            Variables.Artists.Add(new Artist("Arthur", "Mafokate", "Arthur", 59, new List<string>() { "Zombo" }, new List<string>() { "Kwaito" }));
            Variables.Artists.Add(new Artist("Kurt Johan", "van Heerden", "Kurt Durren", 51, new List<string>() { "Die Goeie Ou Dae" }, new List<string>() { "Rock","Pop" }));
            Variables.Artists.Add(new Artist("William", "Murphy", "William Murphy ", 48, new List<string>() { "Settle Here" }, new List<string>() { "Gospel" }));
            Variables.Artists.Add(new Artist("Amanda", "Antony", "Amanda Black", 28, new List<string>() { "Kahle" }, new List<string>() { "Afro Soul" }));
            Variables.Artists.Add(new Artist("Johnathan", "Clegg", "Le Zoulou Blanc", 66, new List<string>() { "Impi" }, new List<string>() { "Mbaqanga" }));
            Variables.Artists.Add(new Artist("Kenneth", "Gorelick", "Kenny G", 65, new List<string>() { "Forever in love" }, new List<string>() { "Jazz" }));
            Variables.Artists.Add(new Artist("Teddy", "Pendegrass", "Teddy Pendegrass", 59, new List<string>() { "Love TKO" }, new List<string>() { "Soul" }));
            Variables.Artists.Add(new Artist("Carlos", "Phillips", "Saint JHN", 35, new List<string>() { "Trap" }, new List<string>() { "Hip hop" }));
            Variables.Artists.Add(new Artist("Bekhumuzi", "Luthuli", "bekhumuzi Luthui", 48, new List<string>() { "Emateksini" }, new List<string>() { "Maskandi" }));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogIn());
        }
    }
}
