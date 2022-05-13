using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Serilog;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFCResourceManagement
{
    public partial class frmCoopFoodTrucThuoc : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        DataTable _oDataSource;
        public frmCoopFoodTrucThuoc()
        {
            
            InitializeComponent();
            this.Text = "Danh sách Co.opFood trực thuộc";
        }
        void c1()
        {
            dgvStores.AllowUserToOrderColumns = true;
            dgvStores.AllowUserToResizeColumns = true;

            dgvStores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvStores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvStores.AutoResizeColumns(dgvStores.AutoSizeColumnsMode);
        }
        private void frmCoopFoodTrucThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataSource();
                this.dgvStores.DataSource = _oDataSource;
                FillDataCmbFielName();



                lblRecords.Text = "Stores :" + _oDataSource.Rows.Count.ToString("N0");

            }
            catch (Exception ex)
            {

                
            }

        }
        void FillDataCmbFielName()
        {

            for (int i = 0; i < _oDataSource.Columns.Count; i++)
            {
                var sValue = String.Format("{0}-{1}", i.ToString(), _oDataSource.Columns[i].ColumnName);
                txtFieldName.Items.Add(sValue);

            }
            txtFieldName.SelectedIndex = 0;

        }
        void LoadDataSource()
        {

            try
            {
                SqlHelper sqlHelper = new SqlHelper("cnn");
                _oDataSource = sqlHelper.GetData("SELECT * FROM CF_TRUC_THUOC");
            }
            catch (Exception ex)
            {

                Logger.Debug(ex, "error");
            }

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtGiaTri.Text;
            dgvStores.ClearSelection();
            dgvStores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var i = Convert.ToInt16(txtFieldName.Text.Split('-')[0]);

            try
            {
                foreach (DataGridViewRow row in dgvStores.Rows)
                {
                    if (row.Cells[i].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        dgvStores.FirstDisplayedScrollingRowIndex = row.Index;
                        dgvStores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                        dgvStores.CurrentCell = dgvStores[0, row.Index];
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                
            }
        }

        private void dgvStores_MouseDown(object sender, MouseEventArgs e)
        {
            c1();
        }

        private void dgvStores_MouseUp(object sender, MouseEventArgs e)
        {
            c1();
        }

        private void dgvStores_MouseMove(object sender, MouseEventArgs e)
        {
            c1();
        }

        private void dgvStores_Scroll(object sender, ScrollEventArgs e)
        {
            c1();
        }

        private void txtGiaTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }


        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            dgvStores.SelectAll();
            DataObject dataObj = dgvStores.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            clsExcel oXlsx = new clsExcel(dataObj);
            oXlsx.ExportExcel();
            dgvStores.ClearSelection();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCoopFoodTrucThuoc_Update oFrmUpdate = new frmCoopFoodTrucThuoc_Update();
            oFrmUpdate.Show();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {


            openFileDialog1.Filter = "Excel|*.xls;*.xlsx;";
            var dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.Abort)
                return;
            if (dr == DialogResult.Cancel)
                return;

            var sExcelPath = openFileDialog1.FileName.ToString();

            clsExcel o = new clsExcel(sExcelPath);
            var isSucessful = o.ImportExcel();

            if (isSucessful)
            {
                MessageBox.Show("The " + sExcelPath + "  has been imported.");
                var sPath = sExcelPath.Replace(Path.GetFileName(sExcelPath), "");
                System.IO.File.Move(sExcelPath, Path.Combine(sPath, Path.GetFileNameWithoutExtension(sExcelPath) + "_imported.xlsx"));
                LoadDataSource();
            }

        }

        private void btnDelay_Click(object sender, EventArgs e)
        {
            var sMaCH = string.Empty;
            var sQueryUpd = string.Empty;


            sMaCH = dgvStores.CurrentRow.Cells[0].Value.ToString();
            try
            {
                SqlHelper oSqlHelper = new SqlHelper("cnn");
                sQueryUpd = String.Format("UPDATE cf_truc_thuoc SET NGAYKT_CT = '9999/12/31', updatetime=GETDATE() WHERE MACH='{0}'", sMaCH);
                oSqlHelper.ExecNonQuery(sQueryUpd);
                LoadDataSource();
                dgvStores.DataSource = _oDataSource;
                MessageBox.Show(String.Format("The store {0} has been delay opening.", sMaCH), "Delay Opening", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "error");
            }

        }

        private void btnCloseStore_Click(object sender, EventArgs e)
        {
            var sMaCH = string.Empty;
            var sQueryUpd = string.Empty;


            sMaCH = dgvStores.CurrentRow.Cells[0].Value.ToString();
            try
            {
                SqlHelper oSqlHelper = new SqlHelper("cnn");
                sQueryUpd = String.Format("UPDATE cf_truc_thuoc SET NgayDongCua = Getdate(),hoatdong=0, ktslbh=0, updatetime=GETDATE() WHERE MACH='{0}'", sMaCH);
                oSqlHelper.ExecNonQuery(sQueryUpd);
                LoadDataSource();
                dgvStores.DataSource = _oDataSource;
                MessageBox.Show(String.Format("The store {0} has been close.", sMaCH), "Close store", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "error");
            }
        }
    }
}
