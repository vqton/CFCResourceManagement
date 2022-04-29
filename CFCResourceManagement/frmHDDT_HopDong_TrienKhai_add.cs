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
    public partial class frmHDDT_HopDong_TrienKhai_add : Form
    {
        DataTable _dtDoitac;
        public frmHDDT_HopDong_TrienKhai_add()
        {
            InitializeComponent();
        }

        private void frmHDDT_HopDong_TrienKhai_add_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
        }

        void SetDefaultValues()
        {
            txtChucDanh.SelectedIndex = 0;
            txtLoaiHD.SelectedIndex = 0;
            txtLoaiTien.SelectedIndex = 0;
            txtDVT_TGian.SelectedIndex = 0;

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
                errSoHD.SetError(txtNguoiKy, "Contract id should not be left blank!");
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
                errThoiHan.SetError(txtThoiHan, "Contract id should not be left blank!");
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

            if (!clsValidatingFunctions.NotEmpty(textBox13.Text))
            {
                e.Cancel = true;
                textBox13.Focus();
                errPTThanhToan.SetError(textBox13, "Contract id should not be left blank!");
            }
            {
                e.Cancel = false;
                errPTThanhToan.SetError(textBox13, string.Empty);
            }
        }
    }
}
