namespace CFCResourceManagement
{
    partial class frmHDDT_HopDong_TrienKhai_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiKy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMucDich = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPTThanhToan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNgayhD = new System.Windows.Forms.DateTimePicker();
            this.txtLoaiHD = new System.Windows.Forms.ComboBox();
            this.txtChucDanh = new System.Windows.Forms.ComboBox();
            this.txtDoiTac = new System.Windows.Forms.ComboBox();
            this.txtLoaiTien = new System.Windows.Forms.ComboBox();
            this.txtDVT_TGian = new System.Windows.Forms.ComboBox();
            this.errSoHD = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNguoiKy = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPTThanhToan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNoiDung = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMucDich = new System.Windows.Forms.ErrorProvider(this.components);
            this.errThoiHan = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errSoHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNguoiKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPTThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMucDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errThoiHan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(262, 350);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số hợp đồng";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(156, 12);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(310, 20);
            this.txtSoHD.TabIndex = 0;
            this.txtSoHD.TextChanged += new System.EventHandler(this.txtSoHD_TextChanged);
            this.txtSoHD.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoHD_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày hợp đồng";
            // 
            // txtNguoiKy
            // 
            this.txtNguoiKy.Location = new System.Drawing.Point(156, 84);
            this.txtNguoiKy.Name = "txtNguoiKy";
            this.txtNguoiKy.Size = new System.Drawing.Size(310, 20);
            this.txtNguoiKy.TabIndex = 3;
            this.txtNguoiKy.Validating += new System.ComponentModel.CancelEventHandler(this.txtNguoiKy_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Người ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chức danh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đối tác";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(156, 156);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(310, 20);
            this.txtNoiDung.TabIndex = 6;
            this.txtNoiDung.Validating += new System.ComponentModel.CancelEventHandler(this.txtNoiDung_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nội dung";
            // 
            // txtMucDich
            // 
            this.txtMucDich.Location = new System.Drawing.Point(156, 180);
            this.txtMucDich.Name = "txtMucDich";
            this.txtMucDich.Size = new System.Drawing.Size(310, 20);
            this.txtMucDich.TabIndex = 7;
            this.txtMucDich.Validating += new System.ComponentModel.CancelEventHandler(this.txtMucDich_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mục đích";
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Location = new System.Drawing.Point(156, 204);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(310, 20);
            this.txtThoiHan.TabIndex = 8;
            this.txtThoiHan.Validating += new System.ComponentModel.CancelEventHandler(this.txtThoiHan_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Thời hạn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Đơn vị";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(156, 252);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(310, 20);
            this.txtGiaTri.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Giá trị";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Loại tiền";
            // 
            // txtPTThanhToan
            // 
            this.txtPTThanhToan.Location = new System.Drawing.Point(156, 300);
            this.txtPTThanhToan.Name = "txtPTThanhToan";
            this.txtPTThanhToan.Size = new System.Drawing.Size(310, 20);
            this.txtPTThanhToan.TabIndex = 12;
            this.txtPTThanhToan.Validating += new System.ComponentModel.CancelEventHandler(this.textBox13_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 304);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "P.thức thanh toán";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(156, 324);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(310, 20);
            this.textBox14.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cloud path";
            // 
            // txtNgayhD
            // 
            this.txtNgayhD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayhD.Location = new System.Drawing.Point(156, 60);
            this.txtNgayhD.Name = "txtNgayhD";
            this.txtNgayhD.Size = new System.Drawing.Size(200, 20);
            this.txtNgayhD.TabIndex = 2;
            // 
            // txtLoaiHD
            // 
            this.txtLoaiHD.FormattingEnabled = true;
            this.txtLoaiHD.Items.AddRange(new object[] {
            "Hợp đồng",
            "Phụ lục hợp đồng"});
            this.txtLoaiHD.Location = new System.Drawing.Point(156, 35);
            this.txtLoaiHD.Name = "txtLoaiHD";
            this.txtLoaiHD.Size = new System.Drawing.Size(121, 21);
            this.txtLoaiHD.TabIndex = 1;
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.FormattingEnabled = true;
            this.txtChucDanh.Items.AddRange(new object[] {
            "Giám đốc",
            "Phó Tổng Giám đốc",
            "Tổng Giám đốc"});
            this.txtChucDanh.Location = new System.Drawing.Point(156, 108);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Size = new System.Drawing.Size(121, 21);
            this.txtChucDanh.TabIndex = 4;
            // 
            // txtDoiTac
            // 
            this.txtDoiTac.FormattingEnabled = true;
            this.txtDoiTac.Location = new System.Drawing.Point(156, 132);
            this.txtDoiTac.Name = "txtDoiTac";
            this.txtDoiTac.Size = new System.Drawing.Size(121, 21);
            this.txtDoiTac.TabIndex = 5;
            // 
            // txtLoaiTien
            // 
            this.txtLoaiTien.FormattingEnabled = true;
            this.txtLoaiTien.Items.AddRange(new object[] {
            "VND",
            "USD"});
            this.txtLoaiTien.Location = new System.Drawing.Point(156, 276);
            this.txtLoaiTien.Name = "txtLoaiTien";
            this.txtLoaiTien.Size = new System.Drawing.Size(121, 21);
            this.txtLoaiTien.TabIndex = 11;
            // 
            // txtDVT_TGian
            // 
            this.txtDVT_TGian.FormattingEnabled = true;
            this.txtDVT_TGian.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.txtDVT_TGian.Location = new System.Drawing.Point(156, 228);
            this.txtDVT_TGian.Name = "txtDVT_TGian";
            this.txtDVT_TGian.Size = new System.Drawing.Size(121, 21);
            this.txtDVT_TGian.TabIndex = 9;
            // 
            // errSoHD
            // 
            this.errSoHD.ContainerControl = this;
            // 
            // errNguoiKy
            // 
            this.errNguoiKy.ContainerControl = this;
            // 
            // errPTThanhToan
            // 
            this.errPTThanhToan.ContainerControl = this;
            // 
            // errNoiDung
            // 
            this.errNoiDung.ContainerControl = this;
            // 
            // errMucDich
            // 
            this.errMucDich.ContainerControl = this;
            // 
            // errThoiHan
            // 
            this.errThoiHan.ContainerControl = this;
            // 
            // frmHDDT_HopDong_TrienKhai_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 379);
            this.Controls.Add(this.txtDVT_TGian);
            this.Controls.Add(this.txtLoaiTien);
            this.Controls.Add(this.txtDoiTac);
            this.Controls.Add(this.txtChucDanh);
            this.Controls.Add(this.txtLoaiHD);
            this.Controls.Add(this.txtNgayhD);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPTThanhToan);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtThoiHan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMucDich);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNguoiKy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmHDDT_HopDong_TrienKhai_add";
            this.Text = "frmHDDT_HopDong_TrienKhai_add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHDDT_HopDong_TrienKhai_add_FormClosing);
            this.Load += new System.EventHandler(this.frmHDDT_HopDong_TrienKhai_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errSoHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNguoiKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPTThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMucDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errThoiHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMucDich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPTThanhToan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker txtNgayhD;
        private System.Windows.Forms.ComboBox txtLoaiHD;
        private System.Windows.Forms.ComboBox txtChucDanh;
        private System.Windows.Forms.ComboBox txtDoiTac;
        private System.Windows.Forms.ComboBox txtLoaiTien;
        private System.Windows.Forms.ComboBox txtDVT_TGian;
        private System.Windows.Forms.ErrorProvider errSoHD;
        private System.Windows.Forms.ErrorProvider errNguoiKy;
        private System.Windows.Forms.ErrorProvider errPTThanhToan;
        private System.Windows.Forms.ErrorProvider errNoiDung;
        private System.Windows.Forms.ErrorProvider errMucDich;
        private System.Windows.Forms.ErrorProvider errThoiHan;
    }
}