using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using static DTO.DTO_QLPhongTro;
namespace GUI
{
    public partial class UC_Cus : UserControl
    {
        private BUS_customers bus_c;
        public UC_Cus()
        {
            InitializeComponent();
            bus_c = new BUS_customers();
            da_Cus.CellClick += da_Customers_CellClick;
        }
        public void LoadKHData()
        {
            da_Cus.AutoGenerateColumns = false;
            List<KhachHang> ctp = bus_c.GetListKhachHang();
            da_Cus.DataSource = ctp;
            da_Cus.Columns["MaKH"].DataPropertyName = "MaKH";
            da_Cus.Columns["MaKH"].Visible =false;
            da_Cus.Columns["Ho"].DataPropertyName = "Ho";
            da_Cus.Columns["Ten"].DataPropertyName = "Ten";
            da_Cus.Columns["NamSinh"].DataPropertyName = "NamSinh";
            da_Cus.Columns["SDT"].DataPropertyName = "SDT";
            da_Cus.Columns["CCCD"].DataPropertyName = "CCCD";
            da_Cus.Columns["Email"].DataPropertyName = "Email";
            da_Cus.Columns["QueQuan"].DataPropertyName = "QueQuan";
            da_Cus.Columns["SoXe"].DataPropertyName = "SoXe";
            da_Cus.Columns["MaPhong"].DataPropertyName = "MaPhong";

            if (da_Cus.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
                btnDeleteColumn.Name = "btnDelete";
                btnDeleteColumn.HeaderText = "Xóa";
                btnDeleteColumn.Text = "Xóa";
                btnDeleteColumn.UseColumnTextForButtonValue = true;
                da_Cus.Columns.Add(btnDeleteColumn);
            }
        }

        private void UC_Cus_Load(object sender, EventArgs e)
        {
            LoadKHData();
        }

        private void da_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cbChucNang.Text=="Cập nhật thông tin")
            {
                if (e.RowIndex >= 0)
                {
                    // Kiểm tra tên cột chính xác là "MaPhong"
                    int maKH = Convert.ToInt32(da_Cus.Rows[e.RowIndex].Cells["MaKH"].Value);

                    // Lấy thông tin phòng từ cơ sở dữ liệu
                    var khList = bus_c.GetListKHByMaKH(maKH);
                    if (khList.Count > 0)
                    {
                        var kh = khList[0];

                        // Điền thông tin vào các TextBox và ComboBox
                        txtMaKH.Text = kh.MaKH.ToString();
                        txtHo.Text = kh.Ho.ToString();
                        txtTen.Text = kh.Ten.ToString();
                        txtSdt.Text = kh.SDT.ToString();
                        txtCCCD.Text = kh.CCCD.ToString();
                        txtEmail.Text = kh.Email.ToString();
                        txtSoXe.Text = kh.SoXe.ToString();
                        txtQQ.Text = kh.QueQuan.ToString();
                        txtMaPhong.Text = kh.MaPhong.ToString();
                        date_NS.Value = kh.NamSinh;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với mã số này.");
                    }

                }            
            }
            if (e.ColumnIndex == da_Cus.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                // Lấy mã khách hàng từ dòng hiện tại
                int maKH = Convert.ToInt32(da_Cus.Rows[e.RowIndex].Cells["MaKH"].Value);

                // Xác nhận xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xóa Khách Hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Gọi phương thức xóa khách hàng từ lớp BUS
                    bool isDeleted = bus_c.DeleteKhachHang(maKH);
                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa khách hàng thành công.");
                        LoadKHData(); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại.");
                    }
                }
            }
        }
        private void cbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbChucNang.Text=="Cập nhật thông tin")
            {
                btAdd.Visible = false;
                txtMaKH.Visible = true;
                btUpdete.Visible = true;
                pn_ThongTin.Visible = true;
                clear_info();
            }
            else
            {
                btAdd.Visible = true;
                txtMaKH.Visible = false;
                btUpdete.Visible = false;
                pn_ThongTin.Visible = true;
                clear_info();
            }
        }

        private void da_Cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btUpdete_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có dữ liệu hợp lệ cho MaKH không
            if (int.TryParse(txtMaKH.Text, out int maKH))
            {
                // Xử lý ngày sinh từ DateTimePicker
                DateTime? namSinh = null;
                if (date_NS.Value >= new DateTime(1753, 1, 1) && date_NS.Value <= new DateTime(9999, 12, 31))
                {
                    namSinh = date_NS.Value;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.");
                    return;
                }

                // Tạo đối tượng KhachHang với các thông tin từ form
                var updatedKH = new KhachHang
                {
                    MaKH = maKH,
                    Ho = txtHo.Text,
                    Ten = txtTen.Text,
                    SDT = txtSdt.Text,
                    CCCD = txtCCCD.Text,
                    Email = txtEmail.Text,
                    QueQuan = txtQQ.Text,
                    SoXe = int.TryParse(txtSoXe.Text, out int soxe) ? soxe : 0,
                    MaPhong = int.TryParse(txtMaPhong.Text, out int maphong) ? maphong : 0,
                    NamSinh = namSinh ?? DateTime.MinValue // Xử lý giá trị ngày sinh
                };

                // Gọi phương thức cập nhật từ lớp BUS
                bool isUpdated = bus_c.UpdateKhachHang(updatedKH);
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công.");
                    LoadKHData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khách hàng để cập nhật.");
            }
            clear_info();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Xử lý ngày sinh từ DateTimePicker
            DateTime? namSinh = null;
            if (date_NS.Value >= new DateTime(1753, 1, 1) && date_NS.Value <= new DateTime(9999, 12, 31))
            {
                namSinh = date_NS.Value;
            }
            else
            {
                MessageBox.Show("Ngày sinh không hợp lệ.");
                return;
            }

            // Tạo đối tượng KhachHang với các thông tin từ form
            var newKH = new KhachHang
            {
                Ho = txtHo.Text,
                Ten = txtTen.Text,
                SDT = txtSdt.Text,
                CCCD = txtCCCD.Text,
                Email = txtEmail.Text,
                QueQuan = txtQQ.Text,
                SoXe = int.TryParse(txtSoXe.Text, out int soxe) ? soxe : 0,
                MaPhong = int.TryParse(txtMaPhong.Text, out int maphong) ? maphong : 0,
                NamSinh = namSinh ?? DateTime.MinValue // Xử lý giá trị ngày sinh
            };

            // Gọi phương thức thêm khách hàng từ lớp BUS
            bool isAdded = bus_c.AddKhachHang(newKH);
            if (isAdded)
            {
                MessageBox.Show("Thêm khách hàng thành công.");
                LoadKHData(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại.");
            }
            clear_info();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTK.Text.Trim()))
            {
                LoadKHData();
                return;
            }
            string option = cb_options.SelectedItem?.ToString();
            string searchText = txtTK.Text.Trim();
            List<KhachHang> resultList = bus_c.TimKiemKhachHang(option, searchText);
            da_Cus.DataSource = resultList;
            clear_info();
        }
        private void clear_info()
        {
            txtTK.Text = "";
            txtMaKH.Text = "";
            txtHo.Text= "";
            txtTen.Text= "";
            txtMaPhong.Text= "";
            txtEmail.Text= "";
            txtCCCD.Text= "";
            txtQQ.Text= "";
            txtSdt.Text= "";
            txtSoXe.Text= "";
            cb_options.SelectedIndex= -1;
        }
    }
}

