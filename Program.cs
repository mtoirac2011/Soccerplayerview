using System;

namespace Soccerplayerview
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainOption;
            bool alreadyCsv;
            do
            {
                mainOption = " ";
                Menu.MainMenu();
                mainOption = Click.Prompt("Choose the option: ").ToUpper();
                Console.Clear();

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

        }


    }
}

