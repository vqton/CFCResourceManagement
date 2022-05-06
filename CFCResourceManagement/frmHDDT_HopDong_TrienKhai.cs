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

        public void LoadDataSource()
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
            frmHDDT_HopDong_TrienKhai_add oAddRow = new frmHDDT_HopDong_TrienKhai_add(this);
            oAddRow.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var sSoHopDong = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var msg = String.Format("Do you want remove the {0}?", sSoHopDong);
            DialogResult oResult = MessageBox.Show(msg, "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var sQuery = string.Empty;

            if (oResult == DialogResult.Yes)

            {
                try
                {
                    SqlHelper oSql = new SqlHelper();
                    sQuery = String.Format("DELETE FROM Hd_trienKhai_hddt WHERE so_hd ='{0}'", sSoHopDong);
                    oSql.ExecNonQuery(sQuery);
                    LoadDataSource();
                    dataGridView1.DataSource = _oDataSource;
                }
                catch (Exception ex)
                {

                    clsLog.logger_ERROR(ex.Message);
                }

            }
        }

        private void frmHDDT_HopDong_TrienKhai_Enter(object sender, EventArgs e)
        {
            LoadDataSource();
            dataGridView1.DataSource = _oDataSource;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectAll();
                DataObject dataObj = dataGridView1.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);

                clsExcel oXlsx = new clsExcel(dataObj);
                oXlsx.ExportExcel();
                dataGridView1.ClearSelection();
                MessageBox.Show("Exported data to Excel file successfully.", "Exporting data Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                clsLog.logger_ERROR(ex.Message);
            }
        }
    }
}
