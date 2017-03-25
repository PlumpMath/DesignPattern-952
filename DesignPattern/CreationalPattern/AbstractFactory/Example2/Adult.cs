using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.AbstractFactory.Example2
{
    public class Adult:Recipe
    {
        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }
    }
}
