using Polymorphism_2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2.Models
{
    public class Car : Vehicle
    {
        public int PassengerCapacity { get; set; }
        public override decimal CalcualateDailyRentalRate()
        {
            return 100m + (PassengerCapacity * 10m);
        }
    }
}
