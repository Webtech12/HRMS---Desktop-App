using HRMS.Model;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace HRMS
{
    /// <summary>
    /// Interaction logic for Dashboard3.xaml
    /// </summary>
    public partial class Dashboard3 : Window
    {
        public Dashboard3()
        {
            InitializeComponent();
            dataGrid3.ItemsSource = LoadCollectionData();
        }

        private List<Devices3> LoadCollectionData()
        {
            List<Devices3> devices = new List<Devices3>();
            devices.Add(new Devices3()
            {
                DeviceName = "Device 1",
                Status = "",
            });
            return devices;
        }
    }
}
