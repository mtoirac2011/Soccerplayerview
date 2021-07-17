﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Soccerplayerview
{
    class Util
    {
        
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


        public static void AddRecord(string campo1, string campo2, string fileNamePath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(fileNamePath, true))
                {
                    file.WriteLine(campo1 + "," + campo2);
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Error message ", ex);
            }

        }

        public static string[] ReadRecord(string searchTerm, string filePath, int positionOfSearch)
        {
            positionOfSearch--;
            string[] recordNotFound = {"Record not found"};
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);

                for (int i=0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');

                    for (int f=0; f < fields.Length; f++)
                    {
                        Console.WriteLine("Realizar recorrido sub-lista");
                    }
                    Console.ReadKey();                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex );               
            }
            return recordNotFound;
        }

        public static string[] RecordMatches(string searchTerm, string[] record, int positionOfSearch)
        {
            string[] result = new string[3];

            return result;
        }
    }
}