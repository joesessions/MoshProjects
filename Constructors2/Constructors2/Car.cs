using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber + "z")
        {
            Console.WriteLine("Car is being initialized. " + registrationNumber);
        }
    }
}
