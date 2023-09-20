using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary
{
    public class Vehicle
    {
        public int vehicleID {  get; set; }
        public string Description { get; set; }
        public string vehicleMake { get; set; }
        public int numKM { get; set; }
        public int serviceKM { get; set; }
        public string ServiceMessage { get; set; }

        public string AddVehicle()
        {
            return vehicleID + "#" + Description + "#" + vehicleMake + "#" + numKM +"#" + serviceKM;
    }
        public override string ToString()
        {
            return vehicleID + "\t" + Description + "\t" + vehicleMake + "\t" + numKM + "\t" + serviceKM;
        }
        public string CalculateRemaining()
        {
            string result = "";
            int remaining = 0;
            remaining = serviceKM - numKM;
            if (remaining <= 3000)
            {
                result = "Remaining Kilometers: " + remaining;
            }
            else if (remaining > 3000)
            {
                result = "No Sevice Needed! ";
            }
            return result;
        }
    }

    
}
