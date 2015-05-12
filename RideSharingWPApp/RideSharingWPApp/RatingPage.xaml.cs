using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace RideSharingWPApp
{
    public partial class RatingPage : PhoneApplicationPage
    {
        public RatingPage()
        {
            InitializeComponent();

            
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            /*Dictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("type", txtbType.Text.Trim());

            HttpFormUrlEncodedContent content =
                new HttpFormUrlEncodedContent(postData);

            var result = await RequestToServer.sendPostRequest("vehicle", content);*/
        }
    }
}