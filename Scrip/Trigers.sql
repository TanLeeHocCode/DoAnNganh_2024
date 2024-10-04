-- Nếu bạn đang sử dụng một công cụ quản lý SQL, hãy chắc chắn rằng phần dưới đây bắt đầu từ dòng đầu tiên.
CREATE TRIGGER trg_UpdatePhongTrangThai
ON KhachHang
AFTER INSERT
AS
BEGIN
    -- Cập nhật trạng thái của phòng thành 1 khi có khách hàng liên kết với MaPhong đó
    UPDATE Phong
    SET TrangThai = 1
    FROM Phong p
    INNER JOIN inserted i ON p.MaPhong = i.MaPhong
    WHERE i.MaPhong IS NOT NULL;
END;

CREATE TRIGGER trg_UpdateSoXe
ON KhachHang
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE ChiTietPhong
    SET SoXe = (
        SELECT SUM(kh.SoXe)
        FROM KhachHang kh
        WHERE kh.MaPhong = ChiTietPhong.MaPhong
    )
    WHERE EXISTS (
        SELECT 1
        FROM KhachHang kh
        WHERE kh.MaPhong = ChiTietPhong.MaPhong
    );
END;



ALTER TABLE ChiTietPhong
ADD CONSTRAINT DF_SoDienCu DEFAULT 0 FOR SoDienCu;

ALTER TABLE ChiTietPhong
ADD CONSTRAINT DF_SoDienMoi DEFAULT 0 FOR SoDienMoi;

CREATE TRIGGER trg_InsertChiTietPhong
ON Phong
AFTER INSERT
AS
BEGIN
    -- Thêm một dòng mới vào ChiTietPhong cho mỗi phòng vừa được tạo
    INSERT INTO ChiTietPhong (MaPhong, SoXe, SoNguoi)
    SELECT i.MaPhong, 0, 0 -- Khởi tạo SoXe và SoNguoi bằng 0 hoặc giá trị mặc định
    FROM Inserted i;
END;


CREATE TRIGGER trg_UpdateSoNguoi
ON KhachHang
AFTER INSERT, UPDATE
AS
BEGIN
    -- Cập nhật số người trong ChiTietPhong
    UPDATE ChiTietPhong
    SET SoNguoi = (
        SELECT COUNT(*)
        FROM KhachHang kh
        WHERE kh.MaPhong = ChiTietPhong.MaPhong
    )
    WHERE EXISTS (
        SELECT 1
        FROM KhachHang kh
        WHERE kh.MaPhong = ChiTietPhong.MaPhong
    );
END;


-- Thiết lập giá trị mặc định của cột SoDien là 0
ALTER TABLE ChiTietPhong
ADD CONSTRAINT DF_ChiTietPhong_SoDien DEFAULT 0 FOR SoDien;
ALTER TABLE ChiTietPhong
-- Thiết lập giá trị mặc định của cột SoNguoi là 0
ADD CONSTRAINT DF_ChiTietPhong_SoNguoi DEFAULT 0 FOR SoNguoi;

-- Thiết lập giá trị mặc định của cột TrangThai là 0
alter table Phong
ADD CONSTRAINT DF_Phong_TrangThai DEFAULT 0 FOR TrangThai;
--Xóa dữ liệu trong 2 bảng ChiTietPhong và Phòng
Delete from ChiTietPhong
Delete from HoaDon
Delete from HopDong
Delete from KhachHang
Delete from Phong
Delete from ThongKe

 




-- Reset giá trị IDENTITY của bảng Phong về 1
DBCC CHECKIDENT ('Phong', RESEED, 0);
DBCC CHECKIDENT ('ChiTietPhong', RESEED, 0);
DBCC CHECKIDENT ('KhachHang', RESEED, 0);
DBCC CHECKIDENT ('HopDong', RESEED, 0);
DBCC CHECKIDENT ('HoaDon', RESEED, 0);
DBCC CHECKIDENT ('ThongKe', RESEED, 0);








