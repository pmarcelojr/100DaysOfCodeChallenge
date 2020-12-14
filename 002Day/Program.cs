using System;
using System.Globalization;

namespace _002Day
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            
            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Conta p = new Conta("", 0, num);
            Console.Write("Entre com o nome do Titular da conta: ");
            p.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string x = Console.ReadLine();
            if(x == "s" || x == "S")
            {
                Console.Write("Entre com um valor de depósito inicial: ");
                p.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
                p.Saldo = 0.0;
            
            Console.WriteLine($"\nDados da conta:\n{p}");

        }
    }
}
