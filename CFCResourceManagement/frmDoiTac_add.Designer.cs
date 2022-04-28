namespace CFCResourceManagement
{
    partial class frmDoiTac_add
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMa_DTac = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMST = new System.Windows.Forms.TextBox();
            this.txtNganHang = new System.Windows.Forms.TextBox();
            this.txtTKNganHang = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCDanhSale = new System.Windows.Forms.TextBox();
            this.txtSalePerson = new System.Windows.Forms.TextBox();
            this.txtChucDanh = new System.Windows.Forms.TextBox();
            this.txtChuTich = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGetXML = new System.Windows.Forms.Button();
            this.errChuTich = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errChuTich)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(270, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(351, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã số thuế";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngân hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số TK NHàng";
            // 
            // txtMa_DTac
            // 
            this.txtMa_DTac.Location = new System.Drawing.Point(189, 12);
            this.txtMa_DTac.Name = "txtMa_DTac";
            this.txtMa_DTac.Size = new System.Drawing.Size(286, 20);
            this.txtMa_DTac.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(189, 37);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(286, 20);
            this.txtTen.TabIndex = 10;
            // 
            // txtDChi
            // 
            this.txtDChi.Location = new System.Drawing.Point(189, 62);
            this.txtDChi.Name = "txtDChi";
            this.txtDChi.Size = new System.Drawing.Size(286, 20);
            this.txtDChi.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtMST
            // 
            this.txtMST.Location = new System.Drawing.Point(189, 112);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(286, 20);
            this.txtMST.TabIndex = 13;
            // 
            // txtNganHang
            // 
            this.txtNganHang.Location = new System.Drawing.Point(189, 137);
            this.txtNganHang.Name = "txtNganHang";
            this.txtNganHang.Size = new System.Drawing.Size(286, 20);
            this.txtNganHang.TabIndex = 14;
            // 
            // txtTKNganHang
            // 
            this.txtTKNganHang.Location = new System.Drawing.Point(189, 162);
            this.txtTKNganHang.Name = "txtTKNganHang";
            this.txtTKNganHang.Size = new System.Drawing.Size(286, 20);
            this.txtTKNganHang.TabIndex = 15;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(189, 187);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(286, 20);
            this.txtDienThoai.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Chức danh";
            // 
            // txtCDanhSale
            // 
            this.txtCDanhSale.Location = new System.Drawing.Point(189, 287);
            this.txtCDanhSale.Name = "txtCDanhSale";
            this.txtCDanhSale.Size = new System.Drawing.Size(286, 20);
            this.txtCDanhSale.TabIndex = 24;
            // 
            // txtSalePerson
            // 
            this.txtSalePerson.Location = new System.Drawing.Point(189, 262);
            this.txtSalePerson.Name = "txtSalePerson";
            this.txtSalePerson.Size = new System.Drawing.Size(286, 20);
            this.txtSalePerson.TabIndex = 23;
            // 
            // txtChucDanh
            // 
            this.txtChucDanh.Location = new System.Drawing.Point(189, 237);
            this.txtChucDanh.Name = "txtChucDanh";
            this.txtChucDanh.Size = new System.Drawing.Size(286, 20);
            this.txtChucDanh.TabIndex = 22;
            // 
            // txtChuTich
            // 
            this.txtChuTich.Location = new System.Drawing.Point(189, 212);
            this.txtChuTich.Name = "txtChuTich";
            this.txtChuTich.Size = new System.Drawing.Size(286, 20);
            this.txtChuTich.TabIndex = 21;
            this.txtChuTich.Validated += new System.EventHandler(this.txtChuTich_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Đại diện Sale";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Chức danh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Chủ tịch";
            // 
            // btnGetXML
            // 
            this.btnGetXML.Location = new System.Drawing.Point(189, 313);
            this.btnGetXML.Name = "btnGetXML";
            this.btnGetXML.Size = new System.Drawing.Size(75, 23);
            this.btnGetXML.TabIndex = 26;
            this.btnGetXML.Text = "XML Content";
            this.btnGetXML.UseVisualStyleBackColor = true;
            this.btnGetXML.Click += new System.EventHandler(this.btnGetXML_Click);
            // 
            // errChuTich
            // 
            this.errChuTich.BlinkRate = 1000;
            this.errChuTich.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errChuTich.ContainerControl = this;
            // 
            // frmDoiTac_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 344);
            this.Controls.Add(this.btnGetXML);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCDanhSale);
            this.Controls.Add(this.txtSalePerson);
            this.Controls.Add(this.txtChucDanh);
            this.Controls.Add(this.txtChuTich);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTKNganHang);
            this.Controls.Add(this.txtNganHang);
            this.Controls.Add(this.txtMST);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa_DTac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmDoiTac_add";
            this.Text = "frmDoiTac_add";
            ((System.ComponentModel.ISupportInitialize)(this.errChuTich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMa_DTac;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMST;
        private System.Windows.Forms.TextBox txtNganHang;
        private System.Windows.Forms.TextBox txtTKNganHang;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCDanhSale;
        private System.Windows.Forms.TextBox txtSalePerson;
        private System.Windows.Forms.TextBox txtChucDanh;
        private System.Windows.Forms.TextBox txtChuTich;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGetXML;
        private System.Windows.Forms.ErrorProvider errChuTich;
    }
}