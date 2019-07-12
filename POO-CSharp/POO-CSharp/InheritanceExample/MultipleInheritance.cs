using System;

namespace POO_CSharp.InheritanceExample
{

    class MultipleInheritance : BaseClass, MyInterface
    {
        public void getAreaByDerivedClass()
        {
            double area = length * width;
            Console.WriteLine("getAreaByDerivedClass: {0}", area);
        }

        public void getAreaByInterface(int area)
        {
            double newArea = length + area;
            Console.WriteLine("getAreaByInterface: {0}", newArea);
        }
    }
}
