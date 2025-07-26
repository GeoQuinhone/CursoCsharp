using System;
using System.Globalization;
namespace InterfaceDois.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
            + Color
            + ", radius = "
            + Radius.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
            + ", area = "
            + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
