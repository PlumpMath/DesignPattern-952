using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.AbstractFactory
{
   public interface VechileFactory
    {
         Bike GetBike(string type);
         Car GetCar(string type);
    }
}
