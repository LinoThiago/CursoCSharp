using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SomaNotas
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public string Resultado()
        {
            double notaFinal = NotaFinal();
            if(NotaFinal() > 60)
            {
                return $"NOTA FINAL = {notaFinal:F2}\nAPROVADO";
            }
            else
            {
                return $"NOTA FINAL = {notaFinal:F2}\nREPROVADO\nFALTARAM {60 - notaFinal:F2} PONTOS";
            }
        }
    }
}
