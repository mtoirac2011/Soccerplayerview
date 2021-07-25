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
        
        public string firstName { get; set; }
        public string lastname { get; set; }
        public string nationality { get; set; }
        public string dob { get; set; }

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
                    string fullName = player.firstName + " " + player.lastname;
                    Console.WriteLine(fullName.PadRight(35) + " " + player.nationality.PadRight(15) + "  " + player.dob);

                }

            }
            else
            {
                var lPlayerOderByName = lPlayers.OrderBy(p => p.firstName);
                foreach (var player in lPlayerOderByName)
                {
                    string fullName = player.firstName + " " + player.lastname;
                    Console.WriteLine(fullName.PadRight(35) + " " + player.nationality.PadRight(15) + "  " + player.dob);

                }
            }
        }
    }   
}
