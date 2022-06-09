# Firebase_FCMdemo
Firebase 由使用舊版 HTTP 改為使用 HTTP v1發送消息 C#範例

1.透過NuGet安裝FirebaseAdmin

2.初始化SDK,官網沒寫先判斷物件是否執行,但我覺得有判斷比較好

     if (FirebaseApp.DefaultInstance == null)
     {
         FirebaseApp.Create(new AppOptions()
         {
             Credential = GoogleCredential.FromFile("你的json路徑")
         });
     }

3.建構發送請求方法,官網分特定設備、多個設備、主題與批量發送

請參閱官方文檔
https://firebase.google.com/docs/cloud-messaging/send-message?hl=zh&authuser=0
