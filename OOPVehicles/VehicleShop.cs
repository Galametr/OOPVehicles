using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicles
{
    public class VehicleShop
    {
        List<Vehicle> VehicleList = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            Vehicle vozidlo = new Vehicle();
            VehicleList.Append(vozidlo);

        }

        public void ShowVehicleList()
        {

            Console.WriteLine(VehicleList);


        }


        public void SaveToFile(string path)
        {
            File.WriteAllText(path, VehicleList);

        }



    }
}
