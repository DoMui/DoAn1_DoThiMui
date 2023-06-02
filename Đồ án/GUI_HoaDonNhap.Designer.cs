namespace Đồ_án
{
    partial class GUI_HoaDonNhap
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHDN = new System.Windows.Forms.DataGridView();
            this.grbTKHDN = new System.Windows.Forms.GroupBox();
            this.rdoTKMNV = new System.Windows.Forms.RadioButton();
            this.rdoTKMHDN = new System.Windows.Forms.RadioButton();
            this.btnTKHDN = new System.Windows.Forms.Button();
            this.txtTKHDN = new System.Windows.Forms.TextBox();
            this.lblTKHDN = new System.Windows.Forms.Label();
            this.grbTTHDN = new System.Windows.Forms.GroupBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnChitietHDN = new System.Windows.Forms.Button();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.lblMaHDN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).BeginInit();
            this.grbTKHDN.SuspendLayout();
            this.grbTTHDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(886, 507);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 48);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(447, 507);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 48);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(225, 507);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 48);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.Location = new System.Drawing.Point(26, 507);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 48);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHDN
            // 
            this.dgvHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHDN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHDN.Location = new System.Drawing.Point(12, 235);
            this.dgvHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHDN.Name = "dgvHDN";
            this.dgvHDN.RowHeadersWidth = 62;
            this.dgvHDN.RowTemplate.Height = 28;
            this.dgvHDN.Size = new System.Drawing.Size(1008, 252);
            this.dgvHDN.TabIndex = 10;
            this.dgvHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDN_CellClick);
            // 
            // grbTKHDN
            // 
            this.grbTKHDN.BackColor = System.Drawing.Color.Lavender;
            this.grbTKHDN.Controls.Add(this.rdoTKMNV);
            this.grbTKHDN.Controls.Add(this.rdoTKMHDN);
            this.grbTKHDN.Controls.Add(this.btnTKHDN);
            this.grbTKHDN.Controls.Add(this.txtTKHDN);
            this.grbTKHDN.Controls.Add(this.lblTKHDN);
            this.grbTKHDN.Location = new System.Drawing.Point(652, 12);
            this.grbTKHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKHDN.Name = "grbTKHDN";
            this.grbTKHDN.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKHDN.Size = new System.Drawing.Size(368, 204);
            this.grbTKHDN.TabIndex = 9;
            this.grbTKHDN.TabStop = false;
            this.grbTKHDN.Text = "Tìm kiếm hóa đơn nhập";
            // 
            // rdoTKMNV
            // 
            this.rdoTKMNV.AutoSize = true;
            this.rdoTKMNV.Location = new System.Drawing.Point(224, 93);
            this.rdoTKMNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTKMNV.Name = "rdoTKMNV";
            this.rdoTKMNV.Size = new System.Drawing.Size(128, 24);
            this.rdoTKMNV.TabIndex = 6;
            this.rdoTKMNV.TabStop = true;
            this.rdoTKMNV.Text = "Mã nhân viên";
            this.rdoTKMNV.UseVisualStyleBackColor = true;
            // 
            // rdoTKMHDN
            // 
            this.rdoTKMHDN.AutoSize = true;
            this.rdoTKMHDN.Location = new System.Drawing.Point(35, 93);
            this.rdoTKMHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTKMHDN.Name = "rdoTKMHDN";
            this.rdoTKMHDN.Size = new System.Drawing.Size(95, 24);
            this.rdoTKMHDN.TabIndex = 5;
            this.rdoTKMHDN.TabStop = true;
            this.rdoTKMHDN.Text = "Mã HDN";
            this.rdoTKMHDN.UseVisualStyleBackColor = true;
            // 
            // btnTKHDN
            // 
            this.btnTKHDN.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKHDN.Location = new System.Drawing.Point(46, 144);
            this.btnTKHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTKHDN.Name = "btnTKHDN";
            this.btnTKHDN.Size = new System.Drawing.Size(294, 44);
            this.btnTKHDN.TabIndex = 4;
            this.btnTKHDN.Text = "Tìm kiếm";
            this.btnTKHDN.UseVisualStyleBackColor = false;
            this.btnTKHDN.Click += new System.EventHandler(this.btnTKHDN_Click);
            // 
            // txtTKHDN
            // 
            this.txtTKHDN.Location = new System.Drawing.Point(191, 41);
            this.txtTKHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTKHDN.Name = "txtTKHDN";
            this.txtTKHDN.Size = new System.Drawing.Size(149, 26);
            this.txtTKHDN.TabIndex = 1;
            // 
            // lblTKHDN
            // 
            this.lblTKHDN.AutoSize = true;
            this.lblTKHDN.Location = new System.Drawing.Point(42, 44);
            this.lblTKHDN.Name = "lblTKHDN";
            this.lblTKHDN.Size = new System.Drawing.Size(71, 20);
            this.lblTKHDN.TabIndex = 0;
            this.lblTKHDN.Text = "Tìm kiếm";
            // 
            // grbTTHDN
            // 
            this.grbTTHDN.BackColor = System.Drawing.Color.Lavender;
            this.grbTTHDN.Controls.Add(this.dtNgayNhap);
            this.grbTTHDN.Controls.Add(this.btnChitietHDN);
            this.grbTTHDN.Controls.Add(this.lblNgayNhap);
            this.grbTTHDN.Controls.Add(this.txtMaNCC);
            this.grbTTHDN.Controls.Add(this.lblMaNCC);
            this.grbTTHDN.Controls.Add(this.txtMaNV);
            this.grbTTHDN.Controls.Add(this.lblMaNV);
            this.grbTTHDN.Controls.Add(this.txtMaHDN);
            this.grbTTHDN.Controls.Add(this.lblMaHDN);
            this.grbTTHDN.Location = new System.Drawing.Point(12, 12);
            this.grbTTHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTHDN.Name = "grbTTHDN";
            this.grbTTHDN.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTHDN.Size = new System.Drawing.Size(629, 204);
            this.grbTTHDN.TabIndex = 8;
            this.grbTTHDN.TabStop = false;
            this.grbTTHDN.Text = "Thông tin hóa đơn nhập";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(478, 99);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(132, 26);
            this.dtNgayNhap.TabIndex = 9;
            // 
            // btnChitietHDN
            // 
            this.btnChitietHDN.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChitietHDN.Location = new System.Drawing.Point(39, 144);
            this.btnChitietHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChitietHDN.Name = "btnChitietHDN";
            this.btnChitietHDN.Size = new System.Drawing.Size(572, 44);
            this.btnChitietHDN.TabIndex = 8;
            this.btnChitietHDN.Text = "Chi tiết hóa đơn nhập";
            this.btnChitietHDN.UseVisualStyleBackColor = false;
            this.btnChitietHDN.Click += new System.EventHandler(this.btnChitietHDN_Click);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(325, 98);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(85, 20);
            this.lblNgayNhap.TabIndex = 6;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(478, 41);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(132, 26);
            this.txtMaNCC.TabIndex = 5;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(325, 44);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(131, 20);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(158, 95);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 26);
            this.txtMaNV.TabIndex = 3;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(35, 98);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(103, 20);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(158, 41);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(132, 26);
            this.txtMaHDN.TabIndex = 1;
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Location = new System.Drawing.Point(35, 44);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(70, 20);
            this.lblMaHDN.TabIndex = 0;
            this.lblMaHDN.Text = "Mã HDN";
            // 
            // GUI_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1034, 574);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHDN);
            this.Controls.Add(this.grbTKHDN);
            this.Controls.Add(this.grbTTHDN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_HoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_HoaDonNhap";
            this.Load += new System.EventHandler(this.GUI_HoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDN)).EndInit();
            this.grbTKHDN.ResumeLayout(false);
            this.grbTKHDN.PerformLayout();
            this.grbTTHDN.ResumeLayout(false);
            this.grbTTHDN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHDN;
        private System.Windows.Forms.GroupBox grbTKHDN;
        private System.Windows.Forms.Button btnTKHDN;
        private System.Windows.Forms.TextBox txtTKHDN;
        private System.Windows.Forms.Label lblTKHDN;
        private System.Windows.Forms.GroupBox grbTTHDN;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Button btnChitietHDN;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.RadioButton rdoTKMNV;
        private System.Windows.Forms.RadioButton rdoTKMHDN;
    }
}