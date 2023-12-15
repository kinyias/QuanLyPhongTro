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
    public partial class frmEditPhong : Form
    {
        XuLyPhong xuLy;
        public frmEditPhong()
        {
            InitializeComponent();
            xuLy = new XuLyPhong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGiaTien.Text != "" && cbbMaPhong.SelectedIndex != -1)
            {
                try
                {
                    xuLy.UpdatePhong(cbbMaPhong.SelectedValue.ToString(), double.Parse(txtGiaTien.Text));
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
        void hienThiLenCombobox()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuLy.getAll();
            cbbMaPhong.DisplayMember = "MaPhong";
            cbbMaPhong.ValueMember = "MaPhong";
            cbbMaPhong.DataSource = bs;
        }

        private void frmEditPhong_Load(object sender, EventArgs e)
        {
            hienThiLenCombobox();
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
    }
}
