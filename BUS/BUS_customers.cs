using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_customers:DBConnect
    {
        DatabaseAccessFunctionCustomers dafc = new DatabaseAccessFunctionCustomers();
        public List<KhachHang> GetListKhachHang()
        {
            return dafc.GetListKhachHang();
        }
        public List<KhachHang> GetListKHByMaKH(int MaKH)
        {
            return dafc.GetListKHUpdete(MaKH);
        }
            public bool UpdateKhachHang(KhachHang kh)
        {
            return dafc.UpdateKH(kh);
        }
        public bool AddKhachHang(KhachHang kh)
        {
            return dafc.AddKhachHang(kh);
        }
        public bool DeleteKhachHang(int maKH)
        {
            return dafc.DeleteKhachHang(maKH);
        }
        public List<KhachHang> TimKiemKhachHang(string option, string searchText)
        {
            List<KhachHang> resultList = new List<KhachHang>();
            string query;
            if (string.IsNullOrEmpty(searchText))
            {
                // Nếu không có giá trị tìm kiếm, lấy tất cả khách hàng
                query = "SELECT * FROM KhachHang";
            }
            else
            {
                query = $"SELECT * FROM KhachHang WHERE {option} = @searchText";
            }


            try
            {
                _conn.Open(); // Sử dụng kết nối có sẵn (_conn là SqlConnection)
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    // Thêm giá trị cho tham số @searchText
                    cmd.Parameters.AddWithValue("@searchText", searchText);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            KhachHang khachHang = new KhachHang
                            {
                                MaKH = reader["MaKH"] != DBNull.Value ? Convert.ToInt32(reader["MaKH"]) : 0,
                                Ho = reader["Ho"].ToString(),
                                Ten = reader["Ten"].ToString(),
                                NamSinh = reader["NamSinh"] != DBNull.Value ? Convert.ToDateTime(reader["NamSinh"]) : DateTime.MinValue,
                                SDT = reader["SDT"].ToString(),
                                CCCD = reader["CCCD"].ToString(),
                                Email = reader["Email"].ToString(),
                                QueQuan = reader["QueQuan"].ToString(),
                                SoXe = reader["SoXe"] != DBNull.Value ? Convert.ToInt32(reader["SoXe"]) : 0,
                                MaPhong = reader["MaPhong"] != DBNull.Value ? Convert.ToInt32(reader["MaPhong"]) : 0
                            };
                            resultList.Add(khachHang);
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
    }
}
