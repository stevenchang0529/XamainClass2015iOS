
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace L01
{
	public partial class TestViewController : UIViewController
	{
		public TestViewController () : base ("TestViewController", null)
		{
            //lab:新增一個Button後，新增Action，並關閉此controller
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void MyButton (NSObject sender)
		{
			this.DismissViewController(true,null);
		}

	}
}

