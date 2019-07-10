using System;

namespace POO_CSharp.NullableExample
{
    class Nullables
    {

        public void Display()
        {
            int? num1 = null;
            int? num2 = 45;
            int? num3 = new int?();
            int num4;
            bool? boolval = new bool?();

            Console.WriteLine("num1: {0}\nnum2: {1}\nnum3:{2}", num1, num2, num3);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);

            num4 = num1 ?? 20;
            Console.WriteLine("Value of num4: {0}", num4);

            num4 = num2 ?? 20;
            Console.WriteLine("Value of num4: {0}", num4);
        }

    }
}
