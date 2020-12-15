using System;
using System.Globalization;

namespace _002Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao, resp;
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
            
            Console.Clear();
            Console.WriteLine($"Dados da conta:\n{p}");

            do
            {
                Console.WriteLine("\n1 - Depositar\t2 - Sacar\t3 - Sair\nEscolha uma opção: ");
                opcao = Console.ReadLine();
                if(opcao == "3")
                {
                    resp = "Não";
                    break;
                }
                else
                {
                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Entre com um valor para depósito: ");
                            break;
                        case "2":
                            Console.Write("Entre com um valor para saque: ");
                            break;
                        default:
                            Console.Write("Opção Invalida!");
                            break;
                    }
                    Console.Write("Deseja realizar outra operação (Sim/Não): ");
                    resp = Console.ReadLine();
                }
            } while (resp == "Sim" || resp == "SIM" || resp == "sim" || resp == "s" || resp == "S");

        }
    }
}
