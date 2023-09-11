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
            Console.WriteLine();
            Console.WriteLine($"Dias: {new TimeSpan(5, 15, 21, 30, 500).Days}");
            Console.WriteLine($"Horas: {new TimeSpan(5, 15, 21, 30, 500).Hours}");
            Console.WriteLine($"Minutos: {new TimeSpan(5, 15, 21, 30, 500).Minutes}");
            Console.WriteLine($"Segundos: {new TimeSpan(5, 15, 21, 30, 500).Seconds}");
            Console.WriteLine($"Milisegundos: {new TimeSpan(5, 15, 21, 30, 500).Milliseconds}");
            Console.WriteLine($"Ticks: {new TimeSpan(5, 15, 21, 30, 500).Ticks}");
            Console.WriteLine();
            Console.WriteLine($"Dias: {new TimeSpan(5, 15, 21, 30, 500).TotalDays}");
            Console.WriteLine($"Horas: {new TimeSpan(5, 15, 21, 30, 500).TotalHours}");
            Console.WriteLine($"Minutos: {new TimeSpan(5, 15, 21, 30, 500).TotalMinutes}");
            Console.WriteLine($"Segundos: {new TimeSpan(5, 15, 21, 30, 500).TotalSeconds}");
            Console.WriteLine($"Milisegundos: {new TimeSpan(5, 15, 21, 30, 500).TotalMilliseconds}");
            Console.WriteLine();
            Console.WriteLine($"Soma 1h + 1h = {new TimeSpan(1,0,0).Add(new TimeSpan(1,0,0))}");
            Console.WriteLine($"Subtração 1h + 5m = {new TimeSpan(1,0,0).Subtract(new TimeSpan(0,5,0))}");
            Console.WriteLine($"Multiplicação 1h * 5 = {new TimeSpan(1,0,0).Multiply(5)}");
            Console.WriteLine($"Divisão 1h / 5 = {new TimeSpan(1,0,0).Divide(5)}");
        }
    }
}