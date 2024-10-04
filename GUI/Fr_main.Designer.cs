
namespace GUI
{
    partial class Fr_main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHome = new Guna.UI2.WinForms.Guna2Button();
            this.btContract = new Guna.UI2.WinForms.Guna2Button();
            this.bt_web = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Bill = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Customers = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Room = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.home1 = new GUI.Home();
            this.uC_contract1 = new GUI.UC_contract();
            this.uC_Cus1 = new GUI.UC_Cus();
            this.uC_Room1 = new GUI.UC_Room();
            this.uC_HoaDon1 = new GUI.UC_HoaDon();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1.SuspendLayout();
            this.pn_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.btContract);
            this.panel1.Controls.Add(this.bt_web);
            this.panel1.Controls.Add(this.bt_Bill);
            this.panel1.Controls.Add(this.bt_Customers);
            this.panel1.Controls.Add(this.bt_Room);
            this.panel1.Location = new System.Drawing.Point(72, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 142);
            this.panel1.TabIndex = 0;
            // 
            // btHome
            // 
            this.btHome.BorderRadius = 25;
            this.btHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHome.FillColor = System.Drawing.Color.SlateGray;
            this.btHome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.ImageSize = new System.Drawing.Size(45, 45);
            this.btHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btHome.Location = new System.Drawing.Point(30, 19);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(204, 100);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btContract
            // 
            this.btContract.BorderRadius = 25;
            this.btContract.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btContract.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btContract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btContract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btContract.FillColor = System.Drawing.Color.SlateGray;
            this.btContract.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btContract.ForeColor = System.Drawing.Color.White;
            this.btContract.Image = ((System.Drawing.Image)(resources.GetObject("btContract.Image")));
            this.btContract.ImageSize = new System.Drawing.Size(45, 45);
            this.btContract.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btContract.Location = new System.Drawing.Point(250, 19);
            this.btContract.Name = "btContract";
            this.btContract.Size = new System.Drawing.Size(204, 100);
            this.btContract.TabIndex = 0;
            this.btContract.Text = "Manage contract list";
            this.btContract.Click += new System.EventHandler(this.btContract_Click);
            // 
            // bt_web
            // 
            this.bt_web.BorderRadius = 25;
            this.bt_web.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_web.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_web.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_web.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_web.FillColor = System.Drawing.Color.SlateGray;
            this.bt_web.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bt_web.ForeColor = System.Drawing.Color.White;
            this.bt_web.Image = ((System.Drawing.Image)(resources.GetObject("bt_web.Image")));
            this.bt_web.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_web.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_web.Location = new System.Drawing.Point(1130, 19);
            this.bt_web.Name = "bt_web";
            this.bt_web.Size = new System.Drawing.Size(204, 100);
            this.bt_web.TabIndex = 0;
            this.bt_web.Text = "Website";
            this.bt_web.Click += new System.EventHandler(this.bt_web_Click);
            // 
            // bt_Bill
            // 
            this.bt_Bill.BorderRadius = 25;
            this.bt_Bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Bill.FillColor = System.Drawing.Color.SlateGray;
            this.bt_Bill.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bt_Bill.ForeColor = System.Drawing.Color.White;
            this.bt_Bill.Image = ((System.Drawing.Image)(resources.GetObject("bt_Bill.Image")));
            this.bt_Bill.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_Bill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Bill.Location = new System.Drawing.Point(910, 19);
            this.bt_Bill.Name = "bt_Bill";
            this.bt_Bill.Size = new System.Drawing.Size(204, 100);
            this.bt_Bill.TabIndex = 0;
            this.bt_Bill.Text = "Manage bill list";
            this.bt_Bill.Click += new System.EventHandler(this.bt_Bill_Click);
            // 
            // bt_Customers
            // 
            this.bt_Customers.BorderRadius = 25;
            this.bt_Customers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Customers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Customers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Customers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Customers.FillColor = System.Drawing.Color.SlateGray;
            this.bt_Customers.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bt_Customers.ForeColor = System.Drawing.Color.White;
            this.bt_Customers.Image = ((System.Drawing.Image)(resources.GetObject("bt_Customers.Image")));
            this.bt_Customers.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_Customers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Customers.Location = new System.Drawing.Point(470, 19);
            this.bt_Customers.Name = "bt_Customers";
            this.bt_Customers.Size = new System.Drawing.Size(204, 100);
            this.bt_Customers.TabIndex = 0;
            this.bt_Customers.Text = "Manage customers list";
            this.bt_Customers.Click += new System.EventHandler(this.bt_Customers_Click);
            // 
            // bt_Room
            // 
            this.bt_Room.BorderRadius = 25;
            this.bt_Room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Room.FillColor = System.Drawing.Color.SlateGray;
            this.bt_Room.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.bt_Room.ForeColor = System.Drawing.Color.White;
            this.bt_Room.Image = ((System.Drawing.Image)(resources.GetObject("bt_Room.Image")));
            this.bt_Room.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_Room.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Room.Location = new System.Drawing.Point(690, 19);
            this.bt_Room.Name = "bt_Room";
            this.bt_Room.Size = new System.Drawing.Size(204, 100);
            this.bt_Room.TabIndex = 0;
            this.bt_Room.Text = "Manage room list";
            this.bt_Room.Click += new System.EventHandler(this.bt_Room_Click);
            // 
            // pn_Main
            // 
            this.pn_Main.Controls.Add(this.home1);
            this.pn_Main.Controls.Add(this.uC_contract1);
            this.pn_Main.Controls.Add(this.uC_Cus1);
            this.pn_Main.Controls.Add(this.uC_Room1);
            this.pn_Main.Controls.Add(this.uC_HoaDon1);
            this.pn_Main.Location = new System.Drawing.Point(12, 175);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(1513, 650);
            this.pn_Main.TabIndex = 0;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.home1.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home1.Location = new System.Drawing.Point(1, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1513, 650);
            this.home1.TabIndex = 4;
            // 
            // uC_contract1
            // 
            this.uC_contract1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(104)))), ((int)(((byte)(159)))));
            this.uC_contract1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_contract1.Location = new System.Drawing.Point(0, -4);
            this.uC_contract1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_contract1.Name = "uC_contract1";
            this.uC_contract1.Size = new System.Drawing.Size(1513, 650);
            this.uC_contract1.TabIndex = 2;
            // 
            // uC_Cus1
            // 
            this.uC_Cus1.BackColor = System.Drawing.Color.White;
            this.uC_Cus1.Location = new System.Drawing.Point(-3, 0);
            this.uC_Cus1.Name = "uC_Cus1";
            this.uC_Cus1.Size = new System.Drawing.Size(1513, 650);
            this.uC_Cus1.TabIndex = 0;
            // 
            // uC_Room1
            // 
            this.uC_Room1.BackColor = System.Drawing.Color.White;
            this.uC_Room1.ForeColor = System.Drawing.Color.Maroon;
            this.uC_Room1.Location = new System.Drawing.Point(0, -2);
            this.uC_Room1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_Room1.Name = "uC_Room1";
            this.uC_Room1.Size = new System.Drawing.Size(1513, 650);
            this.uC_Room1.TabIndex = 1;
            // 
            // uC_HoaDon1
            // 
            this.uC_HoaDon1.BackColor = System.Drawing.Color.White;
            this.uC_HoaDon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uC_HoaDon1.Location = new System.Drawing.Point(0, -4);
            this.uC_HoaDon1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_HoaDon1.Name = "uC_HoaDon1";
            this.uC_HoaDon1.Size = new System.Drawing.Size(1513, 650);
            this.uC_HoaDon1.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.pn_Main;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1442, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 2;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1493, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // Fr_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(64)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1550, 852);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fr_main";
            this.Load += new System.EventHandler(this.Fr_main_Load);
            this.panel1.ResumeLayout(false);
            this.pn_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button bt_web;
        private Guna.UI2.WinForms.Guna2Button bt_Bill;
        private Guna.UI2.WinForms.Guna2Button bt_Customers;
        private Guna.UI2.WinForms.Guna2Button bt_Room;
        private System.Windows.Forms.Panel pn_Main;
        private Guna.UI2.WinForms.Guna2Button btContract;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC_Cus uC_Cus1;
        private UC_Room uC_Room1;
        private UC_contract uC_contract1;
        private UC_HoaDon uC_HoaDon1;
        private Guna.UI2.WinForms.Guna2Button btHome;
        private Home home1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}