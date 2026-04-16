namespace QL_Diem.Forms
{
    partial class fTaiKhoan
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
            cmbLoaiTaiKhoan = new ComboBox();
            label4 = new Label();
            btnThoat = new Button();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtMatKhau = new TextBox();
            label3 = new Label();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dgvTaiKhoan = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            MatKhau = new DataGridViewTextBoxColumn();
            LoaiTaiKhoan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbLoaiTaiKhoan);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 119);
            panel1.TabIndex = 0;
            // 
            // cmbLoaiTaiKhoan
            // 
            cmbLoaiTaiKhoan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiTaiKhoan.FormattingEnabled = true;
            cmbLoaiTaiKhoan.Items.AddRange(new object[] { "Admin", "Giáo Viên" });
            cmbLoaiTaiKhoan.Location = new Point(88, 76);
            cmbLoaiTaiKhoan.Name = "cmbLoaiTaiKhoan";
            cmbLoaiTaiKhoan.Size = new Size(88, 27);
            cmbLoaiTaiKhoan.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 79);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 8;
            label4.Text = "LOẠI TK:";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 10.2F);
            btnThoat.Location = new Point(465, 72);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 32);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Times New Roman", 10.2F);
            btnLamMoi.Location = new Point(545, 72);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(86, 32);
            btnLamMoi.TabIndex = 8;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Times New Roman", 10.2F);
            btnXoa.Location = new Point(385, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 32);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Times New Roman", 10.2F);
            btnSua.Location = new Point(305, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 32);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Times New Roman", 10.2F);
            btnThem.Location = new Point(225, 72);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 32);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(535, 28);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(98, 27);
            txtMatKhau.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 4;
            label3.Text = "MẬT KHẨU:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(266, 28);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(166, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 2;
            label2.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(51, 28);
            txtID.Name = "txtID";
            txtID.Size = new Size(54, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvTaiKhoan);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 119);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 371);
            panel2.TabIndex = 1;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { ID, TenDangNhap, MatKhau, LoaiTaiKhoan });
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 0);
            dgvTaiKhoan.Margin = new Padding(4);
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 30;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(645, 371);
            dgvTaiKhoan.TabIndex = 1;
            dgvTaiKhoan.TabStop = false;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
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
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "TÊN ĐĂNG NHẬP";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            TenDangNhap.Width = 250;
            // 
            // MatKhau
            // 
            MatKhau.DataPropertyName = "MatKhau";
            MatKhau.HeaderText = "MẬT KHẨU";
            MatKhau.MinimumWidth = 6;
            MatKhau.Name = "MatKhau";
            MatKhau.ReadOnly = true;
            MatKhau.Width = 150;
            // 
            // LoaiTaiKhoan
            // 
            LoaiTaiKhoan.DataPropertyName = "LoaiTaiKhoan";
            LoaiTaiKhoan.HeaderText = "LOẠI TÀI KHOẢN";
            LoaiTaiKhoan.MinimumWidth = 6;
            LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            LoaiTaiKhoan.ReadOnly = true;
            LoaiTaiKhoan.Width = 200;
            // 
            // fTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 490);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTaiKhoan";
            Load += fTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvTaiKhoan;
        private TextBox txtID;
        private Label label1;
        private TextBox txtMatKhau;
        private Label label3;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Button btnThoat;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cmbLoaiTaiKhoan;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn LoaiTaiKhoan;
    }
}