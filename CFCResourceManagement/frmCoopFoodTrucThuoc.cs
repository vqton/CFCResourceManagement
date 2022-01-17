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
    public partial class frmCoopFoodTrucThuoc : Form
    {
        public frmCoopFoodTrucThuoc()
        {
            InitializeComponent();
        }

        private void frmCoopFoodTrucThuoc_Load(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper();
            
            dgvStores.DataSource =  sqlHelper.ExecReader("SELECT * FROM cf_TRUC_THUOC");
        }
    }
}
