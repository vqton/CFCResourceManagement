using System;
using System.IO;
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
    public partial class frmDoiTac : Form
    {
        DataTable _dtSource;
        public frmDoiTac()
        {
            InitializeComponent();
        }

        void GetData()
        {
            SqlHelper sqlHelper = new SqlHelper();
            _dtSource = new DataTable();
            _dtSource = sqlHelper.GetData("SELECT * FROM doi_tac");
            dataGridView1.DataSource = _dtSource;
        }

        private void frmDoiTac_Load(object sender, EventArgs e)
        {
            GetData();
            this.WindowState = FormWindowState.Maximized;
            dataGridView1.AutoResizeColumns();
        }

        private void btnExportXLSX_Click(object sender, EventArgs e)
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

        private void btnXMLContact_Click(object sender, EventArgs e)
        {
            frmDoiTac_add doiTac_Add = new frmDoiTac_add();
            doiTac_Add.Show();


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var sMaDTac = string.Empty;
            sMaDTac = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {
                var result = MessageBox.Show("Do you want remove " + sMaDTac + " ?", "Deleting record",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

                // If the no button was pressed ... 
                if (result == DialogResult.Yes)
                {
                    SqlHelper sqlHelper = new SqlHelper();
                    sqlHelper.ExecNonQuery(String.Format("DELETE FROM doi_tac WHERE ma_doi_tac = '{0}'", sMaDTac));
                    GetData();
                }
               
            }
            catch (Exception ex)
            {

                clsLog.logger_ERROR(ex.Message);
            }
        }
    }
}
