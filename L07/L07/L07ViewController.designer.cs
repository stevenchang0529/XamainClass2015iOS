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

namespace L07
{
	[Register ("L07ViewController")]
	partial class L07ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCall { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblResult { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnCall != null) {
				btnCall.Dispose ();
				btnCall = null;
			}
			if (lblResult != null) {
				lblResult.Dispose ();
				lblResult = null;
			}
		}
	}
}
