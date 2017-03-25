using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.AbstractFactory
{
    public class RegularBike: Bike
    {
        public string Name()
        {
            return "Regular Bike";
        }
    }
}
