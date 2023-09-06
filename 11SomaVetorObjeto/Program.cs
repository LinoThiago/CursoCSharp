namespace _11SomaVetorObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;
            Produto[] produtos;
            double total = 0;

            Console.Write("Quantidade de produtos: ");
            quantidade = int.Parse(Console.ReadLine());
            produtos = new Produto[quantidade];
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("Entre com nome e valor do produto: ");
                produtos[i] = new Produto { Name = Console.ReadLine(), Preco = double.Parse(Console.ReadLine())};
            }
            for (int i = 0;i < produtos.Length; i++)
            {
                total += produtos[i].Preco; 
            }
            Console.WriteLine($"Valor total: {total}");
            Console.WriteLine($"Média : {total / produtos.Length:F2}");
        }
    }
}