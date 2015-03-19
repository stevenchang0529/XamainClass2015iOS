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

namespace L05
{
	[Register ("MyCell")]
	partial class MyCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView img { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lbl { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (img != null) {
				img.Dispose ();
				img = null;
			}
			if (lbl != null) {
				lbl.Dispose ();
				lbl = null;
			}
		}
	}
}
