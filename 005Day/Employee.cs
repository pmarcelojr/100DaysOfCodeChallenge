using System;

namespace _005Day
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double porcentagem)
        {
            Salary += (porcentagem / 100);
        }
    }
}