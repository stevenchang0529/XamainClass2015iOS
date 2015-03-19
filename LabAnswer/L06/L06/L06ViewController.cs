using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SQLite;
using System.IO;
using System.Collections.Generic;
using L06_Share;

namespace L06
{
    public partial class L06ViewController : UIViewController
    {
        public L06ViewController(IntPtr handle)
            : base(handle)
        {
        }



        MyService service;
        public async  override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            //lab:使用Share File來操作Sqlite
            service = new MyService(path);
         
        }



        partial void btnQuery_TouchUpInside(UIButton sender)
        {
            //lab:查詢資料
                var data = service.Query(this.lblName.Text);
                this.tableData.Source = new MySource() { Items = data };
                this.tableData.ReloadData();
        }
    }

    public class MySource:UITableViewSource
    {
        public List<Info> Items { get; set; }



        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
          var cell=  tableView.DequeueReusableCell("ID");
            var item=Items[indexPath.Row];
          if (cell == null)
              cell = new UITableViewCell(UITableViewCellStyle.Value1, "ID");
          cell.TextLabel.Text = item.Name;
          cell.DetailTextLabel.Text = item.Age;
          return cell;
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            return Items.Count;
        }
    }


   
}