using System;

namespace POO_CSharp.PolymorphismExample
{
    /// <summary>
    /// Function Overloading Example
    /// </summary>
    class StaticPolymorphism1
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }
        public void print(int i, double f)
        {
            Console.WriteLine("Printing int: {0}, float: {1}", i, f);
        }
        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}
