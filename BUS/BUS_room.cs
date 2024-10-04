using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using static DTO.DTO_QLPhongTro;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_room:DBConnect
    {
        DatabaseAccessFunctionRoom dafr = new DatabaseAccessFunctionRoom();
        DatabaseAccessGet dag = new DatabaseAccessGet();
        public List<CombinedPhongInfo> GetCombinedPhongList()
        {
            var combinedList = new List<CombinedPhongInfo>();

            var phongList = dag.GetListPhong();
            var loaiPhongList = dag.GetListLoaiPhong();
            var tangList = dag.GetListTang();
            var soPhongList = dag.GetListSoPhong();

            foreach (var phong in phongList)
            {
                var combinedInfo = new CombinedPhongInfo
                {
                    MaPhong = phong.MaPhong,
                    LoaiPhong = loaiPhongList.FirstOrDefault(lp => lp.MaLP == phong.MaLP)?.TenLP,
                    Tang = tangList.FirstOrDefault(t => t.MaTang == phong.MaTang)?.TenTang,
                    TrangThai = phong.TrangThai,
                    GiaTien = (int)loaiPhongList.FirstOrDefault(lp => lp.MaLP == phong.MaLP)?.GiaTien,
                    TenPhong = soPhongList.FirstOrDefault(sp => sp.MaSP == phong.MaSP)?.TenPhong
                };

                combinedList.Add(combinedInfo);
            }

            return combinedList;
        }
        public List<CombinedPhongInfo> SearchPhong(int? maTang, int? trangThai)
        {
            var combinedList = new List<CombinedPhongInfo>();

            var phongList = dag.GetListPhong();
            var loaiPhongList = dag.GetListLoaiPhong();
            var tangList = dag.GetListTang();
            var soPhongList = dag.GetListSoPhong();

            // Áp dụng bộ lọc dựa trên Mã Tầng và Trạng Thái
            if (maTang.HasValue)
            {
                phongList = phongList.Where(p => p.MaTang == maTang.Value).ToList();
            }

            if (trangThai.HasValue)
            {
                phongList = phongList.Where(p => p.TrangThai == trangThai.Value).ToList();
            }

            foreach (var phong in phongList)
            {
                var combinedInfo = new CombinedPhongInfo
                {
                    MaPhong = phong.MaPhong,
                    LoaiPhong = loaiPhongList.FirstOrDefault(lp => lp.MaLP == phong.MaLP)?.TenLP,
                    Tang = tangList.FirstOrDefault(t => t.MaTang == phong.MaTang)?.TenTang,
                    TrangThai = phong.TrangThai,
                    GiaTien = (int)loaiPhongList.FirstOrDefault(lp => lp.MaLP == phong.MaLP)?.GiaTien,
                    TenPhong = soPhongList.FirstOrDefault(sp => sp.MaSP == phong.MaSP)?.TenPhong
                };

                combinedList.Add(combinedInfo);
            }

            return combinedList;
        }

        public bool AddPhong(string TenTang, string TenPhong, string TenLP)
        {
            return dafr.AddPhong(TenTang, TenPhong, TenLP);
        }
        public bool DeletePhong(int maPhong)
        {
            return dafr.DeletePhong(maPhong);
        }
        public List<Phong> GetPhongByMaSP(int MaPhong)
        {
            return dafr.GetListPhongUpdete(MaPhong);
        }
        public bool UpdatePhong(Phong phong)
        {
            return dafr.UpdatePhong(phong);
        }
        public int CountRooms(int TrangThai)
        {
            return dafr.CountRoom(TrangThai);
        }
        public List<Phong> TimKiemPhongTheoTrangThai(int? trangThai)
        {
            List<Phong> resultList = new List<Phong>();
            string query;

            if (!trangThai.HasValue)
            {
                // Nếu không có giá trị tìm kiếm, lấy tất cả phòng
                query = "SELECT p.MaPhong, t.TenTang, p.TrangThai, lp.TenLP, sp.TenPhong " +
                        "FROM Phong p " +
                        "JOIN Tang t ON t.MaTang = p.MaTang " +
                        "JOIN LoaiPhong lp ON lp.MaLP = p.MaLP " +
                        "JOIN SoPhong sp ON sp.MaSP = p.MaSP";
            }
            else
            {
                // Lọc phòng theo trạng thái
                query = "SELECT p.MaPhong, t.TenTang, p.TrangThai, lp.TenLP, sp.TenPhong " +
                        "FROM Phong p " +
                        "JOIN Tang t ON t.MaTang = p.MaTang " +
                        "JOIN LoaiPhong lp ON lp.MaLP = p.MaLP " +
                        "JOIN SoPhong sp ON sp.MaSP = p.MaSP " +
                        "WHERE p.TrangThai = @TrangThai";
            }

            try
            {
                _conn.Open(); // Sử dụng kết nối có sẵn (_conn là SqlConnection)
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    // Thêm giá trị cho tham số @trangThai nếu có giá trị
                    if (trangThai.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@TrangThai", trangThai.Value);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Phong phong = new Phong
                            {
                                MaPhong = reader["MaPhong"] != DBNull.Value ? Convert.ToInt32(reader["MaPhong"]) : 0,
                                TenPhong = reader["TenPhong"].ToString(),
                                TenTang = reader["TenTang"].ToString(),
                                TenLP = reader["TenLP"].ToString(),
                                TrangThai = reader["TrangThai"] != DBNull.Value ? Convert.ToInt32(reader["TrangThai"]) : 0,
                            };
                            resultList.Add(phong);
                        }
                    }
                }
            }
            finally
            {
                _conn.Close(); // Đóng kết nối sau khi hoàn thành
            }

            return resultList;
        }

        public Dictionary<string, int> GetRoomCountByType()
        {
            Dictionary<string, int> roomCounts = new Dictionary<string, int>();

            try
            {
                _conn.Open();
                string query = "SELECT lp.TenLP, COUNT(p.MaPhong) AS RoomCount " +
                               "FROM Phong p " +
                               "JOIN LoaiPhong lp ON p.MaLP = lp.MaLP where p.TrangThai=1" +
                               "GROUP BY lp.TenLP;";
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string roomType = reader["TenLP"].ToString();
                    int count = reader["RoomCount"] != DBNull.Value ? (int)reader["RoomCount"] : 0;
                    roomCounts.Add(roomType, count);
                }
            }
            finally
            {
                _conn.Close();
            }

            return roomCounts;
        }


    }
}
