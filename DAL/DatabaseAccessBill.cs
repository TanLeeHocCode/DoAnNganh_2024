using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DatabaseAccessBill:DBConnect
    {
        public List<BillDetail> GetBillDetails()
        {
            List<BillDetail> billDetails = new List<BillDetail>();
            try
            {
                _conn.Open();
                string query = @"
                SELECT p.MaPhong,t.TenTang, sp.TenPhong, ctp.SoDienCu, ctp.SoDienMoi, ctp.SoNguoi, ctp.SoXe,
                       kh.Ho + ' ' + kh.Ten AS HoTen, lp.GiaTien, kh.SDT, kh.Email
                FROM HopDong hd 
                INNER JOIN KhachHang kh ON kh.MaKH = hd.MaKH
                INNER JOIN Phong p ON p.MaPhong = kh.MaPhong
                INNER JOIN ChiTietPhong ctp ON ctp.MaPhong = p.MaPhong
                INNER JOIN Tang t ON t.MaTang = p.MaTang
                INNER JOIN LoaiPhong lp ON lp.MaLP = p.MaLP
                INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
                WHERE p.TrangThai = 1";

                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    BillDetail billDetail = new BillDetail
                    {
                        MaPhong = reader["MaPhong"] != DBNull.Value ? (int)reader["MaPhong"] : 0,
                        TenTang = reader["TenTang"] != DBNull.Value ? (string)reader["TenTang"] : string.Empty,
                        TenPhong = reader["TenPhong"] != DBNull.Value ? (string)reader["TenPhong"] : string.Empty,
                        SoDienCu = reader["SoDienCu"] != DBNull.Value ? (int)reader["SoDienCu"] : 0,
                        SoDienMoi = reader["SoDienMoi"] != DBNull.Value ? (int)reader["SoDienMoi"] : 0,
                        SoNguoi = reader["SoNguoi"] != DBNull.Value ? (int)reader["SoNguoi"] : 0,
                        SoXe = reader["SoXe"] != DBNull.Value ? (int)reader["SoXe"] : 0,
                        HoTen = reader["HoTen"] != DBNull.Value ? (string)reader["HoTen"] : string.Empty,
                        GiaTien = reader["GiaTien"] != DBNull.Value ? (int)reader["GiaTien"] : 0,
                        SDT = reader["SDT"] != DBNull.Value ? (string)reader["SDT"] : string.Empty,
                        Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty
                    };

                    billDetails.Add(billDetail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return billDetails;
        }

        public bool UpdateSoDienMoi(int maPhong, int soDienMoi, DateTime NgayThang)
        {
            try
            {
                _conn.Open();

                // Lấy giá trị SoDienMoi hiện tại từ ChiTietPhong để cập nhật SoDienCu
                string getCurrentSoDienQuery = @"
        SELECT SoDienMoi
        FROM ChiTietPhong
        WHERE MaPhong = @MaPhong";

                SqlCommand getCurrentSoDienCmd = new SqlCommand(getCurrentSoDienQuery, _conn);
                getCurrentSoDienCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                int soDienCu = (int)getCurrentSoDienCmd.ExecuteScalar();

                // Cập nhật SoDienCu bằng giá trị SoDienMoi hiện tại
                string updateSoDienCuQuery = @"
        UPDATE ChiTietPhong
        SET SoDienCu = @SoDienCu
        WHERE MaPhong = @MaPhong";

                SqlCommand updateSoDienCuCmd = new SqlCommand(updateSoDienCuQuery, _conn);
                updateSoDienCuCmd.Parameters.AddWithValue("@SoDienCu", soDienCu);
                updateSoDienCuCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                updateSoDienCuCmd.ExecuteNonQuery();

                // Cập nhật SoDienMoi mới trong ChiTietPhong
                string updateSoDienMoiQuery = @"
        UPDATE ChiTietPhong
        SET SoDienMoi = @SoDienMoi
        WHERE MaPhong = @MaPhong";

                SqlCommand updateSoDienMoiCmd = new SqlCommand(updateSoDienMoiQuery, _conn);
                updateSoDienMoiCmd.Parameters.AddWithValue("@SoDienMoi", soDienMoi);
                updateSoDienMoiCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                updateSoDienMoiCmd.ExecuteNonQuery();

                // Tính toán số điện sử dụng
                int soDienSuDung = soDienMoi - soDienCu;

                // Thêm vào bảng HoaDon với TrangThai = 0
                string insertHoaDonQuery = @"
        INSERT INTO HoaDon(PhiDV, SoDien, NgayThang, MaHDong, TrangThai,TrangThaiThanhToan)
        VALUES (@PhiDV, @SoDienSuDung, @NgayThang, 
        (SELECT MaHDong FROM HopDong WHERE MaPhong = @MaPhong), 0,0)";

                SqlCommand insertHoaDonCmd = new SqlCommand(insertHoaDonQuery, _conn);
                insertHoaDonCmd.Parameters.AddWithValue("@SoDienSuDung", soDienSuDung);
                insertHoaDonCmd.Parameters.AddWithValue("@NgayThang", NgayThang);
                insertHoaDonCmd.Parameters.AddWithValue("@PhiDV", 350000); // Giá trị cố định cho PhiDV
                insertHoaDonCmd.Parameters.AddWithValue("@MaPhong", maPhong);
                insertHoaDonCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public List<GetAllBillPrint> PrintBillDetails()
        {
            List<GetAllBillPrint> billDetails = new List<GetAllBillPrint>();
            try
            {
                _conn.Open();
                string query = @"
                SELECT MaHDon, SDT, Email, SoNguoi, SoXe, 
                   [Tầng], [Số Phòng], [Loại Phòng], [Họ Tên],
                   [Giá Tiền Phòng], [Tiền Xe], [Tiền Nước], 
                   [Tiền Điện], [Phí Dịch Vụ], [Tổng tiền], 
                   TrangThai, TrangThaiThanhToan, ThangHD, NamHD, SoDien, SoNguoi, SoXe,
                   SUM([Tổng tiền]) OVER () AS [SumMoney]
                    FROM BillDetailsView ";

                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    GetAllBillPrint billDetail = new GetAllBillPrint
                    {
                        MaHDon = reader["MaHDon"] != DBNull.Value ? (int)reader["MaHDon"] : 0,
                        TenTang = reader["Tầng"] != DBNull.Value ? (string)reader["Tầng"] : string.Empty,
                        TenPhong = reader["Số Phòng"] != DBNull.Value ? (string)reader["Số Phòng"] : string.Empty,
                        HoTen = reader["Họ Tên"] != DBNull.Value ? (string)reader["Họ Tên"] : string.Empty,
                        TenLP = reader["Loại Phòng"] != DBNull.Value ? (string)reader["Loại Phòng"] : string.Empty,
                        GiaTien = reader["Giá Tiền Phòng"] != DBNull.Value ? (int)reader["Giá Tiền Phòng"] : 0,
                        SDT = reader["SDT"] != DBNull.Value ? (string)reader["SDT"] : string.Empty,
                        Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty,
                        TienXe = reader["Tiền Xe"] != DBNull.Value ? (int)reader["Tiền Xe"] : 0,
                        TienNuoc = reader["Tiền Nước"] != DBNull.Value ? (int)reader["Tiền Nước"] : 0,
                        TienDien = reader["Tiền Điện"] != DBNull.Value ? (int)reader["Tiền Điện"] : 0,
                        PhiDV = reader["Phí Dịch Vụ"] != DBNull.Value ? (int)reader["Phí Dịch Vụ"] : 0,
                        TongTien = reader["Tổng tiền"] != DBNull.Value ? (int)reader["Tổng tiền"] : 0,
                        TrangThaiHD = reader["TrangThai"] != DBNull.Value ? (int)reader["TrangThai"] : 0,
                        TrangThaiThanhToan = reader["TrangThaiThanhToan"] != DBNull.Value ? (int)reader["TrangThaiThanhToan"] : 0,
                        ThangHD = reader["ThangHD"] != DBNull.Value ? (int)reader["ThangHD"] : 0,
                        NamHD = reader["NamHD"] != DBNull.Value ? (int)reader["NamHD"] : 0,
                        SoXe = reader["SoXe"] != DBNull.Value ? (int)reader["SoXe"] : 0,
                        SoNguoi = reader["SoNguoi"] != DBNull.Value ? (int)reader["SoNguoi"] : 0,
                        SoDien = reader["SoDien"] != DBNull.Value ? (int)reader["SoDien"] : 0,
                        SumMoney = reader["SumMoney"] != DBNull.Value ? (int)reader["SumMoney"] : 0
                    };

                    billDetails.Add(billDetail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return billDetails;
        }
        public List<GetAllBillPrint> GetBillDetailsByMonthYear(int month, int year, int trangthaithanhtoan)
        {
            List<GetAllBillPrint> billDetails = new List<GetAllBillPrint>();
            try
            {
                _conn.Open();
                string query = @"
                   SELECT MaHDon, SDT, Email, SoNguoi, SoXe, 
                   [Tầng], [Số Phòng], [Loại Phòng], [Họ Tên],
                   [Giá Tiền Phòng], [Tiền Xe], [Tiền Nước], 
                   [Tiền Điện], [Phí Dịch Vụ], [Tổng tiền], 
                   TrangThai, TrangThaiThanhToan, ThangHD, NamHD, SoDien, SoNguoi, SoXe,
                   SUM([Tổng tiền]) OVER () AS [SumMoney]
                    FROM BillDetailsView 
                    WHERE ThangHD = @Month AND NamHD = @Year AND TrangThaiThanhToan=@TrangThaiThanhToan;
                    ";
    
                SqlCommand cmd = new SqlCommand(query, _conn);

                // Thêm các tham số trước khi thực thi lệnh
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@TrangThaiThanhToan", trangthaithanhtoan);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    GetAllBillPrint billDetail = new GetAllBillPrint
                    {
                        MaHDon = reader["MaHDon"] != DBNull.Value ? (int)reader["MaHDon"] : 0,
                        TenTang = reader["Tầng"] != DBNull.Value ? (string)reader["Tầng"] : string.Empty,
                        TenPhong = reader["Số Phòng"] != DBNull.Value ? (string)reader["Số Phòng"] : string.Empty,
                        HoTen = reader["Họ Tên"] != DBNull.Value ? (string)reader["Họ Tên"] : string.Empty,
                        TenLP = reader["Loại Phòng"] != DBNull.Value ? (string)reader["Loại Phòng"] : string.Empty,
                        GiaTien = reader["Giá Tiền Phòng"] != DBNull.Value ? (int)reader["Giá Tiền Phòng"] : 0,
                        SDT = reader["SDT"] != DBNull.Value ? (string)reader["SDT"] : string.Empty,
                        Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty,
                        TienXe = reader["Tiền Xe"] != DBNull.Value ? (int)reader["Tiền Xe"] : 0,
                        TienNuoc = reader["Tiền Nước"] != DBNull.Value ? (int)reader["Tiền Nước"] : 0,
                        TienDien = reader["Tiền Điện"] != DBNull.Value ? (int)reader["Tiền Điện"] : 0,
                        PhiDV = reader["Phí Dịch Vụ"] != DBNull.Value ? (int)reader["Phí Dịch Vụ"] : 0,
                        TongTien = reader["Tổng tiền"] != DBNull.Value ? (int)reader["Tổng tiền"] : 0,
                        TrangThaiHD = reader["TrangThai"] != DBNull.Value ? (int)reader["TrangThai"] : 0,
                        TrangThaiThanhToan = reader["TrangThaiThanhToan"] != DBNull.Value ? (int)reader["TrangThaiThanhToan"] : 0,
                        ThangHD = reader["ThangHD"] != DBNull.Value ? (int)reader["ThangHD"] : 0,
                        NamHD = reader["NamHD"] != DBNull.Value ? (int)reader["NamHD"] : 0,
                        SoXe = reader["SoXe"] != DBNull.Value ? (int)reader["SoXe"] : 0,
                        SoNguoi = reader["SoNguoi"] != DBNull.Value ? (int)reader["SoNguoi"] : 0,
                        SoDien = reader["SoDien"] != DBNull.Value ? (int)reader["SoDien"] : 0,
                        SumMoney = reader["SumMoney"] != DBNull.Value ? (int)reader["SumMoney"] : 0
                    };

                    billDetails.Add(billDetail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return billDetails;
        }
        public List<ThongKe> GetBillDetailsThongKe(int month, int year)
        {
            List<ThongKe> thongKedetails = new List<ThongKe>();
            try
            {
                _conn.Open();
                string query = @"
            SELECT MaTK,TenTang, TenPhong, ThangTK, NamTK, GiaTri
            FROM ThongKe 
            WHERE ThangTK = @Month AND NamTK = @Year;
        ";

                SqlCommand cmd = new SqlCommand(query, _conn);

                // Thêm các tham số trước khi thực thi lệnh
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ThongKe thongKeDetail = new ThongKe
                    {
                        MaTK = reader["MaTK"] != DBNull.Value ? (int)reader["MaTK"] : 0,
                        TenTang = reader["TenTang"] != DBNull.Value ? (string)reader["TenTang"] : string.Empty,
                        TenPhong = reader["TenPhong"] != DBNull.Value ? (string)reader["TenPhong"] : string.Empty,
                        ThangTK = reader["ThangTK"] != DBNull.Value ? (int)reader["ThangTK"] : 0,
                        NamTK = reader["NamTK"] != DBNull.Value ? (int)reader["NamTK"] : 0,
                        GiaTri = reader["GiaTri"] != DBNull.Value ? (int)reader["GiaTri"] : 0
                    };

                    thongKedetails.Add(thongKeDetail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return thongKedetails;
        }
        public void UpdateBillStatus(int maHDon, int trangThai)
        {
            _conn.Open();
            string query = "UPDATE HoaDon SET TrangThai = @TrangThai WHERE MaHDon = @MaHDon";

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@MaHDon", maHDon);
                cmd.ExecuteNonQuery();
            }
            _conn.Close();
        }
        public void UpdateBillStatusBill(int maHDon, int trangThai)
        {
            _conn.Open();
            string query = "UPDATE HoaDon SET TrangThaiThanhToan = @TrangThai WHERE MaHDon = @MaHDon";

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                cmd.Parameters.AddWithValue("@MaHDon", maHDon);
                cmd.ExecuteNonQuery();
            }
            _conn.Close();
        }
    }
}
