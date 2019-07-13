using System;

namespace POO_CSharp.PolymorphismExample
{
    class DynamicPolymorphism2 
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.VirtualArea();
            Console.WriteLine("VirtualArea: {0}", a);
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public new virtual int VirtualArea()
        {
            Console.WriteLine("Rectangle class VirtualArea :");
            return (width * height);
        }
    }
    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int VirtualArea()
        {
            Console.WriteLine("Triangle class VirtualArea :");
            return (width * height / 2);
        }
    }
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int VirtualArea()
        {
            Console.WriteLine("Parent class VirtualArea:");
            return 0;
        }
    }

}
