using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DatabaseAccessFunctionRoom : DBConnect
    {
        public bool AddPhong(string tenTang, string tenPhong, string tenLP)
        {
            bool isAdded = false;

            try
            {
                if (_conn == null)
                {
                    throw new InvalidOperationException("Connection is not initialized.");
                }

                _conn.Open();

                // Truy vấn để lấy mã tầng từ tên tầng
                string queryMaTang = "SELECT MaTang FROM Tang WHERE TenTang = @TenTang";
                SqlCommand cmdMaTang = new SqlCommand(queryMaTang, _conn);
                cmdMaTang.Parameters.AddWithValue("@TenTang", tenTang);
                object resultMaTang = cmdMaTang.ExecuteScalar();
                if (resultMaTang == null)
                {
                    throw new Exception("Không tìm thấy tầng với tên: " + tenTang);
                }
                int maTang = (int)resultMaTang;

                // Truy vấn để lấy mã phòng từ tên phòng
                string queryMaSP = "SELECT MaSP FROM SoPhong WHERE TenPhong = @TenPhong";
                SqlCommand cmdMaSP = new SqlCommand(queryMaSP, _conn);
                cmdMaSP.Parameters.AddWithValue("@TenPhong", tenPhong);
                object resultMaSP = cmdMaSP.ExecuteScalar();
                if (resultMaSP == null)
                {
                    throw new Exception("Không tìm thấy phòng với tên: " + tenPhong);
                }
                int maSP = (int)resultMaSP;

                // Truy vấn để lấy mã loại phòng từ tên loại phòng
                string queryMaLP = "SELECT MaLP FROM LoaiPhong WHERE TenLP = @TenLP";
                SqlCommand cmdMaLP = new SqlCommand(queryMaLP, _conn);
                cmdMaLP.Parameters.AddWithValue("@TenLP", tenLP);
                object resultMaLP = cmdMaLP.ExecuteScalar();
                if (resultMaLP == null)
                {
                    throw new Exception("Không tìm thấy loại phòng với tên: " + tenLP);
                }
                int maLP = (int)resultMaLP;

                // Chèn dữ liệu vào bảng Phong
                string query = @"
                INSERT INTO Phong (TrangThai, MaLP, MaSP, MaTang)
                VALUES (0, @MaLP, @MaSP, @MaTang)";

                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@MaLP", maLP);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@MaTang", maTang);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isAdded = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm phòng: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return isAdded;
        }


        public bool DeletePhong(int maPhong)
        {
            bool isDeleted = false;

            try
            {
                // Mở kết nối
                _conn.Open();

                using (SqlCommand cmd = new SqlCommand("DeletePhong", _conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                    // Thực thi stored procedure
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Kiểm tra số lượng hàng bị ảnh hưởng để xác nhận thành công
                    isDeleted = rowsAffected > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                // Xử lý lỗi SQL
                Console.WriteLine("Lỗi SQL khi xóa phòng: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi chung
                Console.WriteLine("Lỗi khi xóa phòng: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return isDeleted;
        }


        public List<Phong> GetListPhongUpdete(int MaPhong)
        {
            List<Phong> listP = new List<Phong>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select p.MaPhong, t.TenTang, p.TrangThai, lp.TenLP, sp.TenPhong from Phong p  join Tang t on t.MaTang = p.MaTang  join LoaiPhong lp on lp.MaLP = p.MaLP join SoPhong sp on sp.MaSP = p.MaSP where MaPhong=@MaPhong", _conn);
                cmd.Parameters.AddWithValue("@MaPhong", MaPhong);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Phong phong = new Phong
                    {
                        MaPhong = (int)reader["MaPhong"],
                        TrangThai = (int)reader["TrangThai"],
                        TenLP = reader["TenLP"].ToString(),
                        TenTang = reader["TenTang"].ToString(),
                        TenPhong = reader["TenPhong"].ToString(),
                    };

                    listP.Add(phong);
                }
            }
            finally
            {
                _conn.Close();
            }

            return listP;
        }
        public int CountRoom(int TrangThai)
        {
            int count = 0;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(p.MaPhong) AS [Số phòng] FROM Phong p WHERE p.TrangThai = @TrangThai;", _conn);
                cmd.Parameters.AddWithValue("@TrangThai", TrangThai);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    count = reader["Số phòng"] != DBNull.Value ? (int)reader["Số phòng"] : 0;
                }
            }
            finally
            {
                _conn.Close();
            }
            return count;
        }


        public bool UpdatePhong(Phong phong)
        {
            bool isUpdated = false;
            try
            {
                _conn.Open();

                // Truy vấn để lấy mã tầng từ tên tầng
                string queryMaTang = "SELECT MaTang FROM Tang WHERE TenTang = @TenTang";
                SqlCommand cmdMaTang = new SqlCommand(queryMaTang, _conn);
                cmdMaTang.Parameters.AddWithValue("@TenTang", phong.TenTang);
                int maTang = (int)cmdMaTang.ExecuteScalar();

                string queryMaSP = "SELECT MaSP FROM SoPhong WHERE TenPhong = @TenPhong";
                SqlCommand cmdMaSP = new SqlCommand(queryMaSP, _conn);
                cmdMaSP.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
                int maSP = (int)cmdMaSP.ExecuteScalar();

                // Truy vấn để lấy mã loại phòng từ tên loại phòng
                string queryMaLP = "SELECT MaLP FROM LoaiPhong WHERE TenLP = @TenLP";
                SqlCommand cmdMaLP = new SqlCommand(queryMaLP, _conn);
                cmdMaLP.Parameters.AddWithValue("@TenLP", phong.TenLP);
                int maLP = (int)cmdMaLP.ExecuteScalar();
                string query = @"
            UPDATE Phong
            SET TrangThai = @TrangThai, MaLP = @MaLP, MaTang = @MaTang, MaSP = @MaSP
            WHERE MaPhong = @MaPhong";

                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@MaPhong", phong.MaPhong);
                cmd.Parameters.AddWithValue("@TrangThai", phong.TrangThai);
                cmd.Parameters.AddWithValue("@MaLP", maLP);
                cmd.Parameters.AddWithValue("@MaTang", maTang);
                cmd.Parameters.AddWithValue("@MaSP", maSP);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isUpdated = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật phòng: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return isUpdated;
        }
    }
}