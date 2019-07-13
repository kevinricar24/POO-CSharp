using Encapsulation;
using POO_CSharp.ArrayExample;
using POO_CSharp.ClassExample;
using POO_CSharp.EncapsulationExample;
using POO_CSharp.ExceptionExample;
using POO_CSharp.InheritanceExample;
using POO_CSharp.InterfaceExample;
using POO_CSharp.NullableExample;
using POO_CSharp.ParametersExample;
using POO_CSharp.PolymorphismExample;
using POO_CSharp.PropertyExample;
using POO_CSharp.StructsExample;
using System;

namespace POO_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.DemoEncapsulation();
            //program.DemoParameters();
            //program.DemoNullables();
            //program.DemoArrays();
            //program.DemoStructs();
            //program.DemoClasses();
            //explicit call of the garbage collector and invoke the destructor on .NET Core Apps
            //GC.Collect();
            //program.DemoInheritance();
            //program.DemoPolymorphism();
            //program.DemoInterface();
            //program.DemoExceptions();
            program.DemoProperties();
        }


        public void DemoEncapsulation()
        {
            //Public Access Specifier
            Console.WriteLine("-----------------Public Access Specifier Example-----------------");
            PublicEncapsulation r = new PublicEncapsulation();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();

            //Private Access Specifier
            Console.WriteLine("-----------------Private Access Specifier Example-----------------");
            PrivateEncapsulation r1 = new PrivateEncapsulation();
            r1.Acceptdetails();
            r1.Display();
            Console.ReadLine();

            //Protected Access Specifier
            Console.WriteLine("-----------------Protected Access Specifier Example-----------------");
            ProtectedEncapsulation r2 = new ProtectedEncapsulation();
            r2.Acceptdetails();
            r2.Display();
            Console.ReadLine();

            //Internal Access Specifier
            Console.WriteLine("-----------------Internal Access Specifier Example-----------------");
            //InternalEncapsulationOut r3 = new InternalEncapsulationOut();
            InternalEncapsulationIn r3 = new InternalEncapsulationIn();
            r3.Acceptdetails();
            r3.Display();
            Console.ReadLine();

            //Protected Internal Access Specifier
            Console.WriteLine("-----------------Protected Internal Access Specifier Example-----------------");
            ProtectedInternalEncapsulationOut r4 = new ProtectedInternalEncapsulationOut();
            r4.Acceptdetails();
            r4.Display();
            Console.ReadLine();

            //Private Protected Access Specifier
            Console.WriteLine("-----------------Private Protected Internal Access Specifier Example-----------------");
            //PrivateProtectedEncapsulationIn r5 = new PrivateProtectedEncapsulationIn();
            PrivateProtectedEncapsulationOut r5 = new PrivateProtectedEncapsulationOut();
            r5.Acceptdetails();
            r5.Display();
            Console.ReadLine();
        }

        public void DemoParameters()
        {
            int w = 1;
            int x = 2;
            int y = 3;
            int z = 4;

            Parameters parameters = new Parameters();
            parameters.Display(w, x, y, z);
        }

        public void DemoNullables()
        {
            Nullables nullables = new Nullables();
            nullables.Display();
        }

        public void DemoArrays()
        {
            Arrays arrays = new Arrays();
            arrays.Display();
        }

        public void DemoStructs()
        {
            StructEntity structEntity = new StructEntity();
            structEntity.getValues(1, "Title1", "Author1", "Subject1");
            structEntity.Display();
        }

        public void DemoClasses()
        {
            string ctorParam = "Constructor";
            //Classes clasess = new Classes(ctorParam);
            Classes clasess = new Classes(ctorParam, 2);
            clasess.Display();
            //Invoke the count method and increment the variable in 2
            clasess.count();
            clasess.count();
            Console.WriteLine("Variable num for classes: {0}", clasess.getNum());
            Console.WriteLine("Calling a static method from classes: {0}", Classes.StaticMethod());
            Console.WriteLine("---------------------------------------");
        }

        public void DemoInheritance()
        {
            SingleInheritance singleInheritance = new SingleInheritance();
            Console.WriteLine("-----------------Single Inheritance Example-----------------");
            singleInheritance.setLength(34);
            singleInheritance.setWidth(23);
            singleInheritance.getArea();
            Console.WriteLine();

            MultilevelInheritance multilevelInheritance = new MultilevelInheritance();
            Console.WriteLine("-----------------Multilevel Inheritance Example-----------------");
            multilevelInheritance.setLength(34);
            multilevelInheritance.setWidth(23);
            multilevelInheritance.setDistance();
            multilevelInheritance.getAreaByMultilevelInheritanceClass(44);
            Console.WriteLine();

            Console.WriteLine("-----------------Hierarchical Inheritance Example-----------------");
            Console.WriteLine("-----------------First Class Derived-----------------");
            HierarchicalInheritanceOne hione = new HierarchicalInheritanceOne();
            hione.setLength(34);
            hione.setWidth(23);
            hione.getAreaByHierarchicalInheritanceOneClass(3);
            Console.WriteLine("-----------------Second Class Derived-----------------");
            HierarchicalInheritanceTwo hitwo = new HierarchicalInheritanceTwo();
            hitwo.setLength(34);
            hitwo.setWidth(23);
            hitwo.getAreaByHierarchicalInheritanceTwoClass(3);
            Console.WriteLine();

            MultipleInheritance multipleInheritance = new MultipleInheritance();
            Console.WriteLine("-----------------Multiple Inheritance Example-----------------");
            multipleInheritance.setLength(34);
            multipleInheritance.setWidth(23);
            multipleInheritance.getAreaByDerivedClass();
            multipleInheritance.getAreaByInterface(78);
        }

        public void DemoPolymorphism()
        {
            Console.WriteLine("-----------------Static Polymorphism Example-----------------");
            StaticPolymorphism1 staticPolymorphism1 = new StaticPolymorphism1();
            Console.WriteLine("-----------------Function Overloading Example-----------------");
            staticPolymorphism1.print(5);
            staticPolymorphism1.print(6, 78.8);
            staticPolymorphism1.print("Hello!");
            Console.WriteLine();

            StaticPolymorphism2 staticp1 = new StaticPolymorphism2();
            StaticPolymorphism2 staticp2 = new StaticPolymorphism2();
            StaticPolymorphism2 staticp3 = new StaticPolymorphism2();
            double volume = 0;
            Console.WriteLine("-----------------Operator Overloading Example-----------------");
            Console.WriteLine();
            staticp1.setLength(3.4);
            staticp1.setHeight(5);
            Console.WriteLine("DynamicPolymorphism1: {0}", staticp1.ToString());
            volume = staticp1.getVolume();
            Console.WriteLine("Volume1: {0}", volume);

            staticp2.setLength(6);
            staticp2.setHeight(7.8);
            Console.WriteLine("DynamicPolymorphism2: {0}", staticp2.ToString());
            volume = staticp2.getVolume();
            Console.WriteLine("Volume2: {0}", volume);

            staticp3 = staticp1 + staticp2;
            Console.WriteLine("DynamicPolymorphism3: {0}", staticp3.ToString());
            volume = staticp3.getVolume();
            Console.WriteLine("Volume3: {0}", volume);
            Console.WriteLine();

            Console.WriteLine("-----------------Dynamic Polymorphism Example-----------------");
            Console.WriteLine("-----------------Abstract Class Example-----------------");
            DynamicPolymorphism1 r = new DynamicPolymorphism1(10, 7);
            double a = r.AbstractArea();
            Console.WriteLine("AbstractArea: {0}", a);
            Console.WriteLine();
            Console.WriteLine("-----------------Virtual Functions Example-----------------");
            DynamicPolymorphism2 c = new DynamicPolymorphism2();
            Rectangle rec = new Rectangle(10, 7);
            Triangle tri = new Triangle(10, 5);
            c.CallArea(rec);
            c.CallArea(tri);
        }

        public void DemoInterface()
        {
            Console.WriteLine("-----------------Interface Example-----------------");
            ExampleInterface exampleInterface = new ExampleInterface(4, 5, 6);
            exampleInterface.ShowArea();
        }

        public void DemoExceptions()
        {
            Console.WriteLine("-----------------Exceptions Example-----------------");
            ExceptionClass exceptionClass = new ExceptionClass(7, 0, 9);
            exceptionClass.PrintArea();
        }

        public void DemoProperties()
        {
            Console.WriteLine("-----------------Property Example-----------------");
            Property property = new Property();
            property.myField1 = "2";
            property.MyProperty1 = "3";
            property.MyProperty3 = "4";
            property.MyProperty4 = "5";
            property.MyProjection = "6";

            Console.WriteLine("myField1: {0}", property.myField1);
            Console.WriteLine("MyProperty1: {0}", property.MyProperty1);
            Console.WriteLine("MyProperty2: {0}", property.MyProperty2);
            Console.WriteLine("MyProperty4: {0}", property.MyProperty4);
            Console.WriteLine("MyProjection: {0}", property.MyProjection);
        }

        public void DemoReflection()
        {
            Console.WriteLine("-----------------Reflection Example-----------------");
            
        }

    }
}
