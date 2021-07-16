using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
    public class Quote
    {

        public static string[] InitializeQuotes()
        {
            return new string[] {
                                "Soccer is simple, but it is difficult to play simply", "Your love makes me strong, your hate makes me unstoppable",
                                "I think sometimes the best training is to rest", "Success without honor is the greatest of failures",
                                "There is nothing more dangerous than taking no chances"
            };
        }

        public static void QuoteChosen(string phrase)
        {
            Console.Clear();
            Menu.QuoteMenu();
            Console.WriteLine("      ──  You have chosen  ──");
            Console.WriteLine($"\" {phrase} \"");
        }

        public static void ShowQuotes(string[] quotes)
        {

            Console.WriteLine("\n Inspirational Soccer Quotes");
            Console.WriteLine("───────────────────────────────");
            for (int i = 0; i < quotes.Length; i++)
            {
                Console.WriteLine($"< {i + 1} > {quotes[i]}");
            }

        }

        public static string SearchString(string quote)
        {
            string cadena = Prompt.GetString("Choose the string to search: ");
             
            return (quote.ToUpper().Contains(cadena.ToUpper())) ? $"\n\"{cadena}\" exists in the quote" : $"\n\"{cadena}\" does NOT exist in the quote"; 
        }

        public static void otherQuoteFeatures(string quote)
        {
            Console.WriteLine("\nOther quote's features");
            Console.WriteLine("──────────────────────");
            Console.WriteLine($"Length: {quote.Length}");
            Console.WriteLine($"First char: \"{quote.Substring(0, 1)}\"");
            Console.WriteLine($"Last char: \"{quote.Substring(quote.Length - 1, 1)}\"");
            Console.WriteLine($"Upper case: \"{quote.ToUpper()}\"");
            Console.WriteLine($"Lower case: \"{quote.ToLower()}\"");
            Console.WriteLine($"Spaces deleted: \"{quote.Replace(" ", "")}\"");
            Console.Write("\n Any key to cotinue ...");
        }

        public static int selectQuote()
        {
            int i;
            do
            {
                i = Int32.Parse(Prompt.GetString("Choose the quote between 1-5: "));
                if (i > 5 || i < 1)
                {
                    Console.WriteLine("The number must be between 1 and 5 ...\n");
                }
            } while (i > 5 || i < 1);

            return i;
        }
    }
}
