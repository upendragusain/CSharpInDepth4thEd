using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play
{
    public class ContravariantComparison
    {
        // Note: these classes use some C# 6 and 7 features for brevity.
        // Those features are not directly related to generic variance.
        abstract class Shape
        {
            public abstract double Area { get; }
        }

        class Circle : Shape
        {
            public double Radius { get; }
            public override double Area => Radius * Radius;

            public Circle(double radius) => Radius = radius;
        }

        // Not actually used, but you could sort a List<Rectangle> in the same way.
        class Rectangle : Shape
        {
            public double Width { get; }
            public double Height { get; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double Area => Width * Height;
        }

        class AreaComparer : IComparer<Shape>
        {
            public int Compare(Shape x, Shape y) => x.Area.CompareTo(y.Area);
        }

        public static void Run()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5.3),
                new Circle(2),
                new Circle(33.5),
                new Rectangle(1,12),
                new Rectangle(34,3)
            };
            shapes.Sort(new AreaComparer());
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Area}, {shape.GetType().Name}");
            }
        }
    }
}
