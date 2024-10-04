
namespace GUI
{
    partial class UC_Cus
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.da_Cus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_options = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_TimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChucNang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_ThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.date_NS = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtMaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQQ = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btUpdete = new Guna.UI2.WinForms.Guna2Button();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.da_Cus)).BeginInit();
            this.pn_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // da_Cus
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.da_Cus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.da_Cus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.da_Cus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.da_Cus.ColumnHeadersHeight = 30;
            this.da_Cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_Cus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.ho,
            this.ten,
            this.namsinh,
            this.sdt,
            this.CCCD,
            this.Email,
            this.QueQuan,
            this.SoXe,
            this.MaPhong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.da_Cus.DefaultCellStyle = dataGridViewCellStyle3;
            this.da_Cus.GridColor = System.Drawing.Color.Black;
            this.da_Cus.Location = new System.Drawing.Point(13, 79);
            this.da_Cus.Name = "da_Cus";
            this.da_Cus.RowHeadersVisible = false;
            this.da_Cus.RowHeadersWidth = 51;
            this.da_Cus.RowTemplate.Height = 24;
            this.da_Cus.Size = new System.Drawing.Size(1119, 539);
            this.da_Cus.TabIndex = 7;
            this.da_Cus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.da_Cus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.da_Cus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.da_Cus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.da_Cus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.da_Cus.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.da_Cus.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.da_Cus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.da_Cus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.da_Cus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_Cus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.da_Cus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_Cus.ThemeStyle.HeaderStyle.Height = 30;
            this.da_Cus.ThemeStyle.ReadOnly = false;
            this.da_Cus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.da_Cus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.da_Cus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_Cus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.da_Cus.ThemeStyle.RowsStyle.Height = 24;
            this.da_Cus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.da_Cus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.da_Cus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.da_Cus_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // ho
            // 
            this.ho.FillWeight = 122.2614F;
            this.ho.HeaderText = "Họ";
            this.ho.MinimumWidth = 6;
            this.ho.Name = "ho";
            // 
            // ten
            // 
            this.ten.FillWeight = 81.50757F;
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            // 
            // namsinh
            // 
            this.namsinh.HeaderText = "Năm Sinh";
            this.namsinh.MinimumWidth = 6;
            this.namsinh.Name = "namsinh";
            // 
            // sdt
            // 
            this.sdt.FillWeight = 81.50757F;
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            // 
            // CCCD
            // 
            this.CCCD.FillWeight = 80F;
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            // 
            // Email
            // 
            this.Email.FillWeight = 122.2614F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // QueQuan
            // 
            this.QueQuan.HeaderText = "Quê Quán";
            this.QueQuan.MinimumWidth = 6;
            this.QueQuan.Name = "QueQuan";
            // 
            // SoXe
            // 
            this.SoXe.HeaderText = "Số xe";
            this.SoXe.MinimumWidth = 6;
            this.SoXe.Name = "SoXe";
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // cb_options
            // 
            this.cb_options.AutoRoundedCorners = true;
            this.cb_options.BackColor = System.Drawing.Color.Transparent;
            this.cb_options.BorderRadius = 17;
            this.cb_options.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_options.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_options.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_options.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_options.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_options.ItemHeight = 30;
            this.cb_options.Items.AddRange(new object[] {
            "SDT",
            "CCCD"});
            this.cb_options.Location = new System.Drawing.Point(505, 22);
            this.cb_options.Name = "cb_options";
            this.cb_options.Size = new System.Drawing.Size(117, 36);
            this.cb_options.TabIndex = 20;
            // 
            // txtTK
            // 
            this.txtTK.AutoRoundedCorners = true;
            this.txtTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTK.BorderRadius = 13;
            this.txtTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTK.DefaultText = "";
            this.txtTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.Location = new System.Drawing.Point(664, 29);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTK.Name = "txtTK";
            this.txtTK.PasswordChar = '\0';
            this.txtTK.PlaceholderText = "";
            this.txtTK.SelectedText = "";
            this.txtTK.Size = new System.Drawing.Size(175, 29);
            this.txtTK.TabIndex = 16;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.AutoRoundedCorners = true;
            this.bt_TimKiem.BorderRadius = 15;
            this.bt_TimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_TimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_TimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_TimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_TimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.bt_TimKiem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_TimKiem.ForeColor = System.Drawing.Color.White;
            this.bt_TimKiem.Location = new System.Drawing.Point(873, 29);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(131, 32);
            this.bt_TimKiem.TabIndex = 19;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(1133, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Chức năng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbChucNang
            // 
            this.cbChucNang.AutoRoundedCorners = true;
            this.cbChucNang.BackColor = System.Drawing.Color.Transparent;
            this.cbChucNang.BorderRadius = 17;
            this.cbChucNang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChucNang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucNang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucNang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucNang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic);
            this.cbChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChucNang.ItemHeight = 30;
            this.cbChucNang.Items.AddRange(new object[] {
            "Thêm khách hàng",
            "Cập nhật thông tin"});
            this.cbChucNang.Location = new System.Drawing.Point(1290, 23);
            this.cbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChucNang.Name = "cbChucNang";
            this.cbChucNang.Size = new System.Drawing.Size(209, 36);
            this.cbChucNang.TabIndex = 0;
            this.cbChucNang.SelectedIndexChanged += new System.EventHandler(this.cbChucNang_SelectedIndexChanged);
            // 
            // txtMaKH
            // 
            this.txtMaKH.AutoRoundedCorners = true;
            this.txtMaKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKH.BorderRadius = 20;
            this.txtMaKH.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Italic);
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(1200, 85);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "Nhập vào mã khách hàng...";
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(268, 43);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.Visible = false;
            // 
            // pn_ThongTin
            // 
            this.pn_ThongTin.Controls.Add(this.date_NS);
            this.pn_ThongTin.Controls.Add(this.txtMaPhong);
            this.pn_ThongTin.Controls.Add(this.txtSoXe);
            this.pn_ThongTin.Controls.Add(this.txtQQ);
            this.pn_ThongTin.Controls.Add(this.txtCCCD);
            this.pn_ThongTin.Controls.Add(this.txtTen);
            this.pn_ThongTin.Controls.Add(this.txtSdt);
            this.pn_ThongTin.Controls.Add(this.txtEmail);
            this.pn_ThongTin.Controls.Add(this.txtHo);
            this.pn_ThongTin.Controls.Add(this.label4);
            this.pn_ThongTin.Controls.Add(this.label12);
            this.pn_ThongTin.Controls.Add(this.label10);
            this.pn_ThongTin.Controls.Add(this.label9);
            this.pn_ThongTin.Controls.Add(this.label5);
            this.pn_ThongTin.Controls.Add(this.label8);
            this.pn_ThongTin.Controls.Add(this.label7);
            this.pn_ThongTin.Controls.Add(this.label3);
            this.pn_ThongTin.Controls.Add(this.label2);
            this.pn_ThongTin.Location = new System.Drawing.Point(1156, 137);
            this.pn_ThongTin.Name = "pn_ThongTin";
            this.pn_ThongTin.Size = new System.Drawing.Size(343, 443);
            this.pn_ThongTin.TabIndex = 2;
            this.pn_ThongTin.Visible = false;
            // 
            // date_NS
            // 
            this.date_NS.Checked = true;
            this.date_NS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(181)))));
            this.date_NS.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NS.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_NS.Location = new System.Drawing.Point(23, 368);
            this.date_NS.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_NS.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_NS.Name = "date_NS";
            this.date_NS.Size = new System.Drawing.Size(283, 36);
            this.date_NS.TabIndex = 8;
            this.date_NS.Value = new System.DateTime(2000, 1, 1, 11, 54, 0, 0);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.AutoRoundedCorners = true;
            this.txtMaPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaPhong.BorderRadius = 14;
            this.txtMaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhong.DefaultText = "";
            this.txtMaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhong.Location = new System.Drawing.Point(182, 300);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.PasswordChar = '\0';
            this.txtMaPhong.PlaceholderText = "";
            this.txtMaPhong.SelectedText = "";
            this.txtMaPhong.Size = new System.Drawing.Size(130, 31);
            this.txtMaPhong.TabIndex = 7;
            // 
            // txtSoXe
            // 
            this.txtSoXe.AutoRoundedCorners = true;
            this.txtSoXe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoXe.BorderRadius = 14;
            this.txtSoXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoXe.DefaultText = "";
            this.txtSoXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoXe.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtSoXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoXe.Location = new System.Drawing.Point(23, 296);
            this.txtSoXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoXe.Name = "txtSoXe";
            this.txtSoXe.PasswordChar = '\0';
            this.txtSoXe.PlaceholderText = "";
            this.txtSoXe.SelectedText = "";
            this.txtSoXe.Size = new System.Drawing.Size(130, 31);
            this.txtSoXe.TabIndex = 6;
            // 
            // txtQQ
            // 
            this.txtQQ.AutoRoundedCorners = true;
            this.txtQQ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQQ.BorderRadius = 14;
            this.txtQQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQQ.DefaultText = "";
            this.txtQQ.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQQ.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQQ.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQQ.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtQQ.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQQ.Location = new System.Drawing.Point(182, 214);
            this.txtQQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.PasswordChar = '\0';
            this.txtQQ.PlaceholderText = "";
            this.txtQQ.SelectedText = "";
            this.txtQQ.Size = new System.Drawing.Size(130, 31);
            this.txtQQ.TabIndex = 5;
            // 
            // txtCCCD
            // 
            this.txtCCCD.AutoRoundedCorners = true;
            this.txtCCCD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCCCD.BorderRadius = 14;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.Location = new System.Drawing.Point(182, 140);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.Size = new System.Drawing.Size(130, 31);
            this.txtCCCD.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.AutoRoundedCorners = true;
            this.txtTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.BorderRadius = 14;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(182, 50);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(130, 31);
            this.txtTen.TabIndex = 1;
            // 
            // txtSdt
            // 
            this.txtSdt.AutoRoundedCorners = true;
            this.txtSdt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSdt.BorderRadius = 14;
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.DefaultText = "";
            this.txtSdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtSdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.Location = new System.Drawing.Point(23, 140);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PasswordChar = '\0';
            this.txtSdt.PlaceholderText = "";
            this.txtSdt.SelectedText = "";
            this.txtSdt.Size = new System.Drawing.Size(130, 31);
            this.txtSdt.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderRadius = 14;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(23, 214);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(130, 31);
            this.txtEmail.TabIndex = 4;
            // 
            // txtHo
            // 
            this.txtHo.AutoRoundedCorners = true;
            this.txtHo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHo.BorderRadius = 14;
            this.txtHo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHo.DefaultText = "";
            this.txtHo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtHo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHo.Location = new System.Drawing.Point(23, 50);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHo.Name = "txtHo";
            this.txtHo.PasswordChar = '\0';
            this.txtHo.PlaceholderText = "";
            this.txtHo.SelectedText = "";
            this.txtHo.Size = new System.Drawing.Size(130, 31);
            this.txtHo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(29, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "Năm sinh:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(182, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Mã Phòng:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(23, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "Số Xe:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(182, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Quê Quán:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(23, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số điện thoại:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(182, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "CCCD:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(23, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 31);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btUpdete
            // 
            this.btUpdete.AutoRoundedCorners = true;
            this.btUpdete.BorderRadius = 21;
            this.btUpdete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpdete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUpdete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUpdete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpdete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btUpdete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btUpdete.ForeColor = System.Drawing.Color.White;
            this.btUpdete.Location = new System.Drawing.Point(1232, 587);
            this.btUpdete.Name = "btUpdete";
            this.btUpdete.Size = new System.Drawing.Size(180, 45);
            this.btUpdete.TabIndex = 3;
            this.btUpdete.Text = "Updete";
            this.btUpdete.Visible = false;
            this.btUpdete.Click += new System.EventHandler(this.btUpdete_Click_1);
            // 
            // btAdd
            // 
            this.btAdd.AutoRoundedCorners = true;
            this.btAdd.BorderRadius = 21;
            this.btAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(1232, 587);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(180, 45);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(31, 19);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(250, 39);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "LIST CUSTOMERS";
            // 
            // UC_Cus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.pn_ThongTin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChucNang);
            this.Controls.Add(this.cb_options);
            this.Controls.Add(this.bt_TimKiem);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.da_Cus);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btUpdete);
            this.Name = "UC_Cus";
            this.Size = new System.Drawing.Size(1513, 650);
            this.Load += new System.EventHandler(this.UC_Cus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.da_Cus)).EndInit();
            this.pn_ThongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView da_Cus;
        private Guna.UI2.WinForms.Guna2ComboBox cb_options;
        private Guna.UI2.WinForms.Guna2Button bt_TimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbChucNang;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2Panel pn_ThongTin;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_NS;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoXe;
        private Guna.UI2.WinForms.Guna2TextBox txtQQ;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2TextBox txtSdt;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtHo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btUpdete;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
    }
}
