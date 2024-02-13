namespace QuanLySieuThi
{
    partial class main2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main2));
            this.lb_quyen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_tkquanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_doimk = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_dx = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_phieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_phieuxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_ncc = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_khachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_banhang = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_phieunhap = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_nhapnhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_xuatle = new System.Windows.Forms.ToolStripMenuItem();
            this.bh_bannhieu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_cn5 = new System.Windows.Forms.Label();
            this.lb_cn4 = new System.Windows.Forms.Label();
            this.lb_cn3 = new System.Windows.Forms.Label();
            this.lb_cn2 = new System.Windows.Forms.Label();
            this.lb_cn1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_quyen.Location = new System.Drawing.Point(1067, 603);
            this.lb_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(199, 31);
            this.lb_quyen.TabIndex = 2;
            this.lb_quyen.Text = "Quản Lý                 ";
            this.lb_quyen.Click += new System.EventHandler(this.lb_quyen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_hethong,
            this.mn_quanly,
            this.mn_banhang});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            // 
            // mn_hethong
            // 
            this.mn_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_nhanvien,
            this.mn_tkquanly,
            this.mn_admin,
            this.toolStripMenuItem1,
            this.mn_doimk,
            this.mn_dx});
            this.mn_hethong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.mn_hethong.ForeColor = System.Drawing.Color.Black;
            this.mn_hethong.Name = "mn_hethong";
            this.mn_hethong.Size = new System.Drawing.Size(114, 32);
            this.mn_hethong.Text = " Hệ thống";
            // 
            // mn_nhanvien
            // 
            this.mn_nhanvien.Name = "mn_nhanvien";
            this.mn_nhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mn_nhanvien.Size = new System.Drawing.Size(374, 32);
            this.mn_nhanvien.Text = " - Tài khoản nhân viên";
            this.mn_nhanvien.Click += new System.EventHandler(this.tàiKhoảnNhânViênToolStripMenuItem_Click);
            // 
            // mn_tkquanly
            // 
            this.mn_tkquanly.Name = "mn_tkquanly";
            this.mn_tkquanly.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mn_tkquanly.Size = new System.Drawing.Size(374, 32);
            this.mn_tkquanly.Text = "- Tài khoản Quản lý";
            this.mn_tkquanly.Click += new System.EventHandler(this.mn_tkquanly_Click);
            // 
            // mn_admin
            // 
            this.mn_admin.Name = "mn_admin";
            this.mn_admin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mn_admin.Size = new System.Drawing.Size(374, 32);
            this.mn_admin.Text = "- Tài khoản admin";
            this.mn_admin.Click += new System.EventHandler(this.mn_admin_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(371, 6);
            // 
            // mn_doimk
            // 
            this.mn_doimk.Name = "mn_doimk";
            this.mn_doimk.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mn_doimk.Size = new System.Drawing.Size(374, 32);
            this.mn_doimk.Text = "- Đổi mật khẩu";
            this.mn_doimk.Click += new System.EventHandler(this.mn_doimk_Click);
            // 
            // mn_dx
            // 
            this.mn_dx.Name = "mn_dx";
            this.mn_dx.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mn_dx.Size = new System.Drawing.Size(374, 32);
            this.mn_dx.Text = "- Đăng xuất";
            this.mn_dx.Click += new System.EventHandler(this.mn_dx_Click);
            // 
            // mn_quanly
            // 
            this.mn_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ql_phieunhap,
            this.ql_phieuxuat,
            this.ql_ncc,
            this.ql_khachhang,
            this.ql_nhanvien,
            this.quảnLýSảnPhẩmToolStripMenuItem});
            this.mn_quanly.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.mn_quanly.Name = "mn_quanly";
            this.mn_quanly.Size = new System.Drawing.Size(102, 32);
            this.mn_quanly.Text = "Quản lý ";
            this.mn_quanly.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // ql_phieunhap
            // 
            this.ql_phieunhap.Name = "ql_phieunhap";
            this.ql_phieunhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.ql_phieunhap.Size = new System.Drawing.Size(382, 32);
            this.ql_phieunhap.Text = " - Quản lý phiếu nhập";
            this.ql_phieunhap.Click += new System.EventHandler(this.ql_phieunhap_Click);
            // 
            // ql_phieuxuat
            // 
            this.ql_phieuxuat.Name = "ql_phieuxuat";
            this.ql_phieuxuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.ql_phieuxuat.Size = new System.Drawing.Size(382, 32);
            this.ql_phieuxuat.Text = "- Quản lý phiếu xuất";
            this.ql_phieuxuat.Click += new System.EventHandler(this.ql_phieuxuat_Click);
            // 
            // ql_ncc
            // 
            this.ql_ncc.Name = "ql_ncc";
            this.ql_ncc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.ql_ncc.Size = new System.Drawing.Size(382, 32);
            this.ql_ncc.Text = " - Quản lý nhà cung cấp";
            this.ql_ncc.Click += new System.EventHandler(this.ql_ncc_Click);
            // 
            // ql_khachhang
            // 
            this.ql_khachhang.Name = "ql_khachhang";
            this.ql_khachhang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.ql_khachhang.Size = new System.Drawing.Size(382, 32);
            this.ql_khachhang.Text = "- Quản lý khách hàng";
            this.ql_khachhang.Click += new System.EventHandler(this.ql_khachhang_Click);
            // 
            // ql_nhanvien
            // 
            this.ql_nhanvien.Name = "ql_nhanvien";
            this.ql_nhanvien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.ql_nhanvien.Size = new System.Drawing.Size(382, 32);
            this.ql_nhanvien.Text = " - Quản lý nhân viên";
            this.ql_nhanvien.Click += new System.EventHandler(this.ql_nhanvien_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(382, 32);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "- Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // mn_banhang
            // 
            this.mn_banhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bh_phieunhap,
            this.bh_nhapnhieu,
            this.bh_xuatle,
            this.bh_bannhieu});
            this.mn_banhang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.mn_banhang.Name = "mn_banhang";
            this.mn_banhang.Size = new System.Drawing.Size(112, 32);
            this.mn_banhang.Text = "Bán hàng";
            this.mn_banhang.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // bh_phieunhap
            // 
            this.bh_phieunhap.Name = "bh_phieunhap";
            this.bh_phieunhap.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.bh_phieunhap.Size = new System.Drawing.Size(307, 32);
            this.bh_phieunhap.Text = " - Nhập hàng lẻ";
            this.bh_phieunhap.Click += new System.EventHandler(this.bh_phieunhap_Click);
            // 
            // bh_nhapnhieu
            // 
            this.bh_nhapnhieu.Name = "bh_nhapnhieu";
            this.bh_nhapnhieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.bh_nhapnhieu.Size = new System.Drawing.Size(307, 32);
            this.bh_nhapnhieu.Text = "- Nhập hàng";
            this.bh_nhapnhieu.Click += new System.EventHandler(this.bh_nhapnhieu_Click);
            // 
            // bh_xuatle
            // 
            this.bh_xuatle.Name = "bh_xuatle";
            this.bh_xuatle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.bh_xuatle.Size = new System.Drawing.Size(307, 32);
            this.bh_xuatle.Text = "- Xuất lẻ";
            this.bh_xuatle.Click += new System.EventHandler(this.bh_xuatle_Click);
            // 
            // bh_bannhieu
            // 
            this.bh_bannhieu.Name = "bh_bannhieu";
            this.bh_bannhieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.bh_bannhieu.Size = new System.Drawing.Size(307, 32);
            this.bh_bannhieu.Text = "- Bán hàng";
            this.bh_bannhieu.Click += new System.EventHandler(this.bh_bannhieu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(978, 603);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quyền :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(984, 650);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 34);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chức Năng Khả Dụng";
            // 
            // lb_cn5
            // 
            this.lb_cn5.AutoSize = true;
            this.lb_cn5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.lb_cn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_cn5.Location = new System.Drawing.Point(25, 555);
            this.lb_cn5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cn5.Name = "lb_cn5";
            this.lb_cn5.Size = new System.Drawing.Size(250, 25);
            this.lb_cn5.TabIndex = 11;
            this.lb_cn5.Text = "*                                              ";
            // 
            // lb_cn4
            // 
            this.lb_cn4.AutoSize = true;
            this.lb_cn4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.lb_cn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_cn4.Location = new System.Drawing.Point(25, 512);
            this.lb_cn4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cn4.Name = "lb_cn4";
            this.lb_cn4.Size = new System.Drawing.Size(255, 25);
            this.lb_cn4.TabIndex = 12;
            this.lb_cn4.Text = "*                                               ";
            // 
            // lb_cn3
            // 
            this.lb_cn3.AutoSize = true;
            this.lb_cn3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.lb_cn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_cn3.Location = new System.Drawing.Point(24, 472);
            this.lb_cn3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cn3.Name = "lb_cn3";
            this.lb_cn3.Size = new System.Drawing.Size(260, 25);
            this.lb_cn3.TabIndex = 13;
            this.lb_cn3.Text = "*                                                ";
            // 
            // lb_cn2
            // 
            this.lb_cn2.AutoSize = true;
            this.lb_cn2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.lb_cn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_cn2.Location = new System.Drawing.Point(25, 431);
            this.lb_cn2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cn2.Name = "lb_cn2";
            this.lb_cn2.Size = new System.Drawing.Size(270, 25);
            this.lb_cn2.TabIndex = 14;
            this.lb_cn2.Text = "*                                                  ";
            // 
            // lb_cn1
            // 
            this.lb_cn1.AutoSize = true;
            this.lb_cn1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic);
            this.lb_cn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_cn1.Location = new System.Drawing.Point(25, 389);
            this.lb_cn1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cn1.Name = "lb_cn1";
            this.lb_cn1.Size = new System.Drawing.Size(250, 25);
            this.lb_cn1.TabIndex = 15;
            this.lb_cn1.Text = "*                                              ";
            // 
            // main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLySieuThi.Properties.Resources.hand_drawn_vector_illustration_supermarket_shopping_bag_healthy_food_grocery_store_organic_vegan_food_58464808;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1198, 697);
            this.Controls.Add(this.lb_cn1);
            this.Controls.Add(this.lb_cn2);
            this.Controls.Add(this.lb_cn3);
            this.Controls.Add(this.lb_cn4);
            this.Controls.Add(this.lb_cn5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1216, 744);
            this.MinimumSize = new System.Drawing.Size(1216, 744);
            this.Name = "main2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý siêu thị";
            this.Load += new System.EventHandler(this.main2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_quyen;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mn_hethong;
        public System.Windows.Forms.ToolStripMenuItem mn_nhanvien;
        public System.Windows.Forms.ToolStripMenuItem mn_tkquanly;
        public System.Windows.Forms.ToolStripMenuItem mn_admin;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem mn_doimk;
        public System.Windows.Forms.ToolStripMenuItem mn_dx;
        public System.Windows.Forms.ToolStripMenuItem mn_quanly;
        public System.Windows.Forms.ToolStripMenuItem ql_phieunhap;
        public System.Windows.Forms.ToolStripMenuItem ql_phieuxuat;
        public System.Windows.Forms.ToolStripMenuItem ql_ncc;
        public System.Windows.Forms.ToolStripMenuItem ql_khachhang;
        public System.Windows.Forms.ToolStripMenuItem ql_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mn_banhang;
        public System.Windows.Forms.ToolStripMenuItem bh_phieunhap;
        public System.Windows.Forms.ToolStripMenuItem bh_nhapnhieu;
        public System.Windows.Forms.ToolStripMenuItem bh_xuatle;
        public System.Windows.Forms.ToolStripMenuItem bh_bannhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_cn5;
        public System.Windows.Forms.Label lb_cn4;
        public System.Windows.Forms.Label lb_cn3;
        public System.Windows.Forms.Label lb_cn2;
        public System.Windows.Forms.Label lb_cn1;
    }
}