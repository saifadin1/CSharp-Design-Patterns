using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Products.Cars
{
    internal class TeslaCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Tesla car is driving");
        }
    }
}
