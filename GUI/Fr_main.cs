using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace GUI
{
    public partial class Fr_main : Form
    {
        public Fr_main()
        {
            InitializeComponent();
        }

        /*
                private void bt_Room_Click(object sender, EventArgs e)
                {
                    UC_Room ucr = new UC_Room();
                    ucr.BringToFront();
                }

                private void bt_Customers_Click(object sender, EventArgs e)
                {
                    UC_Cus ucc = new UC_Cus();
                    ucc.BringToFront();
                }*/
        private void bt_Room_Click(object sender, EventArgs e)
        {
            UC_Room ucr = new UC_Room();
            ucr.Dock = DockStyle.Fill; // Đặt Fill để lấp đầy panel
            pn_Main.Controls.Add(ucr); // Thêm UC_Room vào panel
            ucr.BringToFront(); // Đưa UC_Room lên trên cùng trong panel
        }

        private void bt_Customers_Click(object sender, EventArgs e)
        {
            UC_Cus ucc = new UC_Cus();
            ucc.Dock = DockStyle.Fill; // Đặt Fill để lấp đầy panel
            pn_Main.Controls.Add(ucc); // Thêm UC_Cus vào panel
            ucc.BringToFront(); // Đưa UC_Cus lên trên cùng trong panel
        }

        private void bt_Bill_Click(object sender, EventArgs e)
        {
            UC_HoaDon uc_hoadon = new UC_HoaDon();
            uc_hoadon.Dock = DockStyle.Fill; // Đặt Fill để lấp đầy panel
            pn_Main.Controls.Add(uc_hoadon); // Thêm UC_Room vào panel
            uc_hoadon.BringToFront(); // Đưa UC_Room lên trên cùng trong panel
        }

        private void bt_web_Click(object sender, EventArgs e)
        {
            ChromeDriverService chromeService = ChromeDriverService.CreateDefaultService();
            chromeService.HideCommandPromptWindow = true;

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized"); // Tùy chọn: Mở trình duyệt ở chế độ toàn màn hình

            IWebDriver driver = new ChromeDriver(chromeService, options); // Khởi tạo với dịch vụ và tùy chọn
            driver.Navigate().GoToUrl("http://127.0.0.1:5000"); // URL của trang web
        }

     
        private void btHome_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Dock = DockStyle.Fill; // Đặt Fill để lấp đầy panel
            pn_Main.Controls.Add(h); // Thêm UC_Room vào panel
            h.BringToFront(); // Đưa UC_Room lên trên cùng trong panel
        }

        private void btContract_Click(object sender, EventArgs e)
        {
            UC_contract uc_contract = new UC_contract();
            uc_contract.Dock = DockStyle.Fill; // Đặt Fill để lấp đầy panel
            pn_Main.Controls.Add(uc_contract); // Thêm UC_Room vào panel
            uc_contract.BringToFront(); // Đưa UC_Room lên trên cùng trong panel
        }

        private void Fr_main_Load(object sender, EventArgs e)
        {




        }
    }
}
