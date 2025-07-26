using System;


namespace Interfaces.Services
{
    class BrazilTaxService : ITaxService // realização de interface
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
