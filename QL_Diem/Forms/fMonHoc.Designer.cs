namespace QL_Diem.Forms
{
    partial class fMonHoc
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
            btnO = new Button();
            cmbLoaiMon = new ComboBox();
            numSoTiet = new NumericUpDown();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label10 = new Label();
            rdTamNgung = new RadioButton();
            rdDangDay = new RadioButton();
            label9 = new Label();
            label8 = new Label();
            txtKhoiLop = new TextBox();
            label7 = new Label();
            txtTenMon = new TextBox();
            label3 = new Label();
            txtMaMon = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvMonHoc = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaMon = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            LoaiMon = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            KhoiLop = new DataGridViewTextBoxColumn();
            SoTiet = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTiet).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnO);
            panel1.Controls.Add(cmbLoaiMon);
            panel1.Controls.Add(numSoTiet);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(rdTamNgung);
            panel1.Controls.Add(rdDangDay);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtKhoiLop);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtTenMon);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtMaMon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 146);
            panel1.TabIndex = 0;
            // 
            // btnO
            // 
            btnO.Location = new Point(127, 98);
            btnO.Name = "btnO";
            btnO.Size = new Size(35, 27);
            btnO.TabIndex = 46;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            btnO.Click += btnO_Click;
            // 
            // cmbLoaiMon
            // 
            cmbLoaiMon.FormattingEnabled = true;
            cmbLoaiMon.ItemHeight = 19;
            cmbLoaiMon.Location = new Point(605, 55);
            cmbLoaiMon.Name = "cmbLoaiMon";
            cmbLoaiMon.Size = new Size(140, 27);
            cmbLoaiMon.TabIndex = 7;
            // 
            // numSoTiet
            // 
            numSoTiet.Location = new Point(629, 22);
            numSoTiet.Name = "numSoTiet";
            numSoTiet.Size = new Size(49, 27);
            numSoTiet.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10.2F);
            btnThoat.Location = new Point(424, 98);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 30);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 10.2F);
            btnLamMoi.Location = new Point(504, 98);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 30);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 10.2F);
            btnXoa.Location = new Point(344, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 30);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 10.2F);
            btnSua.Location = new Point(264, 98);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 30);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 10.2F);
            btnThem.Location = new Point(184, 98);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 30);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F);
            label10.Location = new Point(504, 59);
            label10.Name = "label10";
            label10.Size = new Size(95, 19);
            label10.TabIndex = 45;
            label10.Text = "LOẠI MÔN:";
            // 
            // rdTamNgung
            // 
            rdTamNgung.AutoSize = true;
            rdTamNgung.Font = new Font("Times New Roman", 10.2F);
            rdTamNgung.Location = new Point(225, 59);
            rdTamNgung.Name = "rdTamNgung";
            rdTamNgung.Size = new Size(104, 23);
            rdTamNgung.TabIndex = 5;
            rdTamNgung.Text = "Tạm ngưng";
            rdTamNgung.UseVisualStyleBackColor = true;
            // 
            // rdDangDay
            // 
            rdDangDay.AutoSize = true;
            rdDangDay.Checked = true;
            rdDangDay.Font = new Font("Times New Roman", 10.2F);
            rdDangDay.Location = new Point(127, 59);
            rdDangDay.Name = "rdDangDay";
            rdDangDay.Size = new Size(92, 23);
            rdDangDay.TabIndex = 4;
            rdDangDay.TabStop = true;
            rdDangDay.Text = "Đang dạy";
            rdDangDay.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F);
            label9.Location = new Point(11, 61);
            label9.Name = "label9";
            label9.Size = new Size(110, 19);
            label9.TabIndex = 44;
            label9.Text = "TRẠNG THÁI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F);
            label8.Location = new Point(552, 26);
            label8.Name = "label8";
            label8.Size = new Size(71, 19);
            label8.TabIndex = 41;
            label8.Text = "SỐ TIẾT:";
            // 
            // txtKhoiLop
            // 
            txtKhoiLop.Font = new Font("Times New Roman", 10.2F);
            txtKhoiLop.Location = new Point(432, 55);
            txtKhoiLop.Name = "txtKhoiLop";
            txtKhoiLop.Size = new Size(66, 27);
            txtKhoiLop.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F);
            label7.Location = new Point(335, 61);
            label7.Name = "label7";
            label7.Size = new Size(91, 19);
            label7.TabIndex = 39;
            label7.Text = "KHỐI LỚP:";
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Times New Roman", 10.2F);
            txtTenMon.Location = new Point(403, 22);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(133, 27);
            txtTenMon.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(309, 26);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 26;
            label3.Text = "TÊN MÔN:";
            // 
            // txtMaMon
            // 
            txtMaMon.Font = new Font("Times New Roman", 10.2F);
            txtMaMon.Location = new Point(207, 22);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(96, 27);
            txtMaMon.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(119, 26);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 23;
            label2.Text = "MÃ MÔN:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Times New Roman", 10.2F);
            txtID.Location = new Point(52, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(59, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 20;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMonHoc);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 408);
            panel2.TabIndex = 1;
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.AllowUserToDeleteRows = false;
            dgvMonHoc.ColumnHeadersHeight = 29;
            dgvMonHoc.Columns.AddRange(new DataGridViewColumn[] { ID, MaMon, TenMon, LoaiMon, TrangThai, KhoiLop, SoTiet });
            dgvMonHoc.Dock = DockStyle.Fill;
            dgvMonHoc.Location = new Point(0, 0);
            dgvMonHoc.Margin = new Padding(4);
            dgvMonHoc.MultiSelect = false;
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.ReadOnly = true;
            dgvMonHoc.RowHeadersVisible = false;
            dgvMonHoc.RowHeadersWidth = 51;
            dgvMonHoc.RowTemplate.Height = 30;
            dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonHoc.Size = new Size(760, 408);
            dgvMonHoc.TabIndex = 3;
            dgvMonHoc.TabStop = false;
            dgvMonHoc.CellClick += dgvMonHoc_CellClick;
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
            // TenMon
            // 
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "TÊN MÔN";
            TenMon.MinimumWidth = 6;
            TenMon.Name = "TenMon";
            TenMon.ReadOnly = true;
            TenMon.Width = 125;
            // 
            // LoaiMon
            // 
            LoaiMon.DataPropertyName = "LoaiMon";
            LoaiMon.HeaderText = "LOẠI MÔN";
            LoaiMon.MinimumWidth = 6;
            LoaiMon.Name = "LoaiMon";
            LoaiMon.ReadOnly = true;
            LoaiMon.Width = 150;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "TRẠNG THÁI";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            TrangThai.Width = 125;
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
            // SoTiet
            // 
            SoTiet.DataPropertyName = "SoTiet";
            SoTiet.HeaderText = "SỐ TIẾT";
            SoTiet.MinimumWidth = 6;
            SoTiet.Name = "SoTiet";
            SoTiet.ReadOnly = true;
            SoTiet.Width = 130;
            // 
            // fMonHoc
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 554);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fMonHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fMonHoc";
            Load += fMonHoc_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTiet).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label10;
        private RadioButton rdTamNgung;
        private RadioButton rdDangDay;
        private Label label9;
        private Label label8;
        private TextBox txtKhoiLop;
        private Label label7;
        private TextBox txtTenMon;
        private Label label3;
        private TextBox txtMaMon;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private NumericUpDown numSoTiet;
        private ComboBox cmbLoaiMon;
        private DataGridView dgvMonHoc;
        private Button btnO;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn LoaiMon;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn KhoiLop;
        private DataGridViewTextBoxColumn SoTiet;
    }
}