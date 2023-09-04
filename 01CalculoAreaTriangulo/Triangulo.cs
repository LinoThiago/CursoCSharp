using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CalculoAreaTriangulo
{
    internal class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;
        public double SemiPerimetro;
        public double Area()
        {
            SemiPerimetro = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(SemiPerimetro * (SemiPerimetro - LadoA) * (SemiPerimetro - LadoB) * (SemiPerimetro - LadoC));
        }
    }
}
