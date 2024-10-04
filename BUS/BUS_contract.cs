using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using Aspose.Words.Replacing;
using System.IO;

namespace BUS
{
    public class BUS_contract
    {
        private DatabaseAccessContract dac = new DatabaseAccessContract();

        public bool AddHopDong(string CCCD, HopDong hopDong, out int newMaHDong)
        {
            // Gọi phương thức DAL để thêm hợp đồng và nhận ID mới
            return dac.AddHopDong(CCCD, hopDong, out newMaHDong);
        }

        public List<HopDong> GetAllHopDongs()
        {
            return dac.GetAllHopDongs();
        }

        public List<HopDong> GetAllHopDongByCCCDs(string cccd)
        {
            return dac.GetAllHopDongByCCCD(cccd);
        }

        public HopDong GetHopDongDetails(int maHDong)
        {
            return dac.GetHopDongDetails(maHDong);
        }

        public void DeleteContract(int maHDong)
        {
            try
            {
                dac.DeleteContract(maHDong);
                Console.WriteLine("Hợp đồng đã được xóa thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public bool IsContractFileExists(int maHDong, string hoTen)
        {
            string fileName = $"Hợp_Đồng_{maHDong}_{hoTen}.docx";
            string filePath = Path.Combine(@"D:\QLPhongTro\HopDong\", fileName);
            return File.Exists(filePath);
        }

        public void GenerateHopDongDocument(int maHDong)
        {
            HopDong hopDong = dac.GetHopDongDetails(maHDong);

            if (hopDong != null)
            {
                // Sử dụng Aspose.Words để tạo tài liệu
                Document doc = new Document(@"D:\QLPhongTro\HopDong\MauHopDong.docx");

                // Thay thế các placeholder với dữ liệu hợp đồng
                FindReplaceOptions options = new FindReplaceOptions();
                doc.Range.Replace("[MaHDong]", hopDong.MaHDong.ToString(), options);
                doc.Range.Replace("[NgayThangBD]", hopDong.NgayThangBD.ToString("dd/MM/yyyy"), options);
                doc.Range.Replace("[NgayThangKT]", hopDong.NgayThangKT.ToString("dd/MM/yyyy"), options);
                doc.Range.Replace("[TienCoc]", hopDong.TienCoc.ToString(), options);
                doc.Range.Replace("[TenPhong]", hopDong.TenPhong, options);
                doc.Range.Replace("[TenTang]", hopDong.TenTang, options);
                doc.Range.Replace("[GiaTien]", hopDong.GiaTien.ToString(), options);
                doc.Range.Replace("[HoTen]", hopDong.HoTen, options);
                doc.Range.Replace("[CCCD]", hopDong.CCCD, options);
                doc.Range.Replace("[SDT]", hopDong.SDT, options);
                doc.Range.Replace("[Email]", hopDong.Email, options);
                doc.Range.Replace("[QueQuan]", hopDong.QueQuan, options);
                doc.Range.Replace("[TenLP]", hopDong.TenLP, options);
                doc.Range.Replace("[DienTich]", hopDong.DienTich.ToString(), options);
                doc.Range.Replace("[SoXe]", hopDong.SoXe.ToString(), options);
                doc.Range.Replace("[SoNguoi]", hopDong.SoNguoi.ToString(), options);
                doc.Range.Replace("[NgayBD]", hopDong.NgayBD.ToString(), options);
                doc.Range.Replace("[ThangBD]", hopDong.ThangBD.ToString(), options);
                doc.Range.Replace("[NamBD]", hopDong.NamBD.ToString(), options);
                doc.Range.Replace("[NgayKT]", hopDong.NgayKT.ToString(), options);
                doc.Range.Replace("[ThangKT]", hopDong.ThangKT.ToString(), options);
                doc.Range.Replace("[NamKT]", hopDong.NamKT.ToString(), options);
                doc.Range.Replace("[NamSinh]", hopDong.NamSinh.ToString("dd/MM/yyyy"), options);
                doc.Range.Replace("[SoThang]", hopDong.SoThang.ToString(), options);

                // Lấy danh sách các khách thuê trong phòng
                List<KhachHang> khachHangList = dac.GetKhachHangByMaPhong(hopDong.MaPhong);

                // Tạo chuỗi danh sách khách thuê với định dạng yêu cầu
                StringBuilder danhSachKhachThue = new StringBuilder();
                int index = 1;

                foreach (var kh in khachHangList)
                {
                    danhSachKhachThue.AppendLine($"{index}. Họ tên: [HT{index}] \t\t Năm sinh: [NS{index}] \t\t SĐT: [SDT{index}]");
                    danhSachKhachThue.AppendLine($"   Số CCCD: [CCCD{index}] \t\t Thường Trú: [DC{index}]");
                    index++;
                }

                // Thay thế placeholder [DanhSachKhachThue] trong template
                ReplacePlaceholder(doc, "[DanhSachKhachThue]", danhSachKhachThue.ToString(), options);

                // Thay thế các placeholder cho từng khách thuê
                index = 1;
                foreach (var kh in khachHangList)
                {
                    ReplacePlaceholder(doc, $"[HT{index}]", $"{kh.Ho} {kh.Ten}", options);
                    ReplacePlaceholder(doc, $"[NS{index}]", kh.NamSinh.ToString("dd/MM/yyyy"), options);
                    ReplacePlaceholder(doc, $"[SDT{index}]", kh.SDT, options);
                    ReplacePlaceholder(doc, $"[CCCD{index}]", kh.CCCD, options);
                    ReplacePlaceholder(doc, $"[DC{index}]", kh.QueQuan, options);
                    index++;
                }

                // Tạo tên file với định dạng Hợp_Đồng_{maHDong}_{hopDong.HoTen}.docx
                string fileName = $"Hợp_Đồng_{maHDong}_{hopDong.HoTen}.docx";

                // Đường dẫn lưu file
                string filePath = Path.Combine(@"D:\QLPhongTro\HopDong\", fileName);

                // Lưu tài liệu với tên hợp đồng
                doc.Save(filePath);
            }
        }

        // Phương thức thay thế placeholder an toàn
        private void ReplacePlaceholder(Document doc, string placeholder, string value, FindReplaceOptions options)
        {
            if (!string.IsNullOrEmpty(value))
            {
                doc.Range.Replace(placeholder, value, options);
            }
        }
    }
}
