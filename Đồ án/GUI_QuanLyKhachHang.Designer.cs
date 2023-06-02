namespace Đồ_án
{
    partial class GUI_QuanLyKhachHang
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
            this.btnThemKH = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.grbTKKH = new System.Windows.Forms.GroupBox();
            this.rdoTenKH = new System.Windows.Forms.RadioButton();
            this.rdoMaKH = new System.Windows.Forms.RadioButton();
            this.btnTKKH = new System.Windows.Forms.Button();
            this.txtTKKH = new System.Windows.Forms.TextBox();
            this.lblTTKKH = new System.Windows.Forms.Label();
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.lblSDTKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.grbTKKH.SuspendLayout();
            this.grbTTKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(888, 564);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 46);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(426, 564);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 46);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(233, 564);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 46);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThemKH.Location = new System.Drawing.Point(27, 564);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(101, 46);
            this.btnThemKH.TabIndex = 10;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.Location = new System.Drawing.Point(12, 294);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 62;
            this.dgvKH.RowTemplate.Height = 28;
            this.dgvKH.Size = new System.Drawing.Size(976, 252);
            this.dgvKH.TabIndex = 9;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // grbTKKH
            // 
            this.grbTKKH.BackColor = System.Drawing.Color.Lavender;
            this.grbTKKH.Controls.Add(this.rdoTenKH);
            this.grbTKKH.Controls.Add(this.rdoMaKH);
            this.grbTKKH.Controls.Add(this.btnTKKH);
            this.grbTKKH.Controls.Add(this.txtTKKH);
            this.grbTKKH.Controls.Add(this.lblTTKKH);
            this.grbTKKH.Location = new System.Drawing.Point(639, 12);
            this.grbTKKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKKH.Name = "grbTKKH";
            this.grbTKKH.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKKH.Size = new System.Drawing.Size(350, 256);
            this.grbTKKH.TabIndex = 8;
            this.grbTKKH.TabStop = false;
            this.grbTKKH.Text = "Tìm kiếm khách hàng";
            // 
            // rdoTenKH
            // 
            this.rdoTenKH.AutoSize = true;
            this.rdoTenKH.Location = new System.Drawing.Point(199, 114);
            this.rdoTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTenKH.Name = "rdoTenKH";
            this.rdoTenKH.Size = new System.Drawing.Size(148, 24);
            this.rdoTenKH.TabIndex = 6;
            this.rdoTenKH.TabStop = true;
            this.rdoTenKH.Text = "Tên khách hàng";
            this.rdoTenKH.UseVisualStyleBackColor = true;
            // 
            // rdoMaKH
            // 
            this.rdoMaKH.AutoSize = true;
            this.rdoMaKH.Location = new System.Drawing.Point(24, 114);
            this.rdoMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMaKH.Name = "rdoMaKH";
            this.rdoMaKH.Size = new System.Drawing.Size(143, 24);
            this.rdoMaKH.TabIndex = 5;
            this.rdoMaKH.TabStop = true;
            this.rdoMaKH.Text = "Mã khách hàng";
            this.rdoMaKH.UseVisualStyleBackColor = true;
            // 
            // btnTKKH
            // 
            this.btnTKKH.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKKH.Location = new System.Drawing.Point(32, 179);
            this.btnTKKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTKKH.Name = "btnTKKH";
            this.btnTKKH.Size = new System.Drawing.Size(280, 46);
            this.btnTKKH.TabIndex = 4;
            this.btnTKKH.Text = "Tìm kiếm";
            this.btnTKKH.UseVisualStyleBackColor = false;
            this.btnTKKH.Click += new System.EventHandler(this.btnTKKH_Click);
            // 
            // txtTKKH
            // 
            this.txtTKKH.Location = new System.Drawing.Point(143, 44);
            this.txtTKKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTKKH.Name = "txtTKKH";
            this.txtTKKH.Size = new System.Drawing.Size(169, 26);
            this.txtTKKH.TabIndex = 1;
            // 
            // lblTTKKH
            // 
            this.lblTTKKH.AutoSize = true;
            this.lblTTKKH.Location = new System.Drawing.Point(6, 46);
            this.lblTTKKH.Name = "lblTTKKH";
            this.lblTTKKH.Size = new System.Drawing.Size(71, 20);
            this.lblTTKKH.TabIndex = 0;
            this.lblTTKKH.Text = "Tìm kiếm";
            // 
            // grbTTKH
            // 
            this.grbTTKH.BackColor = System.Drawing.Color.Lavender;
            this.grbTTKH.Controls.Add(this.txtDiaChi);
            this.grbTTKH.Controls.Add(this.lblDiaChi);
            this.grbTTKH.Controls.Add(this.txtSDTKH);
            this.grbTTKH.Controls.Add(this.lblSDTKH);
            this.grbTTKH.Controls.Add(this.txtTenKH);
            this.grbTTKH.Controls.Add(this.lblTenKH);
            this.grbTTKH.Controls.Add(this.txtMaKH);
            this.grbTTKH.Controls.Add(this.lblMaKH);
            this.grbTTKH.Location = new System.Drawing.Point(12, 12);
            this.grbTTKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTKH.Size = new System.Drawing.Size(606, 256);
            this.grbTTKH.TabIndex = 7;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(220, 211);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(343, 26);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(40, 214);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(220, 154);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(343, 26);
            this.txtSDTKH.TabIndex = 5;
            // 
            // lblSDTKH
            // 
            this.lblSDTKH.AutoSize = true;
            this.lblSDTKH.Location = new System.Drawing.Point(40, 156);
            this.lblSDTKH.Name = "lblSDTKH";
            this.lblSDTKH.Size = new System.Drawing.Size(102, 20);
            this.lblSDTKH.TabIndex = 4;
            this.lblSDTKH.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(220, 100);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(343, 26);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(40, 104);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(123, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(220, 44);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(343, 26);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(40, 47);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(118, 20);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // GUI_QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1007, 625);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.grbTKKH);
            this.Controls.Add(this.grbTTKH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_QuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_QuanLyKhachHang";
            this.Load += new System.EventHandler(this.GUI_QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.grbTKKH.ResumeLayout(false);
            this.grbTKKH.PerformLayout();
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.GroupBox grbTKKH;
        private System.Windows.Forms.Button btnTKKH;
        private System.Windows.Forms.TextBox txtTKKH;
        private System.Windows.Forms.Label lblTTKKH;
        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label lblSDTKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.RadioButton rdoTenKH;
        private System.Windows.Forms.RadioButton rdoMaKH;
    }
}