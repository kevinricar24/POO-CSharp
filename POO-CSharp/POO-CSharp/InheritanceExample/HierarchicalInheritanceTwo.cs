using System;

namespace POO_CSharp.InheritanceExample
{
    class HierarchicalInheritanceTwo : BaseClass
    {
        public void getAreaByHierarchicalInheritanceTwoClass(double param)
        {
            double area = width + param;
            Console.WriteLine("getAreaByHierarchicalInheritanceTwoClass: {0}", area);
        }
    }
}
