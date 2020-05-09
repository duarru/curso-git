using System;
using System.Collections.Generic;
using System.Globalization;
namespace Salary {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employee will be to register: ");
            int numberEmployee = int.Parse(Console.ReadLine());
            Employee[] e = new Employee[numberEmployee];
            List<Employee> register = new List<Employee>();
            bool printMensage = true;
            for (int i = 0; i < e.Length; i++) {
                Console.WriteLine("Employee #" + (i+1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                e[i] = new Employee { Id = id, Name = name, Salary = salary };
            }
            Console.Write("Enter the employee ID that will have salary increase: ");
            int findID = int.Parse(Console.ReadLine());
            for(int i = 0; i < e.Length; i++) {
                if (findID == e[i].Id) {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    e[i].increaseSalary(percentage);
                    printMensage = false;
                }
                register.Add(e[i]);
            }
            Console.WriteLine();
            if (printMensage == true) {
                Console.WriteLine("This ID does not exist!");
                Console.WriteLine();
            }
            Console.WriteLine("Update list of employees:");
            foreach (Employee obj in register) {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}
