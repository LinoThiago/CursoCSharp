namespace _15Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanho;
            int contador = 0;

            Console.WriteLine("Entre com o tamanho da matriz: ");
            tamanho = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamanho,tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"\nEntre com os valores da linha {i} separados por espaço: ");
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < tamanho; j++)
                {
                    matriz[i,j] = int.Parse(valores[j]);
                } 
            }
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0;j < tamanho; j++)
                {
                    Console.Write($"[{matriz[i,j]}]");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nDiagonal principal: ");
            for (int i = 0;i < tamanho; i++)
            {
                Console.Write($"[{matriz[i,i]}]");
            }
            for (int i = 0; i < tamanho ; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        contador++;
                    }
                }
            }
            Console.WriteLine($"\n\nQuantidade de numeros negativos é: {contador}");
        }
    }
}