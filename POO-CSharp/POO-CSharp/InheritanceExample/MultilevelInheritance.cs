using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CSharp.InheritanceExample
{
    class MultilevelInheritance : IntermediateInheritance
    {

        public void getAreaByMultilevelInheritanceClass(double param)
        {
            double area = distance + param;
            Console.WriteLine("getAreaByMultilevelInheritanceClass: {0}", area);
        }
    }

    class IntermediateInheritance : BaseClass
    {
        protected double distance;

        public void setDistance()
        {
            distance = length + width;
            Console.WriteLine("distance: {0}", distance);
        }
    }
}
