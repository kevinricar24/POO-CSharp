using System;

namespace POO_CSharp.ParametersExample
{
    class Parameters
    {
        
        public int GetAreaByValue(int w, int x)
        {
            return w * x;
        }

        public int GetAreaByReference(ref int y)
        {
            return y*= y;
        }

        public int GetAreaByOut(out int z)
        {
            int s = 0;
            int temp = 5;
            z = temp + 1;
            s = z + temp;
            return s;
        }

        public void Display(int w, int x, int y, int z)
        {
            Console.WriteLine("ByValue Area: {0}", GetAreaByValue(w, x));
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Parameter before method: {0}", y);
            Console.WriteLine("ByReference Area: {0}", GetAreaByReference(ref y));
            Console.WriteLine("Parameter after method: {0}", y);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Parameter before method: {0}", z);
            Console.WriteLine("ByOut Area: {0}", GetAreaByOut(out z));
            Console.WriteLine("Parameter after method: {0}", z);
        }


    }
}
