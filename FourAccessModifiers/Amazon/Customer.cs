using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class RateCalculator
    {

        public int Calculate(Customer customer)
        {
            return 0;
        }
    }
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promote Logic changed");
        }


    }
}
