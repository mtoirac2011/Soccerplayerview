using System;
using System.Collections.Generic;

namespace Soccerplayerview
{
    public class Program
    {
        private static List<Player> lstPlayer;
        static void Main(string[] args)
        {            
            string mainMenu;
            Util.AlreadyCsv = false;
            Util.LogFile = Util.SetFileName("Soccerlog.txt");

            if (Util.CheckForEmail())
            {
                do
                {
                    mainMenu = "X";
                    Menu.MainMenu();
                    mainMenu = Prompt.GetString("Choose the option: ").ToUpper();

                    switch (mainMenu)
                    {
                        case "P":

                            GoPlayer();
                            break;

                        case "Q":
                            GoQuote();
                            break;

                        case "R":
                            GoReport();
                            break;

                        case "C":
                            GoConverter();

                            break;

                        default:
                            Console.WriteLine("Closing the application...");
                            break;
                    }
                    Console.Clear();

                } while (mainMenu != "X");
            }
                        
        }

        // Menu Player  //
        static void GoPlayer()
        {
            string playerMenu;
            do
            {
                Menu.PlayerMenu(Util.AlreadyCsv);
                playerMenu = Prompt.GetString("Choose the option: ").ToUpper();

                switch (playerMenu)
                {
                    case "A":
                        GoPlayerAddMenu();
                        break;

                    case "D":
                        GoPlayerDeleteMenu();
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
               Menu.PlayerAddMenu(Util.AlreadyCsv);
               playerAddMenu = Prompt.GetString("Choose the option: ").ToUpper();
               switch (playerAddMenu)
               { 
                
                   case "M":
                        bool done;
                        do
                        {
                            try
                            {
                                lstPlayer.Add(Player.AddPlayer());
                                Util.WriteInLog(Util.LogFile, "A new player has been added");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("The player could not been added..." + ex);
                                Util.WriteInLog(Util.LogFile, "The player could not been added...");
                            }
                            
                            Player.DisplayPlayers(lstPlayer);
                            done = Prompt.GetString("Add another player? (y/n) ").ToUpper() != "Y";                            
                        } while (!done);
                        break;

                    case "C":                     
                        if (!Util.AlreadyCsv)
                        {
                            try
                            {
                                lstPlayer = Player.LoadListPlayer();
                                Util.WriteInLog(Util.LogFile, "Players were loaded from CSV file...");
                            }
                            catch (Exception ex)
                            {
                                Util.WriteInLog(Util.LogFile, "Players were loaded from CSV file...");
                                Console.WriteLine("Error loading players from CSV file..." + ex);
                            }
                            
                            Player.DisplayPlayers(lstPlayer);
                        }
                        break;

                   default:

                       break;
               }

           }while (playerAddMenu != "X");
        }

        public static void GoPlayerDeleteMenu()
        {
            int index = Player.DisplayPlayerForDelete(lstPlayer);
            if (index > 0)
            {
                string playerToBeDelete =$"{lstPlayer[index - 1].FirstName } {lstPlayer[index - 1].LastName}";
                Console.Write("\nThis player has been selected to be deleted: ");
                Console.WriteLine($"<{lstPlayer[index - 1].FirstName} {lstPlayer[index - 1].LastName} from {lstPlayer[index - 1].Team}>");
                string option = Prompt.GetString("\nAre you sure? (y/n) ").ToUpper();
                if (option == "Y")
                {
                    try
                    {
                        lstPlayer.RemoveAt(index - 1);
                        Util.WriteInLog(Util.LogFile, "A player has been successfully deleted");
                        Player.DisplayPlayers(lstPlayer);
                        Console.WriteLine($"\n{playerToBeDelete} successfully deleted. Any key to continue....");
                    }
                    catch (Exception ex)
                    {
                        Util.WriteInLog(Util.LogFile, "An error occurs deleting a player...");                        
                        Console.WriteLine($"\nError deleting {playerToBeDelete}" + ex + "/nAny key to continue...");
                    }
                } 
            }
        }

        // Menu Quote // 
        static void GoQuote()
        {
            string quoteMenu;
            int i = 1;
            string[] quotes = Quote.InitializeQuotes();
            Quote.DisplayQuotes(quotes);
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
                        Quote.DisplayQuotes(quotes);
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
                //Console.WriteLine();
                Console.Clear();
                switch (reportMenu)
                {
                    case "P":
                        if (Util.AlreadyCsv)
                        {
                            Player.DisplayPlayersWithFormat(lstPlayer);
                            Util.anyKeyToContinue();
                        }
                        else
                        {
                            Console.Write("\nThis list is empty, please add players from CSV file in Player Menu. Any key to continue...");
                            Console.ReadKey();
                        }
                        
                        break;

                    case "B":
                        string fileName = Util.SetFileName("Soccerplayersallstar.json");
                        List<Allstarjson> allStar =  Allstarjson.DeserializeAllStarPlayer(fileName);
                        Allstarjson.DisplayAllLeyend(allStar, false);
                        Util.anyKeyToContinue();
                        break;

                    case "Q":
                        string[] quotes = Quote.InitializeQuotes();
                        Quote.DisplayQuotesWithFormat(quotes);
                        Util.anyKeyToContinue();
                        break;

                    case "O":
                        string file = Util.SetFileName("Soccerplayersallstar.json");
                        List<Allstarjson> playerStar = Allstarjson.DeserializeAllStarPlayer(file);
                        Allstarjson.DisplayAllLeyend(playerStar, true);
                        Util.anyKeyToContinue();
                        break;

                    default:
                        break;
                }                
            } while (reportMenu != "X");           
        }

        public static void GoConverter()
        {
            Converter.ConverterTitle();
            double param, stringToDouble;            
            string input = Prompt.GetString("Type the value to convert: ");
            if (double.TryParse(input, out param))
            {
                stringToDouble = param;
                Converter.DisplayConvertion(stringToDouble);
            }
            else
            {
                Console.WriteLine("Error converting string to double: ");
            }

            Util.anyKeyToContinue();
        }        
    }
}

