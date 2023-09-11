using System.Globalization;

namespace _18DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Construtor data: {new DateTime(2023, 09, 11)}");
            Console.WriteLine($"Construtor data e hora: {new DateTime(2023, 09, 11, 17, 11, 50)}");
            Console.WriteLine();
            Console.WriteLine($"Builder Now: {DateTime.Now}");
            Console.WriteLine($"Builder Today: {DateTime.Today}");
            Console.WriteLine($"Builder UtcNow: {DateTime.UtcNow}");
            Console.WriteLine();
            Console.WriteLine($"Data Parse: {DateTime.Parse("2023-09-11")}");
            Console.WriteLine($"Data Hora Parse: {DateTime.Parse("11/09/2023 17:27:43")}");
            Console.WriteLine();
            Console.WriteLine($"Data ParseExact: {DateTime.ParseExact("2023-09-11", "yyyy-MM-dd",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Data Hora ParseExact: {DateTime.ParseExact("11/09/2023 17:20:05", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture)}");
        }
    }
}