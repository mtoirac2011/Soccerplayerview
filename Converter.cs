
using System;

namespace Soccerplayerview
{
    public class Converter
    {
        public string X { get; set; }

        public Converter (string x)
        {
            X = x;
        }

        public static string FarToCelcious(double value)
        {
            return ((value - 32.0) * 5 / 9).ToString("N2");                 
        }

        public static string MilesToKm(double value)
        {
            return (value * 1.60934).ToString("N2");
        }

        public static string FeetToMeter(double value)
        {
  
            return (value * 0.3048).ToString("N2");

        }

        public static string MeterToCm(double value)
        {
            return (value * 100).ToString("N2");
        }

        public static void DisplayConvertion(double value1)
        {
            Console.WriteLine("───────────────────────────────");
            Console.WriteLine($"\nConvertion for value: {value1.ToString()}\n");
            Console.WriteLine("──────────────────────────\n");

            Console.WriteLine($"Fahrenheit to celsius: {FarToCelcious(value1)}\n");
            Console.WriteLine($"  Miles to kilometers: {MilesToKm(value1)}\n");
            Console.WriteLine($"       Feet to meters: {FeetToMeter(value1)}\n");
            Console.WriteLine($"Meters to centimeters: {MeterToCm(value1)}\n");

            Console.WriteLine("───────────────────────────────");
        }

        public static double Truncate( double value, int decimales)
        {
            double aux_value = Math.Pow(10, decimales);
            return (Math.Truncate(value * aux_value) / aux_value);
        }

        public static void ConverterTitle()
        {
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.WriteLine("│              From a number to type,            │");
            Console.WriteLine("│        the converter will show you the         │");
            Console.WriteLine("│            corresponding values:               │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("│            * Fahrenheit to celsius             │");
            Console.WriteLine("│            * Miles to kilometers               │");
            Console.WriteLine("│            * Feet to meters                    │");
            Console.WriteLine("│            * Feet to meters                    │");
            Console.WriteLine("│            * Meters to centimeters             │");
            Console.WriteLine("└────────────────────────────────────────────────┘");
        }
    }
}
