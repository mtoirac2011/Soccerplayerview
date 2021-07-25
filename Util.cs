using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Soccerplayerview
{
    class Util
    {
        public static bool AlreadyCsv { get; set; }
        public static string LogFile { get; set; }
        public static string FileName()
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDir);
            var fileName = Path.Combine(currentDirInfo.FullName, "Soccerplayers.csv");
                        
            // Show fileName Path
            Console.WriteLine("fileName Path");
            Console.WriteLine(fileName);
            Console.WriteLine();
            Console.ReadKey();
            
            var fileContent = ReadCsv(fileName);

            //Show Csv file content
            Console.WriteLine("Csv file content");
            Console.WriteLine(fileContent);
            Console.WriteLine();
            Console.ReadKey();

            return fileName;
        }

        public static string ReadCsv(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        public static void anyKeyToContinue()
        {
            Console.Write($"\nAny key to continue...");
            Console.ReadKey();
        }

        public static string SetFileName(string nameOfFile)
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new(currentDir);
            var fullname = Path.Combine(currentDirInfo.FullName, nameOfFile);

            return fullname;
        }
        public static void WriteInLog(string fileNamePath, string msgToWrite)
        {
            DateTime date1 = DateTime.Now;

            try
            {
                string dateTimeString = date1.ToString("G", DateTimeFormatInfo.InvariantInfo);
                using (StreamWriter file = new StreamWriter(fileNamePath, true))
                {
                    file.WriteLine(dateTimeString + "," + msgToWrite);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error converting datatime to string" + ex);
            }

        }
       public static bool CheckForEmail()
        {
            Regex emailFormat = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");            
            bool emailIsValid;
            int counter = 1;
            do
            {
                Menu.WelcomeMenu();

                Console.SetCursorPosition(54, 33);
                Console.Write($"Enter a valid email format, (chance #{counter}): ");
                string inputEmail = Console.ReadLine().Trim();

                if (emailFormat.IsMatch(inputEmail))
                {
                    emailIsValid = true;
                }else
                {
                    emailIsValid = false;
                }
                
                if (counter == 3 && !emailIsValid)
                {
                    Console.Clear();
                    Console.SetCursorPosition(50, 20);
                    Console.Write("Please, try later. Any key yo continue...");
                    Console.ReadKey();
                    break;
                }
                counter++;

            } while (!emailIsValid);

            return emailIsValid;
        }
    }
}
