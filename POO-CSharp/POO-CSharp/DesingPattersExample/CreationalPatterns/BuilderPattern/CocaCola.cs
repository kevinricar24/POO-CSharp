namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    class CocaCola : ColdDrink
    {
        public override string name()
        {
            return "Coca-Cola";
        }

        public override float price()
        {
            return 12;
        }
    }
}
