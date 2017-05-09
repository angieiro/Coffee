using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Coffee
    {
        public enum Size { Small = 100, Normal = 150, Double = 300 };
        public Size CoffeeSize { get; set; }

        public Coffee(Size cs)
        {
            CoffeeSize = cs;
            Console.WriteLine($"{CoffeeSize} coffee is {(int)CoffeeSize} ml.");
        }

    }
}
