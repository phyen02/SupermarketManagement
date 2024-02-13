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
    public partial class nhapnhieu : Form
    {
        public int a = 0;
        public int y = 0;
        public nhapnhieu()
        {
            InitializeComponent();
        }

        private void nhapnhieu_Load(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select masp,tensp,donvitinh,solg,gianhap from sanpham where tensp like N'%" + txt_timkiem.Text + "%' ";
            chuoiketnoi.timkiem(load1, db1);
            db1.Columns[0].HeaderText = "Mã sản phẩm"; db1.Columns[0].Width = 120;
            db1.Columns[1].HeaderText = "Tên sản phẩm"; db1.Columns[1].Width = 120;
            db1.Columns[2].HeaderText = "Đơn vị tính"; db1.Columns[4].Width = 120;
            db1.Columns[3].HeaderText = "Số lượng"; db1.Columns[3].Width = 120;
            db1.Columns[4].HeaderText = "Giá nhập"; db1.Columns[2].Width = 120;

        }

        private void db1_Click(object sender, EventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            txt_mathuoc.Text = db1.Rows[curow].Cells[0].Value.ToString();
            txt_tenthuoc.Text = db1.Rows[curow].Cells[1].Value.ToString();
            txt_dangthuoc.Text = db1.Rows[curow].Cells[2].Value.ToString();
            txt_gia.Text = db1.Rows[curow].Cells[4].Value.ToString();
            txt_thuoctrongkho.Text = db1.Rows[curow].Cells[3].Value.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_dangthuoc.Text == "" || txt_gia.Text == "" || txt_mathuoc.Text == "" || txt_tenthuoc.Text == "" || txt_thuoctrongkho.Text == "" || txt_slgban.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK);
            else
            {
                int a = int.Parse(txt_gia.Text);
                int b = int.Parse(txt_slgban.Text);
                int d = int.Parse(txt_thuoctrongkho.Text);
                if (txt_chietKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập chiết khấu!", "Thông báo", MessageBoxButtons.OK);

                }
                else if (txt_slgban.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số lượng bán!", "Thông báo", MessageBoxButtons.OK);
                }

                else
                {
                    int x = d + b;

                    int s = a * b;
                    int n = dta2.Rows.Add();
                    double thanhtien = 0;
                    dta2.Rows[n].Cells[0].Value = txt_mathuoc.Text;
                    dta2.Rows[n].Cells[1].Value = txt_tenthuoc.Text;
                    dta2.Rows[n].Cells[2].Value = txt_dangthuoc.Text;
                    dta2.Rows[n].Cells[3].Value = txt_gia.Text;
                    dta2.Rows[n].Cells[4].Value = txt_slgban.Text;
                    dta2.Rows[n].Cells[5].Value = s.ToString();

                    string sql1 = "Update sanpham set solg ='" + x.ToString() + "'   WHERE masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "'";
                    chuoiketnoi.luu(sql1);
                    string load1 = "Select masp,tensp,donvitinh,solg,gianhap from sanpham where  masp ='" + dta2.Rows[n].Cells[0].Value.ToString() + "' ";
                    chuoiketnoi.Chuoiketnoi(load1, db1);
                    txt_dangthuoc.Text = "";
                    txt_gia.Text = "";
                    txt_mathuoc.Text = "";
                    txt_tenthuoc.Text = "";
                    txt_thuoctrongkho.Text = "";

                    txt_slgban.Text = "";

                    int sc = dta2.Rows.Count;

                    for (int i = 0; i < sc - 1; i++)
                    {

                        thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());


                    }
                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien - thanhtien * g / 100;
                    lb_tien.Text = m.ToString() + " VNĐ";
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int h = a - y;
                string sql1 = "Update sanpham set Solg ='" + h.ToString() + "'   WHERE masp ='" + txt_mathuoc.Text + "'";
                chuoiketnoi.Execute(sql1);
                string load1 = "Select masp,tensp,donvitinh,solg,gianhap from sanpham where  masp ='" + txt_mathuoc.Text + "' ";
                chuoiketnoi.Chuoiketnoi(load1, db1);
                int seleRow = dta2.CurrentCell.RowIndex;
                dta2.Rows.RemoveAt(seleRow);
                double thanhtien = 0;
                int sc = dta2.Rows.Count;
                txt_dangthuoc.Text = "";
                txt_gia.Text = "";
                txt_mathuoc.Text = "";
                txt_tenthuoc.Text = "";
                txt_thuoctrongkho.Text = "";

                txt_slgban.Text = "";
                btn_Xoa.Enabled = false;

                for (int i = 0; i < sc - 1; i++)
                {

                    thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());


                }
                btn_Add.Enabled = true;
                txt_slgban.Enabled = true;
                btn_Xoa.Enabled = false;
                double g = double.Parse(txt_chietKhau.Text.ToString());
                double m = thanhtien - thanhtien * g/100;
                lb_tien.Text = m.ToString();
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa! ", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void dta2_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Add.Enabled = false;
                txt_slgban.Enabled = false;
                btn_Xoa.Enabled = true;
                int curow = dta2.CurrentRow.Index;

                txt_mathuoc.Text = dta2.Rows[curow].Cells[0].Value.ToString();
                txt_tenthuoc.Text = dta2.Rows[curow].Cells[1].Value.ToString();
                txt_dangthuoc.Text = dta2.Rows[curow].Cells[2].Value.ToString();
                txt_gia.Text = dta2.Rows[curow].Cells[3].Value.ToString();
                txt_slgban.Text = dta2.Rows[curow].Cells[4].Value.ToString();
                y = int.Parse(txt_slgban.Text);

                string solg = "Select solg from sanpham where masp ='" + txt_mathuoc.Text + "'";
                SqlDataReader rd3 = chuoiketnoi.showtext(solg);
                while (rd3.Read())
                {
                    a = int.Parse(rd3[0].ToString());

                }

            }
            catch
            {
                MessageBox.Show("Trong!", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_dangthuoc.Text = "";
            txt_gia.Text = "";
            txt_mathuoc.Text = "";
            txt_tenthuoc.Text = "";
            txt_thuoctrongkho.Text = "";

            txt_slgban.Text = "";
            btn_Xoa.Enabled = false;
            txt_slgban.Enabled = true;
            btn_Add.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void TongTien_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttim.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên file ! ", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    double thanhtien = 0;
                    string s = "";
                    int sc = dta2.Rows.Count;
                    for (int i = 0; i < sc - 1; i++)
                    {

                        s += dta2.Rows[i].Cells[1].Value.ToString() + " : " + dta2.Rows[i].Cells[4].Value.ToString() + "    ,   ";
                        thanhtien += double.Parse(dta2.Rows[i].Cells[5].Value.ToString());

                    }
                    double g = double.Parse(txt_chietKhau.Text.ToString());
                    double m = thanhtien - thanhtien * g / 100;

                    string str1 = "Insert into nhapnhieu Values(N'" + s.ToString() + "',N'" + date1.Value + "','" + m.ToString() + "')";
                    chuoiketnoi.them_dl1(str1);
                    string duongdan = "D:\\Github\\Project\\Csharp_QuanLySieuThi\\excel\\NhapNhieu";
                    string tenfile = txttim.Text.ToString();
                    XuatExecl.nhapnhieu(dta2, duongdan, tenfile, lb_tien.Text, lb_Tile.Text, txt_chietKhau.Text);
                    MessageBox.Show("Xuất file thành công", "Thông báo ", MessageBoxButtons.OK);
                    MessageBox.Show("Duong dan file dc luu :" + duongdan + MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_slgban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_chietKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }
}
