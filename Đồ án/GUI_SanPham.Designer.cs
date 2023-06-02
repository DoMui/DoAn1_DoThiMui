namespace Đồ_án
{
    partial class GUI_SanPham
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grbTKSP = new System.Windows.Forms.GroupBox();
            this.rdoTenSP = new System.Windows.Forms.RadioButton();
            this.rdoMaSP = new System.Windows.Forms.RadioButton();
            this.lblTKSP = new System.Windows.Forms.Label();
            this.txtTKSP = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbTTSP = new System.Windows.Forms.GroupBox();
            this.lblXuatXu = new System.Windows.Forms.Label();
            this.txtXuatXu = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dgvQLSP = new System.Windows.Forms.DataGridView();
            this.grbTKSP.SuspendLayout();
            this.grbTTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(468, 580);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 48);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(890, 580);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 49);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(238, 580);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 48);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grbTKSP
            // 
            this.grbTKSP.BackColor = System.Drawing.Color.Lavender;
            this.grbTKSP.Controls.Add(this.rdoTenSP);
            this.grbTKSP.Controls.Add(this.rdoMaSP);
            this.grbTKSP.Controls.Add(this.lblTKSP);
            this.grbTKSP.Controls.Add(this.txtTKSP);
            this.grbTKSP.Controls.Add(this.btnTimKiem);
            this.grbTKSP.Location = new System.Drawing.Point(680, 12);
            this.grbTKSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKSP.Name = "grbTKSP";
            this.grbTKSP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKSP.Size = new System.Drawing.Size(333, 261);
            this.grbTKSP.TabIndex = 23;
            this.grbTKSP.TabStop = false;
            this.grbTKSP.Text = "Tìm kiếm sản phẩm";
            // 
            // rdoTenSP
            // 
            this.rdoTenSP.AutoSize = true;
            this.rdoTenSP.Location = new System.Drawing.Point(191, 120);
            this.rdoTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTenSP.Name = "rdoTenSP";
            this.rdoTenSP.Size = new System.Drawing.Size(135, 24);
            this.rdoTenSP.TabIndex = 19;
            this.rdoTenSP.TabStop = true;
            this.rdoTenSP.Text = "Tên sản phẩm";
            this.rdoTenSP.UseVisualStyleBackColor = true;
            // 
            // rdoMaSP
            // 
            this.rdoMaSP.AutoSize = true;
            this.rdoMaSP.Location = new System.Drawing.Point(35, 120);
            this.rdoMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoMaSP.Name = "rdoMaSP";
            this.rdoMaSP.Size = new System.Drawing.Size(130, 24);
            this.rdoMaSP.TabIndex = 18;
            this.rdoMaSP.TabStop = true;
            this.rdoMaSP.Text = "Mã sản phẩm";
            this.rdoMaSP.UseVisualStyleBackColor = true;
            // 
            // lblTKSP
            // 
            this.lblTKSP.AutoSize = true;
            this.lblTKSP.Location = new System.Drawing.Point(32, 55);
            this.lblTKSP.Name = "lblTKSP";
            this.lblTKSP.Size = new System.Drawing.Size(71, 20);
            this.lblTKSP.TabIndex = 17;
            this.lblTKSP.Text = "Tìm kiếm";
            // 
            // txtTKSP
            // 
            this.txtTKSP.Location = new System.Drawing.Point(138, 52);
            this.txtTKSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTKSP.Name = "txtTKSP";
            this.txtTKSP.Size = new System.Drawing.Size(164, 26);
            this.txtTKSP.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTimKiem.Location = new System.Drawing.Point(30, 193);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(287, 47);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.Location = new System.Drawing.Point(12, 580);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 48);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbTTSP
            // 
            this.grbTTSP.BackColor = System.Drawing.Color.Lavender;
            this.grbTTSP.Controls.Add(this.lblXuatXu);
            this.grbTTSP.Controls.Add(this.txtXuatXu);
            this.grbTTSP.Controls.Add(this.lblSoLuong);
            this.grbTTSP.Controls.Add(this.txtSoLuong);
            this.grbTTSP.Controls.Add(this.lblGiaBan);
            this.grbTTSP.Controls.Add(this.txtGiaBan);
            this.grbTTSP.Controls.Add(this.lblTenSP);
            this.grbTTSP.Controls.Add(this.txtTenSP);
            this.grbTTSP.Controls.Add(this.lblMaSP);
            this.grbTTSP.Controls.Add(this.txtMaSP);
            this.grbTTSP.Location = new System.Drawing.Point(12, 12);
            this.grbTTSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTSP.Name = "grbTTSP";
            this.grbTTSP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTSP.Size = new System.Drawing.Size(662, 261);
            this.grbTTSP.TabIndex = 17;
            this.grbTTSP.TabStop = false;
            this.grbTTSP.Text = "Thông tin sản phẩm";
            // 
            // lblXuatXu
            // 
            this.lblXuatXu.AutoSize = true;
            this.lblXuatXu.Location = new System.Drawing.Point(399, 125);
            this.lblXuatXu.Name = "lblXuatXu";
            this.lblXuatXu.Size = new System.Drawing.Size(63, 20);
            this.lblXuatXu.TabIndex = 9;
            this.lblXuatXu.Text = "Xuất xứ";
            // 
            // txtXuatXu
            // 
            this.txtXuatXu.Location = new System.Drawing.Point(496, 122);
            this.txtXuatXu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXuatXu.Name = "txtXuatXu";
            this.txtXuatXu.Size = new System.Drawing.Size(144, 26);
            this.txtXuatXu.TabIndex = 8;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(399, 54);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(72, 20);
            this.lblSoLuong.TabIndex = 7;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(496, 51);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(144, 26);
            this.txtSoLuong.TabIndex = 6;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(21, 193);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(65, 20);
            this.lblGiaBan.TabIndex = 5;
            this.lblGiaBan.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(163, 191);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(150, 26);
            this.txtGiaBan.TabIndex = 4;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(16, 125);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(110, 20);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(163, 122);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(150, 26);
            this.txtTenSP.TabIndex = 2;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.BackColor = System.Drawing.Color.Lavender;
            this.lblMaSP.Location = new System.Drawing.Point(21, 54);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(105, 20);
            this.lblMaSP.TabIndex = 1;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(163, 51);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(150, 26);
            this.txtMaSP.TabIndex = 0;
            // 
            // dgvQLSP
            // 
            this.dgvQLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLSP.Location = new System.Drawing.Point(12, 292);
            this.dgvQLSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.RowHeadersWidth = 62;
            this.dgvQLSP.RowTemplate.Height = 28;
            this.dgvQLSP.Size = new System.Drawing.Size(1000, 258);
            this.dgvQLSP.TabIndex = 25;
            this.dgvQLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSP_CellClick);
            // 
            // GUI_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1024, 646);
            this.Controls.Add(this.dgvQLSP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grbTKSP);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbTTSP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_SanPham";
            this.Load += new System.EventHandler(this.GUI_SanPham_Load);
            this.grbTKSP.ResumeLayout(false);
            this.grbTKSP.PerformLayout();
            this.grbTTSP.ResumeLayout(false);
            this.grbTTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grbTKSP;
        private System.Windows.Forms.Label lblTKSP;
        private System.Windows.Forms.TextBox txtTKSP;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbTTSP;
        private System.Windows.Forms.Label lblXuatXu;
        private System.Windows.Forms.TextBox txtXuatXu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DataGridView dgvQLSP;
        private System.Windows.Forms.RadioButton rdoTenSP;
        private System.Windows.Forms.RadioButton rdoMaSP;
    }
}