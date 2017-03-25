using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.AbstractFactory
{
    public class BMWFactory: VechileFactory
    {
        public Bike GetBike(string type)
        {
            switch (type)
            {
                case "regular": return new RegularBike();
                case "sport": return new SportBike();
                default: throw new Exception("invalid type");
            }
        }

        public Car GetCar(string type)
        {
            switch (type)
            {
                case "regular": return new RegularCar();
                case "sport": return new SportCar();
                default: throw new Exception("invalid type");
            }
        }
    }
}
