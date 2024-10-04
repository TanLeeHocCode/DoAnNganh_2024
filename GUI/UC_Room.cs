using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
using static DTO.DTO_QLPhongTro;
namespace GUI
{
    public partial class UC_Room : UserControl
    {
        BUS_room bus_r = new BUS_room();
        public UC_Room()
        {
            InitializeComponent();
            LoadPhongData();
            da_Room.CellClick += new DataGridViewCellEventHandler(da_Room_CellClick);
        }

        private void da_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbChucNang.Text == "Sửa phòng")
            {
                if (e.RowIndex >= 0)
                {
                    int maPhong = Convert.ToInt32(da_Room.Rows[e.RowIndex].Cells["MaPhong"].Value);
                    var phongList = bus_r.GetPhongByMaSP(maPhong);
                    if (phongList.Count > 0)
                    {
                        var phong = phongList[0];

                        // Loại bỏ khoảng trắng thừa
                        var tenTangTrimmed = phong.TenTang.Trim();
                        var tenPhongTrimmed = phong.TenPhong.Trim();

                        // Gán giá trị vào các điều khiển sau khi loại bỏ khoảng trắng
                        txtMaPhong.Text = phong.MaPhong.ToString();
                        lbTrangThai.Text = phong.TrangThai.ToString();

                        // Gán giá trị đã được Trim vào ComboBox
                        if (cbSTang.Items.Contains(tenTangTrimmed))
                        {
                            cbSTang.SelectedItem = tenTangTrimmed;
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy '{tenTangTrimmed}' trong danh sách tầng.");
                        }

                        if (cbSoPhong.Items.Contains(tenPhongTrimmed))
                        {
                            cbSoPhong.SelectedItem = tenPhongTrimmed;
                        }
                        else
                        {
                            MessageBox.Show($"Không tìm thấy '{tenPhongTrimmed}' trong danh sách số phòng.");
                        }

                        // Gán giá trị cho ComboBox Loại Phòng
                        cbLoaiP.SelectedItem = phong.TenLP.Trim();

                    }
                }
            }
            else
            {
                // Kiểm tra nếu cột nhấn là nút "Xóa" và hàng hợp lệ
                    if (e.ColumnIndex == da_Room.Columns["btnDelete"].Index && e.RowIndex >= 0)
                    {
                        // Xác nhận hành động xóa
                        var result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Nếu người dùng xác nhận xóa
                        if (result == DialogResult.Yes)
                        {
                            // Lấy Mã phòng từ ô của dòng hiện tại
                            int maPhong = Convert.ToInt32(da_Room.Rows[e.RowIndex].Cells["MaPhong"].Value);

                            // Xóa phòng qua BUS
                            bool isDeleted = bus_r.DeletePhong(maPhong);

                            if (isDeleted)
                            {
                                MessageBox.Show("Xóa phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadPhongData(); // Làm mới DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Xóa phòng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
            }
        }
        private void UC_Room_Load(object sender, EventArgs e)
        {
            LoadPhongData();
        }
        private void LoadPhongData(List<CombinedPhongInfo> data = null)
        {
            da_Room.AutoGenerateColumns = false;

            if (data == null)
            {
                data = bus_r.GetCombinedPhongList();
            }

            da_Room.DataSource = data;

            // Mapping giữa các cột và thuộc tính của CombinedPhongInfo
            da_Room.Columns["MaPhong"].DataPropertyName = "MaPhong";
            da_Room.Columns["tang"].DataPropertyName = "Tang";
            da_Room.Columns["SoPhong"].DataPropertyName = "TenPhong";
            da_Room.Columns["LoaiPhong"].DataPropertyName = "LoaiPhong";
            da_Room.Columns["TrangThai"].DataPropertyName = "TrangThai";
            da_Room.Columns["GiaTien"].DataPropertyName = "GiaTien";

            // Thêm nút "Xóa" nếu chưa tồn tại
            if (da_Room.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                {
                    Name = "btnDelete",
                    HeaderText = "Xóa",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true
                };
                da_Room.Columns.Add(btnDelete);
            }

            da_Room.CellFormatting += Da_Room_CellFormatting;
        }


        private void Da_Room_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang xử lý cột TrangThai và giá trị là 0 hoặc 1
            if (da_Room.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                int trangThaiValue;
                if (int.TryParse(e.Value.ToString(), out trangThaiValue))
                {
                    // Thay đổi giá trị hiển thị dựa trên giá trị của TrangThai
                    if (trangThaiValue == 0)
                    {
                        e.Value = "Trống";
                    }
                    else if (trangThaiValue == 1)
                    {
                        e.Value = "Đã cho thuê";
                    }

                    // Đánh dấu rằng sự kiện đã được xử lý, không cần DataGridView tự động format lại
                    e.FormattingApplied = true;
                }
            }
        }

        private void cbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChucNang.Text == "Thêm phòng")
            {
                label14.Visible = false;
                txtMaPhong.Visible = false;
                btUpdete.Visible = false;
                btAdd.Visible = true;
                clear_info();
            }
            else
            {
                label14.Visible = true;
                txtMaPhong.Visible = true;
                btUpdete.Visible = true;
                btAdd.Visible = false;
                clear_info();
            }

        }
        private void clear_info()
        {
            cbTrangThai.Text = "";
            cbLoaiP.SelectedIndex = -1;
            txtMaPhong.Text = "";
            lbGiaTien.Text = "";
            cbLoaiP.SelectedIndex = -1;
            cbSTang.SelectedIndex = -1;
            cbSoPhong.SelectedIndex = -1;
            lbGiaTien.Text = "";
        }

