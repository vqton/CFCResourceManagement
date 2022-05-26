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
    public partial class frmTheoDoiBaoTri : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        DataTable _dt = new DataTable();
        int _iSLgCuaHang;
        decimal _GiaTri;

        public frmTheoDoiBaoTri()
        {
            InitializeComponent();
        }

        private void frmTheoDoiBaoTri_Load(object sender, EventArgs e)
        {
            txtNgay.Text = DateTime.Today.ToString("dd/MM/yyyy");
            LoadDataSource();
            this.WindowState = FormWindowState.Maximized;
        }

        void LoadDataSource()
        {
            var sQuery = string.Empty;
            var sSQLDATE = txtNgay.Text.Split('/');
                        sQuery = String.Format("EXEC usp_TheoDoiBaoTri '{0}'", sSQLDATE[2] + sSQLDATE[1] + sSQLDATE[0]);
            Logger.Info(sQuery);

            try
            {
                var oSQL = new SqlHelper("cnn");
                _dt = oSQL.GetData(sQuery);
                dataGridView1.DataSource = _dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                _iSLgCuaHang = _dt.AsEnumerable().Count();
                _GiaTri = _dt.AsEnumerable().Sum(x=>x.Field<decimal>("GiaTri"));
                this.toolStripStatusLabel1.Text = String.Format("Cửa hàng: {0}", _iSLgCuaHang.ToString("N0"));
                this.toolStripStatusLabel2.Text = String.Format("Tổng tiền: {0}", _GiaTri.ToString("N0"));
                Logger.Info(sQuery);
            }
            catch (Exception ex)
            {
                Logger.Debug(ex, "Error");
                
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadDataSource();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            this.toolStripStatusLabel1.Text = String.Format("Cửa hàng: {0}", _iSLgCuaHang.ToString("N0"));


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";

                try
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    Logger.Debug(ex, ex.Message);
                    //MessageBox.Show(ex.Message);
                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex) {
                Logger.Debug(ex, ex.Message);
            }
        }
    }
}
