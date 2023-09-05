namespace _04Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double preco;
            int quantidade;
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            Produto produto = new Produto(nome, preco,quantidade);
            Console.WriteLine($"\nDados do produto: {produto}\n");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"\nDados atualizados: {produto}\n");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine($"\nDados atualizados: {produto}");
        }
    }
}