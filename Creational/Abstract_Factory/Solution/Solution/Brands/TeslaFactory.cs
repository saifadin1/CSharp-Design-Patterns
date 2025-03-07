using Solution.Products.Cars;
using Solution.Products.Trucks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Factories
{
    internal class TeslaFactory : IVehicleFactory
    {
        public ICar CreateCar()
        {
            return new TeslaCar();
        }

        public ITruck CreateTruck()
        {
            return new TeslaTruck();
        }
    }
}
