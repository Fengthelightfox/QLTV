using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapnhom
{
    public partial class Form1 : Form
    {
        string connect = @"Data Source=LAPTOP-I1TQ5S0E\MSSQLSERVER01;Initial Catalog=QLSV;Integrated Security=True";
        public dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("select * from TK_QL where Ten_tai_khoan = @dn", conn);
            cmd.Parameters.AddWithValue("@dn", textBox1.Text.Trim());
            try
            {
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if ((textBox1.Text.Trim() == rd["dn"].ToString().Trim()) && textBox2.Text.Trim() == rd["mk"].ToString().Trim())
                    {
                        MessageBox.Show("Đăng nhập thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);coi
            }
             this.Hide();
            manghinhgiaodien f2 = new manghinhgiaodien();
            f2.Show();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(464, 261);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
