using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;


namespace L08
{
    public partial class L08ViewController : UIViewController
    {
        public L08ViewController(IntPtr handle)
            : base(handle)
        {
        }




        //lab:http://testmyapi.azurewebsites.net/api/values/
        //lab:新增PCL專案並加入參考
        //lab:於兩個專案中加入Json.net
        //lab:於PCL專案中加入httpClient套件(NuGet)
        //lab:於PCL專案呼叫API並轉換為物件回傳
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //lab:註冊btnCall的TouchUpInside事件，呼叫PCL中的類別，將結果回傳並顯示於畫面

        
        }

       
    }
}