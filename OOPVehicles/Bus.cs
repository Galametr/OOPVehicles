using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    internal class Bus : Vehicle
    {
        public Bus(string model, int year, string registrationNumber1, double v)
        {
            this.model = model;
            this.year = year;
        }

        public int Capacity { get; set; }

    }
}
