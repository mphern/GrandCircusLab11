using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab11
{
    class Program
    {
        static void Main()
        {
            List<object> movieList = MovieList();
            bool goAgain = true;
            while (goAgain)
            {
                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("There are " + movieList.Count + " movies in this list in the following catagories: \n");
                Console.WriteLine("1. Horror");
                Console.WriteLine("2. Sci Fi");
                Console.WriteLine("3. Action");
                Console.WriteLine("4. Sports");
                Console.WriteLine("5. Comedy");
                Console.WriteLine("6. Drama");
                
                string catagory = GetCatagory("What catagory are you interested in? (Enter 1-6): ");

                DisplayMovies(catagory, movieList);

                goAgain = GoAgain("Continue? (Y/N): ");
            }

        }


        static public List<object> MovieList()
        {
            Movie Halloween = new Movie("Halloween", "horror");
            Movie IndependenceDay = new Movie("Independence Day", "scifi");
            Movie MadMax = new Movie("Mad Max: Fury Road", "action");
            Movie RememberTheTitans = new Movie("Remember the Titans", "sports");
            Movie ItFollows = new Movie("It Follows", "horror");
            Movie RogueOne = new Movie("Rogue One: A Star Wars Story", "scifi");
            Movie TommyBoy = new Movie("Tommy Boy", "comedy");
            Movie BillyMadison = new Movie("Billy Madison", "comedy");
            Movie TopGun = new Movie("Top Gun", "drama");
            Movie OlympusHasFallan = new Movie("Olympus Has Fallen", "action");
            Movie EvilDead = new Movie("Evil Dead, The", "horror");
            Movie BattleLA = new Movie("Battle: Los Angeles", "scifi");
            Movie HappyGilmore = new Movie("Happy Gilmore", "sports");
            Movie MontyPython = new Movie("Monty Python and the Holy Grail", "comedy");
            Movie Mohicans = new Movie("Last of the Mohicans, The", "drama");
            Movie T2 = new Movie("Terminator 2: Judgment Day", "action");
            Movie MightyDucks = new Movie("Mighty Ducks, The", "sports");
            Movie Armageddon = new Movie("Armageddon", "action");
            Movie Gump = new Movie("Forrest Gump", "drama");
            Movie Raiders = new Movie("Raiders of the Lost Ark", "action");
            Movie Dumb = new Movie("Dumb and Dumber", "comedy");
            Movie NewHope = new Movie("Star Wars: A New Hope", "scifi");
            Movie Empire = new Movie("Star Wars: The Empire Strikes Back", "scifi");
            Movie Jedi = new Movie("Star Wars: Return of the Jedi", "scifi");
            Movie GrandmasBoy = new Movie("Grandma's Boy", "comedy");
            Movie DieHard = new Movie("Die Hard", "action");
            Movie WarOfTheWorlds = new Movie("War of the Worlds", "scifi");
            Movie DarkKnight = new Movie("Dark Knight, The", "action");
            Movie JurrasicPark = new Movie("Jurassic Park", "action");
            Movie Frailty = new Movie("Frailty", "horror");
            Movie TheThing = new Movie("Thing, The", "horror");
            Movie Apollo13 = new Movie("Apollo 13", "drama");
            Movie Taken = new Movie("Taken", "action");
            Movie EdgeOfTomorrow = new Movie("Edge of Tomorrow", "scifi");
            Movie WindRiver = new Movie("Wind River", "drama");
            Movie Dredd = new Movie("Dredd", "action");
            Movie Goon = new Movie("Goon", "sports");
            Movie Pirates = new Movie("Pirates of the Caribbean: The Curse of the Black Pearl", "action");
            Movie Miracle = new Movie("Miracle", "sports");
            Movie BigLebowski = new Movie("Big Lebowski, The", "comedy");
            Movie Wrestler = new Movie("Wrestler, The", "drama");
            Movie Rocky4 = new Movie("Rocky 4", "sports");
            Movie RoadWarrior = new Movie("Road Warrior, The", "action");
            Movie Tron = new Movie("Tron", "scifi");
            Movie WeekendAtBernies = new Movie("Weekend at Bernie's", "comedy");
            Movie BreakfastClub = new Movie("Breakfast Club, The", "drama");
            Movie AustinPowers = new Movie("Austin Powers: International Man of Mystery", "comedy");

            List<object> movieList = new List<object>()
            {
                Halloween, IndependenceDay, MadMax, RememberTheTitans, ItFollows, RogueOne, TommyBoy, BillyMadison, TopGun,
                OlympusHasFallan, EvilDead, BattleLA, HappyGilmore, MontyPython, Mohicans, T2, MightyDucks, Armageddon, Gump,
                Raiders, Dumb, NewHope, Empire, Jedi, GrandmasBoy, DieHard, WarOfTheWorlds, DarkKnight, JurrasicPark, Frailty,
                Apollo13, Taken, EdgeOfTomorrow, WindRiver, Dredd, Goon, Pirates, Miracle, BigLebowski, Wrestler, Rocky4,
                RoadWarrior, WeekendAtBernies, BreakfastClub, AustinPowers, Tron, TheThing
            };

            return movieList;
        }

        static string GetCatagory(string message)
        {
            Console.Write(message);
            int catagory;
            while(!int.TryParse(Console.ReadLine().Trim(), out catagory) || catagory < 1 || catagory > 6)
            {
                Console.Write("Invalid input. "+message);
            }
            if(catagory == 1) { return "horror"; }
            if(catagory == 2) { return "scifi"; }
            if(catagory == 3) { return "action"; }
            if(catagory == 4) { return "sports"; }
            if(catagory == 5) {return "comedy"; }
            else { return "drama"; }
        }

        static bool GoAgain(string message)
        {
            Console.Write("\n"+message);
            string answer = Console.ReadLine().ToLower().Trim();
            while(answer != "y" && answer != "yes" && answer != "n" && answer != "no")
            {
                Console.Write("Invalid input. "+message);
                answer = Console.ReadLine().ToLower().Trim();
            }
            if(answer == "yes" || answer == "y")
            {
                Console.Clear();
                return true;
            }

            return false;
        }

        static void DisplayMovies(string catagory, List<object> movieList)
        {
            List<string> movies = new List<string>();
            foreach (Movie movie in movieList)
            {
                if (movie.Catagory == catagory)
                {
                    movies.Add(movie.Title);
                }
            }
            movies.Sort();
            if (catagory == "scifi")
            {
                Console.WriteLine("\nMovies in the catagory of Sci Fi:");
            }
            else
            {
                Console.WriteLine("\nMovies in the catagory of " + catagory[0].ToString().ToUpper() + catagory.Substring(1) + ":");
            }
            Console.WriteLine("---------------------------------");
            foreach(string movie in movies)
            {
                Console.WriteLine(movie);
            }

        }
    }
}
