using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Products.Cars
{
    internal class FordCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Ford car is driving");
        }
    }
}
