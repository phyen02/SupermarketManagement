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

namespace QuanLySieuThi.banhang
{
    public partial class PhieuXuat : Form
    {
        public string chuoi = "Select * from phieuxuat";
        public string chuoi1 = "Select masp,tensp,giaban ,solg,donvitinh from sanpham";
        public string tt = "Flase";
        public int a = 0;
        public int key = 0;
        public string ten = "";

        public void tenbang()
        {
            dta2.Columns[0].HeaderText = "Mã sản phẩm"; dta1.Columns[0].Width = 110;
            dta2.Columns[1].HeaderText = "Tên sản phẩm"; dta1.Columns[1].Width = 150;
            dta2.Columns[2].HeaderText = "Giá bán"; dta1.Columns[2].Width = 110;
            dta2.Columns[3].HeaderText = "Số lượng"; dta1.Columns[3].Width = 110;
            dta2.Columns[4].HeaderText = "Đơn vị tính"; dta1.Columns[3].Width = 110;
            //
            dta1.Columns[0].HeaderText = "Mã phiếu xuất"; dta1.Columns[0].Width = 110;
            dta1.Columns[1].HeaderText = "Mã khách hàng"; dta1.Columns[1].Width = 150;
            dta1.Columns[2].HeaderText = "Mã sản phẩm"; dta1.Columns[2].Width = 110;
            dta1.Columns[3].HeaderText = "Số lượng"; dta1.Columns[3].Width = 110;
            dta1.Columns[4].HeaderText = "Đơn vị tính"; dta1.Columns[4].Width = 110;
            dta1.Columns[5].HeaderText = "Giá bán"; dta1.Columns[5].Width = 110;
            dta1.Columns[6].HeaderText = "Nhân viên bán"; dta1.Columns[6].Width = 110;
            dta1.Columns[7].HeaderText = "Ngày bán"; dta1.Columns[7].Width = 110;
            dta1.Columns[8].HeaderText = "Thành tiền"; dta1.Columns[8].Width = 110;
            dta1.Columns[9].HeaderText = "Công nợ"; dta1.Columns[9].Width = 110;
            dta1.Columns[10].HeaderText = "Trạng thái"; dta1.Columns[10].Width = 110;
            int sc = dta1.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhtien++;
            }
            lbl_kq.Text = thanhtien.ToString() + " Phiếu";
            makh();
            nhanvien();
        }
        public void clear()
        {
            txt_mhd.Text = "";

            txt_mathuoc.Text = "";
            txt_solg.Text = "";
            txt_dvt.Text = "";
            txt_gianhap.Text = "";

            txt_tennv.Text = "";
            txt_tongtien.Text = "";

            txt_congno.Text = "";
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
            bnt_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        public PhieuXuat()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            chuoiketnoi.Chuoiketnoi(chuoi1, dta2);
            tenbang();
           
        }

        private void makh()
        {

            string load_mancc = "Select makh from khachhang";
            chuoiketnoi.xulycbx(load_mancc, txt_mancc);
            txt_mancc.DisplayMember = "makh";
            txt_mancc.ValueMember = "makh";

        }


