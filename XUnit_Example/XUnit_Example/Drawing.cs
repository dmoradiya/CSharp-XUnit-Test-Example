using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOP_Shape.Shapes;

namespace OOP_Shape
{
    class Drawing
    {
        // Pillar: Polymorphism
        private List<Shape> Shapes { get; set; }

        public double SpaceCovered => Shapes.Select(x => x.Area).Sum();

        public double LinesDrawn => Shapes.Select(x => x.Perimeter).Sum();

        // Pillar: Encapsulation
        public void Draw(Shape shape)
        {
            Shapes.Add(shape);
        }

        public override string ToString()
        {
            return $"A drawing consisting of {Shapes.Count} shapes.";
        }

        public Drawing()
        {
            Shapes = new List<Shape>();
        }
    }



}
