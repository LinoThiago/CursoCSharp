namespace _05CalculosRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"ÁREA = {retangulo.Area():F2}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro():F2}");
            Console.WriteLine($"dIAGONAL = {retangulo.Diagonal():F2}");
        }
    }
}