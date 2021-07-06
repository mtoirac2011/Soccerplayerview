using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Soccerplayerview
{
    class Player : Person
    {

        public string Team { get; set; }
        public DateTime Since { get; set; }

        public Player(string firstName, string lastName, string country, string team, DateTime since) : base(firstName, lastName, country)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            Team = team;
            Since = since;
        }

        public static void DisplayPlayer()
        {
            Console.WriteLine("Players");
            Console.WriteLine("----------");
            //_players.ForEach((player) => Console.WriteLine(player));
            Console.WriteLine();
        }

        /// <summary>
        /// Prompts user for player name and artist and adds a new player.
        /// </summary>
        public static void AddPlayer()
        {
            bool done;
            do
            {
                string playerName = Click.Prompt("What's the name of the player? ");
                string playerTeam = Click.Prompt("Who's the artist? ");

                //_players.Add(new Player { PlayerName = playerName, PlayerTeam = playerTeam });
                done = Click.Prompt("Add another player? (y/n) ").ToLower() != "y";

            } while (!done);
        }

        public static bool AddPlayersFromCsv()
        {
            //Showing results
            string currentDir = Directory.GetCurrentDirectory();
            Console.WriteLine("Current directory Path using --- Directory.GetCurrentDirectory()");
            Console.WriteLine(currentDir);
            Console.WriteLine();
            Console.ReadKey();

            currentDir = "C:\\CODELOU\\Soccerplayerview\\Files\\";
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDir);
            var fileName = Path.Combine(currentDirInfo.FullName, "Soccerplayers.csv");

          

            //Show Current directory Path
            Console.WriteLine("Current directory Path");
            Console.WriteLine(currentDir);
            Console.WriteLine();
            Console.ReadKey();

            //Show files in current directory
            var files = currentDirInfo.GetFiles();
            Console.WriteLine("files in current directory");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine();
            Console.ReadKey();

            // Show fileName Path
            Console.WriteLine("fileName Path");
            Console.WriteLine(fileName);
            Console.WriteLine();
            Console.ReadKey();
            //End Showing results

            var fileContent = ReadCsv(fileName);

            //Show Csv file content
            Console.WriteLine("Csv file content");
            Console.WriteLine(fileContent);
            Console.WriteLine();
            Console.ReadKey();

            //Show Csv file content By Line
            Console.WriteLine("Csv file content By Line");
            ReadFileByLine(fileContent);
            Console.WriteLine();
            Console.ReadKey();

            return true;
        }

        public static string ReadCsv(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static void ReadFileByLine(string fileContent)
        {
            string[] result = fileContent.Split(new char[] { '\r', '\n' });

            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}