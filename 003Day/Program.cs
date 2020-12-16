using System;

namespace _003Day
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rent[] vect = new Rent[10];

            Console.Clear();
            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine($"Quarto #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                if(!Validator.IsValidEmail(email))
                    throw new InvalidOperationException("Entre com um email válido");
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Rent(nome, email);
            }
            
            Console.Clear();
            Console.WriteLine("Quartos Ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                Console.WriteLine($"{i}: {vect[i]}");
            }
        }
    }
}
