using HRMS.helper;
using HRMS.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows;

namespace HRMS
{
    /// <summary>
    /// Interaction logic for AddDevice.xaml
    /// </summary>
    public partial class AddDevice : Window
    {
        public AddDevice()
        {
            InitializeComponent();
            FillVendors();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var client = new RestClient("http://localhost/AuthenticationApi/public/api/");
                var request = new RestRequest("Device/Create", Method.POST);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddHeader("Authorization", "Bearer " + DBhelper.token);
                request.AddJsonBody(new { device_name = dName.Text, device_vendor = dVendor.Text, ip = ip.Text, port = port.Text, status = 1, user_id = dUID.Text, password = dPass.Text });

                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Some error occured !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void FillVendors()
        {
            try
            {
                var client = new RestClient("http://localhost/AuthenticationApi/public/api/");
                var request = new RestRequest("GetDevice");
                request.AddHeader("Authorization", "Bearer " + DBhelper.token);
                request.AddHeader("Accept", "application/json");
                IRestResponse response = client.Get(request);


                if (response.IsSuccessful)
                {
                    DeviceVendors device = JsonConvert.DeserializeObject<DeviceVendors>(response.Content);

                    int i = 0;
                    foreach (var type in device.Devices)
                    {
                        i++;
                        dVendor.Items.Add(type.Device_vendor);
                    }
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
    }
}
