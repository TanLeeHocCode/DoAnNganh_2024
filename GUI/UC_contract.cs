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
using System.IO;

namespace GUI
{
    public partial class UC_contract : UserControl
    {
        BUS_contract BUS_Contract = new BUS_contract();
        public UC_contract()
        {
            InitializeComponent();
            LoadHopDongData();
            da_contract.CellClick += dataGridView1_CellClick; // Đăng ký sự kiện
            da_contract.CellFormatting += da_contract_CellFormatting;
        }
        private void LoadHopDongData()
        {
            date_BD.Value = DateTime.Today;
            date_KT.Value = date_BD.Value.AddYears(1);
            da_contract.AutoGenerateColumns = false;
            List<HopDong> hopDongs = BUS_Contract.GetAllHopDongs();
            da_contract.DataSource = hopDongs;

            da_contract.Columns["MaHDong"].DataPropertyName = "MaHDong";
            da_contract.Columns["MaHDong"].Visible = false;
            da_contract.Columns["NgayThangBD"].DataPropertyName = "NgayThangBD";
            da_contract.Columns["NgayThangKT"].DataPropertyName = "NgayThangKT";
            da_contract.Columns["TenLoaiPhong"].DataPropertyName = "TenLP";
            da_contract.Columns["GiaTien"].DataPropertyName = "GiaTien";
            da_contract.Columns["TenTang"].DataPropertyName = "TenTang";
            da_contract.Columns["CCCD"].DataPropertyName = "CCCD";
            da_contract.Columns["TenPhong"].DataPropertyName = "TenPhong";
            da_contract.Columns["HoTen"].DataPropertyName = "HoTen";
            da_contract.Columns["TienCoc"].DataPropertyName = "GiaTien";
            da_contract.Columns["SoNguoi"].DataPropertyName = "SoNguoi";
            da_contract.Columns["SoXe"].DataPropertyName = "SoXe";
            da_contract.Columns["DienTich"].DataPropertyName = "DienTich";

            // Kiểm tra và thêm cột nút "Xem Hợp Đồng" nếu chưa tồn tại
            if (!da_contract.Columns.Contains("btnViewContract"))
            {
                DataGridViewButtonColumn btnViewContract = new DataGridViewButtonColumn();
                btnViewContract.HeaderText = "Xem Hợp Đồng";
                btnViewContract.Text = "Xem";
                btnViewContract.Name = "btnViewContract";
                btnViewContract.UseColumnTextForButtonValue = true;
                da_contract.Columns.Add(btnViewContract);
            }
            if (!da_contract.Columns.Contains("btnDeleteContract"))
            {
                DataGridViewButtonColumn btnDeleteContract = new DataGridViewButtonColumn();
                btnDeleteContract.HeaderText = "Xem Hợp Đồng";
                btnDeleteContract.Text = "Xóa";
                btnDeleteContract.Name = "btnDeleteContract";
                btnDeleteContract.UseColumnTextForButtonValue = true;
                da_contract.Columns.Add(btnDeleteContract);
            }
        }
        private void da_contract_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu cột là "HocPhi"
            if (da_contract.Columns[e.ColumnIndex].Name == "GiaTien" || da_contract.Columns[e.ColumnIndex].Name == "TienCoc" && e.Value != null)
            {
                // Chuyển giá trị thành định dạng 000.000
                e.Value = string.Format("{0:0,0}", e.Value);
                e.FormattingApplied = true;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý khi nhấn vào nút xem hợp đồng
            if (e.ColumnIndex == da_contract.Columns["btnViewContract"].Index && e.RowIndex >= 0)
            {
                int maHDong = Convert.ToInt32(da_contract.Rows[e.RowIndex].Cells["MaHDong"].Value);

                // Sử dụng phương thức GetHopDongDetails của lớp BUS để lấy thông tin hợp đồng
                HopDong hopDong = BUS_Contract.GetHopDongDetails(maHDong);

                if (hopDong != null)
                {
                    string fileName = $"Hợp_Đồng_{maHDong}_{hopDong.HoTen}.docx";
                    string filePath = Path.Combine(@"D:\QLPhongTro\HopDong\", fileName);

                    // Mở file Word
                    if (File.Exists(filePath))
                    {
                        System.Diagnostics.Process.Start(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy file hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Xử lý khi nhấn vào nút xóa hợp đồng
            if (e.ColumnIndex == da_contract.Columns["btnDeleteContract"].Index && e.RowIndex >= 0)
            {
                int maHDong = Convert.ToInt32(da_contract.Rows[e.RowIndex].Cells["MaHDong"].Value);

                // Hiển thị hộp thoại xác nhận trước khi xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Gọi phương thức xóa hợp đồng từ lớp BUS
                        BUS_Contract.DeleteContract(maHDong);
                        LoadHopDongData(); // Phương thức để tải lại dữ liệu vào DataGridView
                        MessageBox.Show("Hợp đồng đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa hợp đồng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
        private void UC_contract_Load(object sender, EventArgs e)
        {

        }

        private void date_BD_ValueChanged(object sender, EventArgs e)
        {
            date_KT.Value = date_BD.Value.AddYears(1);
        }

        private void cbChucNangHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChucNangHopDong.Text == "Tìm kiếm hợp đồng")
            {
                btSearch.Visible = true;
                label2.Visible = false;
                label6.Visible = false;
                date_BD.Visible = false;
                date_KT.Visible = false;
                btAdd.Visible = false;
            }
            else
            {
                label2.Visible = true;
                label6.Visible = true;
                date_BD.Visible = true;
                btSearch.Visible = false;
                btAdd.Visible = true;
                date_KT.Visible = true;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string CCCD = txtCCCD.Text;
            List<HopDong> hopDongs = BUS_Contract.GetAllHopDongByCCCDs(CCCD);
            da_contract.DataSource = hopDongs;

            da_contract.Columns["MaHDong"].DataPropertyName = "MaHDong";
            da_contract.Columns["MaHDong"].Visible = false;
            da_contract.Columns["NgayThangBD"].DataPropertyName = "NgayThangBD";
            da_contract.Columns["NgayThangKT"].DataPropertyName = "NgayThangKT";
            da_contract.Columns["TenLoaiPhong"].DataPropertyName = "TenLP";
            da_contract.Columns["GiaTien"].DataPropertyName = "GiaTien";
            da_contract.Columns["TenTang"].DataPropertyName = "TenTang";
            da_contract.Columns["CCCD"].DataPropertyName = "CCCD";
            da_contract.Columns["TenPhong"].DataPropertyName = "TenPhong";
            da_contract.Columns["HoTen"].DataPropertyName = "HoTen";
            da_contract.Columns["TienCoc"].DataPropertyName = "GiaTien";
            da_contract.Columns["SoNguoi"].DataPropertyName = "SoNguoi";
            da_contract.Columns["SoXe"].DataPropertyName = "SoXe";
            da_contract.Columns["DienTich"].DataPropertyName = "DienTich";

            // Kiểm tra và thêm cột nút "Xem Hợp Đồng" nếu chưa tồn tại
            if (!da_contract.Columns.Contains("btnViewContract"))
            {
                DataGridViewButtonColumn btnViewContract = new DataGridViewButtonColumn();
                btnViewContract.HeaderText = "Xem Hợp Đồng";
                btnViewContract.Text = "Xem";
                btnViewContract.Name = "btnViewContract";
                btnViewContract.UseColumnTextForButtonValue = true;
                da_contract.Columns.Add(btnViewContract);
            }
            if (!da_contract.Columns.Contains("btnDeleteContract"))
            {
                DataGridViewButtonColumn btnDeleteContract = new DataGridViewButtonColumn();
                btnDeleteContract.HeaderText = "Xem Hợp Đồng";
                btnDeleteContract.Text = "Xóa";
                btnDeleteContract.Name = "btnDeleteContract";
                btnDeleteContract.UseColumnTextForButtonValue = true;
                da_contract.Columns.Add(btnDeleteContract);
            }
            txtCCCD.Text = "";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các giá trị trên form
                string CCCD = txtCCCD.Text.Trim(); // Giả sử bạn có một TextBox để nhập CCCD

                // Kiểm tra đầu vào
                if (string.IsNullOrEmpty(CCCD))
                {
                    MessageBox.Show("CCCD không được để trống!", "Lỗi");
                    return;
                }

                DateTime ngayThangBD = date_BD.Value;
                DateTime ngayThangKT = date_KT.Value;

                // Tạo đối tượng HopDong với giá trị mặc định, có thể thêm các thuộc tính khác nếu cần
                HopDong hopDong = new HopDong
                {
                    NgayThangBD = ngayThangBD,
                    NgayThangKT = ngayThangKT
                };

                int newMaHDong;
                // Thêm hợp đồng và lấy ID mới
                if (BUS_Contract.AddHopDong(CCCD, hopDong, out newMaHDong))
                {
                    // Tạo tài liệu hợp đồng
                    BUS_Contract.GenerateHopDongDocument(newMaHDong);

                    MessageBox.Show("Hợp đồng đã được thêm và file hợp đồng đã được tạo và hiển thị thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm hợp đồng thất bại!", "Lỗi");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng định dạng: " + ex.Message, "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi");
            }
            finally
            {
                // Tải lại dữ liệu hợp đồng để cập nhật giao diện
                LoadHopDongData();
            }
            txtCCCD.Text = "";
        }

        private void date_BD_ValueChanged_1(object sender, EventArgs e)
        {
            date_KT.Value = date_BD.Value.AddYears(1);
        }
    }
}
