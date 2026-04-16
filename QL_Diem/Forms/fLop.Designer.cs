namespace QL_Diem.Forms
{
    partial class fLop
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
            panel1 = new Panel();
            chbDaKetThuc = new CheckBox();
            txtPhongHoc = new TextBox();
            label8 = new Label();
            txtKhoiLop = new TextBox();
            label7 = new Label();
            txtNamHoc = new TextBox();
            label6 = new Label();
            cmbGiaoVienChuNhiem = new ComboBox();
            label5 = new Label();
            numSoLuong = new NumericUpDown();
            label4 = new Label();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenLop = new TextBox();
            label3 = new Label();
            txtMaLop = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvLop = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaLop = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            KhoiLop = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaoVienChuNhiem = new DataGridViewTextBoxColumn();
            PhongHoc = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            DaKetThuc = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chbDaKetThuc);
            panel1.Controls.Add(txtPhongHoc);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtKhoiLop);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtNamHoc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbGiaoVienChuNhiem);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numSoLuong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenLop);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaLop);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 167);
            panel1.TabIndex = 0;
            // 
            // chbDaKetThuc
            // 
            chbDaKetThuc.AutoSize = true;
            chbDaKetThuc.Location = new Point(585, 81);
            chbDaKetThuc.Name = "chbDaKetThuc";
            chbDaKetThuc.Size = new Size(89, 23);
            chbDaKetThuc.TabIndex = 7;
            chbDaKetThuc.Text = "Kết thúc";
            chbDaKetThuc.UseVisualStyleBackColor = true;
            // 
            // txtPhongHoc
            // 
            txtPhongHoc.Location = new Point(131, 119);
            txtPhongHoc.MaxLength = 255;
            txtPhongHoc.Name = "txtPhongHoc";
            txtPhongHoc.Size = new Size(60, 27);
            txtPhongHoc.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 123);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 27;
            label8.Text = "PHÒNG HỌC:";
            // 
            // txtKhoiLop
            // 
            txtKhoiLop.Location = new Point(111, 76);
            txtKhoiLop.MaxLength = 255;
            txtKhoiLop.Name = "txtKhoiLop";
            txtKhoiLop.Size = new Size(60, 27);
            txtKhoiLop.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 79);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 19);
            label7.TabIndex = 25;
            label7.Text = "KHỐI LỚP:";
            // 
            // txtNamHoc
            // 
            txtNamHoc.Location = new Point(447, 79);
            txtNamHoc.MaxLength = 255;
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(132, 27);
            txtNamHoc.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(349, 83);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 23;
            label6.Text = "NĂM HỌC:";
            // 
            // cmbGiaoVienChuNhiem
            // 
            cmbGiaoVienChuNhiem.FormattingEnabled = true;
            cmbGiaoVienChuNhiem.Items.AddRange(new object[] { "Đặng Thanh Hiếu", "Bùi Ngọc Hoa", "Thanh Thanh Tăng", "Lương Kim Tuyền", "Huỳnh Trung Kiên", "Dương Ngọc Nga", "Thái Thanh Ngân", "Nguyễn Minh Ngọc", "Bùi Minh Kha", "Doãn Ngọc Tân", "Lê Minh Hiếu", "Huỳnh Thanh Nhẹ\t", "Trần Ba Vạn", "Phạm Hồng Thái", "Phạm Thị Cẩm Hồng", "Nguyễn Bích Châu", "Huỳnh Thị Yến Nhi", "Nguyễn Minh Trực", "Trần Thị Bích Thủy", "Lý Minh Kha" });
            cmbGiaoVienChuNhiem.Location = new Point(491, 32);
            cmbGiaoVienChuNhiem.Name = "cmbGiaoVienChuNhiem";
            cmbGiaoVienChuNhiem.Size = new Size(181, 27);
            cmbGiaoVienChuNhiem.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 22;
            label5.Text = "GVCN:";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(293, 79);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(49, 27);
            numSoLuong.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 83);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 19;
            label4.Text = "SỐ LƯỢNG:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10.2F);
            btnThoat.Location = new Point(447, 117);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 30);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 10.2F);
            btnLamMoi.Location = new Point(527, 117);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 30);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 10.2F);
            btnXoa.Location = new Point(367, 117);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 30);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 10.2F);
            btnSua.Location = new Point(287, 117);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 30);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 10.2F);
            btnThem.Location = new Point(207, 117);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 30);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(349, 32);
            txtTenLop.MaxLength = 255;
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(74, 27);
            txtTenLop.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 36);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 15;
            label3.Text = "TÊN LỚP:";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(178, 32);
            txtMaLop.MaxLength = 255;
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(76, 27);
            txtMaLop.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 12;
            label2.Text = "MÃ LỚP:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(48, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(38, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvLop);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 329);
            panel2.TabIndex = 1;
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AllowUserToDeleteRows = false;
            dgvLop.ColumnHeadersHeight = 29;
            dgvLop.Columns.AddRange(new DataGridViewColumn[] { ID, MaLop, TenLop, KhoiLop, SoLuong, GiaoVienChuNhiem, PhongHoc, NamHoc, DaKetThuc });
            dgvLop.Dock = DockStyle.Fill;
            dgvLop.Location = new Point(0, 0);
            dgvLop.Margin = new Padding(4);
            dgvLop.MultiSelect = false;
            dgvLop.Name = "dgvLop";
            dgvLop.ReadOnly = true;
            dgvLop.RowHeadersVisible = false;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.RowTemplate.Height = 30;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(680, 329);
            dgvLop.TabIndex = 2;
            dgvLop.TabStop = false;
            dgvLop.CellClick += dgvLop_CellClick;
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
            // MaLop
            // 
            MaLop.DataPropertyName = "MaLop";
            MaLop.HeaderText = "MÃ LỚP";
            MaLop.MinimumWidth = 6;
            MaLop.Name = "MaLop";
            MaLop.ReadOnly = true;
            MaLop.Width = 140;
            // 
            // TenLop
            // 
            TenLop.DataPropertyName = "TenLop";
            TenLop.HeaderText = "TÊN LỚP";
            TenLop.MinimumWidth = 6;
            TenLop.Name = "TenLop";
            TenLop.ReadOnly = true;
            TenLop.Width = 130;
            // 
            // KhoiLop
            // 
            KhoiLop.DataPropertyName = "KhoiLop";
            KhoiLop.HeaderText = "KHỐI LỚP";
            KhoiLop.MinimumWidth = 6;
            KhoiLop.Name = "KhoiLop";
            KhoiLop.ReadOnly = true;
            KhoiLop.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "SỐ LƯỢNG";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 130;
            // 
            // GiaoVienChuNhiem
            // 
            GiaoVienChuNhiem.DataPropertyName = "GiaoVienChuNhiem";
            GiaoVienChuNhiem.HeaderText = "GIÁO VIÊN CHỦ NHIỆM";
            GiaoVienChuNhiem.MinimumWidth = 6;
            GiaoVienChuNhiem.Name = "GiaoVienChuNhiem";
            GiaoVienChuNhiem.ReadOnly = true;
            GiaoVienChuNhiem.Width = 300;
            // 
            // PhongHoc
            // 
            PhongHoc.DataPropertyName = "PhongHoc";
            PhongHoc.HeaderText = "PHÒNG HỌC";
            PhongHoc.MinimumWidth = 6;
            PhongHoc.Name = "PhongHoc";
            PhongHoc.ReadOnly = true;
            PhongHoc.Width = 125;
            // 
            // NamHoc
            // 
            NamHoc.DataPropertyName = "NamHoc";
            NamHoc.HeaderText = "NĂM HỌC";
            NamHoc.MinimumWidth = 6;
            NamHoc.Name = "NamHoc";
            NamHoc.ReadOnly = true;
            NamHoc.Width = 150;
            // 
            // DaKetThuc
            // 
            DaKetThuc.DataPropertyName = "DaKetThuc";
            DaKetThuc.HeaderText = "ĐÃ KẾT THÚC";
            DaKetThuc.MinimumWidth = 6;
            DaKetThuc.Name = "DaKetThuc";
            DaKetThuc.ReadOnly = true;
            DaKetThuc.Width = 125;
            // 
            // fLop
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 496);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "fLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fLop";
            Load += fLop_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvLop;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenLop;
        private Label label3;
        private TextBox txtMaLop;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Label label4;
        private Label label5;
        private ComboBox cmbGiaoVienChuNhiem;
        private Label label6;
        private TextBox txtNamHoc;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn KhoiLop;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaoVienChuNhiem;
        private DataGridViewTextBoxColumn PhongHoc;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn DaKetThuc;
        private TextBox txtPhongHoc;
        private Label label8;
        private TextBox txtKhoiLop;
        private Label label7;
        private CheckBox chbDaKetThuc;
    }
}