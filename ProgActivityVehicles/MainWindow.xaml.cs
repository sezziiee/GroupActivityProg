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

        private void btnDisplay_Click_1(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader(Path);
            string folder = System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(Path));
            Vehicle vehicle = new Vehicle();
            int count = 0;
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

            var DisplayVehicle = from vehicle1 in vehicles select vehicle1;
            dgvVehicle.ItemsSource = null;
            dgvVehicle.ItemsSource = DisplayVehicle;

            reader.Close();
            count++;
        }

        private void btnAdd_Click_1(object sender, RoutedEventArgs e)
        {
            Vehicle vehicle = new Vehicle(txtID.Text, txtDescr.Text, txtMake.Text, int.Parse(txtKM.Text), int.Parse(txtServiceKM.Text));

            Directory.CreateDirectory(System.IO.Path.Combine(Path, vehicle.Make));
            StreamWriter writer = new StreamWriter(System.IO.Path.Combine(Path, vehicle.Make));


            writer.WriteLine(vehicle.AddVehicle());

            vehicles.Add(vehicle);

            writer.Close();
        }
    }
    }

