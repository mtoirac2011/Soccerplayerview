using System;

namespace Soccerplayerview
{
    public class Menu
	{
		public static void MainMenu()
		{
			Console.Clear();
			Console.WriteLine("╔════════════════════════════════════════════════╗");
			Console.WriteLine("║         ==    Main Menu   ==                   ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             p - Players                        ║");
			Console.WriteLine("║                                                ║");
			Console.WriteLine("║             c - Countries                      ║");
			Console.WriteLine("║                                     x - Exit   ║");
			Console.WriteLine("╚════════════════════════════════════════════════╝");
		}

		public static void PlayerMenu()
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
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

		public static void CountryMenu()
		{
			Console.Clear();
			Console.WriteLine("┌────────────────────────────────────────────────┐");
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
	}
}
