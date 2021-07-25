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
                                "There is nothing more dangerous than taking no chances", "Talent without working hard is nothing",
                                "Enthusiasm is everything. It must be taut and vibrating like a guitar string",
                                "If you are a goalkeeper, it does not matter what you save the ball with, if you keep it out, it is not a goal",
                                "In soccer, the worst blindness is only seeing the ball", "My mother thinks I am the best. And I was raised to always believe what my mother tells me"
            };
        }

        public static void QuoteChosen(string phrase)
        {
            Console.Clear();
            Menu.QuoteMenu();
            Console.WriteLine("      ──  You have chosen  ──");
            Console.WriteLine($"\" {phrase} \"");
        }

        public static void DisplayQuotes(string[] quotes)
        {

            Console.WriteLine("\n Inspirational Soccer Quotes");
            Console.WriteLine("───────────────────────────────");
            for (int i = 0; i < quotes.Length; i++)
            {
                Console.WriteLine($"< {i + 1} > {quotes[i]}");
            }

        }

        public static void DisplayQuotesWithFormat(string[] quotes)
        {
            Console.WriteLine("\n  Inspirational Soccer Quotes");
            Console.WriteLine("───────────────────────────────");
            for (int i = 0; i < quotes.Length; i++)
            {
                Console.WriteLine($"\"{quotes[i]}\"\n");
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
            int i = 0;
            int j = 0;
            string[] quotes = Quote.InitializeQuotes();
            do
            {
                string s = Prompt.GetString($"Choose a quote between 1-{quotes.Length}: ");
                if (Int32.TryParse(s, out j))
                {
                    i = j;
                }
            } while (i > quotes.Length || i < 1);
            return i;
        }
    }
}
