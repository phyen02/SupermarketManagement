using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi.quanly
{
    public partial class nhacungcap : Form
    {
        public string chuoi = "Select * from nhacungcap";
        public nhacungcap()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();

        }
        public void clear()
        {
            dta1.Columns[0].HeaderText = "Mã nhà cung cấp"; dta1.Columns[0].Width = 150;
            dta1.Columns[1].HeaderText = "Tên nhà cung cấp"; dta1.Columns[1].Width = 160;
            dta1.Columns[2].HeaderText = "Địa chỉ";
            dta1.Columns[3].HeaderText = "Số điện thoại";
            dta1.Columns[4].HeaderText = "Công nợ";
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_diachi.Text = "";
            txt_congno.Text = "";
            txt_sdt.Text = "";

            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }
        private void nhacungcap_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (txt_tennv.Text == "" || txt_diachi.Text == "" || txt_sdt.Text == "" || txt_congno.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into nhacungcap values(N'" + txt_tennv.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "','" + txt_congno.Text + "' )";
                chuoiketnoi.them_dl(sql1, dta1);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                clear();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update nhacungcap set tenncc = N'" + txt_tennv.Text + "',diachi = N'" + txt_diachi.Text + "',sdt = '" + txt_sdt.Text + "',congno = '" + txt_congno.Text + "' Where mancc = '" + txt_manv.Text + "' ";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from nhacungcap where mancc= '" + txt_manv.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            clear();
            btn_them.Enabled = true;
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
          
            string duongdan = @"D:\Github\Project\Csharp_QuanLySieuThi\excel\taikhoan\";
            string tenfile = "QuanLyNhaCungCap";
            XuatExecl.exportecxel(dta1, duongdan, tenfile);
            MessageBox.Show("Xuất file thành công", "Thông báo ", MessageBoxButtons.OK);
            MessageBox.Show("Duong dan file dc luu :" + duongdan + MessageBoxButtons.OK);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_manv.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_tennv.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_diachi.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txt_sdt.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            txt_congno.Text = dta1.Rows[curow].Cells[4].Value.ToString();
            txt_manv.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_congno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from nhacungcap where tenncc like N'%" + txt_search.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta1);
            clear();
        }
    }
}
