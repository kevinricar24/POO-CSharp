namespace POO_CSharp.InheritanceExample
{
    /// <summary>
    /// Example from multiple Inheritance using interfaces
    /// </summary>
    class DerivedClass : BaseClass, PaintCost
    {
        public double getArea()
        {
            return (length * width);
        }

        public int getCost(int area)
        {
            return area * 10;
        }
    }

    /// <summary>
    /// Base interface PaintCost
    /// </summary>
    public interface PaintCost
    {
        int getCost(int area);
    }

    /// <summary>
    /// Base Class BaseClass
    /// </summary>
    class BaseClass
    {
        protected double length;
        protected double width;

        public void setLength(double l)
        {
            length = l;
        }
        public void setWidth(double w)
        {
            width = w;
        }
    }
}
