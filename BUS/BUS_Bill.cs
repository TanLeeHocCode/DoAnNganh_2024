// BUS/BUS_Bill.cs
using System.Collections.Generic;
using DTO;
using DAL;
using System;

namespace BUS
{
    public class BUS_Bill
    {
        private DatabaseAccessBill dab = new DatabaseAccessBill();

        public bool UpdateSoDienMoi(int maPhong, int soDienMoi, DateTime ngayThang)
        {
            return dab.UpdateSoDienMoi(maPhong, soDienMoi, ngayThang);
        }

        public List<BillDetail> GetBillDetails()
        {
            return dab.GetBillDetails();
        }
        public List<GetAllBillPrint> AllBillPrints()
        {
            return dab.PrintBillDetails();
        }
        public List<GetAllBillPrint> LayHoaDonTheoThangNam(int thang, int nam, int trangthaithanhtoan)
        {
            return dab.GetBillDetailsByMonthYear(thang, nam, trangthaithanhtoan);
        }
        public List<ThongKe> LayHoaDonThongKe(int thang, int nam)
        {
            return dab.GetBillDetailsThongKe(thang, nam);
        }
        public void UpdateBillStatus(int maHDon, int trangThai)
        {
            // Gọi phương thức UpdateBillStatus từ lớp DAL
            dab.UpdateBillStatus(maHDon, trangThai);
        }
        public void UpdateBillStatusBill(int maHDon, int trangThai)
        {
            // Gọi phương thức UpdateBillStatus từ lớp DAL
            dab.UpdateBillStatusBill(maHDon, trangThai);
        }
    }
}
