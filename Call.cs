using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
    class Call
    {
        
        public static void ToPlayer()
        {
            
            bool exitPlayer;
            string menuPlayer;
            do
            {
                
                Menu.PlayerMenu();
                menuPlayer = Click.Prompt("Choose the option: ").ToUpper();
                exitPlayer = menuPlayer == "X";

                switch (menuPlayer)
                {
                    case "A":
                        ToAddPlayer();
                         
                        
                        break;

                    case "M":
                        
                        break;

                    case "D":
                        
                        break;

                    default:
                        break;
                }

            } while (!exitPlayer);
        }

        public static void ToAddPlayer()
        {
            bool exitAddPlayer;
            string menuAddPlayer;
            do
            {
                Menu.PlayerAddMenu(General.AlreadyCsv);
                menuAddPlayer = Click.Prompt("Choose the option: ").ToUpper();
                exitAddPlayer = menuAddPlayer == "X";

                switch (menuAddPlayer)
                {
                    case "A":

                        break;

                    case "C":
                        General.AlreadyCsv = Player.AddPlayersFromCsv();
                        break;

                    default:

                        break;
                }

            } while (!exitAddPlayer);
        }

        public static void ToCountry()
        {
            bool exitCountry;
            string menuCountry;
            do
            {
                Menu.CountryMenu();
                menuCountry = Click.Prompt("Choose the option: ").ToUpper();
                exitCountry = menuCountry == "X";

                switch (menuCountry)
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

            } while (!exitCountry);
        }

    }
}
