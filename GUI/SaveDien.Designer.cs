
namespace GUI
{
    partial class SaveDien
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
            this.da_InputDien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_SaveDien = new Guna.UI2.WinForms.Guna2Button();
            this.Date_TaoHDon = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.da_InputDien)).BeginInit();
            this.SuspendLayout();
            // 
            // da_InputDien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.da_InputDien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.da_InputDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.da_InputDien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.da_InputDien.ColumnHeadersHeight = 30;
            this.da_InputDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_InputDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenTang,
            this.TenPhong,
            this.GiaTien,
            this.HoTen,
            this.SoNguoi,
            this.SoXe,
            this.DienThangTruoc,
            this.SoDienMoi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.da_InputDien.DefaultCellStyle = dataGridViewCellStyle3;
            this.da_InputDien.GridColor = System.Drawing.Color.Black;
            this.da_InputDien.Location = new System.Drawing.Point(14, 49);
            this.da_InputDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.da_InputDien.Name = "da_InputDien";
            this.da_InputDien.RowHeadersVisible = false;
            this.da_InputDien.RowHeadersWidth = 51;
            this.da_InputDien.RowTemplate.Height = 24;
            this.da_InputDien.Size = new System.Drawing.Size(1455, 452);
            this.da_InputDien.TabIndex = 1;
            this.da_InputDien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.da_InputDien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.da_InputDien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.da_InputDien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.da_InputDien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.da_InputDien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.da_InputDien.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.da_InputDien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.da_InputDien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.da_InputDien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_InputDien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.da_InputDien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.da_InputDien.ThemeStyle.HeaderStyle.Height = 30;
            this.da_InputDien.ThemeStyle.ReadOnly = false;
            this.da_InputDien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.da_InputDien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.da_InputDien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.da_InputDien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.da_InputDien.ThemeStyle.RowsStyle.Height = 24;
            this.da_InputDien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.da_InputDien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.da_InputDien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.da_InputDien_CellContentClick);
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            // 
            // TenTang
            // 
            this.TenTang.HeaderText = "Tầng";
            this.TenTang.MinimumWidth = 6;
            this.TenTang.Name = "TenTang";
            // 
            // TenPhong
            // 
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.MinimumWidth = 6;
            this.GiaTien.Name = "GiaTien";
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
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
            // DienThangTruoc
            // 
            this.DienThangTruoc.HeaderText = "Điện Tháng Trước";
            this.DienThangTruoc.MinimumWidth = 6;
            this.DienThangTruoc.Name = "DienThangTruoc";
            // 
            // SoDienMoi
            // 
            this.SoDienMoi.HeaderText = "Điện Tháng Này";
            this.SoDienMoi.MinimumWidth = 6;
            this.SoDienMoi.Name = "SoDienMoi";
            // 
            // bt_SaveDien
            // 
            this.bt_SaveDien.AutoRoundedCorners = true;
            this.bt_SaveDien.BorderRadius = 20;
            this.bt_SaveDien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_SaveDien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_SaveDien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_SaveDien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_SaveDien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(202)))), ((int)(((byte)(44)))));
            this.bt_SaveDien.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_SaveDien.ForeColor = System.Drawing.Color.White;
            this.bt_SaveDien.Location = new System.Drawing.Point(645, 3);
            this.bt_SaveDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_SaveDien.Name = "bt_SaveDien";
            this.bt_SaveDien.Size = new System.Drawing.Size(216, 42);
            this.bt_SaveDien.TabIndex = 3;
            this.bt_SaveDien.Text = "Save";
            this.bt_SaveDien.Click += new System.EventHandler(this.bt_SaveDien_Click);
            // 
            // Date_TaoHDon
            // 
            this.Date_TaoHDon.Checked = true;
            this.Date_TaoHDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(180)))), ((int)(((byte)(181)))));
            this.Date_TaoHDon.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_TaoHDon.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date_TaoHDon.Location = new System.Drawing.Point(294, 8);
            this.Date_TaoHDon.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_TaoHDon.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_TaoHDon.Name = "Date_TaoHDon";
            this.Date_TaoHDon.Size = new System.Drawing.Size(323, 36);
            this.Date_TaoHDon.TabIndex = 9;
            this.Date_TaoHDon.Value = new System.DateTime(2024, 8, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngày tháng tạo hóa đơn:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // SaveDien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Date_TaoHDon);
            this.Controls.Add(this.bt_SaveDien);
            this.Controls.Add(this.da_InputDien);
            this.Name = "SaveDien";
            this.Size = new System.Drawing.Size(1482, 511);
            this.Load += new System.EventHandler(this.SaveDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.da_InputDien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView da_InputDien;
        private Guna.UI2.WinForms.Guna2Button bt_SaveDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienMoi;
        private Guna.UI2.WinForms.Guna2DateTimePicker Date_TaoHDon;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
