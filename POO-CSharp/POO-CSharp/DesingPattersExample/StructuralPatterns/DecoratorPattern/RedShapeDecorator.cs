using System;

namespace POO_CSharp.DesingPattersExample.StructuralPatterns.DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {

        }

        public override void draw()
        {
            this.decoratedShape.draw();
            setRedBorder(this.decoratedShape);
        }

        private void setRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }


    }
}
