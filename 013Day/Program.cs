using System;
using System.Globalization;
using System.Collections.Generic;
using _013Day.Entities;

namespace _013Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (y/n)? ");
                char typeEmployee = char.Parse(Console.ReadLine());
                if(typeEmployee == 'y' || typeEmployee == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double additionalChange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalChange));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.Clear();
            Console.WriteLine("PAYMENTS:");
            foreach(Employee func in list)
            {
                Console.WriteLine($"{func.Name} - $ {func.Payment().ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
