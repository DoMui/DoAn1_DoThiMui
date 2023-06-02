namespace Đồ_án
{
    partial class GUI_CTHoaDonNhap
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
            this.dgvCTHDN = new System.Windows.Forms.DataGridView();
            this.grbCTHDN = new System.Windows.Forms.GroupBox();
            this.txtMaCTHDN = new System.Windows.Forms.TextBox();
            this.lblMaCTHDN = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.lblMaHDN = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.btnTT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).BeginInit();
            this.grbCTHDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Location = new System.Drawing.Point(874, 562);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 48);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.Location = new System.Drawing.Point(430, 562);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 48);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.Location = new System.Drawing.Point(213, 562);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 48);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.Location = new System.Drawing.Point(14, 562);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 48);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvCTHDN
            // 
            this.dgvCTHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHDN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHDN.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHDN.Location = new System.Drawing.Point(14, 306);
            this.dgvCTHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCTHDN.Name = "dgvCTHDN";
            this.dgvCTHDN.RowHeadersWidth = 62;
            this.dgvCTHDN.RowTemplate.Height = 28;
            this.dgvCTHDN.Size = new System.Drawing.Size(1001, 233);
            this.dgvCTHDN.TabIndex = 14;
            this.dgvCTHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHDN_CellClick);
            // 
            // grbCTHDN
            // 
            this.grbCTHDN.BackColor = System.Drawing.Color.Lavender;
            this.grbCTHDN.Controls.Add(this.txtMaCTHDN);
            this.grbCTHDN.Controls.Add(this.lblMaCTHDN);
            this.grbCTHDN.Controls.Add(this.txtMaHDN);
            this.grbCTHDN.Controls.Add(this.lblMaHDN);
            this.grbCTHDN.Controls.Add(this.txtTong);
            this.grbCTHDN.Controls.Add(this.lblTong);
            this.grbCTHDN.Controls.Add(this.txtGia);
            this.grbCTHDN.Controls.Add(this.lblGia);
            this.grbCTHDN.Controls.Add(this.txtSL);
            this.grbCTHDN.Controls.Add(this.lblSL);
            this.grbCTHDN.Controls.Add(this.txtSP);
            this.grbCTHDN.Controls.Add(this.lblSP);
            this.grbCTHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCTHDN.Location = new System.Drawing.Point(14, 18);
            this.grbCTHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCTHDN.Name = "grbCTHDN";
            this.grbCTHDN.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCTHDN.Size = new System.Drawing.Size(1001, 222);
            this.grbCTHDN.TabIndex = 13;
            this.grbCTHDN.TabStop = false;
            this.grbCTHDN.Text = "Chi tiết HDN";
            // 
            // txtMaCTHDN
            // 
            this.txtMaCTHDN.Location = new System.Drawing.Point(199, 41);
            this.txtMaCTHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCTHDN.Name = "txtMaCTHDN";
            this.txtMaCTHDN.Size = new System.Drawing.Size(181, 26);
            this.txtMaCTHDN.TabIndex = 1;
            // 
            // lblMaCTHDN
            // 
            this.lblMaCTHDN.AutoSize = true;
            this.lblMaCTHDN.Location = new System.Drawing.Point(38, 44);
            this.lblMaCTHDN.Name = "lblMaCTHDN";
            this.lblMaCTHDN.Size = new System.Drawing.Size(120, 20);
            this.lblMaCTHDN.TabIndex = 10;
            this.lblMaCTHDN.Text = "Mã chi tiết HDN";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(762, 41);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(181, 26);
            this.txtMaHDN.TabIndex = 3;
            // 
            // lblMaHDN
            // 
            this.lblMaHDN.AutoSize = true;
            this.lblMaHDN.Location = new System.Drawing.Point(634, 44);
            this.lblMaHDN.Name = "lblMaHDN";
            this.lblMaHDN.Size = new System.Drawing.Size(70, 20);
            this.lblMaHDN.TabIndex = 8;
            this.lblMaHDN.Text = "Mã HDN";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(762, 170);
            this.txtTong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(181, 26);
            this.txtTong.TabIndex = 11;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(634, 173);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(84, 20);
            this.lblTong.TabIndex = 6;
            this.lblTong.Text = "Thành tiền";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(199, 170);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(181, 26);
            this.txtGia.TabIndex = 9;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(38, 173);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(34, 20);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(762, 103);
            this.txtSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(181, 26);
            this.txtSL.TabIndex = 7;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(634, 106);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(72, 20);
            this.lblSL.TabIndex = 2;
            this.lblSL.Text = "Số lượng";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(199, 103);
            this.txtSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(181, 26);
            this.txtSP.TabIndex = 5;
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(38, 106);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(82, 20);
            this.lblSP.TabIndex = 0;
            this.lblSP.Text = "Sản phẩm";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(310, 261);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(75, 20);
            this.lblTongTien.TabIndex = 12;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtTongtien
            // 
            this.txtTongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongtien.Location = new System.Drawing.Point(418, 259);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(300, 26);
            this.txtTongtien.TabIndex = 13;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTT.Location = new System.Drawing.Point(797, 250);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(139, 43);
            this.btnTT.TabIndex = 20;
            this.btnTT.Text = "Sum";
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // GUI_CTHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1029, 629);
            this.Controls.Add(this.btnTT);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCTHDN);
            this.Controls.Add(this.grbCTHDN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GUI_CTHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_CTHoaDonNhap";
            this.Load += new System.EventHandler(this.GUI_CTHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDN)).EndInit();
            this.grbCTHDN.ResumeLayout(false);
            this.grbCTHDN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvCTHDN;
        private System.Windows.Forms.GroupBox grbCTHDN;
        private System.Windows.Forms.TextBox txtMaCTHDN;
        private System.Windows.Forms.Label lblMaCTHDN;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label lblMaHDN;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btnTT;
    }
}