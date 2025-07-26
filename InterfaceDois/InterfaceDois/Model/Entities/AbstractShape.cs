using System;
using InterfaceDois.Model.Entities.Enums;

namespace InterfaceDois.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
