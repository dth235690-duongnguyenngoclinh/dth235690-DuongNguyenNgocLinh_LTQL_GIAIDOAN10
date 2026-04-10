namespace QL_Diem.Forms
{
    partial class fThongTinChiTiet
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
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtLoaiTaiKhoan = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtMatKhau
            // 
            txtMatKhau.Enabled = false;
            txtMatKhau.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.Location = new Point(17, 106);
            txtMatKhau.MaxLength = 255;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(225, 27);
            txtMatKhau.TabIndex = 5;
            txtMatKhau.Text = "**********";
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Enabled = false;
            txtTenDangNhap.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDangNhap.Location = new Point(17, 34);
            txtTenDangNhap.MaxLength = 255;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(225, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 84);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 6;
            label2.Text = "Tên đăng nhập:";
            // 
            // txtLoaiTaiKhoan
            // 
            txtLoaiTaiKhoan.Enabled = false;
            txtLoaiTaiKhoan.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoaiTaiKhoan.Location = new Point(17, 186);
            txtLoaiTaiKhoan.MaxLength = 255;
            txtLoaiTaiKhoan.Name = "txtLoaiTaiKhoan";
            txtLoaiTaiKhoan.Size = new Size(225, 27);
            txtLoaiTaiKhoan.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 164);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 10;
            label1.Text = "Loại tài khoản:";
            // 
            // fThongTinChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 243);
            Controls.Add(txtLoaiTaiKhoan);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fThongTinChiTiet";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "fThongTinChiTiet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private TextBox txtLoaiTaiKhoan;
        private Label label1;
    }
}