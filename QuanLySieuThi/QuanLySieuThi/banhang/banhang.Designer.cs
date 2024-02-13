namespace QuanLySieuThi.banhang
{
    partial class banhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banhang));
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_tenthuoc = new System.Windows.Forms.TextBox();
            this.txt_mathuoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_dangthuoc = new System.Windows.Forms.TextBox();
            this.txt_slgban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_thuoctrongkho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.db1 = new System.Windows.Forms.DataGridView();
            this.lb_Tile = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.lb_tien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_chietKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dta2 = new System.Windows.Forms.DataGridView();
            this.dta_mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_dangthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TongTien = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta2)).BeginInit();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(779, 38);
            this.date1.Margin = new System.Windows.Forms.Padding(4);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(136, 22);
            this.date1.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_tenthuoc);
            this.groupBox1.Controls.Add(this.txt_mathuoc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_dangthuoc);
            this.groupBox1.Controls.Add(this.txt_slgban);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_thuoctrongkho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(857, 176);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Loại Sản Phẩm";
            // 
            // txt_gia
            // 
            this.txt_gia.Enabled = false;
            this.txt_gia.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(670, 35);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(123, 27);
            this.txt_gia.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(569, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "Giá Nhập";
            // 
            // txt_tenthuoc
            // 
            this.txt_tenthuoc.Enabled = false;
            this.txt_tenthuoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenthuoc.Location = new System.Drawing.Point(140, 81);
            this.txt_tenthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenthuoc.Name = "txt_tenthuoc";
            this.txt_tenthuoc.Size = new System.Drawing.Size(223, 27);
            this.txt_tenthuoc.TabIndex = 1;
            // 
            // txt_mathuoc
            // 
            this.txt_mathuoc.Enabled = false;
            this.txt_mathuoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mathuoc.Location = new System.Drawing.Point(140, 33);
            this.txt_mathuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mathuoc.Name = "txt_mathuoc";
            this.txt_mathuoc.Size = new System.Drawing.Size(95, 27);
            this.txt_mathuoc.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Đơn vị tính";
            // 
            // txt_dangthuoc
            // 
            this.txt_dangthuoc.Enabled = false;
            this.txt_dangthuoc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dangthuoc.Location = new System.Drawing.Point(140, 129);
            this.txt_dangthuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dangthuoc.Name = "txt_dangthuoc";
            this.txt_dangthuoc.Size = new System.Drawing.Size(97, 27);
            this.txt_dangthuoc.TabIndex = 2;
            // 
            // txt_slgban
            // 
            this.txt_slgban.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_slgban.Location = new System.Drawing.Point(670, 129);
            this.txt_slgban.Margin = new System.Windows.Forms.Padding(4);
            this.txt_slgban.Name = "txt_slgban";
            this.txt_slgban.Size = new System.Drawing.Size(76, 27);
            this.txt_slgban.TabIndex = 5;
            this.txt_slgban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_slgban_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng Nhập";
            // 
            // txt_thuoctrongkho
            // 
            this.txt_thuoctrongkho.Enabled = false;
            this.txt_thuoctrongkho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thuoctrongkho.Location = new System.Drawing.Point(670, 81);
            this.txt_thuoctrongkho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thuoctrongkho.Name = "txt_thuoctrongkho";
            this.txt_thuoctrongkho.Size = new System.Drawing.Size(76, 27);
            this.txt_thuoctrongkho.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng sản phẩm trong kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(63, 70);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 139);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập Tên Sản Phẩm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 2;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(13, 28);
            this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(220, 45);
            this.txt_timkiem.TabIndex = 1;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // db1
            // 
            this.db1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db1.Location = new System.Drawing.Point(339, 70);
            this.db1.Margin = new System.Windows.Forms.Padding(4);
            this.db1.Name = "db1";
            this.db1.RowHeadersWidth = 51;
            this.db1.Size = new System.Drawing.Size(577, 139);
            this.db1.TabIndex = 52;
            this.db1.Click += new System.EventHandler(this.db1_Click);
            // 
            // lb_Tile
            // 
            this.lb_Tile.AutoSize = true;
            this.lb_Tile.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lb_Tile.Location = new System.Drawing.Point(399, 16);
            this.lb_Tile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Tile.Name = "lb_Tile";
            this.lb_Tile.Size = new System.Drawing.Size(215, 48);
            this.lb_Tile.TabIndex = 68;
            this.lb_Tile.Text = "Bán Hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(544, 706);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 21);
            this.label11.TabIndex = 67;
            this.label11.Text = "Tên file Excel";
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(679, 692);
            this.txttim.Margin = new System.Windows.Forms.Padding(4);
            this.txttim.Multiline = true;
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(235, 38);
            this.txttim.TabIndex = 60;
            // 
            // lb_tien
            // 
            this.lb_tien.AutoSize = true;
            this.lb_tien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tien.Location = new System.Drawing.Point(181, 762);
            this.lb_tien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tien.Name = "lb_tien";
            this.lb_tien.Size = new System.Drawing.Size(95, 21);
            this.lb_tien.TabIndex = 66;
            this.lb_tien.Text = ".................";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 762);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "( Ngàn Đồng )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 711);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 762);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 63;
            this.label6.Text = "Thành Tiền";
            // 
            // txt_chietKhau
            // 
            this.txt_chietKhau.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chietKhau.Location = new System.Drawing.Point(185, 692);
            this.txt_chietKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chietKhau.Multiline = true;
            this.txt_chietKhau.Name = "txt_chietKhau";
            this.txt_chietKhau.Size = new System.Drawing.Size(51, 35);
            this.txt_chietKhau.TabIndex = 59;
            this.txt_chietKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_chietKhau_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 708);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 62;
            this.label5.Text = "Chiết Khấu";
            // 
            // dta2
            // 
            this.dta2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dta2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dta_mathuoc,
            this.dta_tenthuoc,
            this.dta_dangthuoc,
            this.dta_giaban,
            this.dta_soluong,
            this.dta_tongTien});
            this.dta2.Location = new System.Drawing.Point(59, 459);
            this.dta2.Margin = new System.Windows.Forms.Padding(4);
            this.dta2.Name = "dta2";
            this.dta2.RowHeadersWidth = 51;
            this.dta2.Size = new System.Drawing.Size(857, 217);
            this.dta2.TabIndex = 58;
            this.dta2.Click += new System.EventHandler(this.dta2_Click);
            // 
            // dta_mathuoc
            // 
            this.dta_mathuoc.HeaderText = "Mã sản phẩm";
            this.dta_mathuoc.MinimumWidth = 6;
            this.dta_mathuoc.Name = "dta_mathuoc";
            this.dta_mathuoc.Width = 125;
            // 
            // dta_tenthuoc
            // 
            this.dta_tenthuoc.HeaderText = "Tên sản phẩm";
            this.dta_tenthuoc.MinimumWidth = 6;
            this.dta_tenthuoc.Name = "dta_tenthuoc";
            this.dta_tenthuoc.Width = 125;
            // 
            // dta_dangthuoc
            // 
            this.dta_dangthuoc.HeaderText = "Đơn vị tính";
            this.dta_dangthuoc.MinimumWidth = 6;
            this.dta_dangthuoc.Name = "dta_dangthuoc";
            this.dta_dangthuoc.Width = 125;
            // 
            // dta_giaban
            // 
            this.dta_giaban.HeaderText = "Giá bán";
            this.dta_giaban.MinimumWidth = 6;
            this.dta_giaban.Name = "dta_giaban";
            this.dta_giaban.Width = 125;
            // 
            // dta_soluong
            // 
            this.dta_soluong.HeaderText = "Số Lượng";
            this.dta_soluong.MinimumWidth = 6;
            this.dta_soluong.Name = "dta_soluong";
            this.dta_soluong.Width = 125;
            // 
            // dta_tongTien
            // 
            this.dta_tongTien.HeaderText = "Thành Tiền";
            this.dta_tongTien.MinimumWidth = 6;
            this.dta_tongTien.Name = "dta_tongTien";
            this.dta_tongTien.Width = 125;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::QuanLySieuThi.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_revert;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(548, 400);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 52);
            this.button3.TabIndex = 56;
            this.button3.Text = "Nhập Lại";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLySieuThi.Properties.Resources.Hopstarter_Sleek_Xp_Software_Windows_Close_Program;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(777, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 52);
            this.button1.TabIndex = 57;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TongTien
            // 
            this.TongTien.Image = global::QuanLySieuThi.Properties.Resources.Ziggy19_Microsoft_Office_Mac_Tilt_Excel;
            this.TongTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TongTien.Location = new System.Drawing.Point(767, 738);
            this.TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(149, 43);
            this.TongTien.TabIndex = 61;
            this.TongTien.Text = "Xuat Excel";
            this.TongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TongTien.UseVisualStyleBackColor = true;
            this.TongTien.Click += new System.EventHandler(this.TongTien_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::QuanLySieuThi.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Trash_can;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(297, 400);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(125, 52);
            this.btn_Xoa.TabIndex = 55;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = global::QuanLySieuThi.Properties.Resources.Awicons_Vista_Artistic_Add__1_;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.Location = new System.Drawing.Point(56, 400);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(131, 52);
            this.btn_Add.TabIndex = 54;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(972, 795);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.db1);
            this.Controls.Add(this.lb_Tile);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.lb_tien);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_chietKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dta2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(990, 842);
            this.MinimumSize = new System.Drawing.Size(990, 842);
            this.Name = "banhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý siêu thị";
            this.Load += new System.EventHandler(this.banhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_tenthuoc;
        private System.Windows.Forms.TextBox txt_mathuoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_dangthuoc;
        private System.Windows.Forms.TextBox txt_slgban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_thuoctrongkho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView db1;
        private System.Windows.Forms.Label lb_Tile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button TongTien;
        private System.Windows.Forms.Label lb_tien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_chietKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_dangthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_tongTien;
    }
}