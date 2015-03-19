using L06_Share;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace L06
{
	partial class AddViewController : UIViewController
	{
		public AddViewController (IntPtr handle) : base (handle)
		{
		}

        partial void btnAdd_TouchUpInside(UIButton sender)
        {
            //lab:新增資料
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var service = new MyService(path);
            service.Add(new Info()
            {
                 Age=txtAge.Text,
                  Name=txtName.Text
            });
            this.NavigationController.PopViewControllerAnimated(true);
        }
	}
}
