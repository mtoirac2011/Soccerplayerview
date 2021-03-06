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
        public DateTime Dob { get; set; }
      
        public static void DisplayPlayers(List<Player> lPlayers)
        {
            Console.WriteLine("\nList of players");
            Console.WriteLine("-----------------");
            foreach (var player in lPlayers)
            {
                Console.Write(player.FirstName + " " + player.LastName + " " + player.Country + " " + player.Team + " " + player.Dob + "");
                Console.WriteLine("\n--------------------------------------------------------------");
            }
            Util.anyKeyToContinue();
        }

        public static void DisplayPlayersWithFormat(List<Player> lPlayers)
        {
            int age = 0;
            string fullName;
            Console.WriteLine("\n          List of players (with Age calculated)");
            Console.WriteLine("          ---------------\n");
            Console.WriteLine("Fullname               Country      Soccer Team        Age");
            Console.WriteLine("---------------------- ------------ ------------------ ---");
            foreach (var player in lPlayers)
            {
                age = DateTime.Now.Year - player.Dob.Year;
                fullName = player.FirstName + " " + player.LastName;

                if (DateTime.Now.DayOfYear < player.Dob.DayOfYear)
                    age = age - 1;

                Console.WriteLine(fullName.PadRight(22) + " "+ player.Country.PadRight(12) + " " + player.Team.PadRight(18) + "  " + age);
            }
        }

        public static int DisplayPlayerForDelete(List<Player> lPlayers)
        {
            int i = 1;
            Console.WriteLine("Displaying players for delete");
            Console.WriteLine("-----------------------------");
            foreach (var player in lPlayers)
            {
                Console.Write("Item: <" + i + ">\n" + player.FirstName + " " + player.LastName + " " + player.Country + " " + player.Team + " " + player.Dob + "");
                Console.WriteLine("\n--------------------------------------------------------------");
                i++;    
            }

            string input = Prompt.GetString($"Select an item to delete from 1 to {i-1}: ").ToUpper();
            if(int.TryParse(input, out i))
            {
                return i;
            }
            else
            {
                return 0;
            }   
        }
  
        public static List<Player> LoadListPlayer() 
        {            
            List<Player> lstPlayerAux = new();
            DateTime dob;
            string fileContent;
            Util.AlreadyCsv = true;

            string fileName = Util.SetFileName("Soccerplayers.csv");

            using (var reader = new StreamReader(fileName))
            {
                 fileContent = reader.ReadToEnd();
            }

            string[] Lines = System.IO.File.ReadAllLines(fileName);

            for (int i = 1; i < Lines.Length; i++)
            {
                Console.WriteLine("\n=======>> Adding item number: " + i );
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

                if (DateTime.TryParse(fields[4], out dob))
                {
                    playerAux.Dob = dob;
                }
                else
                {
                    Util.AlreadyCsv = false;
                    Console.WriteLine("Error converting string to DateTime...");
                    break;
                }
                Console.WriteLine("playerAux.Dob value: " + playerAux.Dob);

                lstPlayerAux.Add(playerAux);
            }
            
            return lstPlayerAux;
        }

        public static Player AddPlayer()
        {    
            Player manualPlayer = new Player();
            DateTime Dob;

            Console.WriteLine("Type the following info for player");
            Console.WriteLine("==================================");
            
            manualPlayer.FirstName = Prompt.GetString("First name: ");
            manualPlayer.LastName = Prompt.GetString("Last name: ");
            manualPlayer.Country = Prompt.GetString("Country: ");
            manualPlayer.Team = Prompt.GetString("Soccer team: ");
            string input = Prompt.GetString("DOB mm/dd/yyyy: ");

            if (DateTime.TryParse(input, out Dob))
            {
                manualPlayer.Dob = Dob;
            }
            else
            {
                throw new Exception("Error converting data...");
            }

            return manualPlayer;
        }     
    }
}