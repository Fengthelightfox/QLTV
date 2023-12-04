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
    public partial class Thong_ke : Form
    {
        public Thong_ke()
        {
            InitializeComponent();
        }

        private void Thong_ke_Load(object sender, EventArgs e)
        {
            string connectionString = Connection.CnnString;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryString = "SELECT * FROM Sach";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns["Ma_sach"].HeaderText = "Mã sách";
                dataGridView1.Columns["Ten_sach"].HeaderText = "Tên sách";
                dataGridView1.Columns["The_loai"].HeaderText = "Thể loại";
                dataGridView1.Columns["So_luong"].HeaderText = "Số lượng";
                dataGridView1.Columns["Tinh_trang"].HeaderText = "Tình trạng";
                dataGridView1.Columns["Thoi_gian_nhap_kho"].HeaderText = "Thời gian nhập kho";
                dataGridView1.Columns["Mo_ta"].HeaderText = "Mô tả";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
