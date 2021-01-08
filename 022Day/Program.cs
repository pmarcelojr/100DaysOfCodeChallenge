using System;
using System.Globalization;
using System.IO;
using _022Day.Entities;

namespace _022Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"C:\temp\folder\in.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = $@"{sourceFolderPath}\out";
                string targetFilePath = $@"{targetFolderPath}\summary.txt";
                
                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] s = line.Split(',');
                        string name = s[0];
                        double price = double.Parse(s[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(s[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine($"{prod.Name}, {prod.Total().ToString("f2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);                
            }
        }
    }
}