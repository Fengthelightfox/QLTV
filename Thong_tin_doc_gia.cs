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
    public partial class Thong_tin_doc_gia : Form
    {
        public Thong_tin_doc_gia()
        {
            InitializeComponent();
        }

        private void Thong_tin_doc_gia_Load(object sender, EventArgs e)
        {
            string connectionString = Connection.CnnString;
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string queryString = "SELECT * FROM Thong_tin_doc_gia";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Kiểm tra giá trị NULL trước khi gán vào DataGridView
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    if (row[i] == DBNull.Value)
                    {
                        // Nếu giá trị NULL, gán giá trị mặc định hoặc xử lý khác tùy ý
                        row[i] = "Giá trị NULL";
                    }
                }
            }

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Ma_doc_gia"].HeaderText = "Mã độc giả";
            dataGridView1.Columns["Ten_dang_nhap"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["Mat_khau"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["Ho_ten"].HeaderText = "Họ và tên";
            dataGridView1.Columns["So_dien_thoai"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["Dia_chi"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["Email"].HeaderText = "Email";

            connection.Close();
        }
    }
}
