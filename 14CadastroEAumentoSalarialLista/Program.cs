using System.Collections.Generic;

namespace _14CadastroEAumentoSalarialLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario;
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<Funcionario> filtro = new List<Funcionario>();
            int quantidade, id;
            string nome;
            double salario;

            Console.WriteLine("Quantos funcionarios serão registrados? ");
            quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Funcionario {i + 1}");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salario: ");
                salario = double.Parse(Console.ReadLine());
                funcionario = new Funcionario(id,nome,salario);
                funcionarios.Add(funcionario);
                Console.WriteLine();
            }

            Console.Write("Entre com o Id do funcionário que deseja aumentar o salario: ");
            id = int.Parse(Console.ReadLine());

            if (funcionarios.Exists(funcionario => funcionario.Id == id))
            {
                foreach (Funcionario f in funcionarios)
                {
                    if (f.Id == id)
                    {
                        Console.Write("Entre com a porcentagem de aumento: ");
                        f.AumentarSalario(double.Parse(Console.ReadLine()));
                    }
                }
            }
            else
            {
                Console.WriteLine("Este Id não existe!");
            }

            Console.WriteLine("\nLista de funcionarios atualizada: ");
            foreach (Funcionario f in funcionarios)
            {
                Console.WriteLine(f);
            }
        }
    }
}