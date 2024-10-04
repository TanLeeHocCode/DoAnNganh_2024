
namespace GUI
{
    partial class UC_contract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.da_contract = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThangBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThangKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_KT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_BD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cbChucNangHopDong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.da_contract)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1513, 39);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "MANAGEMENT CONTRACT LIST";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // da_contract
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.da_contract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.da_contract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.da_contract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.da_contract.ColumnHeadersHeight = 30;
            this.da_contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_contract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDong,
            this.HoTen,
            this.CCCD,
            this.NgayThangBD,
            this.NgayThangKT,
            this.TenLoaiPhong,
            this.GiaTien,
            this.TenTang,
            this.TenPhong,
            this.TienCoc,
            this.SoNguoi,
            this.SoXe,
            this.DienTich});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.da_contract.DefaultCellStyle = dataGridViewCellStyle6;
            this.da_contract.GridColor = System.Drawing.Color.Black;
            this.da_contract.Location = new System.Drawing.Point(9, 124);
            this.da_contract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.da_contract.Name = "da_contract";
            this.da_contract.RowHeadersVisible = false;
            this.da_contract.RowHeadersWidth = 51;
            this.da_contract.RowTemplate.Height = 24;
            this.da_contract.Size = new System.Drawing.Size(1479, 493);
            this.da_contract.TabIndex = 27;
            this.da_contract.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.da_contract.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.da_contract.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.da_contract.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.da_contract.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.da_contract.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.da_contract.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.da_contract.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.da_contract.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.da_contract.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_contract.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.da_contract.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_contract.ThemeStyle.HeaderStyle.Height = 30;
            this.da_contract.ThemeStyle.ReadOnly = false;
            this.da_contract.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.da_contract.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.da_contract.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_contract.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.da_contract.ThemeStyle.RowsStyle.Height = 24;
            this.da_contract.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.da_contract.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaHDong
            // 
            this.MaHDong.HeaderText = "Mã Hợp Đồng";
            this.MaHDong.MinimumWidth = 6;
            this.MaHDong.Name = "MaHDong";
            this.MaHDong.Visible = false;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Tên Khách Hàng";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            // 
            // NgayThangBD
            // 
            this.NgayThangBD.HeaderText = "Ngày Bắt Đầu";
            this.NgayThangBD.MinimumWidth = 6;
            this.NgayThangBD.Name = "NgayThangBD";
            // 
            // NgayThangKT
            // 
            this.NgayThangKT.HeaderText = "Ngày Kết Thúc";
            this.NgayThangKT.MinimumWidth = 6;
            this.NgayThangKT.Name = "NgayThangKT";
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.HeaderText = "Tên Loại Phòng";
            this.TenLoaiPhong.MinimumWidth = 6;
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            // 
            // TenTang
            // 
            this.TenTang.HeaderText = "Tầng";
            this.TenTang.MinimumWidth = 6;
            this.TenTang.Name = "TenTang";
            // 
            // TenPhong
            // 
            this.TenPhong.HeaderText = "Số Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            // 
            // TienCoc
            // 
            this.TienCoc.HeaderText = "Tiền Cọc";
            this.TienCoc.MinimumWidth = 6;
            this.TienCoc.Name = "TienCoc";
            // 
            // SoNguoi
            // 
            this.SoNguoi.HeaderText = "Số Người";
            this.SoNguoi.MinimumWidth = 6;
            this.SoNguoi.Name = "SoNguoi";
            // 
            // SoXe
            // 
            this.SoXe.HeaderText = "Số Xe";
            this.SoXe.MinimumWidth = 6;
            this.SoXe.Name = "SoXe";
            // 
            // DienTich
            // 
            this.DienTich.HeaderText = "Diện Tích";
            this.DienTich.MinimumWidth = 6;
            this.DienTich.Name = "DienTich";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.date_KT);
            this.panel1.Controls.Add(this.date_BD);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Location = new System.Drawing.Point(9, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 56);
            this.panel1.TabIndex = 29;
            // 
            // date_KT
            // 
            this.date_KT.Checked = true;
            this.date_KT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(181)))));
            this.date_KT.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_KT.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_KT.Location = new System.Drawing.Point(1049, 10);
            this.date_KT.MaxDate = new System.DateTime(2109, 12, 28, 0, 0, 0, 0);
            this.date_KT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_KT.Name = "date_KT";
            this.date_KT.Size = new System.Drawing.Size(283, 36);
            this.date_KT.TabIndex = 55;
            this.date_KT.Value = new System.DateTime(2024, 8, 17, 0, 0, 0, 0);
            // 
            // date_BD
            // 
            this.date_BD.Checked = true;
            this.date_BD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(181)))));
            this.date_BD.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_BD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_BD.Location = new System.Drawing.Point(661, 10);
            this.date_BD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_BD.MinDate = new System.DateTime(2024, 8, 26, 0, 0, 0, 0);
            this.date_BD.Name = "date_BD";
            this.date_BD.Size = new System.Drawing.Size(283, 36);
            this.date_BD.TabIndex = 54;
            this.date_BD.Value = new System.DateTime(2024, 8, 26, 0, 0, 0, 0);
            this.date_BD.ValueChanged += new System.EventHandler(this.date_BD_ValueChanged_1);
            // 
            // txtCCCD
            // 
            this.txtCCCD.AutoRoundedCorners = true;
            this.txtCCCD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCCCD.BorderRadius = 17;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(144, 10);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(214, 36);
            this.txtCCCD.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(974, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 36);
            this.label6.TabIndex = 58;
            this.label6.Text = "Đến";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(59, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 36);
            this.label1.TabIndex = 59;
            this.label1.Text = "CCCD:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(596, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 36);
            this.label2.TabIndex = 59;
            this.label2.Text = "Từ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAdd
            // 
            this.btAdd.AutoRoundedCorners = true;
            this.btAdd.BorderRadius = 21;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(381, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(150, 45);
            this.btAdd.TabIndex = 60;
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSearch
            // 
            this.btSearch.AutoRoundedCorners = true;
            this.btSearch.BorderRadius = 21;
            this.btSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(381, 3);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(150, 45);
            this.btSearch.TabIndex = 60;
            this.btSearch.Text = "Search";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // cbChucNangHopDong
            // 
            this.cbChucNangHopDong.AutoRoundedCorners = true;
            this.cbChucNangHopDong.BackColor = System.Drawing.Color.Transparent;
            this.cbChucNangHopDong.BorderRadius = 17;
            this.cbChucNangHopDong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChucNangHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucNangHopDong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucNangHopDong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucNangHopDong.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbChucNangHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChucNangHopDong.ItemHeight = 30;
            this.cbChucNangHopDong.Items.AddRange(new object[] {
            "Tìm kiếm hợp đồng",
            "Tạo hợp đồng"});
            this.cbChucNangHopDong.Location = new System.Drawing.Point(167, 18);
            this.cbChucNangHopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChucNangHopDong.Name = "cbChucNangHopDong";
            this.cbChucNangHopDong.Size = new System.Drawing.Size(250, 36);
            this.cbChucNangHopDong.TabIndex = 54;
            this.cbChucNangHopDong.SelectedIndexChanged += new System.EventHandler(this.cbChucNangHopDong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 36);
            this.label5.TabIndex = 57;
            this.label5.Text = "Chức năng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_contract
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbChucNangHopDong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.da_contract);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_contract";
            this.Size = new System.Drawing.Size(1513, 650);
            this.Load += new System.EventHandler(this.UC_contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.da_contract)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView da_contract;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbChucNangHopDong;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_KT;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_BD;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2Button btSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThangBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThangKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienTich;
    }
}
