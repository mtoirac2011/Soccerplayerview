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
            bool morePlayer;
            string menuPlayer;
            do
            {
                Console.Clear();
                Menu.PlayerMenu();
                menuPlayer = Click.Prompt("Choose the option: ").ToUpper();
                morePlayer = menuPlayer == "X";


                switch (menuPlayer)
                {
                    case "A":
                        Menu.PlayerAddMenu();
                        break;

                    case "M":
                        Call.ToCountry();
                        break;

                    case "D":
                        Call.ToCountry();
                        break;

                    default:
                        break;
                }

            } while (!morePlayer);
        }

        public static void ToCountry()
        {
            bool moreCountry;
            do
            {
                Menu.CountryMenu();
                moreCountry = Click.Prompt("Choose the option: ").ToUpper() == "X";
                Console.Clear();

            } while (!moreCountry);
        }

    }
}
