using System;
using System.Globalization;

namespace _002Day
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep;

            Console.Clear();
            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do Titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string x = Console.ReadLine();
            if(x == "s" || x == "S")
            {
                Console.Write("Entre com um valor de depósito inicial: ");
                dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
                dep = 0.0;
            
            Conta p = new Conta(nome, dep, num);    
            Console.WriteLine($"\nDados da conta:\n{p}");

        }
    }
}
