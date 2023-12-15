using QuanLyPhongTro.views.Pages;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            UC_Phong uc = new UC_Phong();
            AddUserControl(uc);
        }
        private void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlPages.Controls.Clear();
            pnlPages.Controls.Add(uc);
            uc.BringToFront();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
