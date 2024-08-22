namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_danhmuc = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_sanpham = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_khachhang = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_nhanvien_sidebar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_main = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sidebar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_thoat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_nhaphang = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_banhang = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sidebarTransaction = new System.Windows.Forms.Timer(this.components);
            this.hoverDelayTimer = new System.Windows.Forms.Timer(this.components);
            this.hoverDelayTimer2 = new System.Windows.Forms.Timer(this.components);
            this.pnl_main = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.hoverDelayTimer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_danhmuc
            // 
            this.btn_danhmuc.BackColor = System.Drawing.Color.Transparent;
            this.btn_danhmuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_danhmuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_danhmuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_danhmuc.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_danhmuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_danhmuc.FillColor = System.Drawing.Color.Transparent;
            this.btn_danhmuc.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_danhmuc.FocusedColor = System.Drawing.Color.Black;
            this.btn_danhmuc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhmuc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_danhmuc.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_danhmuc.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_danhmuc.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_danhmuc.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_danhmuc.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhmuc.Image")));
            this.btn_danhmuc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_danhmuc.Location = new System.Drawing.Point(3, 128);
            this.btn_danhmuc.Name = "btn_danhmuc";
            this.btn_danhmuc.Size = new System.Drawing.Size(182, 50);
            this.btn_danhmuc.TabIndex = 1;
            this.btn_danhmuc.Text = "Danh mục";
            this.btn_danhmuc.UseTransparentBackground = true;
            this.btn_danhmuc.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.BackColor = System.Drawing.Color.Transparent;
            this.btn_sanpham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sanpham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sanpham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sanpham.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sanpham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sanpham.FillColor = System.Drawing.Color.Transparent;
            this.btn_sanpham.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_sanpham.FocusedColor = System.Drawing.Color.Black;
            this.btn_sanpham.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sanpham.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sanpham.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_sanpham.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_sanpham.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_sanpham.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_sanpham.Image = ((System.Drawing.Image)(resources.GetObject("btn_sanpham.Image")));
            this.btn_sanpham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_sanpham.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_sanpham.Location = new System.Drawing.Point(0, 190);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(177, 50);
            this.btn_sanpham.TabIndex = 3;
            this.btn_sanpham.Text = "Sản phẩm";
            this.btn_sanpham.UseTransparentBackground = true;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.BackColor = System.Drawing.Color.Transparent;
            this.btn_khachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_khachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_khachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_khachhang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_khachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_khachhang.FillColor = System.Drawing.Color.Transparent;
            this.btn_khachhang.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_khachhang.FocusedColor = System.Drawing.Color.Black;
            this.btn_khachhang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_khachhang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_khachhang.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_khachhang.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_khachhang.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_khachhang.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_khachhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_khachhang.Image")));
            this.btn_khachhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_khachhang.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_khachhang.Location = new System.Drawing.Point(0, 308);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.Size = new System.Drawing.Size(185, 50);
            this.btn_khachhang.TabIndex = 3;
            this.btn_khachhang.Text = "Khách hàng";
            this.btn_khachhang.UseTransparentBackground = true;
            this.btn_khachhang.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // btn_nhanvien_sidebar
            // 
            this.btn_nhanvien_sidebar.BackColor = System.Drawing.Color.Transparent;
            this.btn_nhanvien_sidebar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhanvien_sidebar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhanvien_sidebar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nhanvien_sidebar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nhanvien_sidebar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nhanvien_sidebar.FillColor = System.Drawing.Color.Transparent;
            this.btn_nhanvien_sidebar.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_nhanvien_sidebar.FocusedColor = System.Drawing.Color.Black;
            this.btn_nhanvien_sidebar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien_sidebar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nhanvien_sidebar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_nhanvien_sidebar.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_nhanvien_sidebar.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_nhanvien_sidebar.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_nhanvien_sidebar.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhanvien_sidebar.Image")));
            this.btn_nhanvien_sidebar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_nhanvien_sidebar.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_nhanvien_sidebar.Location = new System.Drawing.Point(-3, 469);
            this.btn_nhanvien_sidebar.Name = "btn_nhanvien_sidebar";
            this.btn_nhanvien_sidebar.Size = new System.Drawing.Size(177, 50);
            this.btn_nhanvien_sidebar.TabIndex = 3;
            this.btn_nhanvien_sidebar.Text = "Nhân viên";
            this.btn_nhanvien_sidebar.UseTransparentBackground = true;
            this.btn_nhanvien_sidebar.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // btn_main
            // 
            this.btn_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_main.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_main.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_main.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_main.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_main.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_main.FillColor = System.Drawing.Color.Transparent;
            this.btn_main.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_main.Location = new System.Drawing.Point(42, 0);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(122, 63);
            this.btn_main.TabIndex = 7;
            this.btn_main.Text = "Convenience store";
            this.btn_main.UseTransparentBackground = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(47, 46);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // sidebar
            // 
            this.sidebar.Controls.Add(this.btn_thoat);
            this.sidebar.Controls.Add(this.guna2GradientButton7);
            this.sidebar.Controls.Add(this.btn_nhaphang);
            this.sidebar.Controls.Add(this.btn_banhang);
            this.sidebar.Controls.Add(this.btn_main);
            this.sidebar.Controls.Add(this.guna2GradientButton3);
            this.sidebar.Controls.Add(this.guna2PictureBox1);
            this.sidebar.Controls.Add(this.guna2GradientButton1);
            this.sidebar.Controls.Add(this.btn_danhmuc);
            this.sidebar.Controls.Add(this.btn_nhanvien_sidebar);
            this.sidebar.Controls.Add(this.btn_sanpham);
            this.sidebar.Controls.Add(this.btn_khachhang);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.sidebar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.sidebar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(150, 711);
            this.sidebar.TabIndex = 6;
            this.sidebar.Click += new System.EventHandler(this.sidebar_Click);
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel3_Paint);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_thoat.FillColor = System.Drawing.Color.Transparent;
            this.btn_thoat.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_thoat.FocusedColor = System.Drawing.Color.Black;
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_thoat.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_thoat.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_thoat.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_thoat.Location = new System.Drawing.Point(0, 658);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(150, 50);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseTransparentBackground = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // guna2GradientButton7
            // 
            this.guna2GradientButton7.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton7.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton7.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.FocusedColor = System.Drawing.Color.Black;
            this.guna2GradientButton7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2GradientButton7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton7.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton7.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2GradientButton7.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2GradientButton7.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton7.Image")));
            this.guna2GradientButton7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton7.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton7.Location = new System.Drawing.Point(0, 525);
            this.guna2GradientButton7.Name = "guna2GradientButton7";
            this.guna2GradientButton7.Size = new System.Drawing.Size(177, 50);
            this.guna2GradientButton7.TabIndex = 9;
            this.guna2GradientButton7.Text = "Phân quyền";
            this.guna2GradientButton7.UseTransparentBackground = true;
            // 
            // btn_nhaphang
            // 
            this.btn_nhaphang.BackColor = System.Drawing.Color.Transparent;
            this.btn_nhaphang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhaphang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhaphang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nhaphang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nhaphang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nhaphang.FillColor = System.Drawing.Color.Transparent;
            this.btn_nhaphang.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_nhaphang.FocusedColor = System.Drawing.Color.Black;
            this.btn_nhaphang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaphang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nhaphang.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_nhaphang.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_nhaphang.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_nhaphang.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_nhaphang.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhaphang.Image")));
            this.btn_nhaphang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_nhaphang.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_nhaphang.Location = new System.Drawing.Point(0, 244);
            this.btn_nhaphang.Name = "btn_nhaphang";
            this.btn_nhaphang.Size = new System.Drawing.Size(177, 50);
            this.btn_nhaphang.TabIndex = 9;
            this.btn_nhaphang.Text = "Nhập hàng";
            this.btn_nhaphang.UseTransparentBackground = true;
            this.btn_nhaphang.Click += new System.EventHandler(this.btn_nhaphang_Click);
            // 
            // btn_banhang
            // 
            this.btn_banhang.BackColor = System.Drawing.Color.Transparent;
            this.btn_banhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_banhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_banhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_banhang.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_banhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_banhang.FillColor = System.Drawing.Color.Transparent;
            this.btn_banhang.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_banhang.FocusedColor = System.Drawing.Color.Black;
            this.btn_banhang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_banhang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_banhang.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_banhang.HoverState.BorderColor = System.Drawing.Color.White;
            this.btn_banhang.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btn_banhang.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_banhang.Image = ((System.Drawing.Image)(resources.GetObject("btn_banhang.Image")));
            this.btn_banhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_banhang.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_banhang.Location = new System.Drawing.Point(0, 72);
            this.btn_banhang.Name = "btn_banhang";
            this.btn_banhang.Size = new System.Drawing.Size(185, 50);
            this.btn_banhang.TabIndex = 9;
            this.btn_banhang.Text = "Bán hàng";
            this.btn_banhang.UseTransparentBackground = true;
            this.btn_banhang.Click += new System.EventHandler(this.btn_banhang_Click);
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.FocusedColor = System.Drawing.Color.Black;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2GradientButton3.Location = new System.Drawing.Point(0, 364);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(193, 50);
            this.guna2GradientButton3.TabIndex = 9;
            this.guna2GradientButton3.Text = "Nhà cung cấp";
            this.guna2GradientButton3.UseTransparentBackground = true;
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click_1);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FocusedColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2GradientButton1.Location = new System.Drawing.Point(3, 420);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(171, 50);
            this.guna2GradientButton1.TabIndex = 8;
            this.guna2GradientButton1.Text = "Thống kê";
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // sidebarTransaction
            // 
            this.sidebarTransaction.Enabled = true;
            this.sidebarTransaction.Interval = 10;
            this.sidebarTransaction.Tick += new System.EventHandler(this.sidebarTransaction_Tick);
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_main.FillColor2 = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_main.Location = new System.Drawing.Point(150, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1220, 711);
            this.pnl_main.TabIndex = 7;
            this.pnl_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_main_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1370, 711);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_danhmuc;
        private Guna.UI2.WinForms.Guna2GradientButton btn_nhanvien_sidebar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_khachhang;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sanpham;
        private Guna.UI2.WinForms.Guna2GradientPanel sidebar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_main;
        private System.Windows.Forms.Timer sidebarTransaction;
        private System.Windows.Forms.Timer hoverDelayTimer;
        private System.Windows.Forms.Timer hoverDelayTimer2;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_main;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Timer hoverDelayTimer3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_banhang;
        private Guna.UI2.WinForms.Guna2GradientButton btn_nhaphang;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton7;
        private Guna.UI2.WinForms.Guna2GradientButton btn_thoat;
    }
}

