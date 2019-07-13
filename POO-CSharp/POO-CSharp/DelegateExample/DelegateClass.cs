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

        public void PrintNumSimpleDelegate()
        {
            int x = 4;
            Console.WriteLine("-----------------Simple Delegate Example-----------------");
            MyDelegate myDelegateSum = new MyDelegate(SumNum);
            MyDelegate myDelegateMult = new MyDelegate(MultNum);
            myDelegateSum(x);
            Console.WriteLine("Value of Num: {0}", GetNum());
            myDelegateMult(x);
            Console.WriteLine("Value of Num: {0}", GetNum());
            Console.WriteLine();
        }

        public void PrintNumMulticastDelegate()
        {
            int x = 4;
            Console.WriteLine("-----------------Multicast Delegate Example-----------------");
            MyDelegate myDelegate = new MyDelegate(SumNum);
            myDelegate(x);
            Console.WriteLine("Value of Num: {0}", GetNum());
            //Add Second Delegate
            myDelegate += new MyDelegate(MultNum);
            myDelegate(x);
            Console.WriteLine("Value of Num: {0}", GetNum());
            //Remove Second Delegate
            myDelegate -= new MyDelegate(MultNum);
            myDelegate(x);
            Console.WriteLine("Value of Num: {0}", GetNum());
        }

    }
}
