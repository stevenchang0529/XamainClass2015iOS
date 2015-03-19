using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using STC.Xamarin.MVVMFramework;
using L09_ViewModel;
namespace L09_iOS
{
    public partial class L09_iOSViewController : UIViewController
    {
        public L09_iOSViewController(IntPtr handle)
            : base(handle)
        {
        }


        //lab:將android與iOS改為MVVM模式
        int count = 1;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
          button.TouchUpInside += delegate { button.SetTitle(string.Format("{0} clicks!", count++), UIControlState.Normal); };

      
        }

    }
}