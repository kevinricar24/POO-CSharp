using System;

namespace POO_CSharp.InterfaceExample
{
    class ExampleInterface : IExampleInterface
    {
        private int height;
        private int width;

        public ExampleInterface(int h, int w)
        {
            height = h;
            width = w;
        }

        public int GetArea()
        {
            return (height * width);
        }

        public void ShowArea()
        {
            Console.WriteLine("GetArea: {0}", GetArea());
        }
    }

    interface IExampleInterface
    {
        int GetArea();

        void ShowArea();
    }
}
