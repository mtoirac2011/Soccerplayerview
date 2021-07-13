using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
    class Prompt
    {
        public static string GetString(string message)
        {
            string userInput = " ";
            Console.Write("\n" + message );
            userInput = Console.ReadLine();
            return userInput.Trim();
        }
    }
}
