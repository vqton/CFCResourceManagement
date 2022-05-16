namespace CFCResourceManagement
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblIPAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserID = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cFTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBaoTri = new System.Windows.Forms.ToolStripMenuItem();
            this.cFNQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.eInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deploymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warrantyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.parnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTrienKhai = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblIPAddress,
            this.toolStripStatusLabel3,
            this.lblUserID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = "datetime";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(53, 17);
            this.lblIPAddress.Text = "ipaddress";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel3.Text = "connectionStatus";
            // 
            // lblUserID
            // 
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(39, 17);
            this.lblUserID.Text = "userID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cFTTToolStripMenuItem,
            this.cFNQToolStripMenuItem,
            this.eInvoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cFTTToolStripMenuItem
            // 
            this.cFTTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.btnBaoTri,
            this.btnTrienKhai});
            this.cFTTToolStripMenuItem.Name = "cFTTToolStripMenuItem";
            this.cFTTToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cFTTToolStripMenuItem.Text = "CFTT";
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.storesToolStripMenuItem.Text = "Stores";
            this.storesToolStripMenuItem.Click += new System.EventHandler(this.storesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(180, 22);
            this.btnBaoTri.Text = "Theo dõi bảo trì";
            // 
            // cFNQToolStripMenuItem
            // 
            this.cFNQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storesToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cFNQToolStripMenuItem.Name = "cFNQToolStripMenuItem";
            this.cFNQToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cFNQToolStripMenuItem.Text = "CFNQ";
            // 
            // storesToolStripMenuItem1
            // 
            this.storesToolStripMenuItem1.Name = "storesToolStripMenuItem1";
            this.storesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.storesToolStripMenuItem1.Text = "Stores";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // eInvoiceToolStripMenuItem
            // 
            this.eInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deploymentToolStripMenuItem,
            this.warrantyToolStripMenuItem,
            this.toolStripMenuItem4,
            this.parnerToolStripMenuItem,
            this.toolStripMenuItem3});
            this.eInvoiceToolStripMenuItem.Name = "eInvoiceToolStripMenuItem";
            this.eInvoiceToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eInvoiceToolStripMenuItem.Text = "EInvoice";
            // 
            // deploymentToolStripMenuItem
            // 
            this.deploymentToolStripMenuItem.Name = "deploymentToolStripMenuItem";
            this.deploymentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deploymentToolStripMenuItem.Text = "Hợp đồng triển khai";
            this.deploymentToolStripMenuItem.Click += new System.EventHandler(this.deploymentToolStripMenuItem_Click);
            // 
            // warrantyToolStripMenuItem
            // 
            this.warrantyToolStripMenuItem.Name = "warrantyToolStripMenuItem";
            this.warrantyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.warrantyToolStripMenuItem.Text = "Hơp đồng bảo trì";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 6);
            // 
            // parnerToolStripMenuItem
            // 
            this.parnerToolStripMenuItem.Name = "parnerToolStripMenuItem";
            this.parnerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.parnerToolStripMenuItem.Text = "Đối tác";
            this.parnerToolStripMenuItem.Click += new System.EventHandler(this.parnerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 6);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 24);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 404);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnTrienKhai
            // 
            this.btnTrienKhai.Name = "btnTrienKhai";
            this.btnTrienKhai.Size = new System.Drawing.Size(180, 22);
            this.btnTrienKhai.Text = "Theo dõi triển khai";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "CFC Resources Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cFTTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnBaoTri;
        private System.Windows.Forms.ToolStripMenuItem cFNQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblIPAddress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblUserID;
        private System.Windows.Forms.ToolStripMenuItem deploymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warrantyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem parnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem btnTrienKhai;
    }
}

