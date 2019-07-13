using System;

namespace POO_CSharp.DelegateExample
{
    class DelegateClass
    {
        private int num = 10;
        public delegate int MyDelegate(int num);

        public int SumNum(int n)
        {
            num += n;
            return num;
        }

        public int MultNum(int n)
        {
            num *= n;
            return num;
        }

        public int GetNum()
        {
            return num;
        }

        public void PrintNum()
        {
            int x = 4;
            MyDelegate myDelegateSum = new MyDelegate(SumNum);
            MyDelegate myDelegateMult = new MyDelegate(MultNum);
            myDelegateSum(x);
            Console.WriteLine("Value of Num: {0}", GetNum());
            myDelegateMult(x);
            Console.WriteLine("Value of Num: {0}", GetNum());
        }


    }
}
