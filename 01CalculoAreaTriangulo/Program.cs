namespace _01CalculoAreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo trianguloX = new Triangulo();
            Triangulo trianguloY = new Triangulo();
            double areaX, areaY;
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            trianguloX.LadoA = double.Parse(Console.ReadLine());
            trianguloX.LadoB = double.Parse(Console.ReadLine());
            trianguloX.LadoC = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            trianguloY.LadoA = double.Parse(Console.ReadLine());
            trianguloY.LadoB = double.Parse(Console.ReadLine());
            trianguloY.LadoC = double.Parse(Console.ReadLine());
            areaX = trianguloX.Area();
            areaY = trianguloY.Area();
            Console.WriteLine($"Área do triangulo X: {areaX:F2}");
            Console.WriteLine($"Área do triangulo Y: {areaY:F2}");
            if(areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}