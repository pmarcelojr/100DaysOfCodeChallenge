using System;
using System.Globalization;
using _009Day.Entities;
using _009Day.Entities.Enums;

namespace _009Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter cliente Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client c1 = new Client(name, email, date);

            Console.WriteLine("Enter order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now , status, c1);

            Console.WriteLine(order);
        }
    }
}
