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
            MaHocSinh = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            MaMon = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            KTThuongXuyen1 = new DataGridViewTextBoxColumn();
            KTThuongXuyen2 = new DataGridViewTextBoxColumn();
            KTThuongXuyen3 = new DataGridViewTextBoxColumn();
            DiemGiuaKy = new DataGridViewTextBoxColumn();
            DiemCuoiKy = new DataGridViewTextBoxColumn();
            HocKy = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            DanhGia = new DataGridViewTextBoxColumn();
            NhanXet = new DataGridViewTextBoxColumn();
            NgayCapNhat = new DataGridViewTextBoxColumn();
            IsLock = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label10 = new Label();
            label7 = new Label();
            txtMaHocSinh = new TextBox();
            label3 = new Label();
            txtMaMon = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txtTenMon = new TextBox();
            btnIn = new Button();
            txtDiemCuoiKy = new TextBox();
            label16 = new Label();
            txtDiemGiuaKy = new TextBox();
            label15 = new Label();
            txtKTThuongXuyen3 = new TextBox();
            label14 = new Label();
            txtKTThuongXuyen2 = new TextBox();
            label13 = new Label();
            txtKTThuongXuyen1 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtTenLop = new TextBox();
            label9 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            cmbHocKy = new ComboBox();
            cmbDanhGia = new ComboBox();
            dtpkNgayCapNhat = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            txtNhanXet = new TextBox();
            dtpkNamHoc = new DateTimePicker();
            label6 = new Label();
            btnKhoa = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLDiem).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvQLDiem);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(1372, 444);
            panel2.TabIndex = 3;
            // 
            // dgvQLDiem
            // 
            dgvQLDiem.AllowUserToAddRows = false;
            dgvQLDiem.AllowUserToDeleteRows = false;
            dgvQLDiem.ColumnHeadersHeight = 29;
            dgvQLDiem.Columns.AddRange(new DataGridViewColumn[] { ID, MaHocSinh, HoTen, TenLop, MaMon, TenMon, KTThuongXuyen1, KTThuongXuyen2, KTThuongXuyen3, DiemGiuaKy, DiemCuoiKy, HocKy, NamHoc, DanhGia, NhanXet, NgayCapNhat, IsLock });
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
            dgvQLDiem.Size = new Size(1372, 444);
            dgvQLDiem.TabIndex = 3;
            dgvQLDiem.TabStop = false;
            dgvQLDiem.CellClick += dgvQLDiem_CellClick;
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
            // MaHocSinh
            // 
            MaHocSinh.DataPropertyName = "MaHocSinh";
            MaHocSinh.HeaderText = "MÃ HỌC SINH";
            MaHocSinh.MinimumWidth = 6;
            MaHocSinh.Name = "MaHocSinh";
            MaHocSinh.ReadOnly = true;
            MaHocSinh.Width = 125;
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "TÊN HỌC SINH";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 175;
            // 
            // TenLop
            // 
            TenLop.DataPropertyName = "TenLop";
            TenLop.HeaderText = "LỚP";
            TenLop.MinimumWidth = 6;
            TenLop.Name = "TenLop";
            TenLop.ReadOnly = true;
            TenLop.Width = 90;
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
            // TenMon
            // 
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "TÊN MÔN";
            TenMon.MinimumWidth = 6;
            TenMon.Name = "TenMon";
            TenMon.ReadOnly = true;
            TenMon.Width = 125;
            // 
            // KTThuongXuyen1
            // 
            KTThuongXuyen1.DataPropertyName = "KTThuongXuyen1";
            KTThuongXuyen1.HeaderText = "THƯỜNG XUYÊN 1 (10%)";
            KTThuongXuyen1.MinimumWidth = 6;
            KTThuongXuyen1.Name = "KTThuongXuyen1";
            KTThuongXuyen1.ReadOnly = true;
            KTThuongXuyen1.Width = 175;
            // 
            // KTThuongXuyen2
            // 
            KTThuongXuyen2.DataPropertyName = "KTThuongXuyen2";
            KTThuongXuyen2.HeaderText = "THƯỜNG XUYÊN 2 (10%)";
            KTThuongXuyen2.MinimumWidth = 6;
            KTThuongXuyen2.Name = "KTThuongXuyen2";
            KTThuongXuyen2.ReadOnly = true;
            KTThuongXuyen2.Width = 175;
            // 
            // KTThuongXuyen3
            // 
            KTThuongXuyen3.DataPropertyName = "KTThuongXuyen3";
            KTThuongXuyen3.HeaderText = "THƯỜNG XUYÊN 3 (10%)";
            KTThuongXuyen3.MinimumWidth = 6;
            KTThuongXuyen3.Name = "KTThuongXuyen3";
            KTThuongXuyen3.ReadOnly = true;
            KTThuongXuyen3.Width = 175;
            // 
            // DiemGiuaKy
            // 
            DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            DiemGiuaKy.HeaderText = "ĐIỂM GIỮA KỲ";
            DiemGiuaKy.MinimumWidth = 6;
            DiemGiuaKy.Name = "DiemGiuaKy";
            DiemGiuaKy.ReadOnly = true;
            DiemGiuaKy.Width = 170;
            // 
            // DiemCuoiKy
            // 
            DiemCuoiKy.DataPropertyName = "DiemCuoiKy";
            DiemCuoiKy.HeaderText = "ĐIỂM CUỐI KỲ";
            DiemCuoiKy.MinimumWidth = 6;
            DiemCuoiKy.Name = "DiemCuoiKy";
            DiemCuoiKy.ReadOnly = true;
            DiemCuoiKy.Width = 175;
            // 
            // HocKy
            // 
            HocKy.DataPropertyName = "HocKy";
            HocKy.HeaderText = "HỌC KỲ";
            HocKy.MinimumWidth = 6;
            HocKy.Name = "HocKy";
            HocKy.ReadOnly = true;
            HocKy.Width = 90;
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
            DanhGia.Width = 170;
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
            // IsLock
            // 
            IsLock.DataPropertyName = "IsLock";
            IsLock.HeaderText = "IsLock";
            IsLock.MinimumWidth = 6;
            IsLock.Name = "IsLock";
            IsLock.ReadOnly = true;
            IsLock.Width = 125;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10.2F);
            btnThoat.Location = new Point(644, 179);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(83, 34);
            btnThoat.TabIndex = 19;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 10.2F);
            btnLamMoi.Location = new Point(734, 179);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(97, 34);
            btnLamMoi.TabIndex = 20;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 10.2F);
            btnXoa.Location = new Point(554, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 34);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 10.2F);
            btnSua.Location = new Point(464, 179);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 34);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 10.2F);
            btnThem.Location = new Point(374, 179);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 34);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F);
            label10.Location = new Point(810, 128);
            label10.Name = "label10";
            label10.Size = new Size(97, 19);
            label10.TabIndex = 45;
            label10.Text = "ĐÁNH GIÁ: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F);
            label7.Location = new Point(23, 128);
            label7.Name = "label7";
            label7.Size = new Size(95, 19);
            label7.TabIndex = 39;
            label7.Text = "NHẬN XÉT:";
            // 
            // txtMaHocSinh
            // 
            txtMaHocSinh.Font = new Font("Times New Roman", 10.2F);
            txtMaHocSinh.Location = new Point(224, 24);
            txtMaHocSinh.Name = "txtMaHocSinh";
            txtMaHocSinh.Size = new Size(93, 27);
            txtMaHocSinh.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(144, 28);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 26;
            label3.Text = "MÃ HS:";
            // 
            // txtMaMon
            // 
            txtMaMon.Font = new Font("Times New Roman", 10.2F);
            txtMaMon.Location = new Point(940, 24);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(93, 27);
            txtMaMon.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(841, 28);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 23;
            label2.Text = "MÃ MÔN:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Times New Roman", 10.2F);
            txtID.Location = new Point(60, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(66, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 20;
            label1.Text = "ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKhoa);
            panel1.Controls.Add(txtTenMon);
            panel1.Controls.Add(btnIn);
            panel1.Controls.Add(txtDiemCuoiKy);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(txtDiemGiuaKy);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtKTThuongXuyen3);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtKTThuongXuyen2);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtKTThuongXuyen1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtTenLop);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbHocKy);
            panel1.Controls.Add(cmbDanhGia);
            panel1.Controls.Add(dtpkNgayCapNhat);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNhanXet);
            panel1.Controls.Add(dtpkNamHoc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label10);
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
            panel1.Size = new Size(1372, 224);
            panel1.TabIndex = 2;
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Times New Roman", 10.2F);
            txtTenMon.Location = new Point(1133, 25);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(186, 27);
            txtTenMon.TabIndex = 75;
            // 
            // btnIn
            // 
            btnIn.Font = new Font("Times New Roman", 10.2F);
            btnIn.Location = new Point(841, 179);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(83, 34);
            btnIn.TabIndex = 74;
            btnIn.Text = "IN";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // txtDiemCuoiKy
            // 
            txtDiemCuoiKy.Location = new Point(850, 75);
            txtDiemCuoiKy.MaxLength = 255;
            txtDiemCuoiKy.Name = "txtDiemCuoiKy";
            txtDiemCuoiKy.Size = new Size(74, 27);
            txtDiemCuoiKy.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(716, 79);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(127, 19);
            label16.TabIndex = 73;
            label16.Text = "ĐIỂM CUỐI KỲ:";
            // 
            // txtDiemGiuaKy
            // 
            txtDiemGiuaKy.Location = new Point(631, 75);
            txtDiemGiuaKy.MaxLength = 255;
            txtDiemGiuaKy.Name = "txtDiemGiuaKy";
            txtDiemGiuaKy.Size = new Size(74, 27);
            txtDiemGiuaKy.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(497, 79);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(127, 19);
            label15.TabIndex = 71;
            label15.Text = "ĐIỂM GIỮA KỲ:";
            // 
            // txtKTThuongXuyen3
            // 
            txtKTThuongXuyen3.Location = new Point(405, 75);
            txtKTThuongXuyen3.MaxLength = 255;
            txtKTThuongXuyen3.Name = "txtKTThuongXuyen3";
            txtKTThuongXuyen3.Size = new Size(74, 27);
            txtKTThuongXuyen3.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(333, 79);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(65, 19);
            label14.TabIndex = 69;
            label14.Text = "KTTX3:";
            // 
            // txtKTThuongXuyen2
            // 
            txtKTThuongXuyen2.Location = new Point(252, 75);
            txtKTThuongXuyen2.MaxLength = 255;
            txtKTThuongXuyen2.Name = "txtKTThuongXuyen2";
            txtKTThuongXuyen2.Size = new Size(74, 27);
            txtKTThuongXuyen2.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(180, 79);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(65, 19);
            label13.TabIndex = 67;
            label13.Text = "KTTX2:";
            // 
            // txtKTThuongXuyen1
            // 
            txtKTThuongXuyen1.Location = new Point(94, 75);
            txtKTThuongXuyen1.MaxLength = 255;
            txtKTThuongXuyen1.Name = "txtKTThuongXuyen1";
            txtKTThuongXuyen1.Size = new Size(74, 27);
            txtKTThuongXuyen1.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 79);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(65, 19);
            label12.TabIndex = 65;
            label12.Text = "KTTX1:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F);
            label11.Location = new Point(1039, 28);
            label11.Name = "label11";
            label11.Size = new Size(88, 19);
            label11.TabIndex = 62;
            label11.Text = "TÊN MÔN:";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(756, 24);
            txtTenLop.MaxLength = 255;
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(74, 27);
            txtTenLop.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(668, 28);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 19);
            label9.TabIndex = 60;
            label9.Text = "TÊN LỚP:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Times New Roman", 10.2F);
            txtHoTen.Location = new Point(407, 24);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(254, 27);
            txtHoTen.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.Location = new Point(331, 28);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 58;
            label4.Text = "TÊN HS:";
            // 
            // cmbHocKy
            // 
            cmbHocKy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHocKy.FormattingEnabled = true;
            cmbHocKy.Items.AddRange(new object[] { "I", "II" });
            cmbHocKy.Location = new Point(1031, 75);
            cmbHocKy.Name = "cmbHocKy";
            cmbHocKy.Size = new Size(73, 27);
            cmbHocKy.TabIndex = 11;
            // 
            // cmbDanhGia
            // 
            cmbDanhGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDanhGia.FormattingEnabled = true;
            cmbDanhGia.Items.AddRange(new object[] { "HOÀN THÀNH TỐT", "HOÀN THÀNH", "CHƯA HOÀN THÀNH", "KÉM" });
            cmbDanhGia.Location = new Point(908, 124);
            cmbDanhGia.Name = "cmbDanhGia";
            cmbDanhGia.Size = new Size(148, 27);
            cmbDanhGia.TabIndex = 14;
            // 
            // dtpkNgayCapNhat
            // 
            dtpkNgayCapNhat.Format = DateTimePickerFormat.Short;
            dtpkNgayCapNhat.Location = new Point(1211, 124);
            dtpkNgayCapNhat.Name = "dtpkNgayCapNhat";
            dtpkNgayCapNhat.Size = new Size(110, 27);
            dtpkNgayCapNhat.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1063, 128);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(141, 19);
            label8.TabIndex = 55;
            label8.Text = "NGÀY CẬP NHẬT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(939, 79);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 53;
            label5.Text = "HỌC KỲ:";
            // 
            // txtNhanXet
            // 
            txtNhanXet.Font = new Font("Times New Roman", 10.2F);
            txtNhanXet.Location = new Point(124, 124);
            txtNhanXet.Name = "txtNhanXet";
            txtNhanXet.Size = new Size(677, 27);
            txtNhanXet.TabIndex = 13;
            // 
            // dtpkNamHoc
            // 
            dtpkNamHoc.Format = DateTimePickerFormat.Short;
            dtpkNamHoc.Location = new Point(1209, 75);
            dtpkNamHoc.Name = "dtpkNamHoc";
            dtpkNamHoc.Size = new Size(110, 27);
            dtpkNamHoc.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1111, 79);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 19);
            label6.TabIndex = 51;
            label6.Text = "NĂM HỌC:";
            // 
            // btnKhoa
            // 
            btnKhoa.Font = new Font("Times New Roman", 10.2F);
            btnKhoa.Location = new Point(932, 179);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.Size = new Size(83, 34);
            btnKhoa.TabIndex = 76;
            btnKhoa.Text = "Khóa";
            btnKhoa.UseVisualStyleBackColor = true;
            btnKhoa.Click += btnKhoa_Click;
            // 
            // fQLDiem
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 668);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label10;
        private Label label7;
        private TextBox txtMaHocSinh;
        private Label label3;
        private TextBox txtMaMon;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dtpkNamHoc;
        private Label label6;
        private Label label5;
        private TextBox txtNhanXet;
        private DateTimePicker dtpkNgayCapNhat;
        private Label label8;
        private ComboBox cmbDanhGia;
        private ComboBox cmbHocKy;
        private TextBox txtHoTen;
        private Label label4;
        private TextBox txtTenLop;
        private Label label9;
        private Label label11;
        private TextBox txtKTThuongXuyen3;
        private TextBox txtKTThuongXuyen2;
        private Label label12;
        private TextBox textBox2;
        private Label label14;
        private Label label13;
        private TextBox txtKTThuongXuyen1;
        private TextBox txtDiemCuoiKy;
        private Label label16;
        private TextBox txtDiemGiuaKy;
        private Label label15;
        private Button btnIn;
        private TextBox txtTenMon;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaHocSinh;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn KTThuongXuyen1;
        private DataGridViewTextBoxColumn KTThuongXuyen2;
        private DataGridViewTextBoxColumn KTThuongXuyen3;
        private DataGridViewTextBoxColumn DiemGiuaKy;
        private DataGridViewTextBoxColumn DiemCuoiKy;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn DanhGia;
        private DataGridViewTextBoxColumn NhanXet;
        private DataGridViewTextBoxColumn NgayCapNhat;
        private DataGridViewTextBoxColumn IsLock;
        private Button btnKhoa;
    }
}