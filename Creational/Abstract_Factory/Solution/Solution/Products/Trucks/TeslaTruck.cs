using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Products.Trucks
{
    internal class TeslaTruck : ITruck
    {
        public void Haul()
        {
            Console.WriteLine("Tesla truck is hauling");
        }
    }
}
