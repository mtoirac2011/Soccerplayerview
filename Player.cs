using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
    class Player : Person
    {

        string Team { get; set; }
        DateTime Since { get; set; }

        public Player(string firstname, string lastname, string country, string team, DateTime since) : base(firstname, lastname, country)
        {
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
            return true;
        }
    }
}