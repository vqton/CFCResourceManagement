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
    }
}
