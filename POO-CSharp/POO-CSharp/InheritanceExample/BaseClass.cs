using System;

namespace POO_CSharp.InheritanceExample
{
    class BaseClass
    {
        protected double length;
        protected double width;

        public void setLength(double l)
        {
            length = l;
            Console.WriteLine("length: {0}", length);
        }
        public void setWidth(double w)
        {
            width = w;
            Console.WriteLine("width: {0}", width);
        }
    }
}
