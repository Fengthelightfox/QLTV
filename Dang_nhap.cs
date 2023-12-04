using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_thu_vien
{
    public partial class Dang_nhap : Form
    {
        public Dang_nhap()
        {
            InitializeComponent();
        }
        string connectionString = Connection.CnnString;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                if (radioButton1.Checked)
                {
                    SqlCommand cmd = new SqlCommand("select * from TK_QL where Ten_tai_khoan = @dn", conn);
                    cmd.Parameters.AddWithValue("@dn", textBox1.Text.Trim());
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        if ((textBox1.Text.Trim() == rd["Ten_tai_khoan"].ToString().Trim()) && textBox2.Text.Trim() == rd["Mat_khau"].ToString().Trim())
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            this.Hide();
                            Trang_chu tc = new Trang_chu();
                            tc.ShowDialog();
                        }
                        if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "")
                        {
                            MessageBox.Show("Vui lòng điền đủ các thông tin!");
                        }
                        if (textBox1.Text.Trim() != rd["Ten_tai_khoan"].ToString().Trim())
                        {
                            MessageBox.Show("Tài khoản không tồn tại!");
                        }
                        if (textBox2.Text.Trim() != rd["Mat_khau"].ToString().Trim())
                        {
                            MessageBox.Show("Sai mật khẩu.");
                        }
                    }
                }
                if(radioButton2.Checked)
                {
                    SqlCommand cmd2 = new SqlCommand("select * from  Thong_tin_doc_gia where Ten_tai_khoan=@dn and Mat_khau=@mk ",conn);
                    cmd2.Parameters.AddWithValue("@dn", textBox1.Text.Trim());
                    cmd2.Parameters.AddWithValue("@mk", textBox2.Text.Trim());
                    SqlDataReader rd = cmd2.ExecuteReader();
                    while (rd.Read())
                    {
                        if ((textBox1.Text.Trim() == rd["Ten_tai_khoan"].ToString().Trim()) && textBox2.Text.Trim() == rd["Mat_khau"].ToString().Trim())
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            this.Hide();
                            Tim_kiem tk = new Tim_kiem();
                            tk.ShowDialog();
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
