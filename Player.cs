using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Soccerplayerview
{
    public class Player : Person
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
                string playerName = Prompt.GetString("What's the name of the player? ");
                string playerTeam = Prompt.GetString("Who's the artist? ");

                //_players.Add(new Player { PlayerName = playerName, PlayerTeam = playerTeam });
                done = Prompt.GetString("Add another player? (y/n) ").ToUpper() != "Y";

            } while (!done);
        }

        public static bool AddPlayersFromCsv(string fileContent)
        {
            //Show Csv file content By Line
            Console.WriteLine("Csv file content By Line");
            //ReadCsvByLine(fileContent);
            //Console.WriteLine();
            Console.ReadKey();

            return true;
        }

        

        public static void ReadCsvByLine(string fileContent)
        {
            string[] result = fileContent.Split(new char[] { '\r', '\n' });

            foreach (var res in result)
            {
                Console.WriteLine(res);
               
            }

            General.AlreadyCsv = true;
  
        }
    }
}