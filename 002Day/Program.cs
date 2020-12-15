using System;
using System.Globalization;

namespace _002Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao, resp;
            double dep;
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
                dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.Depositar(dep);
            }
            else
                p.Depositar(0.0);
            
            Console.Clear();
            Console.WriteLine($"Dados da conta:\n{p}\n");

            do
            {
                Console.WriteLine("1 - Depositar\t2 - Sacar\t3 - Atualizar Dados\t4 - Sair\nEscolha uma opção: ");
                opcao = Console.ReadLine();
                if(opcao == "4")
                {
                    resp = "Não";
                    break;
                }
                else
                {
                    switch (opcao)
                    {
                        case "1":
                            Console.Clear();
                            Console.Write("Entre com um valor para depósito: ");
                            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            p.Depositar(dep);
                            Console.WriteLine($"\nDados da Conta Atualizados:\n{p}");
                            break;
                        case "2":
                            Console.Clear();
                            Console.Write("Entre com um valor para saque: ");
                            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            p.Sacar(dep);
                            Console.WriteLine($"\nDados da Conta Atualizados:\n{p}");
                            break;
                        case "3":
                            Console.Clear();
                            Console.Write($"O nome atual é {p.Nome}\nAtualize o nome do Titular da conta: ");
                            p.Nome = Console.ReadLine();
                            Console.Write($"O nome Atualizado é {p.Nome}");
                            break;
                        default:
                            Console.Write("Opção Invalida!");
                            break;
                    }
                    Console.Write("\nDeseja realizar outra operação (Sim/Não): ");
                    resp = Console.ReadLine();
                    Console.Clear();
                }
            } while (resp == "Sim" || resp == "SIM" || resp == "sim" || resp == "s" || resp == "S");

        }
    }
}