        private void nhanvien()
        {
            string load_gianhap = "select tennv from nhanvien  ";
            chuoiketnoi.xulycbx(load_gianhap, txt_tennv);

            txt_tennv.DisplayMember = "tennv";
            txt_tennv.ValueMember = "tennv";

        }
        private void PhieuXuat_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_congno.Text == "" || txt_dvt.Text == "" || txt_solg.Text == "" || txt_mathuoc.Text == "" || txt_gianhap.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông tin!", "Error", MessageBoxButtons.OK);
            }
            else
            {

                int c, d;
                c = int.Parse(txt_solg.Text.ToString());
                d = int.Parse(txt_gianhap.Text.ToString());
                if (c > a)
                {
                    MessageBox.Show("Số lượng sản phẩm này trong kho không đủ", "Thông báo ! ");

                }
                else
                {
                    key = c * d;
                    string sql1 = "Insert into phieuxuat values('" + txt_mancc.SelectedValue + "','" + txt_mathuoc.Text + "','" + txt_solg.Text + "',N'" + txt_dvt.Text + "', '" + txt_gianhap.Text + "',N'" + txt_tennv.Text + "','" + txt_ngaynhap.Value + "','" + key.ToString() + "','" + txt_congno.Text + "','" + tt + "' )";
                    chuoiketnoi.them_dl(sql1, dta1);

                    chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                    tenbang();
                    clear();
                }
            }
        }

        private void dta2_Click(object sender, EventArgs e)
        {
            int curow = dta2.CurrentRow.Index;
            txt_mathuoc.Text = dta2.Rows[curow].Cells[0].Value.ToString();
            txt_gianhap.Text = dta2.Rows[curow].Cells[2].Value.ToString();
            txt_dvt.Text = dta2.Rows[curow].Cells[4].Value.ToString();
        }

        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;

            txt_mhd.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_mancc.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_mathuoc.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txt_solg.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            txt_dvt.Text = dta1.Rows[curow].Cells[4].Value.ToString();
            txt_gianhap.Text = dta1.Rows[curow].Cells[5].Value.ToString();
            txt_tennv.Text = dta1.Rows[curow].Cells[6].Value.ToString();
            txt_ngaynhap.Text = dta1.Rows[curow].Cells[7].Value.ToString();
            txt_tongtien.Text = dta1.Rows[curow].Cells[8].Value.ToString();
            txt_congno.Text = dta1.Rows[curow].Cells[9].Value.ToString();
            if (String.Compare(dta1.Rows[curow].Cells[10].Value.ToString(), "true") == 0)
            {
                btn_luu.Enabled = false;
                bnt_sua.Enabled = false;
                btn_xoa.Enabled = false;
                btn_them.Enabled = true;
            }
            else
            {
                btn_luu.Enabled = true;
                bnt_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;
            }

            tenbang();
        }

        private void txt_mathuoc_TextChanged(object sender, EventArgs e)
        {
            string solg = "Select solg from sanpham where masp ='" + txt_mathuoc.Text + "'";
            SqlDataReader rd3 = chuoiketnoi.showtext(solg);
            while (rd3.Read())
            {
                a = int.Parse(rd3[0].ToString());

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
            btn_them.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from phieuxuat where mahdx = '" + txt_mhd.Text + "'";
            chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            tenbang();
            clear();
        }

        private void bnt_sua_Click(object sender, EventArgs e)
        {
            int c, d;
            c = int.Parse(txt_solg.Text.ToString());
            d = int.Parse(txt_gianhap.Text.ToString());
            if (c > a)
            {
                MessageBox.Show("Số lượng sản phẩm này trong kho không đủ", "Thông báo ! ");

            }
            else
            {
                key = c * d;
                string sql = "Update phieuxuat set makh = '" + txt_mancc.SelectedValue + "',masp = '" + txt_mathuoc.Text + "',solg = N'" + txt_solg.Text + "',donvitinh = N'" + txt_dvt.Text + "',giaban = '" + txt_gianhap.Text + "',nvban = N'" + txt_tennv.Text + "',ngayban = '" + txt_ngaynhap.Value + "',thanhtien = '" + key.ToString() + "',congno = N'" + txt_congno.Text + "' where mahdx = '" + txt_mhd.Text + "'";
                chuoiketnoi.Execute1(sql);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                tenbang();
                clear();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            //try
            //{
                string duongdan = "D:\\Github\\Project\\Csharp_QuanLySieuThi\\excel\\ThongTinPhieu\\";
                String tenfile = "PhieuXuat";
                XuatExecl.export_phieu(dta1, duongdan, tenfile, lbl_kq.Text);
                MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
            //}
            //catch (Exception ex)
            //{
                //MessageBox.Show(ex.Message);
            //}
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string s = "true";
            string sql = "Update phieuxuat set trangthai='" + s + "'  WHERE mahdx ='" + txt_mhd.Text + "'";
            MessageBox.Show("Bạn lưu thành công !", "Thông báo", MessageBoxButtons.OK);
            int b = int.Parse(txt_solg.Text.ToString());
            int c = a - b;
            string sql1 = "Update sanpham set solg ='" + c.ToString() + "'   WHERE masp ='" + txt_mathuoc.Text + "'";
            chuoiketnoi.luu(sql1);
            chuoiketnoi.luu(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            chuoiketnoi.Chuoiketnoi(chuoi1, dta2);
            dta2.Columns[0].HeaderText = "Mã sản phẩm"; dta2.Columns[0].Width = 120;
            dta2.Columns[1].HeaderText = "Tên sản phẩm"; dta2.Columns[1].Width = 120;
            dta2.Columns[2].HeaderText = "Giá nhập"; dta2.Columns[2].Width = 120;
            dta2.Columns[3].HeaderText = "Số lượng"; dta2.Columns[3].Width = 120;
            dta2.Columns[4].HeaderText = "Đơn vị tính"; dta2.Columns[4].Width = 120;
            tenbang();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select masp,tensp,giaban ,solg,donvitinh from sanpham where tensp like N'%" + txt_search.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta2);
            tenbang();
        }

        private void txt_solg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_congno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}
