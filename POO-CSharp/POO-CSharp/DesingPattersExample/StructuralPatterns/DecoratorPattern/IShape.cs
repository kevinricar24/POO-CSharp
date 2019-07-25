using System;

namespace POO_CSharp.DesingPattersExample.StructuralPatterns.DecoratorPattern
{
    public interface IShape
    {
        void draw();
    }

    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }

    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }

}
