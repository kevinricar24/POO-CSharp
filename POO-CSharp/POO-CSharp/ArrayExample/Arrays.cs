using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CSharp.ArrayExample
{
    class Arrays
    {

        int[] list = { 34, 72, 13, 44, 25};

        public void Display()
        {
            ArrayDefinedAndParams(list, 24, 56);
        }

        public void ArrayDefinedAndParams(int[] array, params int[] array1)
        {
            Console.WriteLine("----------Example ArrayData Defined----------------");
            PrintArray(array);
            Console.WriteLine("----------Example ArrayData Properties----------------");
            PrintProperties(array);
            Console.WriteLine("----------Example ArrayData Methods----------------");
            PrintMethods(array);
            Console.WriteLine("----------Example ArrayData By Params----------------");
            PrintArray(array1);

        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}]: {1}", i, array[i]);
            }
        }

        public void PrintProperties(int[] array)
        {
            Console.WriteLine("IsFixedSize: {0}", array.IsFixedSize);
            Console.WriteLine("IsReadOnly: {0}", array.IsReadOnly);
            Console.WriteLine("IsSynchronized: {0}", array.IsSynchronized);
            Console.WriteLine("Length: {0}", array.Length);
            Console.WriteLine("LongLength: {0}", array.LongLength);
            Console.WriteLine("Rank: {0}", array.Rank);
            Console.WriteLine("SyncRoot: {0}", array.SyncRoot);
        }

        public void PrintMethods(int[] array)
        {
            Console.WriteLine("GetEnumerator: {0}", array.GetEnumerator());
            Console.WriteLine("GetHashCode: {0}", array.GetHashCode());
            Console.WriteLine("GetLength(0): {0}", array.GetLength(0));
            Console.WriteLine("GetLongLength(0): {0}", array.GetLongLength(0));
            Console.WriteLine("GetLowerBound(0): {0}", array.GetLowerBound(0));
            Console.WriteLine("GetType: {0}", array.GetType());
            Console.WriteLine("GetUpperBound(0): {0}", array.GetUpperBound(0));
            Console.WriteLine("GetValue(3): {0}", array.GetValue(3));
            Console.WriteLine("ToString: {0}", array.ToString());
            Console.WriteLine("----------Example ArrayData Method Reverse----------------");
            Array.Reverse(array);
            PrintArray(array);
            Console.WriteLine("----------Example ArrayData Method Sorted----------------");
            Array.Sort(array);
            PrintArray(array);
        }

    }
}
