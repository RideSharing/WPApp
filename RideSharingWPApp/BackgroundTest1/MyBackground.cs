using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.Networking.PushNotifications;

namespace BackgroundTest1
{
    public sealed class MyBackground : IBackgroundTask
    {
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            // simple example with a Toast, to enable this go to manifest file
            // and mark App as TastCapable - it won't work without this
            // The Task will start but there will be no Toast.
            //ToastTemplateType toastTemplate = ToastTemplateType.ToastText02;
            //XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplate);
            //XmlNodeList textElements = toastXml.GetElementsByTagName("text");
            //textElements[0].AppendChild(toastXml.CreateTextNode("My first Task - Yeah"));
            //textElements[1].AppendChild(toastXml.CreateTextNode("I'm a message from your background task!"));
            //ToastNotificationManager.CreateToastNotifier().Show(new ToastNotification(toastXml));




            var deferral = taskInstance.GetDeferral();
            RawNotification raw = taskInstance.TriggerDetails as RawNotification;
            if (raw != null)
            {
                Debug.WriteLine(
                  string.Format("XXXXXXXXXXXXXReceived from cloud:XXXXXXXXXX [{0}]",
                  raw.Content));
            } 

            deferral.Complete();
        }

        private static async Task test()
        {
            
        }
    }
}
