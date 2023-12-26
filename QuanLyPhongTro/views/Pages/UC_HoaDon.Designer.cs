namespace QuanLyPhongTro.views.Pages
{
    partial class UC_HoaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dgvHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            txtDien = new Guna.UI2.WinForms.Guna2TextBox();
            txtNuoc = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            MaKhachHang = new DataGridViewTextBoxColumn();
            Tiendien = new DataGridViewTextBoxColumn();
            Tiennuoc = new DataGridViewTextBoxColumn();
            Trangthai = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(dgvHienThi);
            guna2Panel1.Controls.Add(panel2);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(43, 54);
            guna2Panel1.Margin = new Padding(3, 2, 3, 2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(812, 472);
            guna2Panel1.TabIndex = 2;
            // 
            // dgvHienThi
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvHienThi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(191, 191, 191);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(191, 191, 191);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHienThi.ColumnHeadersHeight = 40;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHienThi.Columns.AddRange(new DataGridViewColumn[] { Column1, MaPhong, MaKhachHang, Tiendien, Tiennuoc, Trangthai });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHienThi.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHienThi.Dock = DockStyle.Fill;
            dgvHienThi.GridColor = Color.FromArgb(231, 229, 255);
            dgvHienThi.Location = new Point(0, 127);
            dgvHienThi.Margin = new Padding(3, 2, 3, 2);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersVisible = false;
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.RowTemplate.Height = 40;
            dgvHienThi.Size = new Size(812, 345);
            dgvHienThi.TabIndex = 2;
            dgvHienThi.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvHienThi.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvHienThi.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvHienThi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvHienThi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvHienThi.ThemeStyle.BackColor = Color.White;
            dgvHienThi.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvHienThi.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvHienThi.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHienThi.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvHienThi.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvHienThi.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvHienThi.ThemeStyle.HeaderStyle.Height = 40;
            dgvHienThi.ThemeStyle.ReadOnly = false;
            dgvHienThi.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvHienThi.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHienThi.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvHienThi.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvHienThi.ThemeStyle.RowsStyle.Height = 40;
            dgvHienThi.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvHienThi.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvHienThi.RowEnter += dgvHienThi_RowEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDien);
            panel2.Controls.Add(txtNuoc);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 72);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 55);
            panel2.TabIndex = 1;
            // 
            // txtDien
            // 
            txtDien.CustomizableEdges = customizableEdges1;
            txtDien.DefaultText = "";
            txtDien.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDien.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDien.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDien.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDien.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDien.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDien.Location = new Point(204, 12);
            txtDien.Name = "txtDien";
            txtDien.PasswordChar = '\0';
            txtDien.PlaceholderText = "";
            txtDien.SelectedText = "";
            txtDien.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtDien.Size = new Size(200, 31);
            txtDien.TabIndex = 4;
            // 
            // txtNuoc
            // 
            txtNuoc.CustomizableEdges = customizableEdges3;
            txtNuoc.DefaultText = "";
            txtNuoc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNuoc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNuoc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNuoc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNuoc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNuoc.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNuoc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNuoc.Location = new Point(587, 12);
            txtNuoc.Name = "txtNuoc";
            txtNuoc.PasswordChar = '\0';
            txtNuoc.PlaceholderText = "";
            txtNuoc.SelectedText = "";
            txtNuoc.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNuoc.Size = new Size(200, 31);
            txtNuoc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(415, 12);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá tiền nước:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 12);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 1;
            label2.Text = "Đơn giá tiền điện:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh sách hoá đơn";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Mahoadon";
            Column1.HeaderText = "#Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // MaPhong
            // 
            MaPhong.DataPropertyName = "Maphong";
            MaPhong.HeaderText = "Mã phòng";
            MaPhong.Name = "MaPhong";
            // 
            // MaKhachHang
            // 
            MaKhachHang.DataPropertyName = "Makhachhang";
            MaKhachHang.HeaderText = "Mã khách hàng";
            MaKhachHang.Name = "MaKhachHang";
            // 
            // Tiendien
            // 
            Tiendien.DataPropertyName = "Tiendien";
            Tiendien.HeaderText = "Tiền điện";
            Tiendien.Name = "Tiendien";
            // 
            // Tiennuoc
            // 
            Tiennuoc.DataPropertyName = "Tiennuoc";
            Tiennuoc.HeaderText = "Tiền nước";
            Tiennuoc.Name = "Tiennuoc";
            // 
            // Trangthai
            // 
            Trangthai.DataPropertyName = "Trangthai";
            Trangthai.HeaderText = "Trạng thái";
            Trangthai.Name = "Trangthai";
            // 
            // UC_HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "UC_HoaDon";
            Size = new Size(898, 528);
            Load += UC_HoaDon_Load;
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHienThi;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDien;
        private Guna.UI2.WinForms.Guna2TextBox txtNuoc;
        private Label label3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaKhachHang;
        private DataGridViewTextBoxColumn Tiendien;
        private DataGridViewTextBoxColumn Tiennuoc;
        private DataGridViewTextBoxColumn Trangthai;
    }
}
