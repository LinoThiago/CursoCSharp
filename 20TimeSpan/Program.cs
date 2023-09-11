namespace _20TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Construtor vazio: {new TimeSpan()}");
            Console.WriteLine($"Construtor ticks: {new TimeSpan(9000000000L)}");
            Console.WriteLine($"Construtor ticks: {new TimeSpan(9000000000L)}");
            Console.WriteLine($"Construtor hora, minuto, segundo: {new TimeSpan(5, 30, 21)}");
            Console.WriteLine($"Construtor dia, hora, minuto, segundo: {new TimeSpan(5, 15, 21, 30)}");
            Console.WriteLine($"Construtor dia, hora, minuto, segundo, milisegundo: {new TimeSpan(5, 15, 21, 30, 500)}");
            Console.WriteLine();
            Console.WriteLine($"From dias: {TimeSpan.FromDays(1.5)}");
            Console.WriteLine($"From horas: {TimeSpan.FromHours(1.5)}");
            Console.WriteLine($"From minutos: {TimeSpan.FromMinutes(1.5)}");
            Console.WriteLine($"From segundos: {TimeSpan.FromSeconds(1.5)}");
            Console.WriteLine($"From milisegundos: {TimeSpan.FromMilliseconds(1.5)}");
            Console.WriteLine($"From ticks: {TimeSpan.FromTicks(900000000L)}");
        }
    }
}