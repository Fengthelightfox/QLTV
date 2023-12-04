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
    public partial class Xoa_sach : Form
    {
        public Xoa_sach()
        {
            InitializeComponent();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ms = tb_MS.Text.Trim();
            string connectionString = Connection.CnnString;

            SqlConnection conn = new SqlConnection(connectionString);
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
    }
}
