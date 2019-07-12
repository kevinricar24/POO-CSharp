using System;

namespace POO_CSharp.InheritanceExample
{
    class SingleInheritance : BaseClass
    {
        public void getArea()
        {
            double area = length * width;
            Console.WriteLine("getAreaBySingleInheritanceClass: {0}", area);
        }
    }
}
