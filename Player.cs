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
      
        public static void DisplayPlayer(List<Player> lPlayers)
        {
            Console.WriteLine("Displaying players");
            Console.WriteLine("------------------");
            foreach (var player in lPlayers)
            {
                Console.Write(player.FirstName + " " + player.LastName + " " + player.Country + " " + player.Team + " " + player.Since + "");
                Console.WriteLine("\n--------------------------------------------------------------");
            }
        }

        public static List<Player> LoadListPlayer() 
        {
            
            List<Player> lstPlayerAux = new();
            DateTime since;
            string fileContent;

            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDir);
            var fileName = Path.Combine(currentDirInfo.FullName, "Soccerplayers.csv");

            using (var reader = new StreamReader(fileName))
            {
                 fileContent = reader.ReadToEnd();
            }

            //string[] Lines = fileContent.Split(new char[] { '\r', '\n' });
            string[] Lines = System.IO.File.ReadAllLines(fileName);

            for (int i = 1; i < Lines.Length; i++)
            {
                Console.WriteLine("Line number = " + i);
                Console.WriteLine(Lines[i]);

                string[] fields = Lines[i].Split(',');

                Player playerAux = new();
                
                playerAux.FirstName = fields[0];
                Console.WriteLine("playerAux.FirstName value: " + playerAux.FirstName);

                playerAux.LastName = fields[1];
                Console.WriteLine("playerAux.LastName value: " + playerAux.LastName);

                playerAux.Country = fields[2];
                Console.WriteLine("playerAux.Country value: " + playerAux.Country);

                playerAux.Team = fields[3];
                Console.WriteLine("playerAux.Team value: " + playerAux.Team);

                if (DateTime.TryParse(fields[4], out since))
                {
                    playerAux.Since = since;
                }
                Console.WriteLine("playerAux.Since value: " + playerAux.Since);

                Console.WriteLine("===================>>");

                lstPlayerAux.Add(playerAux);

                Console.ReadKey();
            }

            General.AlreadyCsv = true;
            return lstPlayerAux;
        }

        /// <summary>
        /// Prompts user for player name and artist and adds a new player.
        /// </summary>
        public static Player AddPlayer()
        {
            Player manualPlayer = new();
            bool done;
            do
            {
                string playerName = Prompt.GetString("What's the name of the player? ");
                string playerTeam = Prompt.GetString("Who's the artist? ");

                //_players.Add(new Player { PlayerName = playerName, PlayerTeam = playerTeam });
                done = Prompt.GetString("Add another player? (y/n) ").ToUpper() != "Y";

            } while (!done);

            return manualPlayer;
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