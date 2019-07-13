namespace POO_CSharp.PolymorphismExample
{
    /// <summary>
    /// Abstract Class Example
    /// </summary>
    class DynamicPolymorphism1 : AbstractShape
    {
        private int length;
        private int width;

        public DynamicPolymorphism1(int l, int w)
        {
            length = l;
            width = w;
        }

        public override int AbstractArea()
        {
            return (length * width);
        }
    }

    abstract class AbstractShape
    {
        public abstract int AbstractArea();
    }

}
