namespace _03MediaSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioA = new Funcionario();
            Funcionario funcionarioB = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionarioA.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioA.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionarioB.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionarioB.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"Salário médio = {(funcionarioA.Salario + funcionarioB.Salario)/2:F2}");
        }
    }
}