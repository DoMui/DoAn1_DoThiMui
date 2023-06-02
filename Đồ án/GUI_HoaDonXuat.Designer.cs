namespace Đồ_án
{
    partial class GUI_HoaDonXuat
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
            this.dgvHDB = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTTHDB = new System.Windows.Forms.GroupBox();
            this.dateNgayBan = new System.Windows.Forms.DateTimePicker();
            this.btnChitietHDB = new System.Windows.Forms.Button();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.lblMaHDB = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTKHDB = new System.Windows.Forms.Label();
            this.txtTKHDB = new System.Windows.Forms.TextBox();
            this.btnTKHDB = new System.Windows.Forms.Button();
            this.grbTKHDB = new System.Windows.Forms.GroupBox();
            this.rdoTKMNV = new System.Windows.Forms.RadioButton();
            this.rdoTKMHDB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).BeginInit();
            this.grbTTHDB.SuspendLayout();
            this.grbTKHDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHDB
            // 
            this.dgvHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHDB.Location = new System.Drawing.Point(18, 284);
            this.dgvHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHDB.Name = "dgvHDB";
            this.dgvHDB.RowHeadersWidth = 62;
            this.dgvHDB.RowTemplate.Height = 28;
            this.dgvHDB.Size = new System.Drawing.Size(979, 285);
            this.dgvHDB.TabIndex = 23;
            this.dgvHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDB_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(842, 586);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 48);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbTTHDB
            // 
            this.grbTTHDB.BackColor = System.Drawing.Color.Lavender;
            this.grbTTHDB.Controls.Add(this.dateNgayBan);
            this.grbTTHDB.Controls.Add(this.btnChitietHDB);
            this.grbTTHDB.Controls.Add(this.lblNgayBan);
            this.grbTTHDB.Controls.Add(this.txtMaKH);
            this.grbTTHDB.Controls.Add(this.lblMaKH);
            this.grbTTHDB.Controls.Add(this.txtMaNV);
            this.grbTTHDB.Controls.Add(this.lblMaNV);
            this.grbTTHDB.Controls.Add(this.txtMaHDB);
            this.grbTTHDB.Controls.Add(this.lblMaHDB);
            this.grbTTHDB.Location = new System.Drawing.Point(18, 16);
            this.grbTTHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTHDB.Name = "grbTTHDB";
            this.grbTTHDB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTTHDB.Size = new System.Drawing.Size(615, 247);
            this.grbTTHDB.TabIndex = 16;
            this.grbTTHDB.TabStop = false;
            this.grbTTHDB.Text = "Thông tin hóa đơn xuất";
            // 
            // dateNgayBan
            // 
            this.dateNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayBan.Location = new System.Drawing.Point(449, 116);
            this.dateNgayBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayBan.Name = "dateNgayBan";
            this.dateNgayBan.Size = new System.Drawing.Size(132, 26);
            this.dateNgayBan.TabIndex = 9;
            // 
            // btnChitietHDB
            // 
            this.btnChitietHDB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChitietHDB.Location = new System.Drawing.Point(18, 189);
            this.btnChitietHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChitietHDB.Name = "btnChitietHDB";
            this.btnChitietHDB.Size = new System.Drawing.Size(562, 44);
            this.btnChitietHDB.TabIndex = 8;
            this.btnChitietHDB.Text = "Chi tiết hóa đơn bán";
            this.btnChitietHDB.UseVisualStyleBackColor = false;
            this.btnChitietHDB.Click += new System.EventHandler(this.btnChitietHDB_Click);
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(325, 122);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(76, 20);
            this.lblNgayBan.TabIndex = 6;
            this.lblNgayBan.Text = "Ngày bán";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(449, 41);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(132, 26);
            this.txtMaKH.TabIndex = 5;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(325, 44);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(118, 20);
            this.lblMaKH.TabIndex = 4;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(158, 119);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(132, 26);
            this.txtMaNV.TabIndex = 3;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(35, 122);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(103, 20);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(158, 41);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(132, 26);
            this.txtMaHDB.TabIndex = 1;
            // 
            // lblMaHDB
            // 
            this.lblMaHDB.AutoSize = true;
            this.lblMaHDB.Location = new System.Drawing.Point(35, 44);
            this.lblMaHDB.Name = "lblMaHDB";
            this.lblMaHDB.Size = new System.Drawing.Size(70, 20);
            this.lblMaHDB.TabIndex = 0;
            this.lblMaHDB.Text = "Mã HDX";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(457, 586);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 48);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(235, 586);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 48);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.Location = new System.Drawing.Point(36, 586);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 48);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTKHDB
            // 
            this.lblTKHDB.AutoSize = true;
            this.lblTKHDB.Location = new System.Drawing.Point(42, 44);
            this.lblTKHDB.Name = "lblTKHDB";
            this.lblTKHDB.Size = new System.Drawing.Size(71, 20);
            this.lblTKHDB.TabIndex = 0;
            this.lblTKHDB.Text = "Tìm kiếm";
            // 
            // txtTKHDB
            // 
            this.txtTKHDB.Location = new System.Drawing.Point(170, 41);
            this.txtTKHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTKHDB.Name = "txtTKHDB";
            this.txtTKHDB.Size = new System.Drawing.Size(149, 26);
            this.txtTKHDB.TabIndex = 1;
            // 
            // btnTKHDB
            // 
            this.btnTKHDB.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTKHDB.Location = new System.Drawing.Point(25, 189);
            this.btnTKHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTKHDB.Name = "btnTKHDB";
            this.btnTKHDB.Size = new System.Drawing.Size(294, 44);
            this.btnTKHDB.TabIndex = 4;
            this.btnTKHDB.Text = "Tìm kiếm";
            this.btnTKHDB.UseVisualStyleBackColor = false;
            this.btnTKHDB.Click += new System.EventHandler(this.btnTKHDB_Click);
            // 
            // grbTKHDB
            // 
            this.grbTKHDB.BackColor = System.Drawing.Color.Lavender;
            this.grbTKHDB.Controls.Add(this.rdoTKMNV);
            this.grbTKHDB.Controls.Add(this.rdoTKMHDB);
            this.grbTKHDB.Controls.Add(this.btnTKHDB);
            this.grbTKHDB.Controls.Add(this.txtTKHDB);
            this.grbTKHDB.Controls.Add(this.lblTKHDB);
            this.grbTKHDB.Location = new System.Drawing.Point(651, 16);
            this.grbTKHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKHDB.Name = "grbTKHDB";
            this.grbTKHDB.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbTKHDB.Size = new System.Drawing.Size(346, 247);
            this.grbTKHDB.TabIndex = 17;
            this.grbTKHDB.TabStop = false;
            this.grbTKHDB.Text = "Tìm kiếm hóa đơn xuất";
            // 
            // rdoTKMNV
            // 
            this.rdoTKMNV.AutoSize = true;
            this.rdoTKMNV.Location = new System.Drawing.Point(191, 111);
            this.rdoTKMNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTKMNV.Name = "rdoTKMNV";
            this.rdoTKMNV.Size = new System.Drawing.Size(128, 24);
            this.rdoTKMNV.TabIndex = 6;
            this.rdoTKMNV.TabStop = true;
            this.rdoTKMNV.Text = "Mã nhân viên";
            this.rdoTKMNV.UseVisualStyleBackColor = true;
            // 
            // rdoTKMHDB
            // 
            this.rdoTKMHDB.AutoSize = true;
            this.rdoTKMHDB.Location = new System.Drawing.Point(38, 111);
            this.rdoTKMHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTKMHDB.Name = "rdoTKMHDB";
            this.rdoTKMHDB.Size = new System.Drawing.Size(95, 24);
            this.rdoTKMHDB.TabIndex = 5;
            this.rdoTKMHDB.TabStop = true;
            this.rdoTKMHDB.Text = "Mã HDX";
            this.rdoTKMHDB.UseVisualStyleBackColor = true;
            // 
            // GUI_HoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1015, 651);
            this.Controls.Add(this.dgvHDB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbTKHDB);
            this.Controls.Add(this.grbTTHDB);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_HoaDonXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_HoaDonBan";
            this.Load += new System.EventHandler(this.GUI_HoaDonXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDB)).EndInit();
            this.grbTTHDB.ResumeLayout(false);
            this.grbTTHDB.PerformLayout();
            this.grbTKHDB.ResumeLayout(false);
            this.grbTKHDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHDB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbTTHDB;
        private System.Windows.Forms.DateTimePicker dateNgayBan;
        private System.Windows.Forms.Button btnChitietHDB;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label lblMaHDB;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTKHDB;
        private System.Windows.Forms.TextBox txtTKHDB;
        private System.Windows.Forms.Button btnTKHDB;
        private System.Windows.Forms.GroupBox grbTKHDB;
        private System.Windows.Forms.RadioButton rdoTKMNV;
        private System.Windows.Forms.RadioButton rdoTKMHDB;
    }
}