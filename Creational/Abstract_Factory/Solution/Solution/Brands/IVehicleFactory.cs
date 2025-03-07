using Solution.Products.Cars;
using Solution.Products.Trucks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Factories
{
    internal interface IVehicleFactory
    {
        ICar CreateCar();
        ITruck CreateTruck();
    }
}
