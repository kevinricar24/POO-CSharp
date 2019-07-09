using System;

namespace POO_CSharp.EncapsulationExample
{
    public class InternalEncapsulationIn
    {
        double length;
        double width;

        double GetArea()
        {
            return length * width;
        }

        internal void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        internal void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
