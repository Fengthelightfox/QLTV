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
    public partial class Muon_sach : Form
    {
        public Muon_sach()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            string maDocGia = tb_maDG.Text.Trim();
            string ms = tb_MS.Text.Trim();
            string connectionString = Connection.CnnString;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                if (dateTimePicker1.Value < dateTimePicker2.Value)
                {
                    SqlCommand cmd = new SqlCommand("insert into Nguoi_muon (Ma_doc_gia, Ma_sach, Ngay_muon, Ngay_tra) values (@mdg,@ms, @nm, @nt)", conn);
                    cmd.Parameters.AddWithValue("@mdg", maDocGia);
                    cmd.Parameters.AddWithValue("@ms", ms);
                    cmd.Parameters.AddWithValue("@nm", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@nt", dateTimePicker2.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mượn sách thành công!");

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
