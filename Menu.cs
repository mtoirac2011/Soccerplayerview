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
			Console.WriteLine("│             c - Converter                      │");
			Console.WriteLine("│                                                │");
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

		
		// Quote Menu
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
			Console.WriteLine("│             p - List players                   │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             q - List soccer quotes             │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             x - Exit                           │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}
	}
}
