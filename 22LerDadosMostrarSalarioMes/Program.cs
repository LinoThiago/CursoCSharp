using System.Globalization;
using _22LerDadosMostrarSalarioMes.Entities;
using _22LerDadosMostrarSalarioMes.Entities.Enums;

namespace _22LerDadosMostrarSalarioMes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker;
            Department department;
            HourContract contract;
            WorkerLevel level;
            string name, monthAndYear;
            int month, year;
            double baseSalary;

            Console.Write("Enter department's name:");
            department = new Department(Console.ReadLine());

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int numberContracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                contract = new HourContract(date, valueHour, hours);
                worker.AddContract(contract);
            }
            
            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            monthAndYear = Console.ReadLine();
            month = int.Parse(monthAndYear.Substring(0, monthAndYear.IndexOf('/')));
            year = int.Parse(monthAndYear.Substring(monthAndYear.IndexOf('/') + 1));
            
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture)}");
            
        }
    }
}