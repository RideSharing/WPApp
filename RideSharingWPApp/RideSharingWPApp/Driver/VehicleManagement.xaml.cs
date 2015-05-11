using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json.Linq;
using RideSharingWPApp.Global;
using Newtonsoft.Json;

namespace RideSharingWPApp.Driver
{
    public partial class VehicleManagement : PhoneApplicationPage
    {
        RootVehicle root = null;
        List<Vehicle> vehicles = new List<Vehicle>();

        public VehicleManagement()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            getListOfVehicles();
        }

        public async void getListOfVehicles()
        {
            var result = await Request.RequestToServer.sendGetRequest("vehicles");

            JObject jsonObject = JObject.Parse(result);

            string error = jsonObject.Value<string>("error").Trim();

            //var xlong = jsonObject.SelectToken("itineraries");
            //JArray jsonVal = (JArray)jsonObject.SelectToken("itineraries");

            root = JsonConvert.DeserializeObject<RootVehicle>(result);

            foreach (Vehicle v in root.vehicles)
            {
                GlobalData.vehicleList.Add(new Vehicle2
                {
                    vehicle_id = v.vehicle_id,
                    user_id = v.user_id,
                    type = v.type,
                    status = v.status,
                    license_plate = v.license_plate,
                    reg_certificate = v.reg_certificate,
                    license_plate_img = ImageConvert.ImageConvert.convertBase64ToImage(v.license_plate_img),
                    motor_insurance_img = ImageConvert.ImageConvert.convertBase64ToImage(v.motor_insurance_img),
                    created_at = v.created_at,
                    vehicle_img = ImageConvert.ImageConvert.convertBase64ToImage(v.vehicle_img)
                });
            }

            longlistVehicles.ItemsSource = GlobalData.vehicleList;
        }


        private void menuAccountInfo_Click(object sender, EventArgs e)
        {

        }

        private void menuAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void menuLogOut_Click(object sender, EventArgs e)
        {

        }

        private void menuHome_Click(object sender, EventArgs e)
        {

        }

        private void menuSearch_Click(object sender, EventArgs e)
        {

        }

        private void menuPostItinerary_Click(object sender, EventArgs e)
        {

        }

        private void menuItineraryManagement_Click(object sender, EventArgs e)
        {

        }

        private void longlistVehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Vehicle2 selectedItem = (Vehicle2)longlistVehicles.SelectedItem;
            MessageBox.Show("ss: " + selectedItem.vehicle_id);
            //luu tru tam thoi
            GlobalData.selectedVehicle = selectedItem;
            //navigate sang details
            NavigationService.Navigate(new Uri("/Driver/VehicleDetails.xaml", UriKind.RelativeOrAbsolute));
        }

       

        
    }
}