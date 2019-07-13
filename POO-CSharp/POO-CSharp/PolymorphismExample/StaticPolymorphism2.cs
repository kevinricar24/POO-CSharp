using System;

namespace POO_CSharp.PolymorphismExample
{
    /// <summary>
    /// Operator Overloading Example
    /// </summary>
    class StaticPolymorphism2
    {

        private double length;  
        private double height; 

        public double getVolume()
        {
            return length * height;
        }
        public void setLength(double l)
        {
            length = l;
        }
        public void setHeight(double h)
        {
            height = h;
        }

        public override string ToString()
        {
            return String.Format("length:{0}, height:{1}", length, height);
        }

        public static StaticPolymorphism2 operator+ (StaticPolymorphism2 a, StaticPolymorphism2 b)
        {
            StaticPolymorphism2 staticPolymorphism2 = new StaticPolymorphism2();
            staticPolymorphism2.length = a.length + b.length;
            staticPolymorphism2.height = a.height + b.height;
            return staticPolymorphism2;
        }
    }
}
