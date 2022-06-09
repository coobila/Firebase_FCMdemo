using System;
using System.Collections.Generic;

namespace FCMdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FCM Server Start!");

            //---S--- 向多台設備發送消息
            FCMNotification fcmNotificationMgr = new FCMNotification();

            // These registration tokens come from the client FCM SDKs.
            var registrationTokens = new List<string>()
            {
                "YOUR_REGISTRATION_TOKEN_1",
                // …
                "YOUR_REGISTRATION_TOKEN_N",
            };

            string response = fcmNotificationMgr.PushMulticastNotificationAsync(registrationTokens, "test", "demo").Result;
            Console.WriteLine("Successfully sent message: " + response);
            //---E--- 向多台設備發送消息

            ////---S--- 向特定設備發送消息
            //FCMNotification fcmNotificationMgr = new FCMNotification();
            //string response = fcmNotificationMgr.PushNotificationAsync("YOUR_REGISTRATION_TOKEN", "test", "demo").Result;
            //Console.WriteLine("Successfully sent message: " + response);
            ////---E--- 向特定設備發送消息
        }

    }
}
