using System;
using System.Windows.Forms;

namespace Pinger
{
   public partial class Form1 : Form
   {
      private HostFindManager hostFindManager = new HostFindManager();

      public Form1()
      {
         InitializeComponent();
      }

      private void scan_ctrl_Click(object sender, EventArgs e)
      {
         hostFindManager.Scan(prapareFilter());
         drawResult();
      }

      private void rescan_ctrl_Click(object sender, EventArgs e)
      {
         hostFindManager.ReScan(prapareFilter());
         drawResult();
      }

      private SearchFilter prapareFilter()
      {
         SearchFilter searchFilter = new SearchFilter();
         searchFilter.Subnet = Convert.ToUInt16(subnet_ctrl.Text);
         searchFilter.SearchFrom = Convert.ToUInt16(scan_from_ctrl.Text);
         searchFilter.SearchTo = Convert.ToUInt16(scan_to_ctrl.Text);
         searchFilter.Timeout = Convert.ToUInt16(timeout_ping_ctrl.Text);
         searchFilter.RetryCount = Convert.ToUInt16(retry_ping_ctrl.Text);

         return searchFilter;
      }

      private void drawResult()
      {
         int counter = 0;
         foreach (var device in hostFindManager.getDevices())
         {
            result_grid_ctrl.Rows.Add((++counter).ToString(), device.IP, device.MacAddress, device.HostName, device.OrganisationName);
         }
      }

   }
}
