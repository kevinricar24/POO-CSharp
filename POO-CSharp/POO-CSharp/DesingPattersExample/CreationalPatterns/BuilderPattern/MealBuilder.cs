using System;
using System.Collections.Generic;
using System.Text;

namespace POO_CSharp.DesingPattersExample.CreationalPatterns.BuilderPattern
{
    class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new VegBurger());
            meal.addItem(new CocaCola());
            return meal;
        }

        public Meal NonprepareVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new ChickenBurger());
            meal.addItem(new Pepsi());
            return meal;
        }


    }
}
