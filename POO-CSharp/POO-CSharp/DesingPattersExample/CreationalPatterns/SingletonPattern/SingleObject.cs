using System;

namespace POO_CSharp.DesingPattersExample.CreationalPatterns.SingletonPattern
{
    public sealed class SingleObject
    {
        private static readonly Lazy<SingleObject> lazy = new Lazy<SingleObject>(() => new SingleObject());

        public static SingleObject Instance {
            get {
                return lazy.Value;
            }
        }
        private SingleObject()
        {

        }
        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }

    }
}
