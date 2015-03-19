using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace L05
{
	partial class MyCell : UITableViewCell
	{
		public MyCell (IntPtr handle) : base (handle)
		{
		}

        public void SetData(Data data)
        {
            this.lbl.Text = data.ShowValue;
            this.img.Image = UIImage.FromBundle(data.ImageName);
        }
	}
}
