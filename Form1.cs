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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-68OEJ1PK\SQLEXPRESS; Initial Catalog = QLTV; Integrated Security = True;");
            try {
                conn.Open();

                string sqlCommandText = "SELECT * FROM Sach WHERE ";

                // Thêm điều kiện từ TextBox và ComboBox vào câu truy vấn
                if (!string.IsNullOrEmpty(mstb.Text))
                {
                    sqlCommandText += "Ma_sach = '" + mstb.Text + "' AND ";
                }
                if (!string.IsNullOrEmpty(tstb.Text))
                {
                    sqlCommandText += "Ten_sach = N'" + tstb.Text + "' AND ";
                }
                if (tlcb.SelectedIndex != -1)
                {
                    string selectedValue = tlcb.SelectedItem.ToString(); // Lấy giá trị được chọn từ ComboBox
                    sqlCommandText += "The_loai = N'" + selectedValue + "' AND ";
                }
                if (ttcb.SelectedIndex != -1)
                {
                    string selectedValue = ttcb.SelectedItem.ToString(); // Lấy giá trị được chọn từ ComboBox
                    sqlCommandText += "Tinh_trang = N'" + selectedValue + "' AND ";
                }


                // Loại bỏ "AND" cuối cùng nếu có
                if (sqlCommandText.EndsWith("AND "))
                {
                    sqlCommandText = sqlCommandText.Substring(0, sqlCommandText.Length - 5);
                }

                // Tạo SqlCommand và thực hiện truy vấn
                SqlCommand cmd = new SqlCommand(sqlCommandText, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adt;
                DataTable dt = new DataTable();
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns["Ma_sach"].HeaderText = "Mã sách ";
                dataGridView1.Columns["Ten_sach"].HeaderText = "Tên sách ";
                dataGridView1.Columns["The_loai"].HeaderText = "Thể loại ";
                dataGridView1.Columns["So_luong"].HeaderText = "Số lượng ";
                dataGridView1.Columns["Tinh_trang"].HeaderText = "Tình trạng  ";
                dataGridView1.Columns["Thoi_gian_nhap_kho"].Visible = false;
                dataGridView1.Columns["Mo_ta"].HeaderText = "Mô tả ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
