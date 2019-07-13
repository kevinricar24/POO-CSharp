using System;

namespace POO_CSharp.ExceptionExample
{
    class ExceptionClass
    {

        private int height;
        private int width;
        private int density;
        private int area;
        public int kevin;
        public int kevin1 { get; set; }
        public int kevin2;

        public int kevin3
        {
            //get { return kevin2; }
            set { kevin2 = value; }
        }


        public ExceptionClass(int h, int w, int d)
        {
            height = h;
            width = w;
            density = d;
        }

        public void PrintArea()
        {
            string result = string.Empty;
            try
            {
                if(density == 0)
                {
                    throw (new DensityIsZeroException("Density Is Zero Exception"));
                }
                area = ((height * density) / width);
                result = string.Format("Area: {0}", area);
            }
            catch (DivideByZeroException ex)
            {
                result = string.Format("Exception: {0}", ex.Message);
            }
            catch (DensityIsZeroException ex)
            {
                result = string.Format("Exception: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
    }

    public class DensityIsZeroException : Exception
    {
        public DensityIsZeroException(string message) : base(message)
        {
        }
    }


}
