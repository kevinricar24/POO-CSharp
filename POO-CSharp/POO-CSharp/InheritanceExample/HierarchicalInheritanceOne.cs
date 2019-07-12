using System;

namespace POO_CSharp.InheritanceExample
{
    class HierarchicalInheritanceOne : BaseClass
    {
        public void getAreaByHierarchicalInheritanceOneClass(double param)
        {
            double area = length + param;
            Console.WriteLine("getAreaByHierarchicalInheritanceOneClass: {0}", area);
        }
    }
}
