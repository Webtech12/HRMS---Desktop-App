using HRMS.Model;
using System.Collections.Generic;
using System.Windows;

namespace HRMS
{
    /// <summary>
    /// Interaction logic for Dashboard2.xaml
    /// </summary>
    public partial class Dashboard2 : Window
    {
        public Dashboard2()
        {
            InitializeComponent();
            dataGrid1.ItemsSource = LoadCollectionData();
        }

        private List<Devices2> LoadCollectionData()
        {
            List<Devices2> devices = new List<Devices2>();
            devices.Add(new Devices2()
            {
                DeviceName = "Device 1",
                Status = "",
            });
            return devices;
        }

    }
}
