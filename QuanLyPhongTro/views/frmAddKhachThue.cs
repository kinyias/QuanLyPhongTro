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
    public partial class frmAddKhachThue : Form
    {
        XuLyKhachHang xuLyKH;
        XuLyPhong xuLyPhong;
        XuLyHoaDon xuLyHD;
        public frmAddKhachThue()
        {
            InitializeComponent();
            xuLyKH = new XuLyKhachHang();
            xuLyPhong = new XuLyPhong();
            xuLyHD = new XuLyHoaDon();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text != "" && txtHoTen.Text != "" & txtQueQuan.Text != "" & txtSdt.Text != "")
            {
                try
                {
                    KhachHang kh = new KhachHang(txtMaKhachHang.Text, cmbMaPhong.Text, txtHoTen.Text, dtpNgaySinh.Value, txtQueQuan.Text, txtSdt.Text, dtpNgayThue.Value, dtpNgayKetThuc.Value);
                    xuLyHD.create(new HoaDon(xuLyHD.getAll().Count.ToString(), txtMaKhachHang.Text, 0, 0, cmbMaPhong.Text, false));
                    xuLyKH.create(kh);
                    xuLyPhong.updateTrangThai(cmbMaPhong.Text, false);
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

        private void frmAddKhachThue_Load(object sender, EventArgs e)
        {
            if (xuLyPhong.getAll().Count > 0)
            {
                List<Phong> listPhong = xuLyPhong.getAll().Where(p => p.BooleanTrangThai).ToList();
                foreach (Phong phong in listPhong)
                {
                    cmbMaPhong.Items.Add(phong);
                }
            }
        }

        private void dtpNgayThue_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpNgayThue.Value, dtpNgayKetThuc.Value) > 0)
            {
                dtpNgayKetThuc.Value = dtpNgayThue.Value;
            }
        }

        private void txtSoNgayO_TextChanged(object sender, EventArgs e)
        {
            if(txtSoNgayO.Text != "")
            {
                dtpNgayKetThuc.Value = dtpNgayKetThuc.Value.AddDays(Double.Parse(txtSoNgayO.Text));
            }
        }
    }
}
