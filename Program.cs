using System;

namespace Soccerplayerview
{
    
    class Program
    {
        //public bool alreadyCsv = false;

        
        static void Main(string[] args)
        {
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

