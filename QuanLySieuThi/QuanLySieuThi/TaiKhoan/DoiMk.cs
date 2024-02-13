using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.TaiKhoan
{
    public partial class DoiMk : Form
    {
        public DoiMk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql1 = "Select count(*) from Admin where tk='" + txt_tk.Text.Trim() + "' ";
            string sql2 = "Select count(*) from tknhanvien where tk ='" + txt_tk.Text + "'";
            string sql3 = "Select count(*) from tkquanly where tk='" + txt_tk.Text + "' ";
            if (txt_newmk.Text.Length < 6)
            {
                MessageBox.Show("Mat khẩu bạn nhập ít nhất phải dài 6 ký tự", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                chuoiketnoi.ktratk(txt_tk.Text, txt_newmk.Text, txt_remk.Text, sql1, sql2, sql3);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                txt_newmk.UseSystemPasswordChar = true;
                txt_remk.UseSystemPasswordChar = true;

            }
            else
                txt_newmk.UseSystemPasswordChar = false;
        }
    }
}
