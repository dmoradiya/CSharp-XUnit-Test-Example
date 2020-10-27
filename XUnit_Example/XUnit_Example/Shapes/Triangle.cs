using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    class Triangle : Shape
    {
        public override double Perimeter => (Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Base / 2, 2)) * 2) + Base;


        public override double Area => Base * Height / 2;

        public double Base { get; set; }

        public double Height { get; set; }

        public Triangle() : base()
        {
            Base = 20;
            Height = 10;
        }

        public Triangle(ColourValue colour, double bottom, double height) : base(colour)
        {
            Base = bottom;
            Height = height;
        }


    }
}
