using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_thu_vien
{
    public partial class Dieu_huong : Form
    {
        public Dieu_huong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thong_tin_nguoi_dung ttnd = new Thong_tin_nguoi_dung();
            ttnd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thong_ke tk = new Thong_ke();
            tk.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==1)
            {
               Them_sach ts = new Them_sach();
               ts.ShowDialog();
            }
            if(comboBox1.SelectedIndex==2)
            {
                Sua_sach ss= new Sua_sach();
                ss.ShowDialog();
            }
            if (comboBox1.SelectedIndex==3)
            {
                Xoa_sach xs =new Xoa_sach();
                xs.ShowDialog();
            }
        }
    }
}
