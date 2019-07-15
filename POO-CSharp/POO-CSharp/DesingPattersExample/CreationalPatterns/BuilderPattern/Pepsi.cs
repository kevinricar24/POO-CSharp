using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    class Pepsi : ColdDrink
    {
        public override string name()
        {
            return "Pepsi";
        }

        public override float price()
        {
            return 10;
        }
    }
}
