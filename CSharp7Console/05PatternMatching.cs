
using System;

namespace CSharp7Console
{
    public class PatternMatching
    {
        private enum ShapeType
        {
            Circle,
            Rectange
        }

        private class Shape { }
        private class Circle : Shape { public int Radius => 100; }
        private class Rectangle : Shape
        {
            public int Length => 100;
            public int Height => 120;
        }

        private static Shape GetShapeFactory(ShapeType style)
        {
            switch (style)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectange:
                    return new Rectangle();
                default:
                    return null;
            }
        }

        public static void SwitchPatternMatchingExample()
        {
            var shape = GetShapeFactory(ShapeType.Rectange);

            switch (shape)
            {
                case Circle c:
                    Console.WriteLine($"circle with radius {c.Radius}");
                    break;
                case Rectangle s when (s.Length == s.Height):
                    Console.WriteLine($"{s.Length} x {s.Height} square");
                    break;
                case Rectangle r:
                    Console.WriteLine($"{r.Length} x {r.Height} rectangle");
                    break;
                default:
                    Console.WriteLine("<unknown shape>");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
            }
        }

        private static object GetMultipler()
        {
            return 100;
        }

        public static void PatternMatchingExample()
        {
            var o = GetMultipler();

            if (o is null) return;

            if (o is int i || o is string s && int.TryParse(s, out i))
            {
                //Why is s not valid??
                //Console.WriteLine($"Multipler is a string with the value {s}");

                Console.WriteLine($"Multipler is set {i} {new string('*', i)}");
            }

            //Illegal as outside the scope of the braces.
            //Console.WriteLine($"Multipler is set {i}");
        }
    }
}