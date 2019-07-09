using System;

namespace Encapsulation
{
    public class ProtectedEncapsulation : ProtectedData
    {
        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

    }

    public class ProtectedData
    {
        protected double length;
        protected double width;

        protected double GetArea()
        {
            return length * width;
        }

    }
}
