using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Order
    {
        public List<Coffee> order;
        

        public Order(List<Coffee> o)
        {
            order = o;
        }
        public void CalculateCost()
        {
            double sum = 0;
            foreach (Coffee c in order)
            {
                switch(c.CoffeeSize)
                {
                    case Coffee.Size.Small:
                        sum += 0.50;
                        break;
                    case Coffee.Size.Normal:
                        sum += 1.50;
                        break;
                    case Coffee.Size.Double:
                        sum += 2.50;
                        break;
                }
            }
            Console.WriteLine($"H paraggelia sas einai: {sum} euro.");
        }
    }
}
