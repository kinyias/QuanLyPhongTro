using QuanLyPhongTro.models;
using QuanLyPhongTro.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro.views
{
    public partial class frmEditKhachThue : Form
    {
        KhachHang khachHang;
        XuLyHoaDon xuLyHD;
        XuLyKhachHang xuLyKH;
        XuLyPhong xuLyPhong;
        public frmEditKhachThue(KhachHang kh)
        {
            InitializeComponent();
            khachHang = kh;
            xuLyHD = new XuLyHoaDon();
            xuLyKH = new XuLyKhachHang();
            xuLyPhong = new XuLyPhong();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtMaKhachHang.Text != "" && txtQueQuan.Text != "" && txtSdt.Text != "")
            {
                try
                {
                    KhachHang kh = new KhachHang(txtMaKhachHang.Text, txtHoTen.Text, dtpNgaySinh.Value, txtQueQuan.Text, txtSdt.Text, dtpNgayThue.Value, dtpNgayKetThuc.Value);
                    HoaDon hd = xuLyHD.getAll().Find(h => h.Makhachhang == khachHang.Makhach);
                    hd.Maphong = cmbMaPhong.Text;
                    xuLyPhong.updateTrangThai(hd.Maphong, false);
                    xuLyKH.update(txtMaKhachHang.Text, kh);
                    this.Close();
                }
                catch
                {
                    MessageBoxGuna.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageBoxGuna.Show("Vui lòng nhập đúng định dạng", "Error");
                }
            }
            else
            {
                MessageBoxGuna.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageBoxGuna.Show("Vui lòng điền đầy đủ thông tin", "Error");
            }

        }

        private void frmEditKhachThue_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = khachHang.Makhach;
            txtHoTen.Text = khachHang.Hoten;
            txtQueQuan.Text = khachHang.Quequan;
            txtSdt.Text = khachHang.Sdt;
            dtpNgaySinh.Value = khachHang.Ngaysinh;
            dtpNgayThue.Value = khachHang.Ngaythue;
            dtpNgayKetThuc.Value = khachHang.Ngayketthuc;
            HoaDon hd = xuLyHD.getAll().Find(h => h.Makhachhang == khachHang.Makhach);
            if (xuLyPhong.getAll().Count > 0)
            {
                List<Phong> listPhong = xuLyPhong.getAll().Where(p => p.BooleanTrangThai).ToList();
                foreach (Phong phong in listPhong)
                {
                    cmbMaPhong.Items.Add(phong);
                }
            }
            cmbMaPhong.Text = hd.Maphong;
            xuLyPhong.updateTrangThai(hd.Maphong, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBoxGuna.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            MessageBoxGuna.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            DialogResult result = MessageBoxGuna.Show("Bạn có chắc chắn muốn thoát ?", "Exit");
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dtpNgayThue_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Compare(dtpNgayThue.Value, dtpNgayKetThuc.Value) > 0)
            {
                dtpNgayKetThuc.Value = dtpNgayThue.Value;
            }
        }
    }
}
