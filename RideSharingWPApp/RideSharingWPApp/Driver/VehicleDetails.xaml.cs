using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace RideSharingWPApp.Driver
{
    public partial class VehicleDetails : PhoneApplicationPage
    {
        PhotoChooserTask photoChooserTask;
        CameraCaptureTask cameraCaptureTask;
        public VehicleDetails()
        {
            InitializeComponent();
        }

        private void btnUpdateProfile_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        void photoVehicleChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgVehicle.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
                //MessageBox.Show(str);
            }
        }

        void photoLicensePlateChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgLicensePlate.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
                //MessageBox.Show(str);
            }
        }

        void photoRegistrationCertificateChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgRegistrationCertificate.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
                //MessageBox.Show(str);
            }
        }

        void photoMotorInsuranceChooserTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgMotorInsurance.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
                //MessageBox.Show(str);
            }
        }

        void cameraCaptureVehicleTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgVehicle.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
            }
        }

        void cameraCaptureLicensePlateTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgLicensePlate.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
            }
        }

        void cameraCaptureRegistrationCertificateTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgRegistrationCertificate.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
            }
        }

        void cameraCaptureMotorInsuranceTask_Completed(object sender, PhotoResult e)
        {
            if (e.TaskResult == TaskResult.OK)
            {
                //Code to display the photo on the page in an image control named myImage.
                System.Windows.Media.Imaging.BitmapImage bmp = new System.Windows.Media.Imaging.BitmapImage();
                bmp.SetSource(e.ChosenPhoto);

                //MessageBox.Show(bmp.ToString());
                Image myImgage = new Image();
                myImgage.Source = bmp;
                string str = ImageConvert.ImageConvert.convertImageToBase64(myImgage);

                imgMotorInsurance.Source = ImageConvert.ImageConvert.convertBase64ToImage(str);
            }
        }

        
        private void btnSlelectMotorPlate_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnSelectMotorInsuranceImg_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnSelectRegistrationCertificate_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnCaptureMotoPlate_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnCaptureMotorInsuranceImg_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

       
        private void btnCaptureRegistrationCertificate_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdateVehicleInfor_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnSelectVehiclePhoto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void btnCaptureVehiclePhoto_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }
    }
}