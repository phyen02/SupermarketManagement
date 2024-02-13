using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class tkquanly : Form
    {
        public string chuoi = "select * from tkquanly";
        public tkquanly()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Tài khoản";
            dta1.Columns[1].HeaderText = "Mật khẩu";
        }

        private void tkquanly_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == "" || txt_mk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string select = "select count(*) from tkquanly where tk='" + txt_tk.Text + "'";
                    string them1 = "insert into tkquanly Values ('" + txt_tk.Text + "','" + txt_mk.Text + "')";
                    chuoiketnoi.Them(select, txt_tk.Text.Trim(), txt_mk.Text.Trim(), them1, dta1);
                    chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                    dta1.Columns[0].HeaderText = "Tài khoản";
                    dta1.Columns[1].HeaderText = "Mật khẩu";
                    txt_tk.Clear();
                    txt_mk.Clear();

                    txt_tk.Focus();
                    btn_them.Enabled = true;
                    btn_xoa.Enabled = false;
                    btn_sua.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại ", "Error", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update tkquanly set mk ='" + txt_mk.Text + "' where tk = '" + txt_tk.Text + "'";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Tài khoản";
            dta1.Columns[1].HeaderText = "Mật khẩu";
            txt_tk.Clear();
            txt_mk.Clear();
            txt_tk.Focus();
            txt_tk.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_tk.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_mk.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_tk.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from tknhanvien  where tk = '" + txt_tk.Text + "'";
            chuoiketnoi.Execute(sql);
            // MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Tài khoản";
            dta1.Columns[1].HeaderText = "Mật khẩu";
            txt_tk.Clear();
            txt_mk.Clear();
            txt_tk.Focus();
            txt_tk.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_tk.Clear();
            txt_mk.Clear();
            txt_tk.Focus();
            txt_tk.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            string duongdan = "C:\\Users\\HPs\\Downloads\\BaiTapLon_QLsieuthi\\excel\\taikhoan\\";
            string tenfile = "TaiKhaon_quanly";
            XuatExecl.exportecxel(dta1, duongdan, tenfile);
            MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
            MessageBox.Show("Duong dan file dc luu :" + duongdan + MessageBoxButtons.OK);
        }
    }
}
