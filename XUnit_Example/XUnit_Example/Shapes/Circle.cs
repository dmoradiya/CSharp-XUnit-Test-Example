using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    // Pillar: Inheritance
    class Circle : Shape
    {
       
        public override double Perimeter => Math.PI * Diameter;

        public override double Area => Math.PI * Math.Pow(Radius, 2);

        public double Radius { get; set; }

        public double Diameter
        {
            get => Radius * 2;
            set
            {
                Radius = value / 2;
            }
        }

        public Circle() : base()
        {
            Radius = 20;
        }

        public Circle(ColourValue colour, double radius) : base(colour)
        {
            Radius = radius;
        }
    }
}
