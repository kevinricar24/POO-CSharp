using System;
using System.Collections.Generic;

namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void addItem(IItem item)
        {
            items.Add(item);
        }

        public float getCost()
        {
            float cost = 0;
            foreach (IItem item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (IItem item in items)
            {
                Console.Write("Item: {0}", item.name());
                Console.Write(", Packing :{0}", item.packing().pack());
                Console.WriteLine(", Price: {0}", item.price());
            }
        }
    }
}
