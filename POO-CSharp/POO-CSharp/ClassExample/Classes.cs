using System;

namespace POO_CSharp.ClassExample
{
    class Classes : ClassesBase
    {
        double length = 12;
        double width = 24;
        static int myNum;

        /// <summary>
        /// Constructor with params and base class
        /// </summary>
        public Classes(string type) : base (type)
        {
            Console.WriteLine("{0}: Object is being created", type);
            Console.WriteLine("-----------------------------------------");
        }

        /// <summary>
        /// Constructor with two params and base class
        /// </summary>
        public Classes(string type, int num) : base(type)
        {
            Console.WriteLine("{0}: Object is being created", type);
            Console.WriteLine("{0}: param num is received", num);
            Console.WriteLine("-----------------------------------------");
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Classes()
        {
            length = 0;
            width = 0;
            Console.WriteLine("Destructor: Object is being deleted");
            Console.WriteLine("Area: {0}", GetArea());
        }

        double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Running your code here");
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("-----------------------------------------");
        }

        public void count()
        {
            myNum++;
        }
        public int getNum()
        {
            return myNum;
        }

        public static string StaticMethod()
        {
            return "example of static method";
        }

    }

    class ClassesBase
    {
        public ClassesBase(string type)
        {
            Console.WriteLine("{0}: Object is being created on the base class", type);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
