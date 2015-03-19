// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace L02_Controls
{
	[Register ("LabViewController")]
	partial class LabViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton MyButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel MyLable { get; set; }

		[Action ("MyButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void MyButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (MyButton != null) {
				MyButton.Dispose ();
				MyButton = null;
			}
			if (MyLable != null) {
				MyLable.Dispose ();
				MyLable = null;
			}
		}
	}
}