CREATE TRIGGER UpdateChiTietPhong
ON KhachHang
AFTER INSERT
AS
BEGIN
    -- Cập nhật số người trong bảng ChiTietPhong
    UPDATE ChiTietPhong
    SET SoNguoi = (SELECT COUNT(*) FROM KhachHang WHERE MaPhong = inserted.MaPhong)
    FROM ChiTietPhong
    JOIN inserted ON ChiTietPhong.MaPhong = inserted.MaPhong;
    
    -- Cập nhật số xe trong bảng ChiTietPhong (giả sử bạn có một cột số xe trong bảng KhachHang, ví dụ MaXe)
    UPDATE ChiTietPhong
    SET SoXe = (SELECT ISNULL(SUM(SoXe), 0) FROM KhachHang WHERE MaPhong = inserted.MaPhong)
    FROM ChiTietPhong
    JOIN inserted ON ChiTietPhong.MaPhong = inserted.MaPhong;
    
    -- Nếu bạn muốn cập nhật trạng thái của phòng, ví dụ là phòng đã được thuê
    UPDATE Phong
    SET TrangThai = 1 -- 1 có thể là "đã được thuê"
    FROM Phong
    JOIN inserted ON Phong.MaPhong = inserted.MaPhong;
END;

CREATE TRIGGER trg_DeleteKhachHang
ON KhachHang
FOR DELETE
AS
BEGIN
    DELETE FROM HopDong
    WHERE MaKH IN (SELECT deleted.MaKH FROM deleted);
END;


 SELECT h.MaHDong, h.NgayThangBD, h.NgayThangKT, h.TienCoc, h.MaPhong, h.MaKH,
                       k.Ho + ' ' + k.Ten AS HoTen, k.CCCD, k.SDT, k.Email, k.QueQuan,
                       sp.TenPhong, t.TenTang, ctp.SoXe, ctp.SoNguoi, lp.GiaTien, lp.DienTich, Day(h.NgayThangBD) as NgayBD,
					   Month(h.NgayThangBD) as ThangBD, Year(h.NgayThangBD) as NamBD, Day(h.NgayThangKT) as NgayKT,
					   Month(h.NgayThangKT) as ThangKT, Year(h.NgayThangKT) as NamKT, DATEDIFF(MONTH, h.NgayThangBD, h.NgayThangKT) AS SoThang, k.NamSinh
                FROM HopDong h
                INNER JOIN Phong p ON h.MaPhong = p.MaPhong
                INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
                INNER JOIN Tang t ON p.MaTang = t.MaTang
                INNER JOIN KhachHang k ON h.MaKH = k.MaKH
                INNER JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
				INNER JOIN ChiTietPhong ctp on p.MaPhong = ctp.MaPhong
SELECT h.MaHDong, h.NgayThangBD, h.NgayThangKT, h.TienCoc, h.MaPhong, h.MaKH,
                    k.Ho + ' ' + k.Ten AS HoTen, k.CCCD, k.SDT, k.Email, k.QueQuan,
                    sp.TenPhong, t.TenTang, lp.TenLP, ctp.SoXe, ctp.SoNguoi, lp.GiaTien, lp.DienTich, Day(h.NgayThangBD) as NgayBD,
					Month(h.NgayThangBD) as ThangBD, Year(h.NgayThangBD) as NamBD, Day(h.NgayThangKT) as NgayKT,
					Month(h.NgayThangKT) as ThangKT, Year(h.NgayThangKT) as NamKT, DATEDIFF(MONTH, h.NgayThangBD, h.NgayThangKT) AS SoThang, k.NamSinh
            FROM HopDong h
            INNER JOIN Phong p ON h.MaPhong = p.MaPhong
            INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
            INNER JOIN Tang t ON p.MaTang = t.MaTang
            INNER JOIN KhachHang k ON h.MaKH = k.MaKH
            INNER JOIN LoaiPhong lp ON p.MaLP = lp.MaLP
			INNER JOIN ChiTietPhong ctp on p.MaPhong = ctp.MaPhong
select*From ChiTietPhong
go
CREATE TRIGGER trg_UpdateChiTietPhong_SoDien
ON ChiTietPhong
AFTER UPDATE
AS
BEGIN
    -- Cập nhật SoDienCu bằng giá trị hiện tại của SoDienMoi trước khi cập nhật SoDienMoi
    UPDATE c
    SET SoDienCu = d.SoDienMoi
    FROM ChiTietPhong c
    INNER JOIN deleted d ON c.MaPhong = d.MaPhong
    WHERE c.MaPhong = d.MaPhong;

    -- Cập nhật số điện mới từ bảng inserted
    UPDATE c
    SET SoDienMoi = i.SoDienMoi
    FROM ChiTietPhong c
    INNER JOIN inserted i ON c.MaPhong = i.MaPhong
    WHERE c.MaPhong = i.MaPhong;
