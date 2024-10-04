using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDong
    {
        public int MaHDong { get; set; }
        public DateTime NgayThangBD { get; set; }
        public DateTime NgayThangKT { get; set; }
        public int TienCoc { get; set; }
        public int MaPhong { get; set; }
        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string QueQuan { get; set; }
        public int GiaTien { get; set; }
        public string TenPhong { get; set; }
        public string TenTang { get; set; }
        public int SoXe { get; set; }
        public int SoNguoi { get; set; }
        public int DienTich { get; set; } // Thêm thuộc tính DienTich
        public string TenLP { get; set; } // Thêm thuộc tính TenLoaiPhong
        public int NgayBD { get; set; }
        public int ThangBD { get; set; }
        public int NamBD { get; set; }
        public int NgayKT { get; set; }
        public int ThangKT { get; set; }
        public int NamKT { get; set; }
        public DateTime NamSinh { get; set; }
        public int SoThang { get; set; }
    }


}
