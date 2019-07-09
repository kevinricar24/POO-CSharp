namespace Encapsulation.Data
{
    public class ProtectedInternalData
    {
        protected internal double length;
        protected internal double width;

        protected internal double GetArea()
        {
            return length * width;
        }

    }
}