END;
go

CREATE VIEW BillDetailsView AS
SELECT h.MaHDon, kh.SDT, kh.Email, ctp.SoNguoi, ctp.SoXe, h.SoDien, 
       t.TenTang AS 'Tầng', sp.TenPhong AS 'Số Phòng', 
       lp.TenLP AS 'Loại Phòng', (kh.Ho + ' ' + kh.Ten) AS 'Họ Tên',lp.TenLP,
       lp.GiaTien AS 'Giá Tiền Phòng',
       ctp.SoXe * 120000 AS 'Tiền Xe', 
       ctp.SoNguoi * 100000 AS 'Tiền Nước',
       h.SoDien * 3800 AS 'Tiền Điện', 
       h.PhiDV AS 'Phí Dịch Vụ',
       lp.GiaTien + ctp.SoXe * 120000 + ctp.SoNguoi * 100000 + h.PhiDV + h.SoDien * 3800 AS 'Tổng tiền',
       p.MaPhong, ctp.SoDienCu, ctp.SoDienMoi, h.TrangThai, month(h.NgayThang) as ThangHD, year(h.NgayThang) as NamHD
FROM HoaDon h
INNER JOIN HopDong hdong ON h.MaHDong = hdong.MaHDong
INNER JOIN KhachHang kh ON kh.MaKH = hdong.MaKH
INNER JOIN Phong p ON p.MaPhong = kh.MaPhong
INNER JOIN ChiTietPhong ctp ON ctp.MaPhong = p.MaPhong
INNER JOIN Tang t ON t.MaTang = p.MaTang
INNER JOIN LoaiPhong lp ON lp.MaLP = p.MaLP
INNER JOIN SoPhong sp ON sp.MaSP = p.MaSP
WHERE p.TrangThai = 1;
SELECT MaHDon, SDT, Email, SoNguoi, SoXe, 
               [Tầng], [Số Phòng], [Loại Phòng], [Họ Tên],
               [Giá Tiền Phòng], [Tiền Xe], [Tiền Nước], 
               [Tiền Điện], [Phí Dịch Vụ], [Tổng tiền], 
               TenLP, TrangThai, ThangHD, NamHD
                FROM BillDetailsView
go
CREATE PROCEDURE DeletePhong
    @MaPhong INT
AS
BEGIN
    -- Bắt đầu giao dịch
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Xóa dữ liệu từ bảng ChiTietPhong
        DELETE FROM ChiTietPhong WHERE MaPhong = @MaPhong;

        -- Xóa dữ liệu từ bảng Phong
        DELETE FROM Phong WHERE MaPhong = @MaPhong;

        -- Cập nhật giá trị IDENTITY trong bảng Phong
        DECLARE @MaxMaPhong INT;
        SELECT @MaxMaPhong = ISNULL(MAX(MaPhong), 0) FROM Phong;
        DBCC CHECKIDENT ('Phong', RESEED, @MaxMaPhong);

        -- Cập nhật giá trị IDENTITY trong bảng ChiTietPhong
        DECLARE @MaxMaPhongCTP INT;
        SELECT @MaxMaPhongCTP = ISNULL(MAX(MaPhong), 0) FROM ChiTietPhong;
        DBCC CHECKIDENT ('ChiTietPhong', RESEED, @MaxMaPhongCTP);

        -- Commit giao dịch
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback giao dịch nếu có lỗi
        ROLLBACK TRANSACTION;

        -- Xử lý lỗi (ghi lỗi ra log hoặc thông báo)
        THROW;
    END CATCH
END
exec DeletePhong 3

select*from HoaDon
SELECT MaHDon, SDT, Email, SoNguoi, SoXe, 
               [Tầng], [Số Phòng], [Loại Phòng], [Họ Tên],
               [Giá Tiền Phòng], [Tiền Xe], [Tiền Nước], 
               [Tiền Điện], [Phí Dịch Vụ], [Tổng tiền], TrangThai, ThangHD, NamHD, SoDien, SoNguoi, SoXe
                FROM BillDetailsView