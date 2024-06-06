using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string model, int year, string registrationNumber1, double v)
        {
            this.model = model;
            this.year = year;
        }

        public int EngineCapacity { get; set; }

    }
}
