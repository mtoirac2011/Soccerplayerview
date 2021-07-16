﻿using System;

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
			Console.WriteLine("║         ==    Main Menu   ==                   ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             p - Players                        ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             c - Countries                      ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             q - Quotes                         ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             r - Reporting                      ║");
			Console.WriteLine("║                                     x - Exit   ║");
			Console.WriteLine("╚════════════════════════════════════════════════╝");
		}

		public static void PlayerMenu()
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│           --  Player Menu --                   │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             a - Add new player                 │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             m - Modify a player                │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             d - Delete a player                │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│                                     x - Exit   │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}

		public static void PlayerAddMenu(bool alreadyCsv)
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│           --  Adding players --                │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             m - Add manually                   │");
			Console.WriteLine("│                                                │");
			if (!alreadyCsv)
			{
				Console.WriteLine("│             c - Add from CSV file              │");
				Console.WriteLine("│                                                │");
			}

			Console.WriteLine("│                                     x - Exit   │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}

		
		// Country Menu
		public static void CountryMenu()
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│           --  Country Menu --                  │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             a - Adding                         │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             m - Modifying                      │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             d - Deleting                       │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│                                     x - Exit   │");
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
			Console.WriteLine("│                                   x - Exit   │");
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
			Console.WriteLine("│             c - List Countries                 │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│                                     x - Exit   │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}
	}
}
