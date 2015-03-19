using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace L03
{
	partial class OneViewController : UIViewController
	{
        public string Value { get; set; }
        public OneViewController(IntPtr handle)
            : base(handle)
		{
		}

        public override void ViewDidLoad()
        {
            this.MyLabel.Text = this.Value;
 
            //lab:為Navigation Bar變更Back按鈕，並增加右邊的按鈕到Final頁

            this.NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem("返回", UIBarButtonItemStyle.Plain, (sender, e) =>
            {
                this.NavigationController.PopViewControllerAnimated(true);
            }), true);

            this.NavigationItem.SetRightBarButtonItem(new UIBarButtonItem(UIBarButtonSystemItem.Play,(sender,e)=>
            {
                this.btnFinal.SendActionForControlEvents(UIControlEvent.TouchUpInside);
            }), true);

            //設定title
           // this.Title = "One";

            //設定Style
           NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;

            //設定文字和背景色
            //this.NavigationController.NavigationBar.TintColor = UIColor.Blue;
            //this.NavigationController.NavigationBar.BarTintColor = UIColor.Brown;
        }
	}
}
