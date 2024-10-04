using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DatabaseAccessLogin : DBConnect
    {
        // Phương thức lấy thông tin Admin bằng tài khoản và mật khẩu
        public Admin GetAdminByCredentials(string taiKhoan, string matKhau)
        {
            Admin admin = null;
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau", _conn))
            {
                cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                _conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    admin = new Admin
                    {
                        TaiKhoan = reader["TaiKhoan"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        // Các thuộc tính khác nếu có
                    };
                }
                reader.Close();
                _conn.Close();
            }
            return admin;
        }

        // Phương thức kiểm tra đăng nhập bằng stored procedure
        public string CheckLoginDTO(Admin admin)
        {
            string user = null;
            _conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", admin.TaiKhoan);
            command.Parameters.AddWithValue("@pass", admin.MatKhau);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // Sử dụng GetInt32 nếu cột là kiểu số, và chuyển đổi sang chuỗi
                    user = reader.GetInt32(0).ToString();
                }
                reader.Close();
                _conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }

    }
}
