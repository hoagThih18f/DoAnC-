using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

     int nLeftRect,
     int nTopRect,
     int nRightRect,
     int nButtomRect,
     int nWidthEllipse,
     int nHeightEllipse

 );
        public Form1()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.StartPosition = FormStartPosition.CenterScreen;
            OpenChildForm(new FrmHome());
        }
        public Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(childForm);
            pnl_main.Tag = childForm;

            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachDanhMuc());
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }
        bool sideBarExpand = true; // Biến để kiểm soát trạng thái mở rộng hoặc thu gọn của sidebar

        private void sidebarTransaction_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                if (sidebar.Width < 150)
                {
                    // Mở rộng sidebar
                    sidebar.Width += 30;

                }
                if (sidebar.Width >= 150)
                {
                    sidebarTransaction.Stop(); // Dừng Timer khi đạt chiều rộng tối đa
                    sideBarExpand = false; // Chuyển trạng thái để chuẩn bị cho việc thu gọn
                }
            }
            else
            {
                // Thu gọn sidebar
                sidebar.Width -= 30;
                if (sidebar.Width <= 60)
                {
                    sidebarTransaction.Stop(); // Dừng Timer khi đạt chiều rộng tối thiểu
                    sideBarExpand = true; // Chuyển trạng thái để chuẩn bị cho việc mở rộng
                }
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            sidebarTransaction.Start(); // Bắt đầu quá trình mở rộng hoặc thu gọn

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
     
     

     

       
        

        private void btn_danhmuc_add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThemDanhMuc());
        }

       

      
        private void btn_main_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHome());
        }

        private void pnl_sanpham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sanpham_add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThemSanPham());
        }

        private void btn_danhmuc_list_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachDanhMuc());
        }

      

        private void btn_sanpham_list_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachSanPham());
        }
        
        private void btn_nv_list_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachNhanVien());
        }

        private void btn_nv_add_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThemNhanVien());
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachNhaCungCap());
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTrangChu());
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachSanPham());
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhapHang());
        }
    }
}