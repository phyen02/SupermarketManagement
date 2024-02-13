using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLySieuThi
{
    class chuoiketnoi
    {
        public static string sqlcon = @"Data Source=DUCKIE\K;Initial Catalog=QuanLySieuThi;Integrated Security=True";
        private static SqlConnection mycon;

        public static SqlConnection Mycon
        {
            get { return chuoiketnoi.mycon; }
            set { chuoiketnoi.mycon = value; }
        }
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;

        public static SqlCommandBuilder bd;
        public static SqlDataReader showtext(string sql)
        {
            SqlDataReader read = null;
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                read = com.ExecuteReader();

            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi kết nối!\n" + ex.Message); }
            return read;
        }
        // ham ket noi
        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }


// n bao câu lệnh chuoi select * cua minh sai

        public static void timkiem(string chuoi, DataGridView db2)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
            cbx.DataSource = dt;


        }


        public static void dodata(string chuoi, DataTable dt)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();

            ad.Fill(dt);
        }

	// ham xu ly thêm
        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Them Thanh công !", "Thong báo ");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+""+ex);
            }

        }


        public static void them_dl1(string sql1)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                
                mycon.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("");
            }

        }

        public static void Them(string select, String tk, String pass, String sql1, DataGridView dt)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();
            
            if (i != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại ! ", "Error", MessageBoxButtons.OKCancel);
            }
            else
            {
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql1, mycon);
                    ad = new SqlDataAdapter(com);
                    DataTable tb = new DataTable();
                    ad.Fill(tb);
                    dt.DataSource = tb;
                    MessageBox.Show("Them Thanh công !", "Thong báo ");
                    mycon.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                }
            }
        }
        public static void Themdangky(string select, String tk, String pass, String sql1)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            com = new SqlCommand(sql, mycon);
            i = (int)com.ExecuteScalar();


            if (i != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại ! ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    luu(sql1);


                    if (MessageBox.Show("Thêm Thành công !Bạn có muốn đăng nhập luôn không ?", "Thông Báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Dangnhap dt = new Dangnhap();
                       dt.Show();
                        DangKy a = new DangKy();
                        a.Close();
                    }
                    mycon.Close();
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                }
            }
        }



        // kta ton tai tai khoan
        public static void ktratk(string tk,string newmk, string repass, string sql1, string sql2, string sql3)
        {
            int a = 0, b = 0, c = 0;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            if (tk == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản ", "Thông báo", MessageBoxButtons.OK);
            }
           
            else
            {

                com = new SqlCommand(sql1, mycon);
                a = (int)com.ExecuteScalar();

                SqlCommand com1 = new SqlCommand(sql2, mycon);
                b = (int)com1.ExecuteScalar();

                SqlCommand com2 = new SqlCommand(sql3, mycon);
                c = (int)com2.ExecuteScalar(); // tra ve 0 hoac 1 
                // neu tra ve ten nguoi dung da ton tai va ta co the doi mk
                // tra ve 0 thi tai khoan ko ton tai nen ko doi dc mk



                if (a > 0)
                {
                    if (newmk == repass)
                    {
                        string sql4 = "update Admin set mk = '" + newmk + "' where tk='" + tk + "'";
                        luu(sql4);
                        MessageBox.Show("Bạn đổi thành công mật khẩu ?", "Thông báo ", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        MessageBox.Show("Phần mật khẩu mới và nhập lại không trùng khớp ! Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
                else if (b > 0)
                {
                    if (newmk == repass)
                    {

                        string sql5 = "update tknhanvien set mk = '" + newmk + "' where tk='" + tk + "'";
                        luu(sql5);
                        MessageBox.Show("Bạn đổi thành công mật khẩu ?", "Thông báo ", MessageBoxButtons.OKCancel);

                    }
                    else
                    {
                        MessageBox.Show("Phần mật khẩu mới và nhập lại không trùng khớp ! Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK);
                    }

                }
                else if (c > 0)
                {
                    if (newmk == repass)
                    {
                        string sql6 = "update tkquanly set mk = '" + newmk + "' where tk='" + tk + "'";
                        luu(sql6);
                        MessageBox.Show("Bạn đổi thành công mật khẩu ?", "Thông báo ", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        MessageBox.Show("Phần mật khẩu mới và nhập lại không trùng khớp ! Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK);
                    }

                }
                else
                {


                    string t = "Tai khoản này không tồn tại !,Bạn vui lòng kiểm tra lại ";
                    MessageBox.Show((t), "thong báo", MessageBoxButtons.OK);



                }

            }
        }


        public static void Xoa(string sql)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Tài khoản bạn sửa trùng với tài khoản đã có ! Vui lòng ktra lại ");
            }

        }
        public static void luu(string sql)
        {


            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                com.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        public static void Execute(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn xóa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        public static void Execute1(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
       
    }
}

          