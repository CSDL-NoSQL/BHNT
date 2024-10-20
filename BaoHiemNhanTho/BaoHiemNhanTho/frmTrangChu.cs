using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoHiemNhanTho
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void thôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmKhachHang formttnv = new frmKhachHang() { TopLevel = false, TopMost = true };
            formttnv.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formttnv);
            formttnv.Show();
        }

        private void thôngTinNgườiThânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmThongTinNguoiThan formttnv = new frmThongTinNguoiThan() { TopLevel = false, TopMost = true };
            formttnv.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formttnv);
            formttnv.Show();
        }

        private void quảnLýDanhSáchBảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmQuanLyBaoHiem formttnv = new frmQuanLyBaoHiem() { TopLevel = false, TopMost = true };
            formttnv.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formttnv);
            formttnv.Show();
        }

        private void thôngTinBảoHiểmSởHữuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.BackgroundImage = null;
            frmThongTinBaoHiemSoHuu formttnv = new frmThongTinBaoHiemSoHuu() { TopLevel = false, TopMost = true };
            formttnv.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(formttnv);
            formttnv.Show();
        }
    }
}
