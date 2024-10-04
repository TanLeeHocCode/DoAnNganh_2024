create proc proc_logic
@user nvarchar(100),
@pass nvarchar(50)
as
Begin 
	Select* From Admin where TaiKhoan=@user and MatKhau=@pass
end


CREATE PROCEDURE proc_get_room
AS
BEGIN
    SELECT 
        p.MaPhong,
        p.TrangThai,
        p.MaLP,
        lp.TenLP, -- Assuming TenLoaiPhong is the name of the column in LoaiPhong table
        p.MaTang,
        t.TenTang, -- Assuming TenTang is the name of the column in Tang table
        p.MaSP,
        sp.TenPhong -- Assuming SoPhong is the name of the column in SoPhong table
    FROM 
        Phong p
    INNER JOIN 
        LoaiPhong lp ON p.MaLP = lp.MaLP
    INNER JOIN 
        Tang t ON p.MaTang = t.MaTang
    INNER JOIN 
        SoPhong sp ON p.MaSP = sp.MaSP
END
SELECT t.TenTang, sp.TenPhong, ctp.SoDienCu, ctp.SoDienMoi, ctp.SoNguoi, ctp.SoXe,
kh.Ho +' '+ kh.Ten as HoTen, lp.GiaTien, kh.SDT, kh.Email
FROM HopDong hd 
inner join KhachHang kh on kh.MaKH = hd.MaKH
inner join Phong p on  p.MaPhong = kh.MaPhong
inner join ChiTietPhong ctp on ctp.MaPhong = p.MaPhong
inner join Tang t on t.MaTang = p.MaTang
inner join LoaiPhong lp on lp.MaLP = p.MaLP
inner join SoPhong sp on sp.MaSP =p.MaSP
Where p.TrangThai=1



SELECT p.MaPhong, t.TenTang, sp.TenPhong, ctp.SoDienCu, ctp.SoDienMoi, ctp.SoNguoi, ctp.SoXe,
       kh.Ho + ' ' + kh.Ten AS HoTen, lp.GiaTien, kh.SDT, kh.Email
FROM HopDong hd 
INNER JOIN KhachHang kh ON kh.MaKH = hd.MaKH
INNER JOIN Phong p ON p.MaPhong = kh.MaPhong
INNER JOIN ChiTietPhong ctp ON ctp.MaPhong = p.MaPhong
INNER JOIN Tang t ON t.MaTang = p.MaTang
INNER JOIN LoaiPhong lp ON lp.MaLP = p.MaLP
INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
WHERE p.TrangThai = 1
-- Cập nhật bảng ChiTietPhong
SELECT * FROM ChiTietPhong

select* from HoaDon


select H.MaHDon,kh.SDT,kh.Email,ctp.SoNguoi, ctp.SoXe, h.SoDien, h.PhiDV, T.TenTang as 'Tầng', sp.TenPhong as'Số Phòng', lp.TenLP as 'Loại Phòng',  (kh.Ho +' '+ kh.Ten) as'Họ Tên', lp.GiaTien as 'Giá Tiền Phòng',
                ctp.SoXe*120000 as 'Tiền Xe', ctp.SoNguoi*100000 as 'Tiền Nước', h.SoDien*3800 as'Tiền Điện',h.PhiDV as 'Phí Dịch Vụ', 
                lp.GiaTien+ctp.SoXe*120000+ctp.SoNguoi*100000+h.PhiDV+h.SoDien*3800 as 'Tổng tiền'
                from HoaDon h
                inner join HopDong hdong on h.MaHDong = hdong.MaHDong
                INNER JOIN KhachHang kh ON kh.MaKH = hdong.MaKH
                INNER JOIN Phong p ON p.MaPhong = kh.MaPhong
                INNER JOIN ChiTietPhong ctp ON ctp.MaPhong = p.MaPhong
                INNER JOIN Tang t ON t.MaTang = p.MaTang
                INNER JOIN LoaiPhong lp ON lp.MaLP = p.MaLP
                INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
where Month(h.NgayThang)=10

select * From Tang
select * From SoPhong
select * From LoaiPhong
select*from Phong

select kh.MaKH, p.MaPhong , lp.GiaTien from KhachHang kh join Phong p on p.MaPhong= kh.MaPhong join LoaiPhong lp on lp.MaLP= p.MaLP where CCCD='091274216700'

