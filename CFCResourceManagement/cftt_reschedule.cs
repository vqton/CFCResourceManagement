using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFCResourceManagement
{
    public partial class cftt_reschedule : Form
    {
        string _MaCH = string.Empty;
        public cftt_reschedule(string MaCH)
        {
            InitializeComponent();
            _MaCH = MaCH;
            txtMaCH.Text = _MaCH;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sQuery = string.Empty;
            SqlHelper sqlHelper = new SqlHelper("cnn");
            sQuery = "UPDATE CF_TRUC_THUOC SET NGAYKT_CT = '" + txtNewDate.Value.ToString("yyyyMMdd") + "', updatetime=GETDATE()";
            sQuery += " where MACH = " + txtMaCH.Text;

            try
            {
                sqlHelper.ExecNonQuery(sQuery);
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
