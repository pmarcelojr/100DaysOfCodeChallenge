using System;
using Funcoes;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int RESULTADO_MEGA = 1;
        public static void Criar()
        {
            Console.WriteLine("|    Seja Bem vindo ao Robô  *-*   |");
            Console.WriteLine("|      Aplicação Console Final     |");
            Console.WriteLine("|----------------------------------|");
            
            while (true)
            {
                Console.WriteLine("|       0 - Sair do Programa       |");
                Console.WriteLine("|       1 - Resultado da Mega      |");
                Console.WriteLine("|       2 - Gerar jogo Aleatório   |");
                Console.WriteLine("|----------------------------------|");
                Console.Write("|Informe uma das Opções acima: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == RESULTADO_MEGA)
                {
                    Mega.Resultado();
                }
                else
                {
                    Console.WriteLine("Opção Inválida digite novamente");
                }
            }
        }
    }
}