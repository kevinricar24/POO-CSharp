using Encapsulation.Data;
using System;

namespace POO_CSharp.EncapsulationExample
{
    public class PrivateProtectedEncapsulationIn : PrivateProtectedData
    {
        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            //length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            //width = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {
            //Console.WriteLine("Length: {0}", length);
            //Console.WriteLine("Width: {0}", width);
            //Console.WriteLine("Area: {0}", GetArea());
        }
    }
}
