using System;
using System.Collections.Generic;
using System.Linq;

namespace Soccerplayerview
{
    public class Program
    {
        private static List<Player> lstPlayer;
        static void Main(string[] args)
        {            
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
            string playerAddMenu;
            
            do
           {
               Menu.PlayerAddMenu(General.AlreadyCsv);
               playerAddMenu = Prompt.GetString("Choose the option: ").ToUpper();
               switch (playerAddMenu)
               { 
                
                   case "M":
                        bool done;
                        
                        do
                        {
                            //Player auxPlayer = new();
                            //auxPlayer = Player.AddPlayer();
                            lstPlayer.Add(Player.AddPlayer());
                            //Console.WriteLine("Imprimiendo valor de auxPlayer = Player.AddPlayer() ");
                            //Console.WriteLine($"auxPlayer.Since: {auxPlayer.Since}");
                            //Console.ReadKey();

                            //lstPlayer.Add(auxPlayer);
                            Player.DisplayPlayer(lstPlayer);
                            done = Prompt.GetString("Add another player? (y/n) ").ToUpper() != "Y";                            
                        } while (!done);
                        //Console.ReadKey();
                        break;

                    case "C":
                        

                        if (!General.AlreadyCsv)
                        {

                            //if (!lstPlayer.Any())
                            //{
                            //    lstPlayer = Player.LoadListPlayer();
                            //}
                            //else
                            //{
                            //    List<Player> lstPlayerLoaded = Player.LoadListPlayer();
                            //    //lstPlayer = manualPlayer.Union(lstPlayerLoaded);
                            //}

                            lstPlayer = Player.LoadListPlayer();
                            Player.DisplayPlayer(lstPlayer);
                            Console.ReadKey();
                        }
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
            string[] quotes = Quote.InitializeQuotes();
            Quote.ShowQuotes(quotes);
            i = Quote.selectQuote();
            Console.WriteLine();     
            
            do
            {
                Quote.QuoteChosen(quotes[i - 1]);
                quoteMenu = Prompt.GetString("Choose the option: ").ToUpper();

                switch (quoteMenu)
                {
                    case "C":
                        Console.Write($"{Quote.SearchString(quotes[i - 1])}  . Any key to cotinue ...");
                        Console.ReadKey();
                        break;

                    case "O":
                        Quote.otherQuoteFeatures(quotes[i - 1]);
                        Console.ReadKey();
                        break;

                    case "S":
                        Quote.ShowQuotes(quotes);
                        i = Quote.selectQuote();
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

