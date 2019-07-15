using System;

namespace POO_CSharp.DesingPattersExample.CreationalPatterns.PrototypePattern
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id): base(id)
        {

        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

}
