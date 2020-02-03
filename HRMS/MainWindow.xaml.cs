using HRMS.helper;
using HRMS.Model;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Windows;

namespace HRMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Url = "http://localhost/AuthenticationApi/public/api/login/";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string uName = username.Text;
            string uPassword = password.Password;

            try
            {
                var client = new RestClient("http://localhost/AuthenticationApi/public/api/");
                var request = new RestRequest("login", Method.POST);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddJsonBody(new { email = uName , password = uPassword });

               // var response = client.Execute(request);
                IRestResponse<List<LoginJsonRootObject>> response = client.Post<List<LoginJsonRootObject>>(request);

                if (response.IsSuccessful)
                {
                    DBhelper.token = response.Data[0].Token;
                    DBhelper.email = response.Data[0].Email;
                    AddDevice addDevice = new AddDevice();
                    //Dashboard dashboard = new Dashboard();
                    MessageBox.Show("Welcome " + response.Data[0].Email);
                    addDevice.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please try again");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
