
namespace GUI
{
    partial class UC_Room
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
            this.da_Room = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChucNang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pn_updete = new Guna.UI2.WinForms.Guna2Panel();
            this.cbSoPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSTang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLoaiP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbGiaTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btUpdete = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btLoc = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.da_Room)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pn_updete.SuspendLayout();
            this.SuspendLayout();
            // 
            // da_Room
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.da_Room.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.da_Room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.da_Room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.da_Room.ColumnHeadersHeight = 30;
            this.da_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_Room.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.tang,
            this.SoPhong,
            this.LoaiPhong,
            this.GiaTien,
            this.TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.da_Room.DefaultCellStyle = dataGridViewCellStyle3;
            this.da_Room.GridColor = System.Drawing.Color.Black;
            this.da_Room.Location = new System.Drawing.Point(19, 85);
            this.da_Room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.da_Room.Name = "da_Room";
            this.da_Room.RowHeadersVisible = false;
            this.da_Room.RowHeadersWidth = 51;
            this.da_Room.RowTemplate.Height = 24;
            this.da_Room.Size = new System.Drawing.Size(1134, 555);
            this.da_Room.TabIndex = 0;
            this.da_Room.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.da_Room.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.da_Room.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.da_Room.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.da_Room.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.da_Room.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.da_Room.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.da_Room.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.da_Room.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.da_Room.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_Room.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.da_Room.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_Room.ThemeStyle.HeaderStyle.Height = 30;
            this.da_Room.ThemeStyle.ReadOnly = false;
            this.da_Room.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.da_Room.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.da_Room.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_Room.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.da_Room.ThemeStyle.RowsStyle.Height = 24;
            this.da_Room.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.da_Room.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // tang
            // 
            this.tang.FillWeight = 50F;
            this.tang.HeaderText = "Tầng";
            this.tang.MinimumWidth = 6;
            this.tang.Name = "tang";
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số Phòng";
            this.SoPhong.MinimumWidth = 6;
            this.SoPhong.Name = "SoPhong";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.HeaderText = "Loại Phòng";
            this.LoaiPhong.MinimumWidth = 6;
            this.LoaiPhong.Name = "LoaiPhong";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 22);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(181, 39);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "LIST ROOM";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.cbChucNang);
            this.guna2Panel1.Controls.Add(this.pn_updete);
            this.guna2Panel1.Controls.Add(this.btAdd);
            this.guna2Panel1.Controls.Add(this.btUpdete);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(1159, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(354, 650);
            this.guna2Panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 36);
            this.label1.TabIndex = 24;
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
            "Thêm phòng",
            "Sửa phòng"});
            this.cbChucNang.Location = new System.Drawing.Point(185, 2);
            this.cbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChucNang.Name = "cbChucNang";
            this.cbChucNang.Size = new System.Drawing.Size(163, 36);
            this.cbChucNang.TabIndex = 0;
            this.cbChucNang.SelectedIndexChanged += new System.EventHandler(this.cbChucNang_SelectedIndexChanged);
            // 
            // pn_updete
            // 
            this.pn_updete.Controls.Add(this.cbSoPhong);
            this.pn_updete.Controls.Add(this.cbSTang);
            this.pn_updete.Controls.Add(this.cbLoaiP);
            this.pn_updete.Controls.Add(this.txtMaPhong);
            this.pn_updete.Controls.Add(this.lbTrangThai);
            this.pn_updete.Controls.Add(this.lbGiaTien);
            this.pn_updete.Controls.Add(this.label9);
            this.pn_updete.Controls.Add(this.label10);
            this.pn_updete.Controls.Add(this.label11);
            this.pn_updete.Controls.Add(this.label14);
            this.pn_updete.Controls.Add(this.label12);
            this.pn_updete.Controls.Add(this.label13);
            this.pn_updete.Location = new System.Drawing.Point(21, 55);
            this.pn_updete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_updete.Name = "pn_updete";
            this.pn_updete.Size = new System.Drawing.Size(312, 543);
            this.pn_updete.TabIndex = 28;
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.AutoRoundedCorners = true;
            this.cbSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbSoPhong.BorderRadius = 17;
            this.cbSoPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoPhong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSoPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSoPhong.ItemHeight = 30;
            this.cbSoPhong.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005",
            "006",
            "007",
            "008",
            "009",
            "010",
            "011",
            "012",
            "013",
            "014",
            "015",
            "016",
            "017",
            "018",
            "019",
            "020"});
            this.cbSoPhong.Location = new System.Drawing.Point(38, 226);
            this.cbSoPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(228, 36);
            this.cbSoPhong.TabIndex = 26;
            // 
            // cbSTang
            // 
            this.cbSTang.AutoRoundedCorners = true;
            this.cbSTang.BackColor = System.Drawing.Color.Transparent;
            this.cbSTang.BorderRadius = 17;
            this.cbSTang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSTang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSTang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSTang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSTang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbSTang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSTang.ItemHeight = 30;
            this.cbSTang.Items.AddRange(new object[] {
            "Tang 1",
            "Tang 2",
            "Tang 3",
            "Tang 4",
            "Tang 5",
            "Tang 6",
            "Tang 7",
            "Tang 8",
            "Tang 9",
            "Tang 10"});
            this.cbSTang.Location = new System.Drawing.Point(38, 140);
            this.cbSTang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSTang.Name = "cbSTang";
            this.cbSTang.Size = new System.Drawing.Size(228, 36);
            this.cbSTang.TabIndex = 26;
            // 
            // cbLoaiP
            // 
            this.cbLoaiP.AutoRoundedCorners = true;
            this.cbLoaiP.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiP.BorderRadius = 17;
            this.cbLoaiP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbLoaiP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiP.ItemHeight = 30;
            this.cbLoaiP.Items.AddRange(new object[] {
            "Phong Co Ban",
            "Phong Plus",
            "Phong Full Noi That"});
            this.cbLoaiP.Location = new System.Drawing.Point(38, 320);
            this.cbLoaiP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiP.Name = "cbLoaiP";
            this.cbLoaiP.Size = new System.Drawing.Size(228, 36);
            this.cbLoaiP.TabIndex = 26;
            this.cbLoaiP.SelectedIndexChanged += new System.EventHandler(this.cbLoaiP_SelectedIndexChanged);
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.AutoRoundedCorners = true;
            this.txtMaPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaPhong.BorderRadius = 19;
            this.txtMaPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhong.DefaultText = "";
            this.txtMaPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMaPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhong.Location = new System.Drawing.Point(155, 43);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.PasswordChar = '\0';
            this.txtMaPhong.PlaceholderText = "";
            this.txtMaPhong.SelectedText = "";
            this.txtMaPhong.Size = new System.Drawing.Size(136, 40);
            this.txtMaPhong.TabIndex = 25;
            this.txtMaPhong.Visible = false;
            this.txtMaPhong.WordWrap = false;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.BackColor = System.Drawing.Color.Gainsboro;
            this.lbTrangThai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTrangThai.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.lbTrangThai.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbTrangThai.Location = new System.Drawing.Point(38, 491);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(228, 34);
            this.lbTrangThai.TabIndex = 17;
            this.lbTrangThai.Text = "0";
            this.lbTrangThai.Click += new System.EventHandler(this.lbTrangThai_Click);
            // 
            // lbGiaTien
            // 
            this.lbGiaTien.BackColor = System.Drawing.Color.Gainsboro;
            this.lbGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbGiaTien.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbGiaTien.ForeColor = System.Drawing.Color.Red;
            this.lbGiaTien.Location = new System.Drawing.Point(38, 407);
            this.lbGiaTien.Name = "lbGiaTien";
            this.lbGiaTien.Size = new System.Drawing.Size(228, 34);
            this.lbGiaTien.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(38, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Trạng thái:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(38, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Giá tiền:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(34, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "Loại phòng:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.AliceBlue;
            this.label14.Location = new System.Drawing.Point(17, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 26);
            this.label14.TabIndex = 23;
            this.label14.Text = "Mã phòng:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Visible = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.AliceBlue;
            this.label12.Location = new System.Drawing.Point(34, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 26);
            this.label12.TabIndex = 22;
            this.label12.Text = "Số phòng:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.AliceBlue;
            this.label13.Location = new System.Drawing.Point(34, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 26);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tầng:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAdd
            // 
            this.btAdd.AutoRoundedCorners = true;
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BorderRadius = 22;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(94, 602);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(180, 46);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdete
            // 
            this.btUpdete.AutoRoundedCorners = true;
            this.btUpdete.BorderRadius = 22;
            this.btUpdete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpdete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUpdete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUpdete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpdete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btUpdete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btUpdete.ForeColor = System.Drawing.Color.White;
            this.btUpdete.Location = new System.Drawing.Point(94, 602);
            this.btUpdete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdete.Name = "btUpdete";
            this.btUpdete.Size = new System.Drawing.Size(180, 46);
            this.btUpdete.TabIndex = 2;
            this.btUpdete.Text = "Update";
            this.btUpdete.Click += new System.EventHandler(this.btUpdete_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(651, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng Thái:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoRoundedCorners = true;
            this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai.BorderRadius = 17;
            this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTrangThai.ItemHeight = 30;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbTrangThai.Location = new System.Drawing.Point(805, 22);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(111, 36);
            this.cbTrangThai.TabIndex = 1;
            // 
            // btLoc
            // 
            this.btLoc.BackColor = System.Drawing.Color.Transparent;
            this.btLoc.BorderRadius = 25;
            this.btLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btLoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.btLoc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLoc.ForeColor = System.Drawing.Color.White;
            this.btLoc.Location = new System.Drawing.Point(963, 16);
            this.btLoc.Name = "btLoc";
            this.btLoc.Size = new System.Drawing.Size(136, 45);
            this.btLoc.TabIndex = 5;
            this.btLoc.Text = "Lọc";
            this.btLoc.Click += new System.EventHandler(this.btLoc_Click);
            // 
            // UC_Room
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.btLoc);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.da_Room);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Room";
            this.Size = new System.Drawing.Size(1513, 650);
            this.Load += new System.EventHandler(this.UC_Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.da_Room)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.pn_updete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView da_Room;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbChucNang;
        private Guna.UI2.WinForms.Guna2Button btUpdete;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangThai;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btLoc;
        private Guna.UI2.WinForms.Guna2Panel pn_updete;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cbSTang;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhong;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbGiaTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
