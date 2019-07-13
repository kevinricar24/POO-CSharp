using System;

namespace POO_CSharp.InterfaceExample
{
    class ExampleInterface : IExampleInterface
    {
        private int height;
        private int width;
        private int myProjection;

        public ExampleInterface(int h, int w, int p)
        {
            height = h;
            width = w;
            myProjection = p;
        }

        public int projection
        {
            get => myProjection;
            set => myProjection = value;
        }

        public int GetArea()
        {
            return (height * width + projection);
        }

        public void ShowArea()
        {
            Console.WriteLine("GetArea: {0}", GetArea());
        }
    }

    interface IExampleInterface
    {
        int projection { get; set; }

        int GetArea();

        void ShowArea();
    }
}
