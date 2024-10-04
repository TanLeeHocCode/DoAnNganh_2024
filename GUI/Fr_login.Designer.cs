
namespace GUI
{
    partial class Fr_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_login));
            this.bt_login = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_Account = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_Exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.BorderRadius = 25;
            this.bt_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(115)))), ((int)(((byte)(108)))));
            this.bt_login.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(479, 239);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(306, 53);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "Login";
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(508, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Login";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(64, 61);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(304, 238);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txt_Account
            // 
            this.txt_Account.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Account.BorderRadius = 25;
            this.txt_Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Account.DefaultText = "";
            this.txt_Account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Account.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Account.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_Account.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Account.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_Account.IconLeft")));
            this.txt_Account.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_Account.Location = new System.Drawing.Point(451, 85);
            this.txt_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.PasswordChar = '\0';
            this.txt_Account.PlaceholderText = "Please input account...";
            this.txt_Account.SelectedText = "";
            this.txt_Account.Size = new System.Drawing.Size(349, 51);
            this.txt_Account.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderRadius = 25;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_password.IconLeft")));
            this.txt_password.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_password.Location = new System.Drawing.Point(451, 158);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Please input password...";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(349, 55);
            this.txt_password.TabIndex = 1;
            // 
            // bt_Exit
            // 
            this.bt_Exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_Exit.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_Exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_Exit.Image")));
            this.bt_Exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_Exit.ImageRotate = 0F;
            this.bt_Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_Exit.Location = new System.Drawing.Point(-1, -2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_Exit.Size = new System.Drawing.Size(34, 40);
            this.bt_Exit.TabIndex = 11;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(176, 326);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(524, 22);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "*Bạn cần phải đăng nhập tài khoản được cấp phép để sử dụng phần mềm";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fr_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 351);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fr_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fr_login";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button bt_login;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Account;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2ImageButton bt_Exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}