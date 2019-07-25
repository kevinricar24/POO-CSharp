namespace POO_CSharp.DesingPattersExample.StructuralPatterns.DecoratorPattern
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape decoratedShape;

        public ShapeDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public abstract void draw();
    }
}
