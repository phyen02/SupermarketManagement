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
    public partial class nhanvien : Form
    {
        public string chuoi = "select * from nhanvien";
        
        public nhanvien()
        {
            InitializeComponent();
            
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Mã nhân viên";
            dta1.Columns[1].HeaderText = "Tên nhân viên";
            dta1.Columns[2].HeaderText = "Giới tính";
            dta1.Columns[3].HeaderText = "Quê quán";
            dta1.Columns[4].HeaderText = "Số điện thoại";
        }


        public void clear()
        {
            dta1.Columns[0].HeaderText = "Mã nhân viên";
            dta1.Columns[1].HeaderText = "Tên nhân viên";
            dta1.Columns[2].HeaderText = "Giới tính";
            dta1.Columns[3].HeaderText = "Quê quán";
            dta1.Columns[4].HeaderText = "Số điện thoại";
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txtqq.Text = "" ;
            txtsdt.Text = "" ;
            txt_gioitinh.Text = "";
           
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }


        private void nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_manv.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_tennv.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_gioitinh.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txtqq.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            txtsdt.Text = dta1.Rows[curow].Cells[4].Value.ToString();
            txt_manv.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            if (txt_tennv.Text == ""  || txtqq.Text == "" || txtsdt.Text == ""|| txt_gioitinh.Text =="")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into nhanvien values(N'" + txt_tennv.Text + "','" + txt_gioitinh.SelectedItem + "','" + txtqq.Text + "',N'" + txtsdt.Text + "' )";
                chuoiketnoi.them_dl(sql1, dta1);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                clear();
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update nhanvien set tennv = N'" + txt_tennv.Text + "',gioitinh = N'" + txt_gioitinh.SelectedItem + "',quequan = N'" + txtqq.Text + "',sdt = '" + txtsdt.Text + "' Where manv = '"+txt_manv.Text+"' ";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            clear();
            btn_them.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from nhanvien where manv= '"+txt_manv.Text+ "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {

            string duongdan = "D:\\Github\\Project\\Csharp_QuanLySieuThi\\excel\\taikhoan\\";
            string tenfile = "QLnhanvien";
            XuatExecl.exportecxel(dta1, duongdan, tenfile);
            MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
            MessageBox.Show("Duong dan file dc luu :" + duongdan + MessageBoxButtons.OK);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from nhanvien where tennv like N'%" + txt_search.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta1);
            clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
