using System;
using System.Collections.Generic;

namespace Soccerplayerview
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //List<Player> players = new List<Player>()
            //{
            //    new Player() { FirstName = "Minardo", LastName = "Isla", Country = "USA", Team = "FC Barcelona", Since = System.DateTime.Today },
            //    new Player() { FirstName = "Jorge", LastName = "Rodriguez", Country = "Cuba", Team = "Milan", Since = System.DateTime.Today },
            //};

            string mainOption;
            General.AlreadyCsv = false;

            do
            {               
                mainOption = " ";
                Menu.MainMenu();
                mainOption = Click.Prompt("Choose the option: ").ToUpper();
                
                switch (mainOption)
                {
                    case "P":
                        Call.ToPlayer();
                        break;

                    case "C":
                        Call.ToCountry();
                        break;

                    default:
                        break;
                }
            } while (mainOption != "X");

            Console.Clear();
        }


    }
}

