using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourAccessModifiers
{
    class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            Console.WriteLine("Promote Logic changed");
        }


    }
}
