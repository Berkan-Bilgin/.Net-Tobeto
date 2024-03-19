using Polymorphism_2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2.Models
{
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }
        public override decimal CalcualateDailyRentalRate()
        {
            return 200m + (LoadCapacity * 5m);
        }
    }
}
