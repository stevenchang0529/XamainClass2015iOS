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
	[Register ("MyViewController")]
	partial class MyViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIDatePicker datePick { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIWebView MyWebView { get; set; }

		[Action ("UIButton170_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton170_TouchUpInside (UIButton sender);

		[Action ("UIButton174_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton174_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (datePick != null) {
				datePick.Dispose ();
				datePick = null;
			}
			if (MyWebView != null) {
				MyWebView.Dispose ();
				MyWebView = null;
			}
		}
	}
}
