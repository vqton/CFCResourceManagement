using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace CFCResourceManagement
{
    public partial class frmMain : Form
    {
        //Hứng các tham số được tiêm vào thông qua constructor

        //private readonly AppContext _context;


        public frmMain()
        {


            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            this.toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            lblIPAddress.Text = "IP: " + GetIPAddress();
            lblUserID.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            DrawDataChart();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoopFoodTrucThuoc o = new frmCoopFoodTrucThuoc();
            o.Show();
        }

        public string GetIPAddress()
        {
            string IPAddress = string.Empty;
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }

        private void parnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiTac frmDoiTac = new frmDoiTac();
            frmDoiTac.Show();
        }

        private void deploymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDDT_HopDong_TrienKhai oHDTrienKhai = new frmHDDT_HopDong_TrienKhai();
            oHDTrienKhai.Show();
        }

        void DrawDataChart()
        {
            chart1.Series.Clear();
            var dtSource = clsMonitorSaleData.CheckTransactionGroup1();
            var dtSource2 = clsMonitorSaleData.CheckTransactionGroup2();
            dtSource.Merge(dtSource2);

            var distinctValues = dtSource.AsEnumerable()
                        .Select(row => new
                        {
                            TXDATE = row.Field<DateTime>("date"),
                        }).Distinct();

            DataView[] dv = new DataView[distinctValues.Count()];
            Series[] s = new Series[distinctValues.Count()];

            MessageBox.Show(dv.Length.ToString());
            for (int i = 0; i <= dv.Length-1; i++)
            {
                dv[i] = new DataView(dtSource);
            }


            int j = 0;

            for (int i = 0; i <= distinctValues.Count() - 1; i++)
            {
                dv[i].RowFilter = String.Format("date = #{0}#", distinctValues.ToList().ElementAt(i).TXDATE.ToString("MM/dd/yyyy"));
                s[i] = new Series(distinctValues.ToList().ElementAt(i).TXDATE.ToString("MM/dd/yyyy"));
                s[i].Points.DataBind(dv[i], "store", "amount", "");
                s[i].ChartType = SeriesChartType.Column;
                chart1.Series.Add(s[i]);
            }
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{#,##0} VND";
            this.chart1.Titles.Add("Sale data monitoring");
            chart1.Legends[0].Title = "Transaction date";
            //dv1.RowFilter = ();
            //dv2.RowFilter = ("date = #05/08/2022#");
            //dv3.RowFilter = ("date = #05/09/2022#");
            //dv4.RowFilter = ("date = #05/10/2022#");
            //dv5.RowFilter = ("date = #05/11/2022#");
            //dv1.RowFilter = ("date = #05/06/2022#");
            //chart1.DataSource = dv1;
            //Series

            //Series a = new Series();
            //a.Points.DataBind(dv2, "store", "amount", "");
            ////a.XValueMember

            //chart1.Series[0].Points.DataBind(dv1, "store", "amount", "");
            ////chart1.Series[0].XValueMember = "store";
            ////chart1.Series[0].YValueMembers = "amount";
            //chart1.Series[0].YValueType = ChartValueType.Auto;
            //chart1.Series.Add(a);
            //this.chart1.Titles.Add("Salary Chart for Employee");
            //chart1.Series[0].ChartType = SeriesChartType.Column;
            //chart1.Series[0].IsValueShownAsLabel = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
