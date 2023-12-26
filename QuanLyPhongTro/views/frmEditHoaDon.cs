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
    public partial class frmEditHoaDon : Form
    {
        HoaDon hoaDon;
        string dgd;
        string dgn;
        XuLyHoaDon xuLyHD;
        public frmEditHoaDon(HoaDon hd, string donGiaDien, string donGiaNuoc)
        {
            InitializeComponent();
            hoaDon = hd;
            dgd = donGiaDien;
            dgn = donGiaNuoc;
            xuLyHD = new XuLyHoaDon();
        }

        private void frmEditHoaDon_Load(object sender, EventArgs e)
        {
            txtDien.Text = hoaDon.Tiendien.ToString();
            txtNuoc.Text = hoaDon.Tiennuoc.ToString();
            if (!hoaDon.BooleanTrangThai)
            {
                rdoDaDong.Checked = true;
                rdoChuaDong.Checked = false;
            }
            else
            {
                rdoDaDong.Checked = true;
                rdoChuaDong.Checked = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            hoaDon.Tiendien = double.Parse(txtDien.Text) * double.Parse(dgd);
            hoaDon.Tiennuoc = double.Parse(txtNuoc.Text) * double.Parse(dgn);
            if (rdoDaDong.Checked) hoaDon.BooleanTrangThai = true;
            else hoaDon.BooleanTrangThai = false;
            xuLyHD.update(hoaDon.Mahoadon, hoaDon);
            this.Close();
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
    }
}
