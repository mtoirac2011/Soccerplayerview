using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
    public class Quote
    {
        
        public static void ShowQuotes(string[] quotes)
        {

            Console.WriteLine("\n Inspirational Football Quotes");
            Console.WriteLine("───────────────────────────────");
            for (int i = 0; i < quotes.Length; i++)
            {
                Console.WriteLine($"< {i + 1} > {quotes[i]}");
            }

        }
    }
}
