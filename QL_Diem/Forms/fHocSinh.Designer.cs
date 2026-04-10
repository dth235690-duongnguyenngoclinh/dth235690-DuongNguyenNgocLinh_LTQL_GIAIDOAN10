namespace QL_Diem.Forms
{
    partial class fHocSinh
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
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýLớpToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMônToolStripMenuItem = new ToolStripMenuItem();
            qUaToolStripMenuItem = new ToolStripMenuItem();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinChiTiếtToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button1 = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dtpkNamHoc = new DateTimePicker();
            label10 = new Label();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            label9 = new Label();
            dtpkNgaySinh = new DateTimePicker();
            label8 = new Label();
            txtLopHoc = new TextBox();
            label7 = new Label();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtSoDienThoaiPhuHuynh = new TextBox();
            label5 = new Label();
            txtGiaoVien = new TextBox();
            label4 = new Label();
            txtTHoTen = new TextBox();
            label3 = new Label();
            txtMaHocSinh = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvHocSinh = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaHocSinh = new DataGridViewTextBoxColumn();
            TenHocSinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            LopHoc = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            SoDienThoaiPhuHuynh = new DataGridViewTextBoxColumn();
            GiaoVien = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1067, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýLớpToolStripMenuItem, quảnLýMônToolStripMenuItem, qUaToolStripMenuItem, quảnLýTàiKhoảnToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(86, 26);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýLớpToolStripMenuItem
            // 
            quảnLýLớpToolStripMenuItem.Name = "quảnLýLớpToolStripMenuItem";
            quảnLýLớpToolStripMenuItem.Size = new Size(232, 26);
            quảnLýLớpToolStripMenuItem.Text = "Quản lý lớp";
            quảnLýLớpToolStripMenuItem.Click += quảnLýLớpToolStripMenuItem_Click;
            // 
            // quảnLýMônToolStripMenuItem
            // 
            quảnLýMônToolStripMenuItem.Name = "quảnLýMônToolStripMenuItem";
            quảnLýMônToolStripMenuItem.Size = new Size(232, 26);
            quảnLýMônToolStripMenuItem.Text = "Quản lý môn";
            quảnLýMônToolStripMenuItem.Click += quảnLýMônToolStripMenuItem_Click;
            // 
            // qUaToolStripMenuItem
            // 
            qUaToolStripMenuItem.Name = "qUaToolStripMenuItem";
            qUaToolStripMenuItem.Size = new Size(232, 26);
            qUaToolStripMenuItem.Text = "Quản lý điểm";
            qUaToolStripMenuItem.Click += qUaToolStripMenuItem_Click;
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(232, 26);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinChiTiếtToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(102, 26);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinChiTiếtToolStripMenuItem
            // 
            thôngTinChiTiếtToolStripMenuItem.Name = "thôngTinChiTiếtToolStripMenuItem";
            thôngTinChiTiếtToolStripMenuItem.Size = new Size(227, 26);
            thôngTinChiTiếtToolStripMenuItem.Text = "Thông tin chi tiết";
            thôngTinChiTiếtToolStripMenuItem.Click += thôngTinChiTiếtToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(227, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(227, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(dtpkNamHoc);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(rdNu);
            panel1.Controls.Add(rdNam);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dtpkNgaySinh);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtLopHoc);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSoDienThoaiPhuHuynh);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtGiaoVien);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTHoTen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaHocSinh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 164);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.2F);
            button1.Location = new Point(850, 109);
            button1.Name = "button1";
            button1.Size = new Size(74, 30);
            button1.TabIndex = 14;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 10.2F);
            btnLamMoi.Location = new Point(930, 109);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 30);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 10.2F);
            btnXoa.Location = new Point(770, 109);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 30);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 10.2F);
            btnSua.Location = new Point(690, 109);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 30);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 10.2F);
            btnThem.Location = new Point(610, 109);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 30);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpkNamHoc
            // 
            dtpkNamHoc.Font = new Font("Times New Roman", 10.2F);
            dtpkNamHoc.Format = DateTimePickerFormat.Short;
            dtpkNamHoc.Location = new Point(947, 16);
            dtpkNamHoc.Name = "dtpkNamHoc";
            dtpkNamHoc.Size = new Size(105, 27);
            dtpkNamHoc.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F);
            label10.Location = new Point(850, 20);
            label10.Name = "label10";
            label10.Size = new Size(91, 19);
            label10.TabIndex = 19;
            label10.Text = "NĂM HỌC:";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Font = new Font("Times New Roman", 10.2F);
            rdNu.Location = new Point(178, 62);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(51, 23);
            rdNu.TabIndex = 6;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Checked = true;
            rdNam.Font = new Font("Times New Roman", 10.2F);
            rdNam.Location = new Point(110, 62);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 23);
            rdNam.TabIndex = 5;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F);
            label9.Location = new Point(14, 64);
            label9.Name = "label9";
            label9.Size = new Size(90, 19);
            label9.TabIndex = 16;
            label9.Text = "GIỚI TÍNH:";
            // 
            // dtpkNgaySinh
            // 
            dtpkNgaySinh.Font = new Font("Times New Roman", 10.2F);
            dtpkNgaySinh.Format = DateTimePickerFormat.Short;
            dtpkNgaySinh.Location = new Point(739, 16);
            dtpkNgaySinh.Name = "dtpkNgaySinh";
            dtpkNgaySinh.Size = new Size(105, 27);
            dtpkNgaySinh.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F);
            label8.Location = new Point(635, 20);
            label8.Name = "label8";
            label8.Size = new Size(101, 19);
            label8.TabIndex = 14;
            label8.Text = "NGÀY SINH:";
            // 
            // txtLopHoc
            // 
            txtLopHoc.Font = new Font("Times New Roman", 10.2F);
            txtLopHoc.Location = new Point(670, 60);
            txtLopHoc.Name = "txtLopHoc";
            txtLopHoc.Size = new Size(66, 27);
            txtLopHoc.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F);
            label7.Location = new Point(618, 64);
            label7.Name = "label7";
            label7.Size = new Size(46, 19);
            label7.TabIndex = 12;
            label7.Text = "LỚP:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Times New Roman", 10.2F);
            txtDiaChi.Location = new Point(93, 105);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(473, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F);
            label6.Location = new Point(14, 109);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 10;
            label6.Text = "ĐỊA CHỈ:";
            // 
            // txtSoDienThoaiPhuHuynh
            // 
            txtSoDienThoaiPhuHuynh.Font = new Font("Times New Roman", 10.2F);
            txtSoDienThoaiPhuHuynh.Location = new Point(893, 60);
            txtSoDienThoaiPhuHuynh.Name = "txtSoDienThoaiPhuHuynh";
            txtSoDienThoaiPhuHuynh.Size = new Size(150, 27);
            txtSoDienThoaiPhuHuynh.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F);
            label5.Location = new Point(742, 64);
            label5.Name = "label5";
            label5.Size = new Size(145, 19);
            label5.TabIndex = 8;
            label5.Text = "SĐT PHỤ HUYNH:";
            // 
            // txtGiaoVien
            // 
            txtGiaoVien.Font = new Font("Times New Roman", 10.2F);
            txtGiaoVien.Location = new Point(337, 60);
            txtGiaoVien.Name = "txtGiaoVien";
            txtGiaoVien.Size = new Size(275, 27);
            txtGiaoVien.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.Location = new Point(235, 64);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 6;
            label4.Text = "GIÁO VIÊN:";
            // 
            // txtTHoTen
            // 
            txtTHoTen.Font = new Font("Times New Roman", 10.2F);
            txtTHoTen.Location = new Point(347, 16);
            txtTHoTen.Name = "txtTHoTen";
            txtTHoTen.Size = new Size(282, 27);
            txtTHoTen.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(278, 20);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 4;
            label3.Text = "TÊN HS:";
            // 
            // txtMaHocSinh
            // 
            txtMaHocSinh.Font = new Font("Times New Roman", 10.2F);
            txtMaHocSinh.Location = new Point(176, 16);
            txtMaHocSinh.Name = "txtMaHocSinh";
            txtMaHocSinh.Size = new Size(96, 27);
            txtMaHocSinh.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(112, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 2;
            label2.Text = "MÃ HS:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Times New Roman", 10.2F);
            txtID.Location = new Point(45, 16);
            txtID.Name = "txtID";
            txtID.Size = new Size(59, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHocSinh);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(1067, 339);
            panel2.TabIndex = 2;
            // 
            // dgvHocSinh
            // 
            dgvHocSinh.AllowUserToAddRows = false;
            dgvHocSinh.AllowUserToDeleteRows = false;
            dgvHocSinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHocSinh.Columns.AddRange(new DataGridViewColumn[] { ID, MaHocSinh, TenHocSinh, GioiTinh, LopHoc, NgaySinh, DiaChi, NamHoc, SoDienThoaiPhuHuynh, GiaoVien });
            dgvHocSinh.Dock = DockStyle.Fill;
            dgvHocSinh.Location = new Point(0, 0);
            dgvHocSinh.MultiSelect = false;
            dgvHocSinh.Name = "dgvHocSinh";
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.RowHeadersVisible = false;
            dgvHocSinh.RowHeadersWidth = 51;
            dgvHocSinh.RowTemplate.Height = 30;
            dgvHocSinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHocSinh.Size = new Size(1067, 339);
            dgvHocSinh.TabIndex = 0;
            dgvHocSinh.TabStop = false;
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
            MaHocSinh.Width = 150;
            // 
            // TenHocSinh
            // 
            TenHocSinh.DataPropertyName = "TenHocSinh";
            TenHocSinh.HeaderText = "TÊN HỌC SINH";
            TenHocSinh.MinimumWidth = 6;
            TenHocSinh.Name = "TenHocSinh";
            TenHocSinh.ReadOnly = true;
            TenHocSinh.Width = 250;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "GIỚI TÍNH";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 125;
            // 
            // LopHoc
            // 
            LopHoc.DataPropertyName = "LopHoc";
            LopHoc.HeaderText = "LỚP";
            LopHoc.MinimumWidth = 6;
            LopHoc.Name = "LopHoc";
            LopHoc.ReadOnly = true;
            LopHoc.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "NGÀY SINH";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            NgaySinh.Width = 170;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "ĐỊA CHỈ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 400;
            // 
            // NamHoc
            // 
            NamHoc.DataPropertyName = "NamHoc";
            NamHoc.HeaderText = "NĂM HỌC";
            NamHoc.MinimumWidth = 6;
            NamHoc.Name = "NamHoc";
            NamHoc.ReadOnly = true;
            NamHoc.Width = 170;
            // 
            // SoDienThoaiPhuHuynh
            // 
            SoDienThoaiPhuHuynh.DataPropertyName = "SoDienThoaiPhuHuynh";
            SoDienThoaiPhuHuynh.HeaderText = "SĐT PHỤ HUYNH";
            SoDienThoaiPhuHuynh.MinimumWidth = 6;
            SoDienThoaiPhuHuynh.Name = "SoDienThoaiPhuHuynh";
            SoDienThoaiPhuHuynh.ReadOnly = true;
            SoDienThoaiPhuHuynh.Width = 200;
            // 
            // GiaoVien
            // 
            GiaoVien.DataPropertyName = "GiaoVien";
            GiaoVien.HeaderText = "GIÁO VIÊN CHỦ NHIỆM";
            GiaoVien.MinimumWidth = 6;
            GiaoVien.Name = "GiaoVien";
            GiaoVien.ReadOnly = true;
            GiaoVien.Width = 300;
            // 
            // fHocSinh
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "fHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fHocSinh";
            Load += fHocSinh_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHocSinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýLớpToolStripMenuItem;
        private ToolStripMenuItem quảnLýMônToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem qUaToolStripMenuItem;
        private ToolStripMenuItem thôngTinChiTiếtToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvHocSinh;
        private TextBox txtLopHoc;
        private Label label7;
        private TextBox txtDiaChi;
        private Label label6;
        private TextBox txtSoDienThoaiPhuHuynh;
        private Label label5;
        private TextBox txtGiaoVien;
        private Label label4;
        private TextBox txtTHoTen;
        private Label label3;
        private TextBox txtMaHocSinh;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private DateTimePicker dtpkNgaySinh;
        private Label label8;
        private Label label9;
        private DateTimePicker dtpkNamHoc;
        private Label label10;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private Button button1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaHocSinh;
        private DataGridViewTextBoxColumn TenHocSinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn LopHoc;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn SoDienThoaiPhuHuynh;
        private DataGridViewTextBoxColumn GiaoVien;
    }
}