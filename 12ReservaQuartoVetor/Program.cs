namespace _12ReservaQuartoVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reservas;
            Locatario[] locatarios = new Locatario[10];
            string nome;
            string email;

            Console.Write("Quantas reservas serão realizadas: ");
            reservas = int.Parse(Console.ReadLine());
            for (int i = 0; i < reservas; i++)
            {
                Console.WriteLine($"\nReserva {i + 1}");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                locatarios[int.Parse(Console.ReadLine()) - 1] = new Locatario { Nome = nome, Email = email};
            }
            Console.WriteLine("\nQuartos reservados:");
            for(int i = 0;i < locatarios.Length; i++)
            {
                if(locatarios[i] != null)
                {
                    Console.WriteLine($"{i + 1}: {locatarios[i]}");
                }
            }
        }
    }
}