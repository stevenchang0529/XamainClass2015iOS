using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace L02_Controls
{
	partial class LabViewController : UIViewController
	{
		public LabViewController (IntPtr handle) : base (handle)
		{
            //lab:新增Button、Lable到畫面上
            //lab:為控制向命名
            //為Button註冊Click事件，變更Lable
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        partial void MyButton_TouchUpInside(UIButton sender)
        {
            this.MyLable.Text = "按下了按鈕";
        }
	}
}
