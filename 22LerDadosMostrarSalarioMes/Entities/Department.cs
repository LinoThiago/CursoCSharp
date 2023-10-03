namespace _22LerDadosMostrarSalarioMes.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }

        public static implicit operator Department?(string? v)
        {
            throw new NotImplementedException();
        }
    }
}
