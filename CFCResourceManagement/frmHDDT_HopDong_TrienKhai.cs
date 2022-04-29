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
    public partial class frmHDDT_HopDong_TrienKhai : Form
    {
        DataTable _oDataSource;
        public frmHDDT_HopDong_TrienKhai()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        void LoadDataSource()
        {
            SqlHelper sqlHelper = new SqlHelper();
            var sSelectQry = string.Empty;

            try
            {
                sSelectQry = "  SELECT * FROM Hd_trienKhai_hddt";
                _oDataSource = sqlHelper.GetData(sSelectQry);
                clsLog.logger_INFO("Get data sucessful");
            }
            catch (Exception ex)
            {

                clsLog.logger_ERROR(ex.Message);
            }

        }

        private void frmHDDT_HopDong_TrienKhai_Load(object sender, EventArgs e)
        {
            LoadDataSource();
            dataGridView1.DataSource = _oDataSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmHDDT_HopDong_TrienKhai_add oAddRow = new frmHDDT_HopDong_TrienKhai_add();
            oAddRow.Show();
        }
    }
}
