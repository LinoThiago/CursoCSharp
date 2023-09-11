namespace _17CondicionalTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            string maioridade = (idade < 18) ? "Menor de Idade" : "Maior de idade";
            Console.WriteLine(maioridade);
        }
    }
}