using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ConversaoMoeda
{
    internal class ConversorDeMoeda
    {
        static double IOF = 0.06;
        public static double CalcularConversao(double cotacao, double quantidade)
        {
            return quantidade * cotacao  * (1 + IOF);
        }
    }
}
