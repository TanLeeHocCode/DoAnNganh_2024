using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DatabaseAccessFunctionCustomers:DBConnect
    {
        public List<KhachHang> GetListKhachHang()
        {
            List<KhachHang> listKH = new List<KhachHang>();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select *from KhachHang", _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = (int)reader["MaKH"];
                    kh.Ho = (string)reader["Ho"];
                    kh.Ten = (string)reader["Ten"];
                    kh.NamSinh = (DateTime)reader["NamSinh"];
                    kh.CCCD = (string)reader["CCCD"];
                    kh.SDT = (string)reader["SDT"];
                    kh.Email = (string)reader["Email"];
                    kh.QueQuan = (string)reader["QueQuan"];
                    kh.SoXe = (int)reader["SoXe"];
                    kh.MaPhong = (int)reader["MaPhong"];
                    listKH.Add(kh);
                }
            }
            finally { _conn.Close(); }
            return listKH;
        }
        public List<KhachHang> GetListKHUpdete(int MaKH)
        {
            List<KhachHang> listKH = new List<KhachHang>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select *from KhachHang where MaKH = @MaKH", _conn);
                cmd.Parameters.AddWithValue("@MaKH", MaKH);
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

        public bool UpdateKH(KhachHang kh)
        {
            bool isUpdated = false;
            try
            {
                _conn.Open();
                string query = @"
            UPDATE KhachHang
            SET Ho = @Ho, Ten = @Ten, NamSinh = @NamSinh, CCCD = @CCCD, SDT = @SDT, Email = @Email, QueQuan = @QueQuan, SoXe = @SoXe, MaPhong = @MaPhong
            WHERE MaKH = @MaKH"; // Thêm điều kiện WHERE để chỉ cập nhật bản ghi cần thiết

                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@Ho", kh.Ho ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Ten", kh.Ten ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NamSinh", kh.NamSinh == DateTime.MinValue ? (object)DBNull.Value : kh.NamSinh); // Xử lý giá trị NULL
                cmd.Parameters.AddWithValue("@CCCD", kh.CCCD ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", kh.Email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@QueQuan", kh.QueQuan ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SoXe", kh.SoXe);
                cmd.Parameters.AddWithValue("@MaPhong", kh.MaPhong);
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);

                int rowsAffected = cmd.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            finally
            {
                _conn.Close();
            }

            return isUpdated;
        }
        public bool AddKhachHang(KhachHang kh)
        {
            bool isAdded = false;
            try
            {
                _conn.Open();
                string query = @"
            INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong)
            VALUES (@Ho, @Ten, @NamSinh, @CCCD, @SDT, @Email, @QueQuan, @SoXe, @MaPhong)";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@Ho", kh.Ho);
                cmd.Parameters.AddWithValue("@Ten", kh.Ten);
                cmd.Parameters.AddWithValue("@NamSinh", kh.NamSinh);
                cmd.Parameters.AddWithValue("@CCCD", kh.CCCD);
                cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                cmd.Parameters.AddWithValue("@Email", kh.Email);
                cmd.Parameters.AddWithValue("@QueQuan", kh.QueQuan);
                cmd.Parameters.AddWithValue("@SoXe", kh.SoXe);
                cmd.Parameters.AddWithValue("@MaPhong", kh.MaPhong);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isAdded = true;
                }
            }
            finally
            {
                _conn.Close();
            }

            return isAdded;
        }
        public bool DeleteKhachHang(int maKH)
        {
            try
            {
                _conn.Open();

                // Xóa các hợp đồng liên quan đến khách hàng
                string deleteContractsQuery = "DELETE FROM HopDong WHERE MaKH = @MaKH";
                SqlCommand deleteContractsCmd = new SqlCommand(deleteContractsQuery, _conn);
                deleteContractsCmd.Parameters.AddWithValue("@MaKH", maKH);
                deleteContractsCmd.ExecuteNonQuery();

                // Xóa khách hàng
                string deleteCustomerQuery = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
                SqlCommand deleteCustomerCmd = new SqlCommand(deleteCustomerQuery, _conn);
                deleteCustomerCmd.Parameters.AddWithValue("@MaKH", maKH);

                int rowsAffected = deleteCustomerCmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần thiết
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

    }
}
