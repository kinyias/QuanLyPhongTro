using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongTro.models;
using QuanLyPhongTro.services;

namespace QuanLyPhongTro.views.Pages
{
    public partial class UC_KhangHang : UserControl
    {
        XuLyKhachHang xuLyKH;
        XuLyHoaDon xuLyHD;
        XuLyPhong xuLyPhong;
        public UC_KhangHang()
        {
            InitializeComponent();
            xuLyKH = new XuLyKhachHang();
            xuLyHD = new XuLyHoaDon();
            xuLyPhong = new XuLyPhong();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmAddKhachThue frm = new frmAddKhachThue();
            frm.FormClosed += frmClosed;
            frm.ShowDialog();
        }

        private void frmClosed(object? sender, FormClosedEventArgs e)
        {
            xuLyKH.DisplayOnDataGridView(dgvHienThi);
        }

        private void UC_KhangHang_Load(object sender, EventArgs e)
        {
            dgvHienThi.AutoGenerateColumns = false;
            xuLyKH.DisplayOnDataGridView(dgvHienThi);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                KhachHang kh = xuLyKH.getAll().Find(ph => ph.Makhach == dgvHienThi.SelectedRows[0].Cells[0].Value.ToString());
                frmEditKhachThue frm = new frmEditKhachThue(kh);
                frm.FormClosed += frmClosed;
                frm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                KhachHang kh = xuLyKH.getAll().Find(ph => ph.Makhach == dgvHienThi.SelectedRows[0].Cells[0].Value.ToString());
                HoaDon hd = xuLyHD.getAll().Find(h => h.Makhachhang.Contains(kh.Makhach));
                if (hd != null)
                {
                xuLyPhong.updateTrangThai(hd.Maphong, true);
                xuLyHD.delete(hd);
                }
                xuLyKH.delete(kh);
                xuLyKH.DisplayOnDataGridView(dgvHienThi);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
                BindingSource bs = new BindingSource();
                bs.DataSource = xuLyKH.getAll().Where(p => p.Hoten.Contains(txtSearch.Text));
                dgvHienThi.DataSource = bs;
        }
    }
}
