using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.AbstractFactory
{
   public class ClientVechile
    {
        Bike bike;
        Car car;

        public ClientVechile(VechileFactory factory, string type)
        {
            bike = factory.GetBike(type);
            car = factory.GetCar(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetCarName()
        {
            return car.Name();
        }
    }
}
