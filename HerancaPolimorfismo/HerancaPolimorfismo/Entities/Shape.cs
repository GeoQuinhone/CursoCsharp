using System;
using HerancaPolimorfismo.Entities.Enums
;

namespace HerancaPolimorfismo.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // método abstrato que deve ser implementado nas subclasses
    }
}
