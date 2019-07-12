﻿using Encapsulation;
using POO_CSharp.ArrayExample;
using POO_CSharp.ClassExample;
using POO_CSharp.EncapsulationExample;
using POO_CSharp.NullableExample;
using POO_CSharp.ParametersExample;
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
            program.DemoClasses();
            //explicit call of the garbage collector and invoke the destructor on .NET Core Apps
            GC.Collect();
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

    }
}
