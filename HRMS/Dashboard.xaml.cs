using HRMS.Model;
using System.Collections.Generic;
using System.Windows;

namespace HRMS
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
            dataGrid.ItemsSource = LoadCollectionData();
        }

        private List<Devices> LoadCollectionData()
        {
            List<Devices> devices = new List<Devices>();
            devices.Add(new Devices()
            {
                DeviceName = "Device 1",
                Status = @"C:\Users\aaa\source\repos\HRMS\HRMS\assets\green light.png",
                Upload = 80,

            });
            return devices;
        }
    }
}
