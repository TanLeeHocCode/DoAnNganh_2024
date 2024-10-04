using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class Fr_login : Form
    {
        Admin admin = new Admin();
        BUS_Admin amBus = new BUS_Admin();
        public Fr_login()
        {
            InitializeComponent();
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
            Admin admin = new Admin
            {
                TaiKhoan = txt_Account.Text,
                MatKhau = txt_password.Text
            };

            BUS_Admin busAdmin = new BUS_Admin();
            string result = busAdmin.CheckLogin(admin);

            switch (result)
            {
                case "Quên nhập tài khoản":
                    MessageBox.Show("Quên nhập tài khoản!!!");
                    return;

                case "Quên nhập mật khẩu":
                    MessageBox.Show("Quên nhập mật khẩu!!!");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show(result);
                    return;

                default:
                    Fr_main fm = new Fr_main();
                    fm.Show();
                    this.Hide();
                    fm.FormClosed += (s, args) => this.Close();
                    break;
            }
        }
    }
}
