using System.Globalization;

namespace _19DateTime
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
            Console.WriteLine("\nPropriedades: ");
            Console.WriteLine($"Data: {DateTime.Now.Date}");
            Console.WriteLine($"Dia: {DateTime.Now.Day}");
            Console.WriteLine($"Dia da semana: {DateTime.Now.DayOfWeek}");
            Console.WriteLine($"Dia do ano: {DateTime.Now.DayOfYear}");
            Console.WriteLine($"Hora: {DateTime.Now.Hour}");
            Console.WriteLine($"Tipo de data: {DateTime.Now.Kind}");
            Console.WriteLine($"Milisegundos: {DateTime.Now.Millisecond}");
            Console.WriteLine($"Minuto: {DateTime.Now.Minute}");
            Console.WriteLine($"Mês: {DateTime.Now.Month}");
            Console.WriteLine($"Segundos: {DateTime.Now.Second}");
            Console.WriteLine($"Ticks: {DateTime.Now.Ticks}");
            Console.WriteLine($"Hora completa: {DateTime.Now.TimeOfDay}");
            Console.WriteLine($"Ano: {DateTime.Now.Year}");
            Console.WriteLine();
            Console.WriteLine("\nFormatação: ");
            Console.WriteLine($"Data por extenso: {DateTime.Now.ToLongDateString()}");
            Console.WriteLine($"Data: {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"Hora: {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"Hora minuto: {DateTime.Now.ToShortTimeString()}");
            Console.WriteLine($"Formatada: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
            Console.WriteLine($"Adicionar 2 horas: {DateTime.Now.AddHours(2)}");
            Console.WriteLine($"Diferença de data: {new DateTime(2023, 12, 25).Subtract(DateTime.Now).Days}");

        }
    }
}