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
        public string ID {  get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public int KM { get; set; }
        public int servicekm { get; set; }

        public Vehicle(string ID, string Desc, string Make, int km, int servicekm)
        {
            this.ID = ID;
            this.Description = Desc;
            this.Make = Make;
            this.KM = km;
            this.servicekm = servicekm;
        }

        public Vehicle()
        {
        }

        public string AddVehicle()
        {
            return ID + "#" + Description + "#" + Make + "#" + KM +"#" + servicekm;
    }
        public override string ToString()
        {
            return ID + "\t" + Description + "\t" + Make + "\t" + KM + "\t" + servicekm;
        }
        public void CalculateRemaining()
        {
            int remaining = 0;
            remaining = servicekm - KM;
            if (remaining <= 3000)
            {
                MessageBox.Show("Remaining Kilometers: " + remaining);
            }
            else if (remaining > 3000)
            {
                MessageBox.Show("No Sevice Needed! ");
            }
        }
    }

    
}
