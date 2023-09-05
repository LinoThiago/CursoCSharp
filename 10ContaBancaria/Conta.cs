namespace _10ContaBancaria
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string? Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta() { }

        public Conta(int numeroConta, string? titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public Conta(int numeroConta, string? titular, double valor) : this(numeroConta, titular)
        {
            Deposito(valor);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string? ToString()
        {
            return $"\nDados da conta:\nConta: {NumeroConta}\nTitular: {Titular}\nSaldo: {Saldo}\n";
        }
    }
}
