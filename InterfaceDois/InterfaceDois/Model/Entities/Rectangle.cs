using System;


namespace InterfaceDois.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