        private void btUpdete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtMaPhong.Text, out int maPhong))
                {
                    int trangThai = int.Parse(lbTrangThai.Text);
                    string tenTang = cbSTang.SelectedItem.ToString();
                    string tenPhong = cbSoPhong.SelectedItem.ToString();
                    string tenLP = cbLoaiP.SelectedItem.ToString();

                    var updatedPhong = new Phong
                    {
                        MaPhong = maPhong,
                        TrangThai = trangThai,
                        TenTang = tenTang,
                        TenPhong = tenPhong,
                        TenLP = tenLP
                    };

                    bool isUpdated = bus_r.UpdatePhong(updatedPhong);
                    if (isUpdated)
                    {
                        MessageBox.Show("Cập nhật phòng thành công.");
                        LoadPhongData(); // Làm mới DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phòng thất bại.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phòng để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phòng: " + ex.Message);
            }
            clear_info();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các ComboBox
                string tenTang = cbSTang.SelectedItem.ToString();
                string tenPhong = cbSoPhong.SelectedItem.ToString();
                string tenLP = cbLoaiP.SelectedItem.ToString();

                // Gọi phương thức AddPhong với các tham số tên
                bool isAdded = bus_r.AddPhong(tenTang, tenPhong, tenLP);

                if (isAdded)
                {
                    MessageBox.Show("Phòng đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Làm mới giao diện hoặc thực hiện các hành động khác
                    LoadPhongData();
                }
                else
                {
                    MessageBox.Show("Không thể thêm phòng. Vui lòng kiểm tra lại thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                clear_info();

            }
        }

        private void cbLoaiP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiP.Text == "Phong Co Ban") { lbGiaTien.Text = "4.500.000"; }
            else if (cbLoaiP.Text == "Phong Plus") { lbGiaTien.Text = "5.500.000"; }
            else { lbGiaTien.Text = "7.000.000"; }

        }    
        private void btLoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Xác định giá trị trạng thái dựa trên lựa chọn trong ComboBox
                int? selectedTrangThai = null;

                if (cbTrangThai.SelectedItem != null)
                {
                    // Lấy giá trị từ ComboBox và chuyển đổi thành số nguyên tương ứng
                    string selectedValue = cbTrangThai.SelectedItem.ToString().Trim();
                    if (selectedValue == "Yes")
                    {
                        selectedTrangThai = 1; // Yes tương ứng với 1
                    }
                    else if (selectedValue == "No")
                    {
                        selectedTrangThai = 0; // No tương ứng với 0
                    }
                }
                if (!selectedTrangThai.HasValue)
                {
                    LoadPhongData();
                }
                else
                {
                    var filteredPhongList = bus_r.TimKiemPhongTheoTrangThai(selectedTrangThai);
                    da_Room.DataSource = filteredPhongList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cbTrangThai.SelectedIndex = -1;
        }

        private void lbTrangThai_Click(object sender, EventArgs e)
        {
            if (lbTrangThai.Text == "0") { lbTrangThai.Text = "No"; }
            else { lbTrangThai.Text = "Yest"; }
        }
    }
}
