using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccerplayerview
{
	public class Menu
	{
		public static void MainMenu()
		{
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

		public static void PlayerAddMenu(bool alrealyCsv)
		{
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│           --  Player Menu --                   │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             a - Add manually                   │");
			Console.WriteLine("│                                                │");
			if (!alrealyCsv)
			{
				Console.WriteLine("│             c - Add from CSV file              │");
				Console.WriteLine("│                                                │");
			}
			Console.WriteLine("│             m - Modify a player                │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             d - Delete a player                │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│                                     x - Exit   │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}

		public static void CountryMenu()
		{
			Console.WriteLine("┌────────────────────────────────────────────────┐");
			Console.WriteLine("│           --  Country Menu --                  │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             a - Adding                         │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             m - Modifying                      │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│             s - Deleting                       │");
			Console.WriteLine("│                                                │");
			Console.WriteLine("│                                     x - Exit   │");
			Console.WriteLine("└────────────────────────────────────────────────┘");
		}
	}
}
