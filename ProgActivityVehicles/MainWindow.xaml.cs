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

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            StreamReader reader = new StreamReader("VehicleData.txt");
            Vehicle veh = new Vehicle();

            string Line = null;
            string[] fields;

            int count = 0;
            while ((Line = reader.ReadLine()) != null)
            {
                fields = Line.Split('#');
                veh.vehicleID = int.Parse(fields[0]);
                veh.Description = fields[1];
                veh.vehicleMake = fields[2];
                veh.numKM = int.Parse(fields[3]);
                veh.serviceKM = int.Parse(fields[4]);
                vehicles.Add(veh);


                count++;
            }
            
        }
    }
}
