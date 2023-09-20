using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VehicleClassLibrary
{
    public class Vehicle
    {
        public int vehicleID {  get; set; }
        public string Description { get; set; }
        public string vehicleMake { get; set; }
        public int numKM { get; set; }
        public int serviceKM { get; set; }

        public string AddVehicle()
        {
            return vehicleID + "#" + Description + "#" + vehicleMake + "#" + numKM +"#" + serviceKM;
    }
        public override string ToString()
        {
            return vehicleID + "\t" + Description + "\t" + vehicleMake + "\t" + numKM + "\t" + serviceKM;
        }

        
    }

    
}
