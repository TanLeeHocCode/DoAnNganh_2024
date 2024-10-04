
namespace GUI
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pn_bill = new Guna.UI2.WinForms.Guna2Panel();
            this.printBill1 = new GUI.PrintBill();
            this.saveDien2 = new GUI.SaveDien();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbChucNangBill = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_bill.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.pn_bill;
            // 
            // pn_bill
            // 
            this.pn_bill.Controls.Add(this.printBill1);
            this.pn_bill.Controls.Add(this.saveDien2);
            this.pn_bill.Location = new System.Drawing.Point(18, 114);
            this.pn_bill.Name = "pn_bill";
            this.pn_bill.Size = new System.Drawing.Size(1482, 511);
            this.pn_bill.TabIndex = 13;
            // 
            // printBill1
            // 
            this.printBill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.printBill1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.printBill1.Location = new System.Drawing.Point(0, 0);
            this.printBill1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printBill1.Name = "printBill1";
            this.printBill1.Size = new System.Drawing.Size(1482, 511);
            this.printBill1.TabIndex = 3;
            // 
            // saveDien2
            // 
            this.saveDien2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.saveDien2.Location = new System.Drawing.Point(0, -3);
            this.saveDien2.Name = "saveDien2";
            this.saveDien2.Size = new System.Drawing.Size(1482, 511);
            this.saveDien2.TabIndex = 2;
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
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "LIST BILL";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbChucNangBill
            // 
            this.cbChucNangBill.AutoRoundedCorners = true;
            this.cbChucNangBill.BackColor = System.Drawing.Color.Transparent;
            this.cbChucNangBill.BorderRadius = 17;
            this.cbChucNangBill.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChucNangBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucNangBill.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucNangBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucNangBill.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbChucNangBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChucNangBill.ItemHeight = 30;
            this.cbChucNangBill.Items.AddRange(new object[] {
            "Nhập điện",
            "Hóa đơn"});
            this.cbChucNangBill.Location = new System.Drawing.Point(156, 43);
            this.cbChucNangBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChucNangBill.Name = "cbChucNangBill";
            this.cbChucNangBill.Size = new System.Drawing.Size(183, 36);
            this.cbChucNangBill.TabIndex = 15;
            this.cbChucNangBill.SelectedIndexChanged += new System.EventHandler(this.cbChucNangBill_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(17, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chức Năng:";
            // 
            // UC_HoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.Controls.Add(this.cbChucNangBill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pn_bill);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(1513, 650);
            this.Load += new System.EventHandler(this.UC_HoaDon_Load);
            this.pn_bill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel pn_bill;
        private SaveDien saveDien1;
        private Guna.UI2.WinForms.Guna2ComboBox cbChucNangBill;
        private SaveDien saveDien2;
        private System.Windows.Forms.Label label7;
        private PrintBill printBill1;
    }
}
