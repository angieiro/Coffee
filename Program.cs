using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee cfee = new Coffee(Coffee.Size.Normal);

            //Δημιουργία λίστας με καφέδες
            List<Coffee> o = new List<Coffee>();
            //Προσθεσα στη λίστα με την παραγγελία 2 καφέδες κανονικού μεγέθους
            o.Add(cfee);
            o.Add(cfee);

            //Δημιουργία αντικειμένου Οrder και ανάθεση της λίστας "ο" σε αυτό
            Order order = new Order(o);
            order.CalculateCost();

            Console.ReadKey();
        }
    }
}
