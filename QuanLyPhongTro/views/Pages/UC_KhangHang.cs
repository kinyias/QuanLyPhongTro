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
            xuLyKH.create(new KhachHang("101", "Nguyen Van A", DateTime.Now, "1 duong so 1 quan 1 TP HCM", "0912345678", DateTime.Now, DateTime.Now));
            xuLyKH.create(new KhachHang("102", "Nguyen Van B", DateTime.Now, "2 duong so 2 quan 3 TP HCM", "0912345678", DateTime.Now, DateTime.Now));
            xuLyKH.create(new KhachHang("103", "Nguyen Van C", DateTime.Now, "3 duong so 3 quan 3 TP HCM", "0912345678", DateTime.Now, DateTime.Now));
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
                xuLyPhong.updateTrangThai(hd.Maphong, true);
                xuLyKH.delete(kh);
                xuLyKH.DisplayOnDataGridView(dgvHienThi);
            }
        }
    }
}
