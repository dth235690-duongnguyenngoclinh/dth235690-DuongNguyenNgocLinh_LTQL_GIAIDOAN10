namespace QL_Diem.Forms
{
    partial class fQLDiem
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
            panel2 = new Panel();
            dgvQLDiem = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaMon = new DataGridViewTextBoxColumn();
            MaHocSinh = new DataGridViewTextBoxColumn();
            DiemGiuaKy = new DataGridViewTextBoxColumn();
            DiemCuoiKy = new DataGridViewTextBoxColumn();
            HocKy = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            DanhGia = new DataGridViewTextBoxColumn();
            NhanXet = new DataGridViewTextBoxColumn();
            NgayCapNhat = new DataGridViewTextBoxColumn();
            btnO = new Button();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            txtMaHocSinh = new TextBox();
            label3 = new Label();
            txtMaMon = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            cmbDanhGia = new ComboBox();
            dtpkNgayCapNhat = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            txtNhanXet = new TextBox();
            dtpkNamHoc = new DateTimePicker();
            label6 = new Label();
            txtDiemCuoiKy = new TextBox();
            txtDiemGiuaKy = new TextBox();
            label4 = new Label();
            cmbHocKy = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDiem).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvQLDiem);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(757, 476);
            panel2.TabIndex = 3;
            // 
            // dgvQLDiem
            // 
            dgvQLDiem.AllowUserToAddRows = false;
            dgvQLDiem.AllowUserToDeleteRows = false;
            dgvQLDiem.ColumnHeadersHeight = 29;
            dgvQLDiem.Columns.AddRange(new DataGridViewColumn[] { ID, MaMon, MaHocSinh, DiemGiuaKy, DiemCuoiKy, HocKy, NamHoc, DanhGia, NhanXet, NgayCapNhat });
            dgvQLDiem.Dock = DockStyle.Fill;
            dgvQLDiem.Location = new Point(0, 0);
            dgvQLDiem.Margin = new Padding(4);
            dgvQLDiem.MultiSelect = false;
            dgvQLDiem.Name = "dgvQLDiem";
            dgvQLDiem.ReadOnly = true;
            dgvQLDiem.RowHeadersVisible = false;
            dgvQLDiem.RowHeadersWidth = 51;
            dgvQLDiem.RowTemplate.Height = 30;
            dgvQLDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLDiem.Size = new Size(757, 476);
            dgvQLDiem.TabIndex = 3;
            dgvQLDiem.TabStop = false;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 75;
            // 
            // MaMon
            // 
            MaMon.DataPropertyName = "MaMon";
            MaMon.HeaderText = "MÃ MÔN";
            MaMon.MinimumWidth = 6;
            MaMon.Name = "MaMon";
            MaMon.ReadOnly = true;
            MaMon.Width = 125;
            // 
            // MaHocSinh
            // 
            MaHocSinh.DataPropertyName = "MaHocSinh";
            MaHocSinh.HeaderText = "MÃ HỌC SINH";
            MaHocSinh.MinimumWidth = 6;
            MaHocSinh.Name = "MaHocSinh";
            MaHocSinh.ReadOnly = true;
            MaHocSinh.Width = 125;
            // 
            // DiemGiuaKy
            // 
            DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            DiemGiuaKy.HeaderText = "ĐIỂM GIỮA KỲ";
            DiemGiuaKy.MinimumWidth = 6;
            DiemGiuaKy.Name = "DiemGiuaKy";
            DiemGiuaKy.ReadOnly = true;
            DiemGiuaKy.Width = 150;
            // 
            // DiemCuoiKy
            // 
            DiemCuoiKy.DataPropertyName = "DiemCuoiKy";
            DiemCuoiKy.HeaderText = "ĐIỂM CUỐI KỲ";
            DiemCuoiKy.MinimumWidth = 6;
            DiemCuoiKy.Name = "DiemCuoiKy";
            DiemCuoiKy.ReadOnly = true;
            DiemCuoiKy.Width = 125;
            // 
            // HocKy
            // 
            HocKy.DataPropertyName = "HocKy";
            HocKy.HeaderText = "HỌC KỲ";
            HocKy.MinimumWidth = 6;
            HocKy.Name = "HocKy";
            HocKy.ReadOnly = true;
            HocKy.Width = 125;
            // 
            // NamHoc
            // 
            NamHoc.DataPropertyName = "NamHoc";
            NamHoc.HeaderText = "NĂM HỌC";
            NamHoc.MinimumWidth = 6;
            NamHoc.Name = "NamHoc";
            NamHoc.ReadOnly = true;
            NamHoc.Width = 130;
            // 
            // DanhGia
            // 
            DanhGia.DataPropertyName = "DanhGia";
            DanhGia.HeaderText = "ĐÁNH GIÁ";
            DanhGia.MinimumWidth = 6;
            DanhGia.Name = "DanhGia";
            DanhGia.ReadOnly = true;
            DanhGia.Width = 125;
            // 
            // NhanXet
            // 
            NhanXet.DataPropertyName = "NhanXet";
            NhanXet.HeaderText = "NHẬN XÉT";
            NhanXet.MinimumWidth = 6;
            NhanXet.Name = "NhanXet";
            NhanXet.ReadOnly = true;
            NhanXet.Width = 400;
            // 
            // NgayCapNhat
            // 
            NgayCapNhat.DataPropertyName = "NgayCapNhat";
            NgayCapNhat.HeaderText = "NGÀY CẬP NHẬT";
            NgayCapNhat.MinimumWidth = 6;
            NgayCapNhat.Name = "NgayCapNhat";
            NgayCapNhat.ReadOnly = true;
            NgayCapNhat.Width = 200;
            // 
            // btnO
            // 
            btnO.Location = new Point(566, 155);
            btnO.Name = "btnO";
            btnO.Size = new Size(35, 27);
            btnO.TabIndex = 46;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            btnO.Click += btnO_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10.2F);
            btnThoat.Location = new Point(385, 152);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 30);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 10.2F);
            btnLamMoi.Location = new Point(465, 152);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 30);
            btnLamMoi.TabIndex = 14;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 10.2F);
            btnXoa.Location = new Point(305, 152);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 30);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 10.2F);
            btnSua.Location = new Point(225, 152);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 30);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 10.2F);
            btnThem.Location = new Point(145, 152);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 30);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F);
            label10.Location = new Point(454, 53);
            label10.Name = "label10";
            label10.Size = new Size(97, 19);
            label10.TabIndex = 45;
            label10.Text = "ĐÁNH GIÁ: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F);
            label9.Location = new Point(74, 52);
            label9.Name = "label9";
            label9.Size = new Size(127, 19);
            label9.TabIndex = 44;
            label9.Text = "ĐIỂM GIỮA KỲ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F);
            label7.Location = new Point(12, 122);
            label7.Name = "label7";
            label7.Size = new Size(95, 19);
            label7.TabIndex = 39;
            label7.Text = "NHẬN XÉT:";
            // 
            // txtMaHocSinh
            // 
            txtMaHocSinh.Font = new Font("Times New Roman", 10.2F);
            txtMaHocSinh.Location = new Point(367, 16);
            txtMaHocSinh.Name = "txtMaHocSinh";
            txtMaHocSinh.Size = new Size(103, 27);
            txtMaHocSinh.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(296, 20);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 26;
            label3.Text = "MÃ HS:";
            // 
            // txtMaMon
            // 
            txtMaMon.Font = new Font("Times New Roman", 10.2F);
            txtMaMon.Location = new Point(208, 16);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(83, 27);
            txtMaMon.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(120, 20);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 23;
            label2.Text = "MÃ MÔN:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Times New Roman", 10.2F);
            txtID.Location = new Point(53, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(59, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 20;
            label1.Text = "ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbHocKy);
            panel1.Controls.Add(cmbDanhGia);
            panel1.Controls.Add(dtpkNgayCapNhat);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNhanXet);
            panel1.Controls.Add(dtpkNamHoc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDiemCuoiKy);
            panel1.Controls.Add(txtDiemGiuaKy);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnO);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtMaHocSinh);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaMon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 194);
            panel1.TabIndex = 2;
            // 
            // cmbDanhGia
            // 
            cmbDanhGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDanhGia.FormattingEnabled = true;
            cmbDanhGia.Items.AddRange(new object[] { "HOÀN THÀNH TỐT", "HOÀN THÀNH", "CHƯA HOÀN THÀNH", "KÉM" });
            cmbDanhGia.Location = new Point(566, 52);
            cmbDanhGia.Name = "cmbDanhGia";
            cmbDanhGia.Size = new Size(132, 25);
            cmbDanhGia.TabIndex = 6;
            // 
            // dtpkNgayCapNhat
            // 
            dtpkNgayCapNhat.Format = DateTimePickerFormat.Short;
            dtpkNgayCapNhat.Location = new Point(439, 86);
            dtpkNgayCapNhat.Name = "dtpkNgayCapNhat";
            dtpkNgayCapNhat.Size = new Size(143, 25);
            dtpkNgayCapNhat.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 91);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 17);
            label8.TabIndex = 55;
            label8.Text = "NGÀY CẬP NHẬT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F);
            label5.Location = new Point(301, 52);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 53;
            label5.Text = "HỌC KỲ:";
            // 
            // txtNhanXet
            // 
            txtNhanXet.Font = new Font("Times New Roman", 10.2F);
            txtNhanXet.Location = new Point(120, 119);
            txtNhanXet.Name = "txtNhanXet";
            txtNhanXet.Size = new Size(602, 27);
            txtNhanXet.TabIndex = 9;
            // 
            // dtpkNamHoc
            // 
            dtpkNamHoc.Format = DateTimePickerFormat.Short;
            dtpkNamHoc.Location = new Point(579, 18);
            dtpkNamHoc.Name = "dtpkNamHoc";
            dtpkNamHoc.Size = new Size(143, 25);
            dtpkNamHoc.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(481, 22);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 51;
            label6.Text = "NĂM HỌC:";
            // 
            // txtDiemCuoiKy
            // 
            txtDiemCuoiKy.Font = new Font("Times New Roman", 10.2F);
            txtDiemCuoiKy.Location = new Point(207, 86);
            txtDiemCuoiKy.Name = "txtDiemCuoiKy";
            txtDiemCuoiKy.Size = new Size(78, 27);
            txtDiemCuoiKy.TabIndex = 7;
            // 
            // txtDiemGiuaKy
            // 
            txtDiemGiuaKy.Font = new Font("Times New Roman", 10.2F);
            txtDiemGiuaKy.Location = new Point(207, 49);
            txtDiemGiuaKy.Name = "txtDiemGiuaKy";
            txtDiemGiuaKy.Size = new Size(78, 27);
            txtDiemGiuaKy.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.Location = new Point(74, 89);
            label4.Name = "label4";
            label4.Size = new Size(127, 19);
            label4.TabIndex = 47;
            label4.Text = "ĐIỂM CUỐI KỲ:";
            // 
            // cmbHocKy
            // 
            cmbHocKy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHocKy.FormattingEnabled = true;
            cmbHocKy.Items.AddRange(new object[] { "I", "II" });
            cmbHocKy.Location = new Point(383, 49);
            cmbHocKy.Name = "cmbHocKy";
            cmbHocKy.Size = new Size(65, 25);
            cmbHocKy.TabIndex = 56;
            // 
            // fQLDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 670);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fQLDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fBangDiem";
            Load += fQLDiem_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLDiem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvQLDiem;
        private Button btnO;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label10;
        private Label label9;
        private Label label7;
        private TextBox txtMaHocSinh;
        private Label label3;
        private TextBox txtMaMon;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel panel1;
        private TextBox txtDiemCuoiKy;
        private TextBox txtDiemGiuaKy;
        private Label label4;
        private DateTimePicker dtpkNamHoc;
        private Label label6;
        private Label label5;
        private TextBox txtNhanXet;
        private DateTimePicker dtpkNgayCapNhat;
        private Label label8;
        private ComboBox cmbDanhGia;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn MaHocSinh;
        private DataGridViewTextBoxColumn DiemGiuaKy;
        private DataGridViewTextBoxColumn DiemCuoiKy;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn DanhGia;
        private DataGridViewTextBoxColumn NhanXet;
        private DataGridViewTextBoxColumn NgayCapNhat;
        private ComboBox cmbHocKy;
    }
}