using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace OOPVehicles
{
    public class Car : Vehicle
    {
        public Car(string model, int year, string registrationNumber1, int v)
        {
            this.model = model;
            this.year = year;
        }

        public int NumberOfDoors { get; set; }





    }
}
