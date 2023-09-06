using System.Collections.Generic;

namespace _13ManipulandoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> filtro = new List<string>();

            Console.WriteLine("Lista populada com Add: ");
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("João");
            list.Add("Sandro");
            list.Add("Saulo");
            ImprimirLista(list);

            Console.WriteLine("Item adicionado a lista com Insert na posição 2 ");
            list.Insert(2, "Marco");
            ImprimirLista(list);

            Console.WriteLine($"Tamanho da lista: {list.Count}");
            Console.WriteLine($"Primeira ocorrencia nome iniciando com A: {list.Find(x => x[0] == 'A')}");
            Console.WriteLine($"Última ocorrencia nome iniciando com A: {list.FindLast(x => x[0] == 'A')}");
            Console.WriteLine($"Indice da primeira ocorrencia nome iniciando com A: {list.FindIndex(x => x[0] == 'A')}");
            Console.WriteLine($"Indice da última ocorrencia nome iniciando com A: {list.FindLastIndex(x => x[0] == 'A')}");
            Console.WriteLine("----------\n");

            Console.WriteLine("Lista filtrada por nomes que contenha 5 caracteres: ");
            filtro = list.FindAll(x => x.Length == 5);
            ImprimirLista(filtro);

            Console.WriteLine("Removendo o item com nome Alex: ");
            list.Remove("Alex");
            ImprimirLista(list);

            Console.WriteLine("Removendo itens que comecem com a letra M: ");
            list.RemoveAll(x => x[0] == 'M');
            ImprimirLista(list);

            Console.WriteLine("Removendo item na posição 2: ");
            list.RemoveAt(2);
            ImprimirLista(list);

            Console.WriteLine("Removendo itens por range a partir sa posição 1, remover 2 itens: ");
            list.RemoveRange(1,2);
            ImprimirLista(list);
        }

        static void ImprimirLista(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------\n");
        }
    }
}