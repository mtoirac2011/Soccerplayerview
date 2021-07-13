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

        public static string SearchString(string quote)
        {
            string cadena = Prompt.GetString("Choose the string to search: ");
            string cadenaUpper = cadena.ToUpper();
             
            return (quote.ToUpper().Contains(cadena.ToUpper())) ? $"\n\"{cadena}\" exists in the quote" : $"\n\"{cadena}\" does NOT exist in the quote"; 
        }
    }
}
