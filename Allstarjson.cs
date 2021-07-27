using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Soccerplayerview
{
    public class RootObject
    {
        public Allstarjson[] Allstarjson { get; set; }
    }

    public class Allstarjson
    {
        
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Nationality { get; set; }
        public string Dob { get; set; }

        public static List<Allstarjson> DeserializeAllStarPlayer(string fileName)
        {           
            var allStarPlayers = new List<Allstarjson>();
            JsonSerializer serializer = new JsonSerializer();

            using (var reader = new StreamReader(fileName))
            using (var jsonreader = new JsonTextReader(reader))
            {
                allStarPlayers = serializer.Deserialize<List<Allstarjson>>(jsonreader);
            }

            return allStarPlayers;
        }

        public static void DisplayAllLeyend(List<Allstarjson> lPlayers, bool orderByName) 
        {
            
            var orderTitle = orderByName ? "(Ordered By Name)" :  "";

            Console.WriteLine($"\n                   List of soccer leyends {orderTitle}");
            Console.WriteLine("                   ----------------------\n");
            Console.WriteLine("Fullname                            Nationality      DOB");
            Console.WriteLine("----------------------------------- ---------------  ----------");
            if (!orderByName)
            {
                foreach (var player in lPlayers)
                {
                    string fullName = player.FirstName + " " + player.Lastname;
                    Console.WriteLine(fullName.PadRight(35) + " " + player.Nationality.PadRight(15) + "  " + player.Dob);

                }
            }
            else
            {
                var lPlayerOderByName = lPlayers.OrderBy(p => p.FirstName);

                foreach (var player in lPlayerOderByName)
                {
                    string fullName = player.FirstName + " " + player.Lastname;
                    Console.WriteLine(fullName.PadRight(35) + " " + player.Nationality.PadRight(15) + "  " + player.Dob);

                }
            }
        }
    }   
}
