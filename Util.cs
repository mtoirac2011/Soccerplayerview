using System;
using System.Collections.Generic;
using System.IO;


namespace Soccerplayerview
{
    class Util
    {
        private static Player playerAux;

        public static string FileName()
        {
            string currentDir = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirInfo = new DirectoryInfo(currentDir);
            var fileName = Path.Combine(currentDirInfo.FullName, "Soccerplayers.csv");

            //Show files in current directory
            //var files = currentDirInfo.GetFiles();
            //Console.WriteLine("files in current directory ");
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}
            //Console.WriteLine();
            //Console.ReadKey();

            // Show fileName Path
            Console.WriteLine("fileName Path");
            Console.WriteLine(fileName);
            Console.WriteLine();
            Console.ReadKey();
            //End Showing results

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

        public static List<Player> ReadCsvByLine(string fileName)
        {
            string firstName;
            string lastName;
            string country;
            string team;
            DateTime since;

            //Player playerAux = new Player();
            List<Player> lstAuxPLayer = new List<Player>();

            
            //string[] fileByLines = fileContent.Split(new char[] { '\r', '\n' });

            string[] Lines = System.IO.File.ReadAllLines(fileName);

            Console.WriteLine("Imprimiendo fichero con todas todas las lineas ReadAllLines ");
            Console.WriteLine(Lines);
            Console.ReadKey();

            for (int i=1; i < Lines.Length; i++)
            {
                
                Console.WriteLine("Valor de Linea para Linea =" + i);
                Console.WriteLine(Lines[i]);

                string[] fields = Lines[i].Split(',');

                //Console.WriteLine("Valor para Linea =" + i + "Subconjunto" + i--);
                //Console.WriteLine(fields[i]);

                for (int j=0; j < fields.Length; j++)
                {
                    Console.WriteLine($"Valor para Linea {i} Subconjunto {j} \n");
                    
                    switch (j)
                    {
                        case 0:
                            //playerAux.FirstName = fields[0];

                            firstName = fields[0];
                            Console.WriteLine("Valor de firstName: " + firstName);
                            break;
                        case 1:
                            //playerAux.LastName = fields[1];
                            lastName = fields[1];
                            Console.WriteLine("Valor de lastName: " + lastName);
                            break;
                        case 2:
                            //playerAux.Country = fields[2];
                            country = fields[2];
                            Console.WriteLine("Valor de country: " + country);
                            break;
                        case 3:
                            //playerAux.Team = fields[3];
                            team = fields[3];
                            Console.WriteLine("Valor de Team: " + team);
                            break;
                        case 4:
                            try
                            {
                                //playerAux.Since = DateTime.Parse(fields[4]);
                                since = DateTime.Parse(fields[4]);
                                Console.WriteLine("Valor de Since: " + since);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error converting Type: ", ex);
                            }
                            
                            break;

                        default:
                            
                            break;
                    }
                   
                    lstAuxPLayer.Add(playerAux);                    
                }

                Console.ReadKey();
            }

            General.AlreadyCsv = true;
            return lstAuxPLayer;
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
