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
            Console.WriteLine("Pending_Payment   Processing   Shipped   Delivered");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now , status, c1);
            
            Console.Clear();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string produtoName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                Product p1 = new Product(produtoName, price);
                OrderItem orderItem = new OrderItem(qtd, price, p1);

                order.AddItems(orderItem);
            }
            Console.Clear();
            Console.WriteLine(order);
        }
    }
}
