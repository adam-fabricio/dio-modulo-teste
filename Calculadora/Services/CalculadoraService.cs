using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraService
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public bool EhPar(int a)
        {
            return a % 2 == 0;
        }
    }
}