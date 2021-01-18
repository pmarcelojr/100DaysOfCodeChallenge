using System;
using System.Collections.Generic;
using conjuntoSet.Entities;

namespace conjuntoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> list = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int qtd = int.Parse(Console.ReadLine());
                list.Add(new Student(qtd));
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int qtd = int.Parse(Console.ReadLine());
                list.Add(new Student(qtd));
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int qtd = int.Parse(Console.ReadLine());
                list.Add(new Student(qtd));
            }

            Console.WriteLine($"Total students: {list.Count}");
        }
    }
}
