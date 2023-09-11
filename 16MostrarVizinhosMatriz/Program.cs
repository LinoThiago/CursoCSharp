namespace _16MostrarVizinhosMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas, valor;
            int[,] matriz;
            string[] valores;

            Console.WriteLine("Informe o numero de linhas da matriz: ");
            linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInforme o numero de colunas da matriz: ");
            colunas = int.Parse(Console.ReadLine());
            matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine($"\nDigite os valores da linha {i} separados por espaço: ");
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i,j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0;i < linhas; i++)
            {
                for (int j = 0;j < colunas; j++)
                {
                    Console.Write($"[{matriz[i,j]}]");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nInforme o valor que deseja mostrar os vizinhos: ");
            valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        Console.WriteLine($"\nPosição: {i},{j}:");
                        if (j != 0)
                        {
                            Console.WriteLine($"Left: {matriz[i,j - 1]}");
                        }
                        if (j < colunas - 1)
                        {
                            Console.WriteLine($"Right: {matriz[i,j + 1]}");
                        }
                        if (i != 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1,j]}");
                        }
                        if (i < linhas - 1)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}