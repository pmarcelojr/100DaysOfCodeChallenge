using System;

namespace _001Day
{
    class Calculdadora
    {
        public void Adicao(int a, int b)
        {
            Console.WriteLine($"\nVocê escolheu Adição => {a} + {b} = {a+b}");
        }
        public void Subtracao(int a, int b)
        {
            Console.WriteLine($"\nVocê escolheu Subtração => {a} - {b} = {a-b}");
        }
        public void Multiplicacao(int a, int b)
        {
            Console.WriteLine($"\nVocê escolheu Multiplicação => {a} * {b} = {a*b}");
        }
    }
}