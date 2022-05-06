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
    public partial class frmHDDT_HopDong_TrienKhai_add : Form
    {
        DataTable _dtDoitac;
        frmHDDT_HopDong_TrienKhai _HopDong_TrienKhai;
        public frmHDDT_HopDong_TrienKhai_add(frmHDDT_HopDong_TrienKhai HopDong_TrienKhai)
        {
            InitializeComponent();
            _HopDong_TrienKhai = HopDong_TrienKhai;
        }

        private void frmHDDT_HopDong_TrienKhai_add_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
            txtSoHD.Focus();
        }

        void SetDefaultValues()
        {
            txtChucDanh.SelectedIndex = 0;
            txtLoaiHD.SelectedIndex = 0;
            txtLoaiTien.SelectedIndex = 0;
            txtDVT_TGian.SelectedIndex = 0;
            txtPTThanhToan.Text = "30 (ba mươi) ngày làm việc kể từ ngày nhận đầy đủ hồ sơ thanh toán hợp lệ.";
            GetMaDoiTac();
            if (_dtDoitac != null)
            {
                foreach (DataRow item in _dtDoitac.Rows)
                {
                    txtDoiTac.Items.Add(item[0].ToString());
                }

                txtDoiTac.SelectedIndex = 0;

            }
        }

        void GetMaDoiTac()
        {

            var sSelectQuery = string.Empty;
            _dtDoitac = new DataTable();
            try
            {

                SqlHelper oSqlHelper = new SqlHelper();
                sSelectQuery = "SELECT ma_doi_tac, ten_cong_ty from doi_tac";

                _dtDoitac = oSqlHelper.GetData(sSelectQuery);
            }
            catch (Exception ex)
            {

                clsLog.logger_ERROR(ex.Message);
            }




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSoHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoHD_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatingFunctions.NotEmpty(txtSoHD.Text))
            {
                e.Cancel = true;
                txtSoHD.Focus();
                errSoHD.SetError(txtSoHD, "Contract id should not be left blank!");
            }
            e.Cancel = false;



        }

        private void txtNguoiKy_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatingFunctions.NotEmpty(txtNguoiKy.Text))
            {
                e.Cancel = true;
                txtNguoiKy.Focus();
                errNguoiKy.SetError(txtNguoiKy, "Contract id should not be left blank!");
            }
            {
                e.Cancel = false;
                errNguoiKy.SetError(txtNguoiKy, string.Empty);
            }


        }

        private void txtNoiDung_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatingFunctions.NotEmpty(txtNoiDung.Text))
            {
                e.Cancel = true;
                txtNoiDung.Focus();
                errNoiDung.SetError(txtNoiDung, "Contract id should not be left blank!");
            }
            {
                e.Cancel = false;
                errNoiDung.SetError(txtNoiDung, string.Empty);
            }
        }

        private void txtMucDich_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatingFunctions.NotEmpty(txtMucDich.Text))
            {
                e.Cancel = true;
                txtMucDich.Focus();
                errMucDich.SetError(txtMucDich, "Contract id should not be left blank!");
            }
            {
                e.Cancel = false;
                errMucDich.SetError(txtMucDich, string.Empty);
            }
        }

        private void txtThoiHan_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatingFunctions.NotEmpty(txtThoiHan.Text))
            {
                e.Cancel = true;
                txtThoiHan.Focus();
                errThoiHan.SetError(txtThoiHan, "Input!");
            }
            var isDigit = clsValidatingFunctions.IsDigit(txtThoiHan.Text);


            if (!isDigit)
            {
                e.Cancel = true;
                txtThoiHan.Focus();
                errThoiHan.SetError(txtThoiHan, "Numeric only");
            }
            else
            {
                e.Cancel = false;
                errThoiHan.SetError(txtThoiHan, string.Empty);
            }
        }

        private void textBox13_Validating(object sender, CancelEventArgs e)
        {

            if (!clsValidatingFunctions.NotEmpty(txtPTThanhToan.Text))
            {
                e.Cancel = true;
                txtPTThanhToan.Focus();
                errPTThanhToan.SetError(txtPTThanhToan, "Contract id should not be left blank!");
            }
            {
                e.Cancel = false;
                errPTThanhToan.SetError(txtPTThanhToan, string.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sQuery = string.Empty;


            try
            {
                sQuery = "EXEC usp_Hd_trienKhai_hddt_add";

                sQuery += " '" + txtSoHD.Text + "'";
                //sQuery += ",'" + txtSoHD.Text + "'";
                sQuery += ",N'" + txtLoaiHD.Text + "'";
                sQuery += ",'" + txtNgayhD.Value.ToString("yyyyMMdd") + "'";
                sQuery += ",N'" + txtNguoiKy.Text + "'";
                sQuery += ",'" + txtDoiTac.Text + "'";
                sQuery += ",N'" + txtChucDanh.Text + "'";
                sQuery += ",N'" + txtNoiDung.Text + "'";
                sQuery += ",N'" + txtMucDich.Text + "'";
                sQuery += "," + txtThoiHan.Text + "";
                sQuery += ",N'" + txtDVT_TGian.Text + "'";
                sQuery += "," + txtGiaTri.Text + "";
                sQuery += ",N'" + txtLoaiTien.Text + "'";
                sQuery += ",N'" + txtPTThanhToan.Text + "'";
                sQuery += ",'" + textBox14.Text + "'";
                sQuery += ",'" + DateTime.Today.ToString("yyyyMMdd") + "'";
                sQuery += ",'" + DateTime.Today.ToString("yyyyMMdd") + "'";

                SqlHelper oSqlHelper = new SqlHelper();
                oSqlHelper.ExecNonQuery(sQuery);
                File.AppendAllText(String.Format("logs\\trace_{0}.txt", DateTime.Today.ToString("yyyyMMdd")), sQuery);
                MessageBox.Show("Ok");
                clsLog.logger_INFO(sQuery);
                this.Close();
            }
            catch (Exception ex)
            {
                clsLog.logger_ERROR(ex.Message);
                clsLog.logger_INFO(sQuery);
            }
        }

        private void frmHDDT_HopDong_TrienKhai_add_FormClosing(object sender, FormClosingEventArgs e)
        {
            _HopDong_TrienKhai.LoadDataSource();
        }
    }
}
