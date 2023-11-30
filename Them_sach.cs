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
    public partial class Them_sach : Form
    {
        public Them_sach()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ms = tb_MS.Text.Trim();
            string ts = tb_TS.Text.Trim();
            string tl = tb_TL.Text.Trim();
            int sl = Convert.ToInt32(tb_SL.Text);
            string tt = tb_TT.Text.Trim();
            string tgnk = tb_TGNK.Text;
            string mt = tb_MT.Text.Trim();

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IP1RMDOK;Initial Catalog=Quan_ly_thu_vien;Integrated Security=True");
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Sach (Ma_sach, Ten_sach, The_loai, So_luong, Tinh_trang, Thoi_gian_nhap_kho, Mo_ta) values (@ms, @ts, @tl, @sl, @tt, @tgnk, NULL)", conn);

                cmd.Parameters.AddWithValue("@ms", ms);
                cmd.Parameters.AddWithValue("@ts", ts);
                cmd.Parameters.AddWithValue("@tl", tl);
                cmd.Parameters.AddWithValue("@sl", sl);
                cmd.Parameters.AddWithValue("@tt", tt);
                cmd.Parameters.AddWithValue("@tgnk", tgnk);
                cmd.Parameters.AddWithValue("@mt", mt);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sách thành công!");

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

    }
}
