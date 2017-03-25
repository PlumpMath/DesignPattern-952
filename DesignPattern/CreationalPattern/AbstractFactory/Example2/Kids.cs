using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.AbstractFactory.Example2
{
    public class Kids: Recipe
    {
        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }

        public override Dessert CreateDessert()
        {
            return new IceCream();
        }
    }
}
