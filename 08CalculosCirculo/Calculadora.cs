﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CalculosCirculo
{
    internal class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double raio)
        {
            return 2 * Pi * raio;
        }
        public static double Volume(double raio)
        {
            return 4 / 3 * Pi * Math.Pow(raio, 3);
        }
    }
}
