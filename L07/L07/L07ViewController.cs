using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;


namespace L07
{
    public partial class L07ViewController : UIViewController
    {
        public L07ViewController(IntPtr handle)
            : base(handle)
        {
        }

        //lab:建立PCL專案
        //lab:在PCL中加入WebService 
        //lab:http://testmyws.azurewebsites.net/Service1.svc
        //lab:將WebService方法封裝成TAP
        //tip:      new BasicHttpBinding(BasicHttpSecurityMode.None);
       //            new EndpointAddress("http://testmyws.azurewebsites.net/Service1.svc");
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //lab:用Button註冊TouchUpInside事件呼叫WebService，將返回值設回lblResult


        }

   
    }
}