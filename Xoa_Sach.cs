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
    public partial class Xoa_Sach : Form
    {
        public Xoa_Sach()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ms = tb_MS.Text.Trim();

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-03MSEE3\KHANG;Initial Catalog=QLTV;Integrated Security=True");
            try
            {
                conn.Open();

                SqlCommand cmd2 = new SqlCommand("delete from Sach where Ma_sach = @ms", conn);

                cmd2.Parameters.AddWithValue("@ms", ms);

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Xóa sách thành công!");

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
        }
    }
}
