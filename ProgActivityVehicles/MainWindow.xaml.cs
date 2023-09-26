using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
        string Path = Directory.GetCurrentDirectory();

        public MainWindow()
        {
            InitializeComponent();
        }
        List<Vehicle> vehicles = new List<Vehicle>();
        Vehicle vehicle = new Vehicle();

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehicle = new Vehicle(txtID.Text, txtDesc.Text, txtMake.Text, int.Parse(txtKM.Text), int.Parse(txtServiceKM.Text));

            Directory.CreateDirectory(System.IO.Path.Combine(Path, vehicle.Make));
            StreamWriter writer = new StreamWriter(System.IO.Path.Combine(Path, vehicle.Make));
            

            writer.WriteLine(vehicle.AddVehicle());

            vehicles.Add(vehicle);

            writer.Close();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(Path);
            string folder = System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(Path));
            Vehicle vehicle = new Vehicle();

            string Line = null;
            string[] fields;


            while ((Line = reader.ReadLine()) != null)
            {
                fields = Line.Split('#');
                vehicle.ID = fields[0];
                vehicle.Description = fields[1];
                vehicle.Make = fields[2];
                vehicle.KM = int.Parse(fields[3]);
                vehicle.servicekm = int.Parse(fields[4]);
            }

            reader.Close();
                count++;
            }

        }
       

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            var DisplayVehicle = from vehicle in vehicles select vehicle;
            dgvVehicle.ItemsSource = null;
            dgvVehicle.ItemsSource = DisplayVehicle;
        }
    }
}
