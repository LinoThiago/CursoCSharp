namespace _18FuncoesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "     String Teste     ";
            Console.WriteLine($"String original: {original}");
            Console.WriteLine($"Transformando em maiusculas ->{original.ToUpper()}<-");
            Console.WriteLine($"Transformando em minusculas ->{original.ToLower()}<-");
            Console.WriteLine($"Removendo espaços em branco ->{original.Trim()}<-");
            Console.WriteLine($"Index da primera ocorrencia 'T' ->{original.IndexOf('T')}<-");
            Console.WriteLine($"Index da ultima ocorrencia 'e' ->{original.LastIndexOf('e')}<-");
            Console.WriteLine($"Recortando do indice em diante ->{original.Substring(12)}<-");
            Console.WriteLine($"Recortando o indice em diante e escolhendo quantidade de caracteres ->{original.Substring(12,5)}<-");
            Console.WriteLine($"Substituindo texto ->{original.Replace("Teste","Replace")}<-");
            Console.WriteLine($"Testando se string é nula ou vazia ->{String.IsNullOrEmpty(original)}<-");
            Console.WriteLine($"Testando se string é nula ou contém só espaços em branco ->{String.IsNullOrWhiteSpace(original)}<-");
            string[] strings = original.Trim().Split(' ');
            foreach (string s in strings)
            {
                Console.WriteLine($"Recortando string pelo caracter ' ' ->{s}<-");
            }
        }
    }
}