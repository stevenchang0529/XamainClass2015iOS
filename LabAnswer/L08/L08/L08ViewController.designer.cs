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

namespace L08
{
	[Register ("L08ViewController")]
	partial class L08ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCall { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblAge { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView lblResult { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblWork { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnCall != null) {
				btnCall.Dispose ();
				btnCall = null;
			}
			if (lblAge != null) {
				lblAge.Dispose ();
				lblAge = null;
			}
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
			if (lblResult != null) {
				lblResult.Dispose ();
				lblResult = null;
			}
			if (lblWork != null) {
				lblWork.Dispose ();
				lblWork = null;
			}
		}
	}
}
