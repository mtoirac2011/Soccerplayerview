using System;
using System.Collections.Generic;
using System.Linq;

namespace Soccerplayerview
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Player> lstPlayer = new List<Player>();

            

            string mainMenu;
            General.AlreadyCsv = false;

            do
            {
                mainMenu = " ";
                Menu.MainMenu();
                mainMenu = Prompt.GetString("Choose the option: ").ToUpper();

                switch (mainMenu)
                {
                    case "P":

                        GoPlayer();
                        break;

                    case "C":
                        GoCountry();
                        break;

                    case "Q":
                        GoQuote();
                        break;

                    case "R":
                        GoReport();
                        break;

                    default:
                        break;
                }


            } while (mainMenu != "X");

            Console.Clear();

        }

        // Menu Player  //
        static void GoPlayer()
        {
            string playerMenu;
            do
            {
                Menu.PlayerMenu();
                playerMenu = Prompt.GetString("Choose the option: ").ToUpper();

                switch (playerMenu)
                {
                    case "A":
                        GoPlayerAddMenu();


                        break;

                    case "M":

                        break;

                    case "D":

                        break;

                    default:
                        break;
                }

            } while (playerMenu != "X");
        }

        // Menu Player Add SubMenu
        static void GoPlayerAddMenu()
        {
            List<Player> lstCsvByLine = new List<Player>();
            string playerAddMenu;
           do
           {
               Menu.PlayerAddMenu(General.AlreadyCsv);
               playerAddMenu = Prompt.GetString("Choose the option: ").ToUpper();
               switch (playerAddMenu)
               { 
                
                   case "M":
                       
                        break;

                   case "C":
                        string CsvPathName = Util.FileName();
                        string CsvContent = Util.ReadCsv(CsvPathName);
                        //lstCsvByLine = Util.ReadCsvByLine(CsvContent);

                        lstCsvByLine = Util.ReadCsvByLine(CsvPathName);

                        Console.WriteLine("Mostrando Lista completa: lstCsvByLine \n ");
                        Console.WriteLine(lstCsvByLine);

                        Console.WriteLine("Mostrando Lista arreglo string \n");

                        foreach (var line in lstCsvByLine)
                        {
                            Console.WriteLine(line);
                        }
                        Console.ReadLine();

                        break;

                   default:

                       break;
               }

           }while (playerAddMenu != "X");
        }

        // Menu Country //
        static void GoCountry()
        {           
            string countryMenu;
            do
            {
                Menu.CountryMenu();
                countryMenu = Prompt.GetString("Choose the option: ").ToUpper();

                switch (countryMenu)
                {
                    case "A":

                        break;

                    case "M":

                        break;

                    case "D":

                        break;

                    default:
                        break;
                }

            } while (countryMenu != "X");

        }

        // Menu Quote // 
        static void GoQuote()
        {
            string quoteMenu;
            int i = 1;
            string[] quotes = new string[] {
            "Soccer is simple, but it is difficult to play simply", "Your love makes me strong, your hate makes me unstoppable",
            "I think sometimes the best training is to rest", "Success without honor is the greatest of failures",
            "There is nothing more dangerous than taking no chances"
            };

            Quote.ShowQuotes(quotes);

            do
            {
                i = Int32.Parse(Prompt.GetString("Choose the quote between 1-5: "));
                if (i > 5 || i < 1)
                {
                    Console.WriteLine("The number must be between 1 and 5 ...");
                }
            } while (i > 5 || i < 1);
            Console.WriteLine();                                            
            do
            {
                Console.Clear();
                Menu.QuoteMenu();

                Console.WriteLine("      ──  You have chosen  ──");
                Console.WriteLine($"\" {quotes[i-1]} \"");

                quoteMenu = Prompt.GetString("Choose the option: ").ToUpper();
                //Console.Clear();

                switch (quoteMenu)
                {
                    case "C":
                        Console.WriteLine($"{Quote.SearchString(quotes[i - 1])}  . Any key to cotinue ...");
                        Console.ReadKey();
                        break;

                    case "M":

                        break;

                    case "D":

                        break;

                    default:
                        break;
                }
                
            } while (quoteMenu != "X");

        }

        // Menu Report  //
        static void GoReport()
        {
            string reportMenu;
            do
            {
                Menu.ReportMenu();
                reportMenu = Prompt.GetString("Choose the option: ").ToUpper();
                Console.WriteLine();
                switch (reportMenu)
                {
                    case "P":

                        break;

                    case "C":

                        break;

                    default:
                        break;
                }

            } while (reportMenu != "X");

        }
    }
}

