using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientacaoObjetos
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double CalcularDolar (double cotacao, double quantia)
        {
            double total = cotacao * quantia;
            return total + total * Iof / 100.00;
        }
    }
}
