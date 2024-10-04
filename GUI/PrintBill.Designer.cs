
namespace GUI
{
    partial class PrintBill
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btXem = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.da_bill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lbTongTIen = new System.Windows.Forms.Label();
            this.cbThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FADS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTrangThaiThanhToan = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.da_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // btXem
            // 
            this.btXem.AutoRoundedCorners = true;
            this.btXem.BorderRadius = 17;
            this.btXem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btXem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btXem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btXem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btXem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btXem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btXem.ForeColor = System.Drawing.Color.White;
            this.btXem.Location = new System.Drawing.Point(953, 17);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(164, 36);
            this.btXem.TabIndex = 55;
            this.btXem.Text = "Xem";
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tháng:";
            // 
            // da_bill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.da_bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.da_bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.da_bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.da_bill.ColumnHeadersHeight = 30;
            this.da_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDon,
            this.ThangHD,
            this.NamHD,
            this.Tang,
            this.SoPhong,
            this.TenLP,
            this.GiaTien,
            this.PhiDV,
            this.HoTen,
            this.Email,
            this.TienDien,
            this.TienNuoc,
            this.TienXe,
            this.TongTien,
            this.TrangThaiThanhToan,
            this.TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.da_bill.DefaultCellStyle = dataGridViewCellStyle3;
            this.da_bill.GridColor = System.Drawing.Color.Black;
            this.da_bill.Location = new System.Drawing.Point(3, 67);
            this.da_bill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.da_bill.Name = "da_bill";
            this.da_bill.RowHeadersVisible = false;
            this.da_bill.RowHeadersWidth = 51;
            this.da_bill.RowTemplate.Height = 24;
            this.da_bill.Size = new System.Drawing.Size(1471, 432);
            this.da_bill.TabIndex = 50;
            this.da_bill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.da_bill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.da_bill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.da_bill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.da_bill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.da_bill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.da_bill.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.da_bill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.da_bill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.da_bill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_bill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.da_bill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_bill.ThemeStyle.HeaderStyle.Height = 30;
            this.da_bill.ThemeStyle.ReadOnly = false;
            this.da_bill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.da_bill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.da_bill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_bill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.da_bill.ThemeStyle.RowsStyle.Height = 24;
            this.da_bill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.da_bill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaHDon
            // 
            this.MaHDon.HeaderText = "Mã Hóa Đơn";
            this.MaHDon.MinimumWidth = 6;
            this.MaHDon.Name = "MaHDon";
            // 
            // ThangHD
            // 
            this.ThangHD.HeaderText = "Tháng";
            this.ThangHD.MinimumWidth = 6;
            this.ThangHD.Name = "ThangHD";
            // 
            // NamHD
            // 
            this.NamHD.HeaderText = "Năm";
            this.NamHD.MinimumWidth = 6;
            this.NamHD.Name = "NamHD";
            // 
            // Tang
            // 
            this.Tang.HeaderText = "Tầng";
            this.Tang.MinimumWidth = 6;
            this.Tang.Name = "Tang";
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.MinimumWidth = 6;
            this.SoPhong.Name = "SoPhong";
            // 
            // TenLP
            // 
            this.TenLP.HeaderText = "Loại Phòng";
            this.TenLP.MinimumWidth = 6;
            this.TenLP.Name = "TenLP";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Phòng";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            // 
            // PhiDV
            // 
            this.PhiDV.HeaderText = "Phí DV";
            this.PhiDV.MinimumWidth = 6;
            this.PhiDV.Name = "PhiDV";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Tên Khách Hàng";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // TienDien
            // 
            this.TienDien.HeaderText = "Tiền Điện";
            this.TienDien.MinimumWidth = 6;
            this.TienDien.Name = "TienDien";
            // 
            // TienNuoc
            // 
            this.TienNuoc.HeaderText = "Tiền Nước";
            this.TienNuoc.MinimumWidth = 6;
            this.TienNuoc.Name = "TienNuoc";
            // 
            // TienXe
            // 
            this.TienXe.HeaderText = "Tiền Xe";
            this.TienXe.MinimumWidth = 6;
            this.TienXe.Name = "TienXe";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // TrangThaiThanhToan
            // 
            this.TrangThaiThanhToan.HeaderText = "Trạng Thái Thanh Toán";
            this.TrangThaiThanhToan.MinimumWidth = 6;
            this.TrangThaiThanhToan.Name = "TrangThaiThanhToan";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái In";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(1160, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tổng tiền:";
            // 
            // lbTongTIen
            // 
            this.lbTongTIen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTongTIen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTIen.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbTongTIen.Location = new System.Drawing.Point(1280, 17);
            this.lbTongTIen.Name = "lbTongTIen";
            this.lbTongTIen.Size = new System.Drawing.Size(194, 35);
            this.lbTongTIen.TabIndex = 56;
            this.lbTongTIen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbThang
            // 
            this.cbThang.AutoRoundedCorners = true;
            this.cbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbThang.BorderRadius = 17;
            this.cbThang.DisplayMember = "9";
            this.cbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbThang.ItemHeight = 30;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(121, 17);
            this.cbThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(132, 36);
            this.cbThang.TabIndex = 57;
            this.cbThang.ValueMember = "9";
            // 
            // cbNam
            // 
            this.cbNam.AutoRoundedCorners = true;
            this.cbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbNam.BorderRadius = 17;
            this.cbNam.DisplayMember = "2024";
            this.cbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNam.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNam.ItemHeight = 30;
            this.cbNam.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbNam.Location = new System.Drawing.Point(350, 17);
            this.cbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(132, 36);
            this.cbNam.TabIndex = 57;
            this.cbNam.ValueMember = "2024";
            // 
            // FADS
            // 
            this.FADS.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.FADS.ForeColor = System.Drawing.Color.AliceBlue;
            this.FADS.Location = new System.Drawing.Point(279, 20);
            this.FADS.Name = "FADS";
            this.FADS.Size = new System.Drawing.Size(65, 36);
            this.FADS.TabIndex = 54;
            this.FADS.Text = "Năm:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(498, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 54;
            this.label1.Text = "Trạng Thái Thanh Toán:";
            // 
            // cbTrangThaiThanhToan
            // 
            this.cbTrangThaiThanhToan.AutoRoundedCorners = true;
            this.cbTrangThaiThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThaiThanhToan.BorderRadius = 17;
            this.cbTrangThaiThanhToan.DisplayMember = "2024";
            this.cbTrangThaiThanhToan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThaiThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThaiThanhToan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThaiThanhToan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThaiThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbTrangThaiThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTrangThaiThanhToan.ItemHeight = 30;
            this.cbTrangThaiThanhToan.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbTrangThaiThanhToan.Location = new System.Drawing.Point(747, 16);
            this.cbTrangThaiThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrangThaiThanhToan.Name = "cbTrangThaiThanhToan";
            this.cbTrangThaiThanhToan.Size = new System.Drawing.Size(184, 36);
            this.cbTrangThaiThanhToan.TabIndex = 57;
            this.cbTrangThaiThanhToan.ValueMember = "2024";
            // 
            // PrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.cbTrangThaiThanhToan);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lbTongTIen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FADS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.da_bill);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrintBill";
            this.Size = new System.Drawing.Size(1482, 511);
            ((System.ComponentModel.ISupportInitialize)(this.da_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btXem;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView da_bill;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbTongTIen;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cbNam;
        private Guna.UI2.WinForms.Guna2ComboBox cbThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangThaiThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FADS;
    }
}
