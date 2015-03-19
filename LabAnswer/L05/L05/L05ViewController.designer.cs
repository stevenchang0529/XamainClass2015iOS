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
	[Register ("L05ViewController")]
	partial class L05ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView MyTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyTable != null) {
				MyTable.Dispose ();
				MyTable = null;
			}
		}
	}
}
