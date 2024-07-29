using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    interface IVehicle
    {
        public void Drive(int distance);
        public bool Refuel(int fuelValue);
    }
}
