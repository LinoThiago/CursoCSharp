namespace _08CalculosCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circunferência: {Calculadora.Circunferencia(raio)}");
            Console.WriteLine($"Volume: {Calculadora.Volume(raio)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi}");
        }
    }
}