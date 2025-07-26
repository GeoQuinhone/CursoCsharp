using System;
using System.Globalization;

namespace Interfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax;  }
        }

        public override string ToString()
        {
            return "Pagamento Básico: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nImposto: " // o \n é usado para quebrar a linha
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}
