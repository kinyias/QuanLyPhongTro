using QuanLyPhongTro.models;
using QuanLyPhongTro.services;

namespace QuanLyPhongTro.views.Pages
{
    public partial class frmAddRoom : Form
    {
        XuLyPhong xuLyPhong;
        public frmAddRoom()
        {
            InitializeComponent();
            xuLyPhong = new XuLyPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDienTichPhong.Text != "" && txtMaPhong.Text != "" && txtTienPhong.Text != "")
            {
                try
                {
                    Phong p = new Phong(txtMaPhong.Text, double.Parse(txtTienPhong.Text), double.Parse(txtDienTichPhong.Text), true);
                    xuLyPhong.create(p);
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
