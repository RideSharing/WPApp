using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Web.Http;
using RideSharingWPApp.Request;

namespace RideSharingWPApp
{
    public partial class RatingPage : PhoneApplicationPage
    {
        public RatingPage()
        {
            InitializeComponent();

            
        }

        private async void btnSend_Click(object sender, RoutedEventArgs e)
        {
            //send rating
            Dictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("rating", ratingDriver.Value.ToString().Trim());
            postData.Add("rating_user_id", Global.GlobalData.selectedItinerary.driver_id.ToString().Trim());

            HttpFormUrlEncodedContent content =
                new HttpFormUrlEncodedContent(postData);

            var result = await RequestToServer.sendPostRequest("rating", content);

            //send comment
            Dictionary<string, string> postData2 = new Dictionary<string, string>();
            postData2.Add("content", txtbComment.Text.Trim());
            postData2.Add("comment_user_id", Global.GlobalData.selectedItinerary.driver_id.ToString().Trim());

            HttpFormUrlEncodedContent content2 =
                new HttpFormUrlEncodedContent(postData);

            var result2 = await RequestToServer.sendPostRequest("rating", content2);
        }
    }
}