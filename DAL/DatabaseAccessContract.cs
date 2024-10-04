using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;
using static DTO.DTO_QLPhongTro;
namespace DAL
{
    public class DatabaseAccessContract : DBConnect
    {
        public List<HopDong> GetAllHopDongs()
        {
            List<HopDong> hopDongs = new List<HopDong>();
            try
            {
                _conn.Open();
                string query = @"
             SELECT h.MaHDong, h.NgayThangBD, h.NgayThangKT, h.TienCoc, h.MaPhong, h.MaKH,
                    k.Ho + ' ' + k.Ten AS HoTen, k.CCCD, k.SDT, k.Email, k.QueQuan,
                    sp.TenPhong, t.TenTang, lp.TenLP, ctp.SoXe, ctp.SoNguoi, lp.GiaTien, lp.DienTich, Day(h.NgayThangBD) as NgayBD,
					Month(h.NgayThangBD) as ThangBD, Year(h.NgayThangBD) as NamBD, Day(h.NgayThangKT) as NgayKT,
					Month(h.NgayThangKT) as ThangKT, Year(h.NgayThangKT) as NamKT, DATEDIFF(MONTH, h.NgayThangBD, h.NgayThangKT) AS SoThang, k.NamSinh
            FROM HopDong h
            INNER JOIN Phong p ON h.MaPhong = p.MaPhong
            INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
            INNER JOIN Tang t ON p.MaTang = t.MaTang
            INNER JOIN KhachHang k ON h.MaKH = k.MaKH
            INNER JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
			INNER JOIN ChiTietPhong ctp on p.MaPhong = ctp.MaPhong";

                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HopDong hopDong = new HopDong
                    {
                        MaHDong = (int)reader["MaHDong"],
                        NgayThangBD = (DateTime)reader["NgayThangBD"],
                        NgayThangKT = (DateTime)reader["NgayThangKT"],
                        TienCoc = (int)reader["TienCoc"],
                        TenLP = (string)reader["TenLP"], // Thêm thuộc tính TenLoaiPhong
                        TenTang = (string)reader["TenTang"],
                        CCCD = (string)reader["CCCD"],
                        TenPhong = (string)reader["TenPhong"],
                        HoTen = (string)reader["HoTen"],
                        SoNguoi = (int)reader["SoNguoi"],
                        SoXe = (int)reader["SoXe"],
                        DienTich = (int)reader["DienTich"], // Thêm thuộc tính DienTich
                        GiaTien = (int)reader["GiaTien"], // Thêm thuộc tính GiaTien
                        NgayBD = (int)reader["NgayBD"],
                        ThangBD = (int)reader["ThangBD"],
                        NamBD = (int)reader["NamBD"],
                        NgayKT = (int)reader["NgayKT"],
                        ThangKT = (int)reader["ThangKT"],
                        NamKT = (int)reader["NamKT"],
                        NamSinh = (DateTime)reader["NamSinh"],
                        SoThang = (int)reader["SoThang"]
                    };
                    hopDongs.Add(hopDong);
                }
            }
            finally
            {
                _conn.Close();
            }
            return hopDongs;
        }
        public List<HopDong> GetAllHopDongByCCCD( string cccd)
        {
            List<HopDong> hopDongs = new List<HopDong>();
            try
            {
                _conn.Open();
                string query = @"
             SELECT h.MaHDong, h.NgayThangBD, h.NgayThangKT, h.TienCoc, h.MaPhong, h.MaKH,
                    k.Ho + ' ' + k.Ten AS HoTen, k.CCCD, k.SDT, k.Email, k.QueQuan,
                    sp.TenPhong, t.TenTang, lp.TenLP, ctp.SoXe, ctp.SoNguoi, lp.GiaTien, lp.DienTich, Day(h.NgayThangBD) as NgayBD,
					Month(h.NgayThangBD) as ThangBD, Year(h.NgayThangBD) as NamBD, Day(h.NgayThangKT) as NgayKT,
					Month(h.NgayThangKT) as ThangKT, Year(h.NgayThangKT) as NamKT, DATEDIFF(MONTH, h.NgayThangBD, h.NgayThangKT) AS SoThang, k.NamSinh
            FROM HopDong h
            INNER JOIN Phong p ON h.MaPhong = p.MaPhong
            INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
            INNER JOIN Tang t ON p.MaTang = t.MaTang
            INNER JOIN KhachHang k ON h.MaKH = k.MaKH
            INNER JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
			INNER JOIN ChiTietPhong ctp on p.MaPhong = ctp.MaPhong
            where k.CCCD=@CCCD";

                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@CCCD", cccd);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HopDong hopDong = new HopDong
                    {
                        MaHDong = (int)reader["MaHDong"],
                        NgayThangBD = (DateTime)reader["NgayThangBD"],
                        NgayThangKT = (DateTime)reader["NgayThangKT"],
                        TienCoc = (int)reader["TienCoc"],
                        TenLP = (string)reader["TenLP"], // Thêm thuộc tính TenLoaiPhong
                        TenTang = (string)reader["TenTang"],
                        CCCD = (string)reader["CCCD"],
                        TenPhong = (string)reader["TenPhong"],
                        HoTen = (string)reader["HoTen"],
                        SoNguoi = (int)reader["SoNguoi"],
                        SoXe = (int)reader["SoXe"],
                        DienTich = (int)reader["DienTich"], // Thêm thuộc tính DienTich
                        GiaTien = (int)reader["GiaTien"], // Thêm thuộc tính GiaTien
                        NgayBD = (int)reader["NgayBD"],
                        ThangBD = (int)reader["ThangBD"],
                        NamBD = (int)reader["NamBD"],
                        NgayKT = (int)reader["NgayKT"],
                        ThangKT = (int)reader["ThangKT"],
                        NamKT = (int)reader["NamKT"],
                        NamSinh = (DateTime)reader["NamSinh"],
                        SoThang = (int)reader["SoThang"]
                    };
                    hopDongs.Add(hopDong);
                }
            }
            finally
            {
                _conn.Close();
            }
            return hopDongs;
        }
        public bool AddHopDong(string CCCD, HopDong hopDong, out int newMaHDong)
        {
            newMaHDong = 0; // Khởi tạo newMaHDong

            try
            {
                _conn.Open();

                // Truy vấn để lấy MaKH, MaPhong và GiaTien từ CCCD
                string queryInfo = @"
            select kh.MaKH, p.MaPhong, lp.GiaTien 
            from KhachHang kh 
            join Phong p on p.MaPhong = kh.MaPhong 
            join LoaiPhong lp on lp.MaLP = p.MaLP 
            where CCCD = @CCCD";

                using (SqlCommand cmdInfo = new SqlCommand(queryInfo, _conn))
                {
                    cmdInfo.Parameters.AddWithValue("@CCCD", CCCD);

                    using (SqlDataReader reader = cmdInfo.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int maKH = reader.GetInt32(0);
                            int maPhong = reader.GetInt32(1);
                            int giaTien = reader.GetInt32(2);

                            reader.Close();

                            // Kiểm tra xem phòng đã có hợp đồng hay chưa
                            string queryCheck = @"
                        SELECT COUNT(*) 
                        FROM HopDong 
                        WHERE MaPhong = @MaPhong";

                            using (SqlCommand cmdCheck = new SqlCommand(queryCheck, _conn))
                            {
                                cmdCheck.Parameters.AddWithValue("@MaPhong", maPhong);
                                int count = (int)cmdCheck.ExecuteScalar();

                                if (count > 0)
                                {
                                    // Nếu phòng đã có hợp đồng, trả về false
                                    return false;
                                }
                            }

                            // Thêm hợp đồng mới với thông tin đã lấy được
                            string queryInsert = @"
                        INSERT INTO HopDong (NgayThangBD, NgayThangKT, TienCoc, MaPhong, MaKH)
                        VALUES (@NgayThangBD, @NgayThangKT, @TienCoc, @MaPhong, @MaKH);
                        SELECT SCOPE_IDENTITY();";

                            using (SqlCommand cmdInsert = new SqlCommand(queryInsert, _conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@NgayThangBD", hopDong.NgayThangBD);
                                cmdInsert.Parameters.AddWithValue("@NgayThangKT", hopDong.NgayThangKT);
                                cmdInsert.Parameters.AddWithValue("@TienCoc", giaTien); // Xem xét lại việc sử dụng giaTien cho TienCoc
                                cmdInsert.Parameters.AddWithValue("@MaPhong", maPhong);
                                cmdInsert.Parameters.AddWithValue("@MaKH", maKH);

                                // Thực hiện câu lệnh SQL và lấy mã hợp đồng mới
                                object result = cmdInsert.ExecuteScalar();
                                if (result != null)
                                {
                                    newMaHDong = Convert.ToInt32(result);
                                    return true; // Trả về true nếu thêm thành công
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu cần thiết
                // Ví dụ: LogException(ex);
                // Có thể thêm thông báo lỗi cụ thể hơn nếu cần thiết
            }
            finally
            {
                _conn.Close();
            }

            return false; // Trả về false nếu gặp lỗi
        }




        public HopDong GetHopDongDetails(int maHDong)
        {
            HopDong hopDong = null;
            try
            {
                _conn.Open();
                string query = @"
                  SELECT h.MaHDong, h.NgayThangBD, h.NgayThangKT, h.TienCoc, h.MaPhong, h.MaKH,
                       k.Ho + ' ' + k.Ten AS HoTen, k.CCCD, k.SDT, k.Email, k.QueQuan,
                       sp.TenPhong, t.TenTang, lp.TenLP, ctp.SoXe, ctp.SoNguoi, lp.GiaTien, lp.DienTich, Day(h.NgayThangBD) as NgayBD,
					   Month(h.NgayThangBD) as ThangBD, Year(h.NgayThangBD) as NamBD, Day(h.NgayThangKT) as NgayKT,
					   Month(h.NgayThangKT) as ThangKT, Year(h.NgayThangKT) as NamKT, DATEDIFF(MONTH, h.NgayThangBD, h.NgayThangKT) AS SoThang, k.NamSinh
                FROM HopDong h
                INNER JOIN Phong p ON h.MaPhong = p.MaPhong
                INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
                INNER JOIN Tang t ON p.MaTang = t.MaTang
                INNER JOIN KhachHang k ON h.MaKH = k.MaKH
                INNER JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
				INNER JOIN ChiTietPhong ctp on p.MaPhong = ctp.MaPhong
                WHERE h.MaHDong = @MaHDong";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@MaHDong", maHDong);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hopDong = new HopDong
                    {
                        MaHDong = (int)reader["MaHDong"],
                        NgayThangBD = reader["NgayThangBD"] != DBNull.Value ? (DateTime)reader["NgayThangBD"] : DateTime.MinValue,
                        NgayThangKT = reader["NgayThangKT"] != DBNull.Value ? (DateTime)reader["NgayThangKT"] : DateTime.MinValue,
                        TienCoc = reader["TienCoc"] != DBNull.Value ? (int)reader["GiaTien"] : 0,
                        MaPhong = reader["MaPhong"] != DBNull.Value ? (int)reader["MaPhong"] : 0,
                        MaKH = reader["MaKH"] != DBNull.Value ? (int)reader["MaKH"] : 0,
                        HoTen = reader["HoTen"] != DBNull.Value ? (string)reader["HoTen"] : string.Empty,
                        CCCD = reader["CCCD"] != DBNull.Value ? (string)reader["CCCD"] : string.Empty,
                        SDT = reader["SDT"] != DBNull.Value ? (string)reader["SDT"] : string.Empty,
                        Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty,
                        QueQuan = reader["QueQuan"] != DBNull.Value ? (string)reader["QueQuan"] : string.Empty,
                        GiaTien = reader["GiaTien"] != DBNull.Value ? (int)reader["GiaTien"] : 0,
                        TenPhong = reader["TenPhong"] != DBNull.Value ? (string)reader["TenPhong"] : string.Empty,
                        TenTang = reader["TenTang"] != DBNull.Value ? (string)reader["TenTang"] : string.Empty,
                        SoXe = reader["SoXe"] != DBNull.Value ? (int)reader["SoXe"] : 0,
                        SoNguoi = reader["SoNguoi"] != DBNull.Value ? (int)reader["SoNguoi"] : 0,
                        DienTich = reader["DienTich"] != DBNull.Value ? (int)reader["DienTich"] : 0,
                        TenLP = reader["TenLP"] != DBNull.Value ? (string)reader["TenLP"] : string.Empty,
                        NgayBD = reader["NgayBD"] != DBNull.Value ? (int)reader["NgayBD"] : 0,
                        ThangBD = reader["ThangBD"] != DBNull.Value ? (int)reader["ThangBD"] : 0,
                        NamBD = reader["NamBD"] != DBNull.Value ? (int)reader["NamBD"] : 0,
                        NgayKT = reader["NgayKT"] != DBNull.Value ? (int)reader["NgayKT"] : 0,
                        ThangKT = reader["ThangKT"] != DBNull.Value ? (int)reader["ThangKT"] : 0,
                        NamKT = reader["NamKT"] != DBNull.Value ? (int)reader["NamKT"] : 0,
                        NamSinh = reader["NamSinh"] != DBNull.Value ? (DateTime)reader["NamSinh"] : DateTime.MinValue,
                        SoThang = reader["SoThang"] != DBNull.Value ? (int)reader["SoThang"] : 0
                    };
                }
            }
            finally
            {
                _conn.Close();
            }
            return hopDong;
        }
        public void DeleteContract(int maHDong)
        {
            _conn.Open();
            SqlTransaction transaction = _conn.BeginTransaction();

            try
            {
                // Lấy MaPhong liên quan đến hợp đồng
                string getMaPhongQuery = @"
            SELECT MaPhong 
            FROM HopDong 
            WHERE MaHDong = @MaHDong;
        ";

                int maPhong = -1;

                using (SqlCommand cmd = new SqlCommand(getMaPhongQuery, _conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@MaHDong", maHDong);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() && reader["MaPhong"] != DBNull.Value)
                    {
                        maPhong = (int)reader["MaPhong"];
                    }
                    reader.Close();
                }

                if (maPhong == -1)
                {
                    throw new Exception("Không tìm thấy phòng liên quan đến hợp đồng.");
                }

                // Xóa hóa đơn liên quan đến hợp đồng
                string deleteHoaDonQuery = @"
            DELETE FROM HoaDon
            WHERE MaHDong = @MaHDong;
        ";

                using (SqlCommand cmd = new SqlCommand(deleteHoaDonQuery, _conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@MaHDong", maHDong);
                    cmd.ExecuteNonQuery();
                }

                // Xóa hợp đồng
                string deleteHopDongQuery = @"
            DELETE FROM HopDong
            WHERE MaHDong = @MaHDong;
        ";

                using (SqlCommand cmd = new SqlCommand(deleteHopDongQuery, _conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@MaHDong", maHDong);
                    cmd.ExecuteNonQuery();
                }

                // Xóa khách hàng liên quan đến phòng
                string deleteKhachHangQuery = @"
            DELETE FROM KhachHang
            WHERE MaPhong = @MaPhong;
        ";

                using (SqlCommand cmd = new SqlCommand(deleteKhachHangQuery, _conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.ExecuteNonQuery();
                }

                // Cập nhật trạng thái của phòng liên quan
                string updatePhongQuery = @"
            UPDATE Phong
            SET TrangThai = 0
            WHERE MaPhong = @MaPhong;
        ";

                using (SqlCommand cmd = new SqlCommand(updatePhongQuery, _conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmd.ExecuteNonQuery();
                }

                // Commit transaction
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // Rollback transaction in case of error
                transaction.Rollback();
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public List<KhachHang> GetKhachHangByMaPhong(int maPhong)
        {
            List<KhachHang> listKH = new List<KhachHang>();
            try
            {
                _conn.Open();
                // Truy vấn SQL để lấy danh sách khách hàng theo mã phòng
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE MaPhong = @MaPhong", _conn);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang
                    {
                        MaKH = (int)reader["MaKH"],
                        Ho = (string)reader["Ho"],
                        Ten = (string)reader["Ten"],
                        NamSinh = (DateTime)reader["NamSinh"],
                        CCCD = (string)reader["CCCD"],
                        SDT = (string)reader["SDT"],
                        Email = (string)reader["Email"],
                        QueQuan = (string)reader["QueQuan"],
                        SoXe = (int)reader["SoXe"],
                        MaPhong = (int)reader["MaPhong"]
                    };

                    listKH.Add(kh);
                }
            }
            finally
            {
                _conn.Close();
            }

            return listKH;
        }

    }
}
