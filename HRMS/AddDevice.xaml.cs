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
                request.AddHeader("Authorization", "Bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjlmNWNlNWNlZDExNjk5M2ZhYzUxYmUyMDc1ZTkyMGJiNTk2MzJkOGNmMTY0NTgzZTU3NzQ4Yjg3Y2M2NGMzOGE2ODliM2U0NDgzMzQ1NGQ5In0.eyJhdWQiOiIxIiwianRpIjoiOWY1Y2U1Y2VkMTE2OTkzZmFjNTFiZTIwNzVlOTIwYmI1OTYzMmQ4Y2YxNjQ1ODNlNTc3NDhiODdjYzY0YzM4YTY4OWIzZTQ0ODMzNDU0ZDkiLCJpYXQiOjE1ODAyODcxMDksIm5iZiI6MTU4MDI4NzEwOSwiZXhwIjoxNjExOTA5NTA5LCJzdWIiOiI3MyIsInNjb3BlcyI6W119.WKKeECDnTRGbS1pmpQE7Ql5NlBBFmRPWa2xj7Px2w8L1NjBIoTQDJL6s-cn78INpcaUZvg0cQGt8ygd_bgjtvPSy7JPLh4X4d4lgQLhZxMtLz9-X56KWUaHlV_GOjI4lUxrkOyo95ZbDuGGPTm2tOBHceLpHFIG18x1aANYLl58HbhvHyO9zefEgJGFXzIb3__PdTWlui4MpEy5WmhJNKUmsm38Mm9pjL2EIqTWTBZA5889QViReHogLENDY-wQF0ed01dr7oSxf8rghJRN5ZR_9xUB0cIXRU83u3a679m1O0z7rbkYhYV_lJsqCuqiUMpbTPh2btIc-4svdKspb5tVHwYJvvwHf7mDgtc3gy3COS61sr65rp-JSuoxviz460vzebcNroHp8bkx1R_GkeTcsAv56xh11zLZZ_052SaW4dN7EQNIkDUasxiXStcwlByFedvIujYI4EwzYOaoOvH7c7rHaUI8mNlYJ2e7Eo1AVsNNi8krr5Dg5fRVWfTHJEAa-BNJRQ4al8ot67w6QkBDm-GV4CRbaYujTcvL5-s2_Z4wMLj0RHFjuRqg1Mkgxj8dK1J5xqNhy4FqofP3bxmpaJd-jCG4-IdxIncD17uApeHsNJ8EUAgTNmk6vfF2SM-lMgXP_sY5fPGQjJGZlHus0tlTQorxWvwe3O_OhzMM");
                request.AddJsonBody(new { device_name = dName.Text, device_vendor = dVendor.Text, ip = ip.Text, port = port.Text, status = 1 });

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
                request.AddHeader("Authorization", "Bearer " + "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjlmNWNlNWNlZDExNjk5M2ZhYzUxYmUyMDc1ZTkyMGJiNTk2MzJkOGNmMTY0NTgzZTU3NzQ4Yjg3Y2M2NGMzOGE2ODliM2U0NDgzMzQ1NGQ5In0.eyJhdWQiOiIxIiwianRpIjoiOWY1Y2U1Y2VkMTE2OTkzZmFjNTFiZTIwNzVlOTIwYmI1OTYzMmQ4Y2YxNjQ1ODNlNTc3NDhiODdjYzY0YzM4YTY4OWIzZTQ0ODMzNDU0ZDkiLCJpYXQiOjE1ODAyODcxMDksIm5iZiI6MTU4MDI4NzEwOSwiZXhwIjoxNjExOTA5NTA5LCJzdWIiOiI3MyIsInNjb3BlcyI6W119.WKKeECDnTRGbS1pmpQE7Ql5NlBBFmRPWa2xj7Px2w8L1NjBIoTQDJL6s-cn78INpcaUZvg0cQGt8ygd_bgjtvPSy7JPLh4X4d4lgQLhZxMtLz9-X56KWUaHlV_GOjI4lUxrkOyo95ZbDuGGPTm2tOBHceLpHFIG18x1aANYLl58HbhvHyO9zefEgJGFXzIb3__PdTWlui4MpEy5WmhJNKUmsm38Mm9pjL2EIqTWTBZA5889QViReHogLENDY-wQF0ed01dr7oSxf8rghJRN5ZR_9xUB0cIXRU83u3a679m1O0z7rbkYhYV_lJsqCuqiUMpbTPh2btIc-4svdKspb5tVHwYJvvwHf7mDgtc3gy3COS61sr65rp-JSuoxviz460vzebcNroHp8bkx1R_GkeTcsAv56xh11zLZZ_052SaW4dN7EQNIkDUasxiXStcwlByFedvIujYI4EwzYOaoOvH7c7rHaUI8mNlYJ2e7Eo1AVsNNi8krr5Dg5fRVWfTHJEAa-BNJRQ4al8ot67w6QkBDm-GV4CRbaYujTcvL5-s2_Z4wMLj0RHFjuRqg1Mkgxj8dK1J5xqNhy4FqofP3bxmpaJd-jCG4-IdxIncD17uApeHsNJ8EUAgTNmk6vfF2SM-lMgXP_sY5fPGQjJGZlHus0tlTQorxWvwe3O_OhzMM");
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
