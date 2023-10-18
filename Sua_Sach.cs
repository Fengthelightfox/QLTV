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

namespace QLDLSach
{
    public partial class Sua_Sach : Form
    {
        public Sua_Sach()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ms = tb_MS.Text.Trim();
            string ts = tb_TS.Text.Trim();
            string tl = tb_TL.Text.Trim();
            string sl = tb_SL.Text.Trim();
            string tt = tb_TT.Text.Trim();
            string mt = tb_MT.Text.Trim();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03MSEE3\KHANG;Initial Catalog=QLTV;Integrated Security=True");
            try
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("update Sach set Ten_Sach = @ts, The_Loai = @tl, So_Luong = @sl, Tinh_Trang = @tt, Mo_Ta = @mt where Ma_Sach= @ms", conn);
                cmd1.Parameters.AddWithValue("@ms", ms);
                cmd1.Parameters.AddWithValue("@ts", ts);
                cmd1.Parameters.AddWithValue("@tl", tl);
                cmd1.Parameters.AddWithValue("@sl", sl);
                cmd1.Parameters.AddWithValue("@tt", tt);
                cmd1.Parameters.AddWithValue("@mt", mt);

                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa sách thành công");

                conn.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            this.Hide();
            Them_Sach them_Sach = new Them_Sach();
            them_Sach.ShowDialog();
            Sua_Sach sua_Sach = new Sua_Sach();
            sua_Sach.ShowDialog();
            Xoa_Sach xoa_Sach = new Xoa_Sach();
            xoa_Sach.ShowDialog();
           
        }

        private void ClearTextBox()
        {
            tb_MS.Text = string.Empty;
            tb_TS.Text = string.Empty;
            tb_TL.Text = string.Empty;
            tb_SL.Text = string.Empty;
            tb_TT.Text = string.Empty;
            tb_MT.Text = string.Empty;
        }
    }
}
