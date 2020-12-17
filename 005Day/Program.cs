using System;

namespace _005Day
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int x = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 0; i < x; i++)
            {
                Console.Clear();
                Console.Write($"Employee #{i + 1}:\nId: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.Clear();
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.Clear();
            Console.WriteLine("Updated list of Employee:");
            foreach(Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
