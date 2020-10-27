using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Shape.Shapes
{
    //Pillar : Abstraction
    abstract class Shape
    {

        abstract public double Area { get; }

        abstract public double Perimeter { get; }

        public enum ColourValue
        {
            Red,
            Green,
            Blue
        }

        public ColourValue Colour { get; set; }

        public Shape()
        {
            Colour = ColourValue.Red;
        }

        public Shape(ColourValue colour)
        {
            Colour = colour;
        }
    }
}
