using System;

namespace Soccerplayerview
{
    public class Menu
	{

		//Main Menu
		public static void MainMenu()
		{
			Console.Clear();
			Console.WriteLine("╔════════════════════════════════════════════════╗");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║          ==    Main Menu   ==                  ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             p - Player Menu                    ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             q - Soccer quotes Menu             ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             r - Report Menu                    ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             c - Converter                      ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             x - Exit                           ║");
			Console.WriteLine("╚════════════════════════════════════════════════╝");
		}

		public static void PlayerMenu(bool alreadyCsv)
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│           --  Player Menu --                   │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             a - Add new player                 │");
			if (alreadyCsv)
            {
				Console.WriteLine("│                                                │");
				Console.WriteLine("│             d - Delete a player                │");

			}			
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             x - Exit                           │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}

		public static void PlayerAddMenu(bool alreadyCsv)
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│           --  Adding players --                │");
			Console.WriteLine("│                                                │");
	
			if (!alreadyCsv)
			{
				Console.WriteLine("│             c - Load players from CSV file     │");
				Console.WriteLine("│                                                │");
            }
            else
            {
				Console.WriteLine("│             m - Add player manually            │");
				Console.WriteLine("│                                                │");
			}
			Console.WriteLine("│             x - Exit                           │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}

		
		public static void QuoteMenu()
		{
			//Console.Clear();
			Console.WriteLine("┌──────────────────────────────────────────────┐"); 
			Console.WriteLine("│                                              │");
			Console.WriteLine("│       --  Soccer Quote Menu --               │");
			Console.WriteLine("│                                              │");
			Console.WriteLine("│   c - Check if a string exists in the quote  │");
			Console.WriteLine("│                                              │");
			Console.WriteLine("│   o - Other features of selected quote       │");
			Console.WriteLine("│                                              │");
			Console.WriteLine("│   s - Switch to other quote                  │");
			Console.WriteLine("│                                              │");
			Console.WriteLine("│   x - Exit                                   │");
			Console.WriteLine("└──────────────────────────────────────────────┘");
		}

		//Report Menu
		public static void ReportMenu()
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│           --  Report Menu --                   │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│        p - List players                        │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│        b - Best soccer start leyend            │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│        o - Best soccer start leyend (by Name)  │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│        q - List soccer quotes                  │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│        x - Exit                                │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}

		public static void WelcomeMenu()
        {
			Console.Clear();
			WriteAt("┌────────────────────────────────────────────────┐", 0, 1);
			WriteAt("│                                                │", 0, 2);
			WriteAt("│       Welcome to the Soccer Player View App    │", 0, 3);
			WriteAt("│                                                │", 0, 4);
			WriteAt("│       ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    │", 0, 5);
			WriteAt("│                                                │", 0, 6);
			WriteAt("│        This is the login menu. You will        │", 0, 7);
			WriteAt("│                                                │", 0, 8);
			WriteAt("│        need to type a valid email format       │", 0, 9);
			WriteAt("│                                                │", 0, 10);
			WriteAt("│           in order to access the App.          │", 0, 11);
			WriteAt("│                                                │", 0, 12);
			WriteAt("│        You will have 3 chances to log in.      │", 0, 13);
			WriteAt("│                                                │", 0, 14);
			WriteAt("│                   Good luck!                   │", 0, 15);
			WriteAt("└────────────────────────────────────────────────┘", 0, 16);
		}

		public static void WriteAt(string s, int x, int y)
		{
			try
			{
				Console.SetCursorPosition(50 + x, 10 + y);
				Console.Write(s);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.Clear();
				Console.WriteLine(e.Message);
			}
		}
	}
}
