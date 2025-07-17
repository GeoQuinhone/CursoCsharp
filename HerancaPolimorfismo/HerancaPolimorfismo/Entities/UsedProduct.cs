using System;
using System.Globalization;

namespace HerancaPolimorfismo.Entities
{
     class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name
                + "(Usado) $ "
                +Price.ToString("F2", CultureInfo.InvariantCulture)
                +"(Data de fabricação: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                +")";
        }
    }
}
