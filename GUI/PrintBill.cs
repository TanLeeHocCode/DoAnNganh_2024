using System;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using System.Net;
using System.Net.Mail;
using System.Drawing.Printing;
using System.IO;
using BUS;
using System.Collections.Generic;
using System.Linq;

namespace GUI
{
    public partial class PrintBill : UserControl
    {
        private BUS_Bill _busBill;
        public PrintBill()
        {
            InitializeComponent();
            _busBill = new BUS_Bill();
            LoadData();
            da_bill.CellClick += da_bill_CellClick;
            da_bill.CellFormatting += da_bill_CellFormatting;
        }
        private void LoadData()
        {
            da_bill.AutoGenerateColumns = false;
            var billPrints = _busBill.AllBillPrints();
            var sortedBillPrints = billPrints
                .OrderBy(b => b.NamHD)    // Sắp xếp theo Năm trước
                .ThenBy(b => b.ThangHD)   // Sau đó sắp xếp theo Tháng
                .ToList();
            da_bill.DataSource = sortedBillPrints;
            da_bill.Columns["MaHDon"].DataPropertyName = "MaHDon";
            da_bill.Columns["MaHDon"].Visible = false;
            da_bill.Columns["ThangHD"].DataPropertyName = "ThangHD";
            da_bill.Columns["NamHD"].DataPropertyName = "NamHD";
            da_bill.Columns["HoTen"].DataPropertyName = "HoTen";
            da_bill.Columns["TenLP"].DataPropertyName = "TenLP";
            da_bill.Columns["Tang"].DataPropertyName = "TenTang";
            da_bill.Columns["Email"].DataPropertyName = "Email";
            da_bill.Columns["SoPhong"].DataPropertyName = "TenPhong";
            da_bill.Columns["GiaTien"].DataPropertyName = "GiaTien";
            da_bill.Columns["HoTen"].DataPropertyName = "HoTen";
            da_bill.Columns["TienDien"].DataPropertyName = "TienDien";
            da_bill.Columns["TienNuoc"].DataPropertyName = "TienNuoc";
            da_bill.Columns["TienXe"].DataPropertyName = "TienXe";
            da_bill.Columns["PhiDV"].DataPropertyName = "PhiDV";
            da_bill.Columns["TongTien"].DataPropertyName = "TongTien";
            da_bill.Columns["TrangThai"].DataPropertyName = "TrangThaiHD";
            da_bill.Columns["TrangThaiThanhToan"].DataPropertyName = "TrangThaiThanhToan";
            bool isPrintColumnExist = false;
            foreach (DataGridViewColumn column in da_bill.Columns)
            {
                if (column.Name == "btnPrint")
                {
                    isPrintColumnExist = true;
                    break;
                }
            }

            if (!isPrintColumnExist)
            {
                DataGridViewButtonColumn btnPrint = new DataGridViewButtonColumn();
                btnPrint.HeaderText = "In Hóa Đơn";
                btnPrint.Text = "In";
                btnPrint.Name = "btnPrint";
                btnPrint.UseColumnTextForButtonValue = true;
                da_bill.Columns.Add(btnPrint);
            }
            if (billPrints.Any())
            {
                lbTongTIen.Text = billPrints.First().SumMoney.ToString("N0") + " VND";
            }
            else
            {
                lbTongTIen.Text = "0 VND";
            }
            bool isStatusColumnExist = false;
            foreach (DataGridViewColumn column in da_bill.Columns)
            {
                if (column.Name == "btnStatus")
                {
                    isStatusColumnExist = true;
                    break;
                }
            }
            if (!isStatusColumnExist)
            {
                DataGridViewButtonColumn btnStatus = new DataGridViewButtonColumn();
                btnStatus.HeaderText = "Trạng thái thanh toán";
                btnStatus.Text = "Done";
                btnStatus.Name = "btnStatus";
                btnStatus.UseColumnTextForButtonValue = true;
                da_bill.Columns.Add(btnStatus);
            }
            int currentYear = DateTime.Now.Year;
            cbNam.SelectedItem = currentYear.ToString();
        }      
        private void da_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == da_bill.Columns["btnPrint"].Index && e.RowIndex >= 0)
            {
                int maHDon = (int)da_bill.Rows[e.RowIndex].Cells["MaHDon"].Value;
                string hoTen = da_bill.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                string tenTang = da_bill.Rows[e.RowIndex].Cells["Tang"].Value.ToString();
                string tenPhong = da_bill.Rows[e.RowIndex].Cells["SoPhong"].Value.ToString();
                string tenLP = da_bill.Rows[e.RowIndex].Cells["TenLP"].Value.ToString();
                int giaTien = (int)da_bill.Rows[e.RowIndex].Cells["GiaTien"].Value;
                int phiDV = (int)da_bill.Rows[e.RowIndex].Cells["PhiDV"].Value;
                int tienDien = (int)da_bill.Rows[e.RowIndex].Cells["TienDien"].Value;
                int tienNuoc = (int)da_bill.Rows[e.RowIndex].Cells["TienNuoc"].Value;
                int tienXe = (int)da_bill.Rows[e.RowIndex].Cells["TienXe"].Value;
                int tongTien = (int)da_bill.Rows[e.RowIndex].Cells["TongTien"].Value;
                int thangHD = (int)da_bill.Rows[e.RowIndex].Cells["ThangHD"].Value;
                int namHD = (int)da_bill.Rows[e.RowIndex].Cells["NamHD"].Value;
                string email = da_bill.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var billDetail = _busBill.AllBillPrints().FirstOrDefault(b => b.MaHDon == maHDon);
                if (billDetail != null)
                {
                    int soDien = billDetail.SoDien;
                    int soNguoi = billDetail.SoNguoi;
                    int soXe = billDetail.SoXe;
                    PrintInvoice(maHDon, thangHD, namHD, hoTen, tenTang, tenPhong, tenLP, giaTien, phiDV, tienDien, tienNuoc, tienXe, soDien, soNguoi, soXe, tongTien);
                    _busBill.UpdateBillStatus(maHDon, 1);
                    da_bill.Rows[e.RowIndex].Cells["TrangThai"].Value = 1;
                    if (!string.IsNullOrEmpty(email))
                    {
                        SendInvoiceByEmail(maHDon, hoTen, tenTang, tenPhong, tenLP, giaTien, phiDV, tienDien, tienNuoc, tienXe, tongTien, thangHD, namHD, email);
                    }
                }
            }
            if (e.ColumnIndex == da_bill.Columns["btnStatus"].Index && e.RowIndex >= 0)
            {
                int maHDon = (int)da_bill.Rows[e.RowIndex].Cells["MaHDon"].Value;
                int trangThaiThanhToan = (int)da_bill.Rows[e.RowIndex].Cells["TrangThaiThanhToan"].Value;
                if (trangThaiThanhToan == 0)
                {
                    _busBill.UpdateBillStatusBill(maHDon, 1);  
                    da_bill.Rows[e.RowIndex].Cells["TrangThaiThanhToan"].Value = 1; 
                    MessageBox.Show("Trạng thái đã cập nhật: Đã thanh toán");
                }
                else
                {
                    MessageBox.Show("Hóa đơn đã thanh toán rồi!");
                }
            }
        }
        private void da_bill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (da_bill.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                int trangThaiValue;
                if (int.TryParse(e.Value.ToString(), out trangThaiValue))
                {
                    e.Value = trangThaiValue == 0 ? "Chưa in" : "Đã in";
                    e.FormattingApplied = true;
                }
            }
            if (da_bill.Columns[e.ColumnIndex].Name == "TrangThaiThanhToan" && e.Value != null)
            {
                int trangThaiThanhToanValue;
                if (int.TryParse(e.Value.ToString(), out trangThaiThanhToanValue))
                {
                    e.Value = trangThaiThanhToanValue == 1 ? "Đã thanh toán" : "Chưa thanh toán";
                    e.FormattingApplied = true;
                }
            }
            if (da_bill.Columns[e.ColumnIndex].Name == "TienDien" || da_bill.Columns[e.ColumnIndex].Name == "TienNuoc"
                   || da_bill.Columns[e.ColumnIndex].Name == "TienXe" || da_bill.Columns[e.ColumnIndex].Name == "PhiDV"
                   || da_bill.Columns[e.ColumnIndex].Name == "TongTien" 
                   || da_bill.Columns[e.ColumnIndex].Name == "TienPhong"
                   && e.Value != null)
            {
                e.Value = string.Format("{0:0,0}", e.Value);
                e.FormattingApplied = true;
            }
        }


        private void PrintInvoice(int maHDon, int thangHD, int namHD, string hoTen, string tenTang, string tenPhong, string tenLP,
                              int giaTien, int phiDV, int tienDien, int tienNuoc, int tienXe, int soDien, int soNguoi, int soXe, int tongTien)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (sender, e) => PrintPage(sender, e, maHDon, thangHD, namHD, hoTen, tenTang, tenPhong, tenLP, giaTien, phiDV, tienDien, tienNuoc, tienXe, soDien, soNguoi, soXe, tongTien);
            PrintDialog printDlg = new PrintDialog
            {
                Document = printDoc
            };

            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e, int maHDon, int thangHD, int namHD, string hoTen, string tenTang,
                        string tenPhong, string tenLP, int giaTien, int phiDV,
                        int tienDien, int tienNuoc, int tienXe, int soDien, int soNguoi, int soXe, int tongTien)
        {
            float pageWidth = e.PageBounds.Width;
            string tenTro = "Trọ Mai Phú";
            Font tenTroFont = new Font("Times New Roman", 28, FontStyle.Bold);
            SizeF tenTroSize = e.Graphics.MeasureString(tenTro, tenTroFont);
            float tenTroX = (pageWidth - tenTroSize.Width) / 2; 
            e.Graphics.DrawString(tenTro, tenTroFont, Brushes.Black, new PointF(tenTroX, 50));
            string diaChi = "Địa chỉ: 583 Khu Y Tế Kỹ Thuật Cao, Phường An Lạc A, Quận Bình Tân, Tp HCM";
            Font diaChiFont = new Font("Times New Roman", 16);
            SizeF diaChiSize = e.Graphics.MeasureString(diaChi, diaChiFont);
            float diaChiX = (pageWidth - diaChiSize.Width) / 2;
            e.Graphics.DrawString(diaChi, diaChiFont, Brushes.Black, new PointF(diaChiX, 100));
            string soDienThoai = "Số điện thoại: 0769 887 973";
            Font soDienThoaiFont = new Font("Times New Roman", 16);
            SizeF soDienThoaiSize = e.Graphics.MeasureString(soDienThoai, soDienThoaiFont);
            float soDienThoaiX = (pageWidth - soDienThoaiSize.Width) / 2;
            e.Graphics.DrawString(soDienThoai, soDienThoaiFont, Brushes.Black, new PointF(soDienThoaiX, 130));
            string hoaDonTitle = "HÓA ĐƠN THANH TOÁN";
            Font hoaDonFont = new Font("Times New Roman", 28, FontStyle.Bold);
            SizeF hoaDonSize = e.Graphics.MeasureString(hoaDonTitle, hoaDonFont);
            float hoaDonX = (e.MarginBounds.Width - hoaDonSize.Width) / 2 + e.MarginBounds.Left;
            e.Graphics.DrawString(hoaDonTitle, hoaDonFont, Brushes.Black, new PointF(hoaDonX, 170));
            e.Graphics.DrawString($"Mã Hóa Đơn: {maHDon}", new Font("Times New Roman", 18), Brushes.Black, new PointF(100, 220));
            e.Graphics.DrawString($"Hóa Đơn Kỳ: {thangHD}/{namHD}", new Font("Times New Roman", 18), Brushes.Black, new PointF(100, 250));
            e.Graphics.DrawString($"Tên Khách Hàng: {hoTen}", new Font("Times New Roman", 18), Brushes.Black, new PointF(100, 280));
            e.Graphics.DrawString($"Tầng: {tenTang}", new Font("Times New Roman", 18), Brushes.Black, new PointF(100, 310));
            e.Graphics.DrawString($"Phòng: {tenPhong}", new Font("Times New Roman", 18), Brushes.Black, new PointF(100, 340));
            e.Graphics.DrawString($"Loại Phòng: {tenLP}", new Font("Times New Roman", 18), Brushes.Black, new PointF(100, 370));
            float yPos = 420;
            e.Graphics.DrawString("STT", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(100, yPos));
            e.Graphics.DrawString("Mô Tả", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(200, yPos));
            e.Graphics.DrawString("Đơn Giá", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(450, yPos));
            e.Graphics.DrawString("SL", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(600, yPos));
            e.Graphics.DrawString("Thành Tiền", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(700, yPos));
            yPos += 40;
            string[] items = { "Giá Tiền Phòng", "Phí Dịch Vụ", "Tiền Điện", "Tiền Nước", "Tiền Xe" };
            int[] prices = { giaTien, phiDV, 3800, 100000, 120000 };
            int[] quantities = { 1, 1, soDien, soNguoi, soXe };

            for (int i = 0; i < items.Length; i++)
            {
                e.Graphics.DrawString((i + 1).ToString(), new Font("Times New Roman", 18), Brushes.Black, new PointF(100, yPos));
                e.Graphics.DrawString(items[i], new Font("Times New Roman", 18), Brushes.Black, new PointF(200, yPos));
                e.Graphics.DrawString(prices[i].ToString("N0"), new Font("Times New Roman", 18), Brushes.Black, new PointF(450, yPos));
                int quantity = quantities[i];
                int total = prices[i] * quantity;
                if (i == 2) 
                {
                    quantity = soDien;
                    total = tienDien;
                }
                else if (i == 3) 
                {
                    quantity = soNguoi;
                    total = tienNuoc;
                }
                else if (i == 4) 
                {
                    quantity = soXe;
                    total = tienXe;
                }

                e.Graphics.DrawString(quantity.ToString("N0"), new Font("Times New Roman", 18), Brushes.Black, new PointF(600, yPos));
                e.Graphics.DrawString(total.ToString("N0"), new Font("Times New Roman", 18), Brushes.Black, new PointF(700, yPos));
                yPos += 40;
            }
            e.Graphics.DrawString($"Tổng Cộng: {tongTien:N0}", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(100, yPos + 40));
            e.Graphics.DrawString("Quý khách vui lòng thanh toán trước ngày thứ 5 trong tháng qua Ngân Hàng MB Bank:", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new PointF(100, yPos + 80));
            e.Graphics.DrawString("Số tài khoản: 1230220039999", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new PointF(100, yPos + 80));
            e.Graphics.DrawString("Tên tài khoản: Lê Hoàng Tấn", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new PointF(100, yPos + 80));
            e.Graphics.DrawString("Xin chân thành cảm ơn sự đồng hành của quý khách!", new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new PointF(100, yPos + 80));
            e.Graphics.DrawString($"Ngày giờ in: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", new Font("Times New Roman", 14), Brushes.Black, new PointF(100, yPos + 120));
            string qrImagePath = @"D:\QLPhongTro\Image_Icon\Image_QRCode.jpg"; // Đường dẫn đến tệp hình ảnh QR
            using (Image qrImage = Image.FromFile(qrImagePath))
            {
                float qrImageWidth = qrImage.Width;
                float qrImageHeight = qrImage.Height;
                float qrPosX = (pageWidth - qrImageWidth) / 2; // Căn giữa theo chiều ngang
                float qrPosY = e.PageBounds.Height - qrImageHeight - 100; // Vị trí gần chân trang (cách mép dưới 100px)
                e.Graphics.DrawImage(qrImage, qrPosX, qrPosY, qrImageWidth, qrImageHeight);
            }
        }
        private void SendInvoiceByEmail(int maHDon, string hoTen, string tenTang, string tenPhong, string tenLP, int giaTien, int phiDV, int tienDien, int tienNuoc, int tienXe, int tongTien, int thangHD, int namHD, string email)
        {
            string invoiceContent =
                "Kính gửi Quý khách hàng,\n\n" +
                "Cảm ơn Quý khách đã sử dụng dịch vụ của Trọ Mai Phú. Dưới đây là thông tin hóa đơn của Quý khách:\n\n" +
                $"{"Mã Hóa Đơn",-100}: {maHDon}\n" +
                $"{"Hóa Đơn Kỳ",-100}: {thangHD}/{namHD}\n" +
                $"{"Tên Khách Hàng",-100}: {hoTen}\n" +
                $"{"Tầng",-100}: {tenTang}\n" +
                $"{"Phòng",-100}: {tenPhong}\n" +
                $"{"Loại Phòng",-100}: {tenLP}\n" +
                $"{"Giá Tiền Phòng",-100}: {giaTien:N0} VND\n" +
                $"{"Phí Dịch Vụ",-100}: {phiDV:N0} VND\n" +
                $"{"Tiền Điện",-100}: {tienDien:N0} VND\n" +
                $"{"Tiền Nước",-100}: {tienNuoc:N0} VND\n" +
                $"{"Tiền Xe",-100}: {tienXe:N0} VND\n" +
                $"{"Tổng Cộng",-100}: {tongTien:N0} VND\n\n" +
                "Quý khách vui lòng thanh toán trước ngày thứ 5 trong tháng qua Ngân Hàng MB Bank:\n" +
                "Số tài khoản: 1230220039999\n" +
                "Tên tài khoản: Lê Hoàng Tấn\n" +
                $"Số tiền thanh toán: {tongTien:N0} VND\n\n" +
                "Chúng tôi chân thành cảm ơn Quý khách đã tin tưởng và lựa chọn dịch vụ của nhà trọ.\n" +
                "Kính chúc Quý khách sức khỏe dồi dào và thành công trong cuộc sống.\n\n" +
                "Trân trọng,\n" +
                "Trọ Mai Phú";

            // Thông tin người gửi và mật khẩu ứng dụng
            string from = "tanlhouhcm03@gmail.com"; // Địa chỉ email của người gửi
            string appPassword = "cdcx nrpv khfj ysxa"; // Mật khẩu ứng dụng của bạn

            // Tạo email
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(email);
            mail.Subject = "Hóa Đơn Tiền Phòng";
            mail.Body = invoiceContent;

            // Thiết lập SMTP client
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(from, appPassword);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Hóa đơn đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi hóa đơn thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString()); 
            }
        }
        private void PrintBill_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbThang.Text) || string.IsNullOrEmpty(cbNam.Text) || string.IsNullOrEmpty(cbTrangThaiThanhToan.Text))
            {
                LoadData();
            }
            else
            {
                try
                {
                    int thang = int.Parse(cbThang.Text);
                    int nam = int.Parse(cbNam.Text);
                    int trangthaithanhtoan = 0;
                    if (cbTrangThaiThanhToan.Text == "Đã thanh toán")
                    {
                        trangthaithanhtoan = 1;
                    }
                    else if (cbTrangThaiThanhToan.Text == "Chưa thanh toán")
                    {
                        trangthaithanhtoan = 0;
                    }

                    // Gọi phương thức và truyền đúng tham số
                    List<GetAllBillPrint> danhSachHoaDon = _busBill.LayHoaDonTheoThangNam(thang, nam, trangthaithanhtoan);

                    if (danhSachHoaDon.Count == 0)
                    {
                        MessageBox.Show($"Không có hóa đơn nào cho tháng {thang} năm {nam}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        da_bill.DataSource = danhSachHoaDon;
                        int tongTien = danhSachHoaDon.Count > 0 ? danhSachHoaDon[0].SumMoney : 0;
                        lbTongTIen.Text = tongTien.ToString("N0") + " VND";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cbThang.SelectedIndex = -1;
                    cbTrangThaiThanhToan.SelectedIndex = -1;
                }
            }

        }
    }
}
