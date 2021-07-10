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

