using System;

namespace GeometryTool
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var square = new Square() {Width = 2};
            var triangle = new Triangle() {Base = 2, Height = 5};
            square.Display();
            triangle.Display();
        }
    }

    internal abstract class Shape
    {
        protected abstract int GetArea();

        public void Display()
        {
            Console.WriteLine("The area is {0}", GetArea());
        }
    }

    internal class Square : Shape
    {
        public int Width;

        protected override int GetArea()
        {
            return Width * Width;
        }
    }

    internal class Triangle : Shape
    {
        public int Base;
        public int Height;

        protected override int GetArea()
        {
            return (Base * Height) / 2;
        }
    }
}