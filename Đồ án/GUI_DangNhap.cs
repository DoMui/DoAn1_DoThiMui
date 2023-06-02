using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Đồ_án
{
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        string connString = @"Data Source=LAPTOP-3JSDS55G\SQLEXPRESS01;Initial Catalog=ĐoAn;Integrated Security=True";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();

                string query = string.Empty;
                Form mainForm = null;

                // Kiểm tra đăng nhập với bảng DangNhap
                query = "SELECT * FROM DangNhap WHERE TenDN = @TenDN and matkhau = @MatKhau";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenDN", txtUser.Text);
                cmd.Parameters.AddWithValue("@MatKhau", txtPass.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    mainForm = new GUI_Main();
                }
                else
                {
                    reader.Close();

                    // Kiểm tra đăng nhập với bảng DangNhapNV
                    query = "SELECT * FROM DangNhapNV WHERE TenDNNV = @TenDN and matkhauNV = @MatKhau";

                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TenDN", txtUser.Text);
                    cmd.Parameters.AddWithValue("@MatKhau", txtPass.Text);
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        mainForm = new GUI_MainNV();
                    }
                }

                reader.Close();

                if (mainForm != null)
                {
                    
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Hãy nhập lại", "Thông báo");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo");
            }
            conn.Close();
        }

        private void ckbHTMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHTMK.Checked == true)
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = '.';
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '.';
        }
        
    }
}
