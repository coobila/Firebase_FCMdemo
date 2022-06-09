# Firebase_FCMdemo
C# Firebase Push Server由使用舊版 HTTP 改為使用 HTTP v1 範例

1.初始化SDK,官網沒寫先判斷物件是否執行,但我覺得有判斷比較好

     if (FirebaseApp.DefaultInstance == null)
     {
         FirebaseApp.Create(new AppOptions()
         {
             Credential = GoogleCredential.FromFile("你的json路徑")
         });
     }
