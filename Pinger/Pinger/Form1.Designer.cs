namespace Pinger
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.rescan_ctrl = new System.Windows.Forms.Button();
         this.scan_ctrl = new System.Windows.Forms.Button();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.retry_ping_ctrl = new System.Windows.Forms.TextBox();
         this.timeout_ping_ctrl = new System.Windows.Forms.TextBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.label6 = new System.Windows.Forms.Label();
         this.subnet_ctrl = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.scan_to_ctrl = new System.Windows.Forms.TextBox();
         this.scan_from_ctrl = new System.Windows.Forms.TextBox();
         this.ping_stop_ctrl = new System.Windows.Forms.Button();
         this.result_grid_ctrl = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.ip_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.mac_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.device_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.organisation_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.groupBox1.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.result_grid_ctrl)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.groupBox1.Controls.Add(this.rescan_ctrl);
         this.groupBox1.Controls.Add(this.scan_ctrl);
         this.groupBox1.Controls.Add(this.groupBox4);
         this.groupBox1.Controls.Add(this.groupBox3);
         this.groupBox1.Controls.Add(this.ping_stop_ctrl);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(202, 390);
         this.groupBox1.TabIndex = 4;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Action";
         // 
         // rescan_ctrl
         // 
         this.rescan_ctrl.Location = new System.Drawing.Point(40, 242);
         this.rescan_ctrl.Name = "rescan_ctrl";
         this.rescan_ctrl.Size = new System.Drawing.Size(126, 23);
         this.rescan_ctrl.TabIndex = 9;
         this.rescan_ctrl.Text = "ReScan";
         this.rescan_ctrl.UseVisualStyleBackColor = true;
         this.rescan_ctrl.Click += new System.EventHandler(this.rescan_ctrl_Click);
         // 
         // scan_ctrl
         // 
         this.scan_ctrl.Location = new System.Drawing.Point(40, 212);
         this.scan_ctrl.Name = "scan_ctrl";
         this.scan_ctrl.Size = new System.Drawing.Size(126, 23);
         this.scan_ctrl.TabIndex = 8;
         this.scan_ctrl.Text = "Scan";
         this.scan_ctrl.UseVisualStyleBackColor = true;
         this.scan_ctrl.Click += new System.EventHandler(this.scan_ctrl_Click);
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.label3);
         this.groupBox4.Controls.Add(this.label4);
         this.groupBox4.Controls.Add(this.retry_ping_ctrl);
         this.groupBox4.Controls.Add(this.timeout_ping_ctrl);
         this.groupBox4.Location = new System.Drawing.Point(29, 129);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(148, 74);
         this.groupBox4.TabIndex = 7;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Ping";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(14, 46);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(27, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "retry";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(14, 20);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(63, 13);
         this.label4.TabIndex = 5;
         this.label4.Text = "timeout [ms]";
         // 
         // retry_ping_ctrl
         // 
         this.retry_ping_ctrl.Location = new System.Drawing.Point(81, 43);
         this.retry_ping_ctrl.MaxLength = 3;
         this.retry_ping_ctrl.Name = "retry_ping_ctrl";
         this.retry_ping_ctrl.Size = new System.Drawing.Size(45, 20);
         this.retry_ping_ctrl.TabIndex = 4;
         this.retry_ping_ctrl.Text = "3";
         // 
         // timeout_ping_ctrl
         // 
         this.timeout_ping_ctrl.Location = new System.Drawing.Point(81, 17);
         this.timeout_ping_ctrl.MaxLength = 5;
         this.timeout_ping_ctrl.Name = "timeout_ping_ctrl";
         this.timeout_ping_ctrl.Size = new System.Drawing.Size(45, 20);
         this.timeout_ping_ctrl.TabIndex = 3;
         this.timeout_ping_ctrl.Text = "50";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.label6);
         this.groupBox3.Controls.Add(this.subnet_ctrl);
         this.groupBox3.Controls.Add(this.label2);
         this.groupBox3.Controls.Add(this.label1);
         this.groupBox3.Controls.Add(this.scan_to_ctrl);
         this.groupBox3.Controls.Add(this.scan_from_ctrl);
         this.groupBox3.Location = new System.Drawing.Point(29, 19);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(148, 104);
         this.groupBox3.TabIndex = 5;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Scan";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(14, 22);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(39, 13);
         this.label6.TabIndex = 9;
         this.label6.Text = "subnet";
         // 
         // subnet_ctrl
         // 
         this.subnet_ctrl.Location = new System.Drawing.Point(81, 19);
         this.subnet_ctrl.MaxLength = 3;
         this.subnet_ctrl.Name = "subnet_ctrl";
         this.subnet_ctrl.Size = new System.Drawing.Size(45, 20);
         this.subnet_ctrl.TabIndex = 7;
         this.subnet_ctrl.Text = "1";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(14, 74);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(16, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "to";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(14, 48);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(27, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "from";
         // 
         // scan_to_ctrl
         // 
         this.scan_to_ctrl.Location = new System.Drawing.Point(81, 71);
         this.scan_to_ctrl.MaxLength = 3;
         this.scan_to_ctrl.Name = "scan_to_ctrl";
         this.scan_to_ctrl.Size = new System.Drawing.Size(45, 20);
         this.scan_to_ctrl.TabIndex = 4;
         this.scan_to_ctrl.Text = "25";
         // 
         // scan_from_ctrl
         // 
         this.scan_from_ctrl.Location = new System.Drawing.Point(81, 45);
         this.scan_from_ctrl.MaxLength = 3;
         this.scan_from_ctrl.Name = "scan_from_ctrl";
         this.scan_from_ctrl.Size = new System.Drawing.Size(45, 20);
         this.scan_from_ctrl.TabIndex = 3;
         this.scan_from_ctrl.Text = "1";
         // 
         // ping_stop_ctrl
         // 
         this.ping_stop_ctrl.Enabled = false;
         this.ping_stop_ctrl.Location = new System.Drawing.Point(40, 320);
         this.ping_stop_ctrl.Name = "ping_stop_ctrl";
         this.ping_stop_ctrl.Size = new System.Drawing.Size(126, 23);
         this.ping_stop_ctrl.TabIndex = 1;
         this.ping_stop_ctrl.Text = "Stop scan";
         this.ping_stop_ctrl.UseVisualStyleBackColor = true;
         // 
         // result_grid_ctrl
         // 
         this.result_grid_ctrl.AllowUserToAddRows = false;
         this.result_grid_ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.result_grid_ctrl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
         this.result_grid_ctrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.result_grid_ctrl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ip_address,
            this.mac_address,
            this.device_name,
            this.organisation_name});
         this.result_grid_ctrl.Location = new System.Drawing.Point(220, 18);
         this.result_grid_ctrl.Name = "result_grid_ctrl";
         this.result_grid_ctrl.ReadOnly = true;
         this.result_grid_ctrl.RowHeadersVisible = false;
         this.result_grid_ctrl.Size = new System.Drawing.Size(707, 384);
         this.result_grid_ctrl.TabIndex = 6;
         // 
         // Column1
         // 
         this.Column1.HeaderText = "No";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         this.Column1.Width = 30;
         // 
         // ip_address
         // 
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
         this.ip_address.DefaultCellStyle = dataGridViewCellStyle6;
         this.ip_address.HeaderText = "IP Address";
         this.ip_address.Name = "ip_address";
         this.ip_address.ReadOnly = true;
         this.ip_address.Width = 120;
         // 
         // mac_address
         // 
         this.mac_address.HeaderText = "MAC";
         this.mac_address.Name = "mac_address";
         this.mac_address.ReadOnly = true;
         this.mac_address.Width = 130;
         // 
         // device_name
         // 
         this.device_name.HeaderText = "Device Name";
         this.device_name.Name = "device_name";
         this.device_name.ReadOnly = true;
         this.device_name.Width = 180;
         // 
         // organisation_name
         // 
         this.organisation_name.HeaderText = "Organization";
         this.organisation_name.Name = "organisation_name";
         this.organisation_name.ReadOnly = true;
         this.organisation_name.Width = 180;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(939, 430);
         this.Controls.Add(this.result_grid_ctrl);
         this.Controls.Add(this.groupBox1);
         this.Name = "Form1";
         this.Text = "Pinger 1.02";
         this.groupBox1.ResumeLayout(false);
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.result_grid_ctrl)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button rescan_ctrl;
      private System.Windows.Forms.Button scan_ctrl;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox retry_ping_ctrl;
      private System.Windows.Forms.TextBox timeout_ping_ctrl;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox subnet_ctrl;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox scan_to_ctrl;
      private System.Windows.Forms.TextBox scan_from_ctrl;
      private System.Windows.Forms.Button ping_stop_ctrl;
      private System.Windows.Forms.DataGridView result_grid_ctrl;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn ip_address;
      private System.Windows.Forms.DataGridViewTextBoxColumn mac_address;
      private System.Windows.Forms.DataGridViewTextBoxColumn device_name;
      private System.Windows.Forms.DataGridViewTextBoxColumn organisation_name;
   }
}

