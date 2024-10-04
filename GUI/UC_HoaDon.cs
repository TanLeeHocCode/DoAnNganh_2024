using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void cbChucNangBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChucNangBill.Text == "Nhập điện")
            {
                SaveDien saveDien = new SaveDien();
                saveDien.Dock = DockStyle.Fill; // Đặt Fill để lấp đầy panel
                pn_bill.Controls.Add(saveDien); // Thêm UC_Room vào panel
                saveDien.BringToFront(); // Đưa UC_Room lên trên cùng trong panel
            }
            else
            {
                PrintBill print = new PrintBill();
                print.Dock = DockStyle.Fill; // Đặt Fill để lấp đầy panel
                pn_bill.Controls.Add(print); // Thêm UC_Room vào panel
                print.BringToFront(); // Đưa UC_Room lên trên cùng trong panel
            }

        }
    }
}
