using Microsoft.Extensions.Logging;
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

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        Dictionary<string, string> dctUpdFields = new Dictionary<string, string>();

        public frmHDDT_HopDong_TrienKhai()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            
        }

        public void LoadDataSource()
        {
            SqlHelper sqlHelper = new SqlHelper("cnn");
            var sSelectQry = string.Empty;

            try
            {
                sSelectQry = "  SELECT * FROM Hd_trienKhai_hddt";
                _oDataSource = sqlHelper.GetData(sSelectQry);
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.Message);
            }

        }

        private void frmHDDT_HopDong_TrienKhai_Load(object sender, EventArgs e)
        {
            LoadDataSource();
            dataGridView1.DataSource = _oDataSource;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                    SqlHelper oSql = new SqlHelper("cnn");
                    sQuery = String.Format("DELETE FROM Hd_trienKhai_hddt WHERE so_hd ='{0}'", sSoHopDong);
                    oSql.ExecNonQuery(sQuery);
                    LoadDataSource();
                    dataGridView1.DataSource = _oDataSource;
                }
                catch (Exception ex)
                {

                    Logger.Info(ex.Message);
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

                Logger.Debug(ex, "error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var sMaHD = string.Empty;
            var sQuery = string.Empty;
            var s = "";

            
            try
            {

                sMaHD = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SqlHelper oSql = new SqlHelper("cnn");
                
                    foreach (KeyValuePair<string, string> item in dctUpdFields)
                    {
                        sQuery = String.Format("UPDATE 1Hd_trienKhai_hddt SET {0}='{1}', ngay_capNhat=GetDate() WHERE so_hd = '{2}'", item.Key, item.Value, sMaHD);
                    oSql.ExecNonQuery(sQuery);

                    }
                Clipboard.SetText(sQuery);
                MessageBox.Show(sQuery);
            }
            catch (Exception ex)
            {

                Logger.Debug(ex, "error");

            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var updValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            var sFieldName = dataGridView1.Columns[e.ColumnIndex].HeaderText;

            dctUpdFields.Add(sFieldName, updValue);


        }
    }
}
