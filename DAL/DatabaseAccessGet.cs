using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DatabaseAccessGet : DBConnect
    {
        public string CheckLoginDTO(Admin admin)
        {
            string user = null;
            _conn.Open();
            SqlCommand command = new SqlCommand("proc_logic", _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", admin.TaiKhoan);
            command.Parameters.AddWithValue("@pass", admin.MatKhau);
            command.Connection = _conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
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
        public List<Phong> GetListPhong()
        {

            List<Phong> listP = new List<Phong>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select *from Phong", _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Phong phong = new Phong();
                    phong.MaPhong = (int)reader["MaPhong"];
                    phong.TrangThai = (int)reader["TrangThai"];
                    phong.MaLP = (int)reader["MaLP"];
                    phong.MaTang = (int)reader["MaTang"];
                    phong.MaSP = (int)reader["MaSP"];

                    listP.Add(phong);
                }
            }
            finally { _conn.Close(); }

            return listP;
        }
        public List<Tang> GetListTang()
        {
            List<Tang> listT = new List<Tang>();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select *from Tang", _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tang t = new Tang();
                    t.MaTang = (int)reader["MaTang"];
                    t.TenTang = (string)reader["TenTang"];


                    listT.Add(t);
                }
            }
            finally { _conn.Close(); }

            return listT;
        }
        public List<LoaiPhong> GetListLoaiPhong()
        {
            List<LoaiPhong> listLP = new List<LoaiPhong>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select *from LoaiPhong", _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LoaiPhong lp = new LoaiPhong();
                    lp.MaLP = (int)reader["MaLP"];
                    lp.TenLP = (string)reader["TenLP"];
                    lp.GiaTien = (int)reader["GiaTien"];

                    listLP.Add(lp);
                }
            }
            finally { _conn.Close(); }

            return listLP;
        }
        public List<SoPhong> GetListSoPhong()
        {
            List<SoPhong> listSP = new List<SoPhong>();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select *from SoPhong", _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SoPhong sp = new SoPhong();
                    sp.MaSP = (int)reader["MaSP"];
                    sp.TenPhong = (string)reader["TenPhong"];
                    listSP.Add(sp);
                }
            }
            finally { _conn.Close(); }
            return listSP;
        }
        public List<ChiTietPhong> GetListCTPhong()
        {
            List<ChiTietPhong> listCTP = new List<ChiTietPhong>();

            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("Select *from ChiTietPhong", _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ChiTietPhong ctp = new ChiTietPhong();
                    ctp.MaCTP = (int)reader["MaCTP"];
                    ctp.SoDienCu = (int)reader["SoDienCu"];
                    ctp.SoDienMoi = (int)reader["SoDienMoi"];
                    ctp.SoXe = (int)reader["SoXe"];
                    ctp.SoNguoi = (int)reader["SoNguoi"];
                    ctp.MaPhong = (int)reader["MaPhong"];
                }
            }
            finally { _conn.Close(); }
            return listCTP;
        }
        





    }
}

