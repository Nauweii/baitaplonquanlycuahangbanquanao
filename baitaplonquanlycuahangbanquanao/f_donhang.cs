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
    public partial class f_donhang : Form
    {
        public f_donhang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_tenkhachhang_Click(object sender, EventArgs e)
        {

        }

        private void label_ngaysinh_Click(object sender, EventArgs e)
        {

        }

        private void f_donhang_Load(object sender, EventArgs e)
        {
            hamdungchung dungchung = new hamdungchung();
            dungchung.ketnoi();
            dungchung.loadgridview("btlMatHang", dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {

        }
    }
}
