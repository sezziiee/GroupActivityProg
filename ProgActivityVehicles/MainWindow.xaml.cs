using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VehicleClassLibrary;


namespace ProgActivityVehicles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

           
            Vehicle veh = new Vehicle();
            var service = 3000;
            int total= 0;
            string Line = null;
            string[] fields;

            
            
                fields = Line.Split('#');
                veh.vehicleID = int.Parse(fields[0]);
                veh.Description = fields[1];
                veh.vehicleMake = fields[2];
                veh.numKM = int.Parse(fields[3]);
                veh.serviceKM = int.Parse(fields[4]);
                vehicles.Add(veh);

                

              

                for (int x = 0; x < vehicles.Count(); x++)
                {
                    total = vehicles[x].serviceKM - vehicles[x].numKM;
                }


            if (total < service)
            {
                MessageBox.Show("service due" + total.ToString());
            }            
            
        }
    }
}
