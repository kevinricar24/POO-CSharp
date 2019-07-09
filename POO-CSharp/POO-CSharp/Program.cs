using POO_CSharp.Encapsulation;
using System;

namespace POO_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Public Access Specifier
            PublicEncapsulation r = new PublicEncapsulation();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
