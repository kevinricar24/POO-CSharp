namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    class ChickenBurger : Burger
    {
        public override string name()
        {
            return "Chicken Burger";
        }

        public override float price()
        {
            return 40;
        }
    }
}
