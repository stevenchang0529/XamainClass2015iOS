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
 
            //lab:��Navigation Bar�ܧ�Back���s�A�üW�[�k�䪺���s��Final��


            //�]�wtitle
           // this.Title = "One";

            //�]�wStyle
          // NavigationController.NavigationBar.BarStyle = UIBarStyle.Black;

            //�]�w��r�M�I����
            //this.NavigationController.NavigationBar.TintColor = UIColor.Blue;
            //this.NavigationController.NavigationBar.BarTintColor = UIColor.Brown;
        }
	}
}
