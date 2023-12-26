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
    public partial class frmThongTinKhacThue : Form
    {
        XuLyKhachHang xuLyKH;
        XuLyHoaDon xuLyHD;
        Phong p;
        public frmThongTinKhacThue(Phong phong)
        {
            InitializeComponent();
            xuLyKH = new XuLyKhachHang();
            xuLyHD = new XuLyHoaDon();
            p = phong;
        }

        private void btnCanle_Click(object sender, EventArgs e)
        {
            MessageBoxGuna.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            MessageBoxGuna.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            DialogResult result = MessageBoxGuna.Show("Bạn có chắc chắn muốn thoát ?", "Exit");
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text != "" && txtHoTen.Text != "" & txtQueQuan.Text != "" & txtSdt.Text != "")
            {
                try
                {
                    KhachHang kh = new KhachHang(txtMaKhachHang.Text, txtHoTen.Text, dtpNgaySinh.Value, txtQueQuan.Text, txtSdt.Text, dtpNgayThue.Value, dtpNgayKetThuc.Value);
                    p.BooleanTrangThai = false;
                    xuLyHD.create(new HoaDon(xuLyHD.getAll().Count.ToString(), kh.Makhach, 0, 0, p.Maphong, false));
                    xuLyKH.create(kh);
                    this.Close();
                }
                catch
                {

                }
            }
            else
            {
                MessageBoxGuna.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageBoxGuna.Show("Vui lòng điền đầy đủ thông tin", "Error");
            }
        }

        private void dtpNgayThue_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpNgayThue.Value, dtpNgayKetThuc.Value) > 0)
            {
                dtpNgayKetThuc.Value = dtpNgayThue.Value;
            }
        }
    }
}
