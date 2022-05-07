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
    }
}
