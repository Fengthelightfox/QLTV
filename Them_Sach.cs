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
    public partial class Them_Sach : Form
    {
        public Them_Sach()
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

           SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03MSEE3\KHANG;Initial Catalog=QLTV;Integrated Security=True");
           try
           {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Sach (Ma_sach, Ten_sach, The_loai, So_luong, Tinh_trang, Thoi_gian_nhap_kho, Mo_ta) values (@ms, @ts, @tl, @sl, @tt, @tgnk, NULL)", conn);

                cmd.Parameters.AddWithValue("@ms",ms);
                cmd.Parameters.AddWithValue("@ts",ts);
                cmd.Parameters.AddWithValue("@tl",tl);
                cmd.Parameters.AddWithValue("@sl",sl);
                cmd.Parameters.AddWithValue("@tt",tt);
                cmd.Parameters.AddWithValue("@tgnk",tgnk);
                cmd.Parameters.AddWithValue("@mt",mt);

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
            tb_TGNK.Text = string.Empty;
            tb_MT.Text = string.Empty;
        }

        
    }
}
