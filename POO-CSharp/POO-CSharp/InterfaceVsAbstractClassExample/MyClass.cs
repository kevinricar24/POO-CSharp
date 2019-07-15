using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CSharp.InterfaceVsAbstractClassExample
{
    class MyClass : AbstractMyClass, IMyClass
    {
        private int moduleLocal = 2;
        public override int ModuleAbstract {
            get => moduleLocal;
            set => moduleLocal = value;
        }
        public int ModuleInterface {
            get => moduleLocal;
            set => moduleLocal = value;
        }

        public override int TriangleAreaByAbstractClass(int b, int h)
        {
            return (b * h) / ModuleAbstract;
        }

        public int TriangleAreaByInterface(int b, int h)
        {
            return (b * h) / ModuleInterface;
        }
    }


    interface IMyClass
    {
        //Properties
        int ModuleInterface { get; set; }

        //Methods
        int TriangleAreaByInterface(int b, int h);

        //Functions
        //Events
        //Delegates
    }

    interface IMyClass1
    {
        //Properties
        int ModuleInterface1 { get; set; }

        //Methods
        int TriangleAreaByInterface1(int b, int h);

        //Functions
        //Events
        //Delegates
    }

    abstract class AbstractMyClass
    {
        #region SIMPLE

        //fields
        public int module = 2;
        //Properties
        public int ModuleSimple { get; set; }
        //Methods
        public int TriangleAreaSimple(int b, int h)
        {
            return (b * h) / ModuleSimple;
        }

        #endregion

        #region ABSTRACT

        //Properties Abstract
        public abstract int ModuleAbstract { get; set; }

        //Methods Abstract
        public abstract int TriangleAreaByAbstractClass(int b, int h);

        #endregion

        //Functions
        //Events
        //Delegates
    }

    abstract class AbstractMyClass1
    {
        #region SIMPLE

        //fields
        public int module1 = 2;
        //Properties
        public int ModuleSimple1 { get; set; }
        //Methods
        public int TriangleArea1(int b, int h)
        {
            return (b * h) / module1;
        }

        #endregion

        #region ABSTRACT

        //Properties Abstract
        public abstract int ModuleAbstract1 { get; set; }

        //Methods Abstract
        public abstract int TriangleAreaByAbstractClass1(int b, int h);

        #endregion

        //Functions
        //Events
        //Delegates
    }
}
