namespace Đồ_án
{
    partial class GUI_QuanLyNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuanv = new System.Windows.Forms.Button();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.grbTKNV = new System.Windows.Forms.GroupBox();
            this.rdoTenNV = new System.Windows.Forms.RadioButton();
            this.rdoMaNV = new System.Windows.Forms.RadioButton();
            this.btnTKNV = new System.Windows.Forms.Button();
            this.txtTKNV = new System.Windows.Forms.TextBox();
            this.lblTKNV = new System.Windows.Forms.Label();
            this.grbTTNV = new System.Windows.Forms.GroupBox();
            this.cboGT = new System.Windows.Forms.ComboBox();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.dtNSNV = new System.Windows.Forms.DateTimePicker();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtMKNV = new System.Windows.Forms.TextBox();
            this.lblMKDN = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTennv = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.lblManv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.grbTKNV.SuspendLayout();
            this.grbTTNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoaNV.Location = new System.Drawing.Point(462, 572);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(122, 51);
            this.btnXoaNV.TabIndex = 14;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuanv
            // 
            this.btnSuanv.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSuanv.Location = new System.Drawing.Point(237, 572);
            this.btnSuanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(122, 51);
            this.btnSuanv.TabIndex = 13;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.UseVisualStyleBackColor = false;
            this.btnSuanv.Click += new System.EventHandler(this.btnSuanv_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThemNV.Location = new System.Drawing.Point(24, 572);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(122, 51);
            this.btnThemNV.TabIndex = 12;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(904, 572);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 51);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLNV.Location = new System.Drawing.Point(12, 333);
            this.dgvQLNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowHeadersWidth = 62;
            this.dgvQLNV.RowTemplate.Height = 28;
            this.dgvQLNV.Size = new System.Drawing.Size(1004, 231);
            this.dgvQLNV.TabIndex = 10;
            this.dgvQLNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLNV_CellClick);
            // 
            // grbTKNV
            // 
            this.grbTKNV.BackColor = System.Drawing.Color.Lavender;
            this.grbTKNV.Controls.Add(this.rdoTenNV);
            this.grbTKNV.Controls.Add(this.rdoMaNV);
            this.grbTKNV.Controls.Add(this.btnTKNV);
            this.grbTKNV.Controls.Add(this.txtTKNV);
            this.grbTKNV.Controls.Add(this.lblTKNV);
            this.grbTKNV.Location = new System.Drawing.Point(641, 12);
            this.grbTKNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKNV.Name = "grbTKNV";
            this.grbTKNV.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKNV.Size = new System.Drawing.Size(375, 304);
            this.grbTKNV.TabIndex = 9;
            this.grbTKNV.TabStop = false;
            this.grbTKNV.Text = "Tìm kiếm nhân viên";
            // 
            // rdoTenNV
            // 
            this.rdoTenNV.AutoSize = true;
            this.rdoTenNV.Location = new System.Drawing.Point(198, 139);
            this.rdoTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTenNV.Name = "rdoTenNV";
            this.rdoTenNV.Size = new System.Drawing.Size(133, 24);
            this.rdoTenNV.TabIndex = 21;
            this.rdoTenNV.TabStop = true;
            this.rdoTenNV.Text = "Tên nhân viên";
            this.rdoTenNV.UseVisualStyleBackColor = true;
            // 
            // rdoMaNV
            // 
            this.rdoMaNV.AutoSize = true;
            this.rdoMaNV.Location = new System.Drawing.Point(42, 139);
            this.rdoMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMaNV.Name = "rdoMaNV";
            this.rdoMaNV.Size = new System.Drawing.Size(128, 24);
            this.rdoMaNV.TabIndex = 20;
            this.rdoMaNV.TabStop = true;
            this.rdoMaNV.Text = "Mã nhân viên";
            this.rdoMaNV.UseVisualStyleBackColor = true;
            // 
            // btnTKNV
            // 
            this.btnTKNV.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKNV.Location = new System.Drawing.Point(44, 228);
            this.btnTKNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(274, 49);
            this.btnTKNV.TabIndex = 6;
            this.btnTKNV.Text = "Tìm kiếm nhân viên";
            this.btnTKNV.UseVisualStyleBackColor = false;
            this.btnTKNV.Click += new System.EventHandler(this.btnTKNV_Click);
            // 
            // txtTKNV
            // 
            this.txtTKNV.Location = new System.Drawing.Point(187, 53);
            this.txtTKNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTKNV.Name = "txtTKNV";
            this.txtTKNV.Size = new System.Drawing.Size(131, 26);
            this.txtTKNV.TabIndex = 15;
            // 
            // lblTKNV
            // 
            this.lblTKNV.AutoSize = true;
            this.lblTKNV.Location = new System.Drawing.Point(40, 56);
            this.lblTKNV.Name = "lblTKNV";
            this.lblTKNV.Size = new System.Drawing.Size(71, 20);
            this.lblTKNV.TabIndex = 2;
            this.lblTKNV.Text = "Tìm kiếm";
            // 
            // grbTTNV
            // 
            this.grbTTNV.BackColor = System.Drawing.Color.Lavender;
            this.grbTTNV.Controls.Add(this.cboGT);
            this.grbTTNV.Controls.Add(this.cboCV);
            this.grbTTNV.Controls.Add(this.dtNSNV);
            this.grbTTNV.Controls.Add(this.lblgioitinh);
            this.grbTTNV.Controls.Add(this.lblNgaysinh);
            this.grbTTNV.Controls.Add(this.lblChucvu);
            this.grbTTNV.Controls.Add(this.txtSDTNV);
            this.grbTTNV.Controls.Add(this.lblSDT);
            this.grbTTNV.Controls.Add(this.txtMKNV);
            this.grbTTNV.Controls.Add(this.lblMKDN);
            this.grbTTNV.Controls.Add(this.txtTenNV);
            this.grbTTNV.Controls.Add(this.lblTennv);
            this.grbTTNV.Controls.Add(this.txtManv);
            this.grbTTNV.Controls.Add(this.lblManv);
            this.grbTTNV.Location = new System.Drawing.Point(12, 12);
            this.grbTTNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTNV.Name = "grbTTNV";
            this.grbTTNV.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTNV.Size = new System.Drawing.Size(616, 304);
            this.grbTTNV.TabIndex = 8;
            this.grbTTNV.TabStop = false;
            this.grbTTNV.Text = "Thông tin nhân viên";
            // 
            // cboGT
            // 
            this.cboGT.FormattingEnabled = true;
            this.cboGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGT.Location = new System.Drawing.Point(428, 186);
            this.cboGT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGT.Name = "cboGT";
            this.cboGT.Size = new System.Drawing.Size(157, 28);
            this.cboGT.TabIndex = 15;
            // 
            // cboCV
            // 
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cboCV.Location = new System.Drawing.Point(428, 40);
            this.cboCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(157, 28);
            this.cboCV.TabIndex = 14;
            // 
            // dtNSNV
            // 
            this.dtNSNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNSNV.Location = new System.Drawing.Point(428, 116);
            this.dtNSNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNSNV.Name = "dtNSNV";
            this.dtNSNV.Size = new System.Drawing.Size(157, 26);
            this.dtNSNV.TabIndex = 11;
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(316, 189);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(67, 20);
            this.lblgioitinh.TabIndex = 12;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(316, 116);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(78, 20);
            this.lblNgaysinh.TabIndex = 10;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.Location = new System.Drawing.Point(317, 44);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(66, 20);
            this.lblChucvu.TabIndex = 8;
            this.lblChucvu.Text = "Chức vụ";
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(145, 254);
            this.txtSDTNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(131, 26);
            this.txtSDTNV.TabIndex = 7;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(25, 256);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(41, 20);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "SĐT";
            // 
            // txtMKNV
            // 
            this.txtMKNV.Location = new System.Drawing.Point(145, 186);
            this.txtMKNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMKNV.Name = "txtMKNV";
            this.txtMKNV.Size = new System.Drawing.Size(131, 26);
            this.txtMKNV.TabIndex = 5;
            // 
            // lblMKDN
            // 
            this.lblMKDN.AutoSize = true;
            this.lblMKDN.Location = new System.Drawing.Point(25, 189);
            this.lblMKDN.Name = "lblMKDN";
            this.lblMKDN.Size = new System.Drawing.Size(75, 20);
            this.lblMKDN.TabIndex = 4;
            this.lblMKDN.Text = "Mật khẩu";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(145, 113);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(131, 26);
            this.txtTenNV.TabIndex = 3;
            // 
            // lblTennv
            // 
            this.lblTennv.AutoSize = true;
            this.lblTennv.Location = new System.Drawing.Point(25, 116);
            this.lblTennv.Name = "lblTennv";
            this.lblTennv.Size = new System.Drawing.Size(108, 20);
            this.lblTennv.TabIndex = 2;
            this.lblTennv.Text = "Tên nhân viên";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(145, 44);
            this.txtManv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(131, 26);
            this.txtManv.TabIndex = 1;
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Location = new System.Drawing.Point(25, 44);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(103, 20);
            this.lblManv.TabIndex = 0;
            this.lblManv.Text = "Mã nhân viên";
            // 
            // GUI_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1026, 635);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuanv);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.grbTKNV);
            this.Controls.Add(this.grbTTNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.GUI_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.grbTKNV.ResumeLayout(false);
            this.grbTKNV.PerformLayout();
            this.grbTTNV.ResumeLayout(false);
            this.grbTTNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuanv;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.GroupBox grbTKNV;
        private System.Windows.Forms.Button btnTKNV;
        private System.Windows.Forms.TextBox txtTKNV;
        private System.Windows.Forms.Label lblTKNV;
        private System.Windows.Forms.GroupBox grbTTNV;
        private System.Windows.Forms.DateTimePicker dtNSNV;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtMKNV;
        private System.Windows.Forms.Label lblMKDN;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblTennv;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.RadioButton rdoTenNV;
        private System.Windows.Forms.RadioButton rdoMaNV;
        private System.Windows.Forms.ComboBox cboGT;
        private System.Windows.Forms.ComboBox cboCV;
    }
}