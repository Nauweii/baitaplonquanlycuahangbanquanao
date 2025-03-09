using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplonquanlycuahangbanquanao
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
        }

        private void f_main_Load(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_donhang fDonhang = new f_donhang();
            fDonhang.MdiParent = this;
            fDonhang.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hàngHoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_hanghoa f_Hanghoa = new f_hanghoa();
            f_Hanghoa.MdiParent = this; 
            f_Hanghoa.Show();
        }

        private void đốiTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_nhacungcap f_Nhacungcap = new f_nhacungcap();
            f_Nhacungcap.MdiParent = this;  
            f_Nhacungcap.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_nhaphang f_Nhaphang = new f_nhaphang();
            f_Nhaphang.MdiParent = this;
            f_Nhaphang.Show();
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_tonkho f_Tonkho = new f_tonkho();
            f_Tonkho.MdiParent = this;
            f_Tonkho.Show();    
        }

        private void doanhSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_doanhthu f_Doanhthu = new f_doanhthu();
            f_Doanhthu.MdiParent = this;
            f_Doanhthu.Show();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_nhanvien f_Nhanvien = new f_nhanvien();
            f_Nhanvien.MdiParent = this;
            f_Nhanvien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_khachhang f_Khachhang = new f_khachhang();
            f_Khachhang.MdiParent = this;
            f_Khachhang.Show();
        }
    }
}
