using DocumentFormat.OpenXml.Drawing.Diagrams;
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

namespace màn_hình_giao_diện
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lich_su_muon_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = CNTT\SQLEXPRESS; Initial Catalog = QLTV; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string queryString = "SELECT * FROM Lich_su_muon";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns["Ma_doc_gia"].HeaderText = "Mã đọc giả";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();

        }

    }
}
