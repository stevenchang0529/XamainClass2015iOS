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

namespace L01
{
	[Register ("L01ViewController")]
	partial class L01ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel My { get; set; }

		[Action ("UIButton28_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton28_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (My != null) {
				My.Dispose ();
				My = null;
			}
		}
	}
}
