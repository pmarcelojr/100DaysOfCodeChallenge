using System;
using System.IO;
using System.Collections.Generic;

namespace conjuntoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> list = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int voto = int.Parse(line[1]);

                        if (list.ContainsKey(name))
                        {
                            list[name] += voto;
                        }
                        else
                        {
                            list[name] = voto;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in list)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
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
