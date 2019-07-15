namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    abstract class Burger : IItem
    {
        public abstract string name();

        public IPacking packing()
        {
            return new Wrapper();
        }

        public abstract float price();
    }
}
