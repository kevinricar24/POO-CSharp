namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    class VegBurger : Burger
    {
        public override string name()
        {
            return "Veg Burger";
        }

        public override float price()
        {
            return 35;
        }
    }
}
