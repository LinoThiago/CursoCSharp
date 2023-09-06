namespace _12ReservaQuartoVetor
{
    internal class Locatario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Email}";
        }
    }
}
