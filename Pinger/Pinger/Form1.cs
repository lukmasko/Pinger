using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pinger
{
   public partial class Form1 : Form
   {
      private HostFindManager hostFindManager = new HostFindManager();
      private SettingsManager settingsManager = new SettingsManager();

      public Form1()
      {
         InitializeComponent();
      }

      private void scan_ctrl_Click(object sender, EventArgs e)
      {
         settingsManager.Save();
         rescan_ctrl.Enabled = false;
         scan_ctrl.Enabled = false;

         hostFindManager.Scan(prapareFilter());
         drawResult();

         rescan_ctrl.Enabled = true;
         scan_ctrl.Enabled = true;
      }

      private void rescan_ctrl_Click(object sender, EventArgs e)
      {
         scan_ctrl.Enabled = false;
         rescan_ctrl.Enabled = false;

         hostFindManager.ReScan(prapareFilter());
         drawResult();

         scan_ctrl.Enabled = true;
         rescan_ctrl.Enabled = true;
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
         result_grid_ctrl.Rows.Clear();
         int counter = 0;
         foreach (var device in hostFindManager.getDevices())
         {
            int col = 0;
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow.CreateCells(result_grid_ctrl);
            dataGridViewRow.Cells[col++].Value = (++counter).ToString();
            dataGridViewRow.Cells[col++].Value = device.IP;
            dataGridViewRow.Cells[col++].Value = device.MacAddress;
            dataGridViewRow.Cells[col++].Value = device.HostName;
            dataGridViewRow.Cells[col++].Value = device.OrganisationName;

            if (device.ScanState == -1)
               dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204);
            else if (device.ScanState == 0)
               dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 204);
            else dataGridViewRow.DefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204);

            result_grid_ctrl.Rows.Add(dataGridViewRow);
         }
      }

   }
}
