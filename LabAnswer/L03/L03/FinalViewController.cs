using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace L03
{
	partial class FinalViewController : UIViewController
	{
		public FinalViewController (IntPtr handle) : base (handle)
		{
		}

        partial void UIButton1330_TouchUpInside(UIButton sender)
        {
            //lab:讓view回上一頁PopViewControllerAnimated()
            this.NavigationController.PopViewControllerAnimated(true);
        }

        partial void UIButton1332_TouchUpInside(UIButton sender)
        {
            //lab:讓view回Root PopToRootViewController()
            this.NavigationController.PopToRootViewController(true);

        }
	}
}
