using QuanLyPhongTro.models;
using QuanLyPhongTro.services;
using System.Data;

namespace QuanLyPhongTro.views.Pages
{
    public partial class UC_Phong : UserControl
    {
        XuLyPhong xuLy;
        public UC_Phong()
        {
            InitializeComponent();
            xuLy = new XuLyPhong();
        }

        private void UC_Phong_Load(object sender, EventArgs e)
        {
            xuLy = new XuLyPhong();
            xuLy.create(new Phong("101", 100, 50, true));
            xuLy.create(new Phong("102", 120, 60, false));
            xuLy.create(new Phong("103", 150, 70, true));
            xuLy.DisplayOnDataGridView(dgvHienThi);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAddRoom frm = new frmAddRoom();
            frm.FormClosed += frmClosed;
            frm.ShowDialog();
        }

        private void frmClosed(object? sender, FormClosedEventArgs e)
        {
            xuLy.DisplayOnDataGridView(dgvHienThi);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmEditPhong frm = new frmEditPhong();
            frm.FormClosed += frmClosed;
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHienThi.SelectedRows.Count > 0)
            {
                Phong p = xuLy.getAll().Find(ph => ph.Maphong == dgvHienThi.SelectedRows[0].Cells[0].Value.ToString());
                xuLy.delete(p);
                xuLy.DisplayOnDataGridView(dgvHienThi);
            }
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilter.SelectedIndex != -1)
            {
                string ds = cbbFilter.Items[cbbFilter.SelectedIndex].ToString();
                BindingSource bs = new BindingSource();
                bs.DataSource = xuLy.getAll().Where(p => p.Trangthai == ds);
                dgvHienThi.DataSource = bs;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = xuLy.getAll().Where(p => p.Maphong.Contains(txtSearch.Text));
                dgvHienThi.DataSource = bs;
            }
        }
    }
}
