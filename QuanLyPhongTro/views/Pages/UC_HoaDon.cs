using Guna.UI2.WinForms;
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

namespace QuanLyPhongTro.views.Pages
{
    public partial class UC_HoaDon : UserControl
    {
        XuLyHoaDon xuLyHD;
        XuLyKhachHang xuLyKH;
        public UC_HoaDon()
        {
            InitializeComponent();
            xuLyHD = new XuLyHoaDon();
            xuLyKH = new XuLyKhachHang();
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            txtDien.Text = "3400";
            txtNuoc.Text = "6000";
            dgvHienThi.AutoGenerateColumns = false;
            //xuLyHD.DisplayOnDataGridView(dgvHienThi);
             BindingSource bs = new BindingSource();
            bs.DataSource = xuLyHD.getAll().Where(e =>
             {
                 KhachHang kh = xuLyKH.getAll().Find(kh => e.Makhachhang == kh.Makhach);
                 return (kh.Ngayketthuc.Month == DateTime.Now.Month && kh.Ngayketthuc.Year == DateTime.Now.Year);
             }).ToList();
             dgvHienThi.DataSource = bs;
        }

        private void dgvHienThi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                HoaDon hd = xuLyHD.getAll().Find(h => h.Mahoadon == dgvHienThi.SelectedRows[0].Cells[0].Value.ToString());
                frmEditHoaDon frm = new frmEditHoaDon(hd, txtDien.Text, txtNuoc.Text);
                frm.ShowDialog();
                dgvHienThi.ClearSelection();
            }
        }
    }
}
