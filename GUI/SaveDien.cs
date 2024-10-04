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
    public partial class SaveDien : UserControl
    {
        private BUS_Bill _busBill;
        public SaveDien()
        {
            InitializeComponent();
            _busBill = new BUS_Bill();
            InitializeDataGridView();
        }
        private void LoadData()
        {
            da_InputDien.AutoGenerateColumns = false;
            var billDetails = _busBill.GetBillDetails();
            da_InputDien.DataSource = billDetails;
            Date_TaoHDon.Value = DateTime.Now;
            // Cấu hình Mapping cột
            da_InputDien.Columns["MaPhong"].DataPropertyName = "MaPhong";
            da_InputDien.Columns["MaPhong"].Visible = false;
            da_InputDien.Columns["TenTang"].DataPropertyName = "TenTang";
            da_InputDien.Columns["TenPhong"].DataPropertyName = "TenPhong";
            da_InputDien.Columns["GiaTien"].DataPropertyName = "GiaTien";
            da_InputDien.Columns["HoTen"].DataPropertyName = "HoTen";
            da_InputDien.Columns["SoNguoi"].DataPropertyName = "SoNguoi";
            da_InputDien.Columns["SoXe"].DataPropertyName = "SoXe";
            da_InputDien.Columns["DienThangTruoc"].DataPropertyName = "SoDienMoi";
        }
        private void InitializeDataGridView()
        {
            da_InputDien.AutoGenerateColumns = false;
        }
        private void SaveDien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_SaveDien_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in da_InputDien.Rows)
            {
                if (row.IsNewRow) continue;

                int maPhong;
                if (int.TryParse(row.Cells["MaPhong"].Value?.ToString(), out maPhong))
                {
                    int soDienMoi;
                    if (int.TryParse(row.Cells["SoDienMoi"].Value?.ToString(), out soDienMoi))
                    {
                        DateTime ngayThang = Date_TaoHDon.Value; // Hoặc lấy từ một TextBox nếu cần thiết

                        // Cập nhật số điện mới vào cơ sở dữ liệu
                        bool success = _busBill.UpdateSoDienMoi(maPhong, soDienMoi, ngayThang);
                        if (!success)
                        {
                            MessageBox.Show($"Không thể cập nhật số điện mới cho phòng {maPhong}.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số điện mới không hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã phòng không hợp lệ.");
                }
            }

            MessageBox.Show("Cập nhật thành công!");
            LoadData();

        }

        private void da_InputDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
