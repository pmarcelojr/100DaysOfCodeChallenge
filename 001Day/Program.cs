using System;

namespace _001Day
{
    class Program
    {
        public static void Main()
        {
            int num1, num2, opcao;
            string resp;
            Calculdadora c = new Calculdadora();

            Console.Clear();
            Console.WriteLine("*** Simples Calculdadora ***");
            Console.WriteLine("Entre com dois numeros: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("1 - Adição\t2 - Subtração\t3 - Multiplicação\t4 - Divisão\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        c.Adicao(num1, num2);
                        break;
                    case 2:
                        c.Subtracao(num1, num2);
                        break;
                    case 3:
                        c.Multiplicacao(num1, num2);
                        break;
                    default:
                        break;
                }

                Console.Write("Você deseja fazer outra operação (yes/no): ");
                resp = Console.ReadLine();
            } while(resp == "yes" || resp == "YES");
        }
    }
}