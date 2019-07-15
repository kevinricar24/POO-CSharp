namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    interface IItem
    {
        string name();
        IPacking packing();
        float price();
    }
}
