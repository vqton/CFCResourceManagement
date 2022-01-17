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

namespace CFCResourceManagement
{
    public partial class frmMain : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            log.Info("Hello world");
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
    }
}
