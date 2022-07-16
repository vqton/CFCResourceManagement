using System;
using System.Data;
using System.Windows.Forms;

namespace CFCResourceManagement
{
    public partial class frmCoopFoodTrucThuoc_Update : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        string _sDataType = "";
        public frmCoopFoodTrucThuoc_Update()
        {
            InitializeComponent();
            this.Text = "Danh sách Co.opFood trực thuộc - Updating";

        }
        void LoadData()
        {
            SqlHelper sqlHelper = new SqlHelper("cnn");
            var dtColumnsOfTable = new DataTable();
            dtColumnsOfTable = sqlHelper.GetData(String.Format("{0} '{1}' ", "exec uspGetColumnNames", "cf_truc_thuoc"));

            dtColumnsOfTable.Columns.Add("Value", typeof(String));
            dgvFields.DataSource = dtColumnsOfTable;
            dgvFields.Columns[0].ReadOnly = true;
            dgvFields.Columns[1].ReadOnly = true;
            dgvFields.Columns[2].ReadOnly = true;
            dgvFields.Focus();
            dgvFields.CurrentCell = dgvFields[3, 0];
        }
        private void frmCoopFoodTrucThuoc_Update_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvFields_CellLeave(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvFields_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _sDataType = dgvFields.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
                var sValue = dgvFields.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (_sDataType)
                {
                    case "nvarchar":
                        dgvFields.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        dgvFields.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = String.Format("N'{0}'", sValue);
                        break;
                    case "varchar":
                        dgvFields.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        dgvFields.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = String.Format("'{0}'", sValue);
                        break;
                    default:
                        break;
                }

                dgvFields.Refresh();


            }
            catch (Exception ex)
            {
Logger.Debug(ex, "Error");
                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dgvRow in dgvFields.Rows)
            {
                if (dgvRow.Cells[3].Value != null && dgvRow.Cells[3].Value.ToString() != "")
                {
                    SqlHelper sqlHelper = new SqlHelper("cnn");

                    var sQuery = String.Format("UPDATE CF_TRUC_THUOC SET UPDATETIME = GETDATE(),{0}={1}",
                        dgvRow.Cells[1].Value.ToString(), dgvRow.Cells[3].Value.ToString());
                    sqlHelper.ExecNonQuery(sQuery);

                }
            }

        }
    }
}
