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
    public partial class frmDoiTac_add : Form
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public frmDoiTac_add()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string GeneratorPartnerID()
        {
            var s = string.Empty;

            SqlHelper sqlHelper = new SqlHelper("cnn");
            int max = (int)sqlHelper.ExecScalar("select count(*) from doi_tac");
            s = "NCC" + max.ToString();

            int isExist = (int)sqlHelper.ExecScalar("select count(*) from doi_tac where ma_doi_tac='" + s + "'");
            if (isExist == 0)
            {
                return s;
            }
            else
            {
                max++;
                s = "NCC" + max.ToString();
                return s;
            }


        }
        private void btnGetXML_Click(object sender, EventArgs e)
        {
            DataSet oXML = new DataSet();


            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetEnvironmentVariable("%USERPROFILE%\\Documents");
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    oXML.ReadXml(filePath);

                    txtTen.Text = oXML.Tables["NBAN"].Rows[0]["Ten"].ToString();
                    txtMST.Text = oXML.Tables["NBAN"].Rows[0]["MST"].ToString();
                    txtDChi.Text = oXML.Tables["NBAN"].Rows[0]["DChi"].ToString();
                    txtDienThoai.Text = oXML.Tables["NBAN"].Rows[0]["SDThoai"].ToString();
                    txtEmail.Text = oXML.Tables["NBAN"].Rows[0]["DCTDTu"].ToString();
                    txtTKNganHang.Text = oXML.Tables["NBAN"].Rows[0]["STKNHang"].ToString();
                    txtNganHang.Text = oXML.Tables["NBAN"].Rows[0]["TNHang"].ToString();
                }
            }
            txtMa_DTac.Text = GeneratorPartnerID();

        }
        private bool IsNameValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (txtChuTich.Text.Length > 0);
        }
        private void txtChuTich_Validated(object sender, EventArgs e)
        {
            if (IsNameValid())
            {
                // Clear the error, if any, in the error provider.
                errChuTich.SetError(this.txtChuTich, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                errChuTich.SetError(this.txtChuTich, "Name is required.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sInsertQuery = string.Empty;
            try
            {
                sInsertQuery = " INSERT INTO doi_tac([ma_doi_tac]";
                sInsertQuery += ",[ten_cong_ty]";
                sInsertQuery += ",[ten_cong_ty_EN]";
                sInsertQuery += ",[ma_so_thue]";
                sInsertQuery += ",[dia_chi]";
                sInsertQuery += ",[e_mail]";
                sInsertQuery += ",[chu_tich]";
                sInsertQuery += ",[chuc_danh]";
                sInsertQuery += ",[nguoi_dai_dien]";
                sInsertQuery += ",[chucDanh_dai_dien]";
                sInsertQuery += ",[ngan_hang]";
                sInsertQuery += ",[tk_ngan_hang]";
                sInsertQuery += ",[ngay_tao]";
                sInsertQuery += ",[ngay_capNhat]";
                sInsertQuery += ",[dien_thoai]) VALUES (";
                sInsertQuery += "'" + txtMa_DTac.Text + "'";
                sInsertQuery += ",N'" + txtTen.Text + "'";
                sInsertQuery += ",N'" + string.Empty + "'";
                sInsertQuery += ",N'" + txtMST.Text + "'";
                sInsertQuery += ",N'" + txtDChi.Text + "'";
                sInsertQuery += ",N'" + txtEmail.Text + "'";
                sInsertQuery += ",N'" + txtChuTich.Text + "'";
                sInsertQuery += ",N'" + txtChucDanh.Text + "'";
                sInsertQuery += ",N'" + this.txtSalePerson.Text + "'";
                sInsertQuery += ",N'" + txtCDanhSale.Text + "'";
                sInsertQuery += ",N'" + txtNganHang.Text + "'";
                sInsertQuery += ",N'" + txtTKNganHang.Text + "'";
                sInsertQuery += ",'" + DateTime.Now.ToString("yyyyMMdd hh:mm:ss") + "'";
                sInsertQuery += ",'" + DateTime.Now.ToString("yyyyMMdd hh:mm:ss") + "'";
                sInsertQuery += ",N'" + txtDienThoai.Text + "')";

                SqlHelper oSqlHelper = new SqlHelper("cnn");
                oSqlHelper.ExecNonQuery(sInsertQuery);
                MessageBox.Show("The record has inserted.", "Add records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               MessageBox.Show("There is issue. Open log file to read technical information about the issue.", "Add records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Debug(ex, "error");
               
            }


            //INSERT INTO[dbo].[doi_tac]
            //     
            //           (<ma_doi_tac, nvarchar(50),>
            //           ,<ten_cong_ty, nvarchar(250),>
            //           ,<ten_cong_ty_EN, nvarchar(250),>
            //           ,<ma_so_thue, nvarchar(50),>
            //           ,<dia_chi, nvarchar(250),>
            //           ,<e_mail, nvarchar(250),>
            //           ,<chu_tich, nvarchar(250),>
            //           ,<chuc_danh, nvarchar(250),>
            //           ,<nguoi_dai_dien, nvarchar(250),>
            //           ,<chucDanh_dai_dien, nvarchar(250),>
            //           ,<ngan_hang, nvarchar(250),>
            //           ,<tk_ngan_hang, nvarchar(250),>
            //           ,<ngay_tao, datetime,>
            //           ,<ngay_capNhat, datetime,>
            //           ,<dien_thoai, nvarchar(100),>)



        }
    }
}
