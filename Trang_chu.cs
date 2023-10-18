﻿using System;
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
    public partial class Trang_chu : Form
    {
        public Trang_chu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-IP1RMDOK;Initial Catalog=Quan_ly_thu_vien;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString); 
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from Nguoi_muon", connection);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Ma_doc_gia"].HeaderText = "Mã độc giả";
                dataGridView1.Columns["Ma_sach"].HeaderText = "Mã sách";
                dataGridView1.Columns["Ngay_muon"].HeaderText = "Ngày mượn";
                dataGridView1.Columns["Ngay_tra"].HeaderText = "Ngày trả";


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trang_chu t1 = new Trang_chu();
            t1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
           // Dang_nhap dn = new Dang_nhap();
            //dn.ShowDialog();
        }
    }
}
