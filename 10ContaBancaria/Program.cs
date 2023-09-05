namespace _10ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            int numero;
            string titular;

            Console.Write("Entre com o número da conta: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n) ");
            if (char.Parse(Console.ReadLine()) == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                conta = new Conta(numero, titular, double.Parse(Console.ReadLine()));
            }
            else
            {
                conta = new Conta(numero, titular);
            }
            
            Console.WriteLine(conta.ToString());

            Console.Write("Entre com o valor de depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta.ToString());

            Console.Write("Entre com o valor de saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta.ToString());

        }
    }
}