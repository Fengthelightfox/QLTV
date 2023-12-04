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
    public partial class Dang_ki_doc_gia : Form
    {
        public Dang_ki_doc_gia()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Connection.CnnString;
            SqlConnection con = new SqlConnection(connectionString);
            string email;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from Thong_tin_doc_gia WHERE Ten_tai_khoan = @ttk", con);
                cmd.Parameters.AddWithValue("@ttk", textBox1.Text.Trim());
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                    return;
                }
                else
                {
                    if (textBox2.Text.Trim() != textBox3.Text.Trim())
                    {
                        MessageBox.Show("Nhập lại mật khẩu không khớp!");
                        return;

                    }

                    else if (textBox4.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên");
                        return;
                    }

                    else if (textBox5.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại");
                        return;
                    }
                    else if (textBox7.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng nhập địa chỉ");
                        return;
                    }
                    else if (textBox6.Text.ToString() == "")
                    {
                        email = null; 
                    }
                    else
                    {
                        email = textBox6.Text;
                    }
                    SqlCommand cm = new SqlCommand("insert into Thong_tin_doc_gia (Ma_doc_gia, Ten_tai_khoan, Mat_khau, Ho_ten, So_dien_thoai, Dia_chi, Email) values(@mdg,@ttk,@mk,@ht,@sdt,@dc, @email) ", con);
                    cm.Parameters.AddWithValue("@mdg", "MD025");
                    cm.Parameters.AddWithValue("@ttk", textBox1.Text);
                    cm.Parameters.AddWithValue("@mk", textBox2.Text);
                    cm.Parameters.AddWithValue("@ht", textBox4.Text);
                    cm.Parameters.AddWithValue("@sdt", textBox5.Text);
                    cm.Parameters.AddWithValue("@dc", textBox7.Text);
                    cm.Parameters.AddWithValue("@email", textBox6.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công");
                    con.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dang_nhap dn = new Dang_nhap();
            dn.ShowDialog();
            
        }
    }
}
