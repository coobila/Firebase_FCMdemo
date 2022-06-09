using System;
using System.Collections.Generic;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using FirebaseAdmin.Messaging;
using System.Threading.Tasks;

/// <summary>
/// FCMNotification 的摘要描述
/// </summary>
public class FCMNotification
{

    public FCMNotification()
    {
        //初始化SDK
        if (FirebaseApp.DefaultInstance == null)
        {
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("add your json path")
            });
        }

    }

    /// <summary>
    /// 向多台設備發送消息
    /// </summary>
    /// <param name="registrationTokens">設備Tokens</param>
    /// <param name="title">主旨</param>
    /// <param name="content">內容</param>
    /// <returns></returns>
    public async Task<string> PushMulticastNotificationAsync(List<String> registrationTokens, string title, string content)
    {
        //registrationTokens = "YOUR_REGISTRATION_TOKEN";

        var message = new MulticastMessage()
        {
            Tokens = registrationTokens,
            Notification = new Notification
            {
                Title = title,
                Body = content
            }
        };

        var response = await FirebaseMessaging.DefaultInstance.SendMulticastAsync(message);


        return response.ToString();
    }

    /// <summary>
    /// 向特定設備發送消息
    /// </summary>
    /// <param name="registrationToken"></param>
    /// <param name="title"></param>
    /// <param name="content"></param>
    /// <returns></returns>
    public async Task<string> PushNotificationAsync(string registrationToken, string title, string content)
    {
        //registrationToken = "YOUR_REGISTRATION_TOKEN";

        var message = new Message()
        {
            Token = registrationToken,
            Notification = new Notification
            {
                Title = title,
                Body = content
            }
        };

        var response = await FirebaseMessaging.DefaultInstance.SendAsync(message);


        return response.ToString();
    }

}