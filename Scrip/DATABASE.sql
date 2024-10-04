USE master;
GO
CREATE DATABASE QLPhongTro;
GO
USE QLPhongTro;
GO

-- Tạo bảng LoaiPhong
CREATE TABLE LoaiPhong(
    MaLP INT IDENTITY(1,1) PRIMARY KEY,
    TenLP NVARCHAR(50) NOT NULL,
    GiaTien INT NOT NULL
);
GO

-- Tạo bảng SoPhong
CREATE TABLE SoPhong(
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong CHAR(10) NOT NULL
);
GO

-- Tạo bảng Tang
CREATE TABLE Tang(
    MaTang INT IDENTITY(1,1) PRIMARY KEY,
    TenTang CHAR(10) NOT NULL
);
GO

-- Tạo bảng Phong
CREATE TABLE Phong(
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TrangThai INT NOT NULL,
    MaLP INT,
    MaSP INT,
    MaTang INT,
    FOREIGN KEY (MaLP) REFERENCES LoaiPhong(MaLP),
    FOREIGN KEY (MaSP) REFERENCES SoPhong(MaSP),
    FOREIGN KEY (MaTang) REFERENCES Tang(MaTang)
);
GO

-- Tạo bảng ChiTietPhong
CREATE TABLE ChiTietPhong(
    MaCTP INT IDENTITY(1,1) PRIMARY KEY,
    SoDienCu INT,
    SoDienMoi INT NOT NULL,
    SoXe INT NOT NULL,
    SoNguoi INT NOT NULL, 
    MaPhong INT,
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);
GO

-- Tạo bảng KhachHang
CREATE TABLE KhachHang(
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    Ho NVARCHAR(50) NOT NULL,
    Ten NVARCHAR(50),
    NamSinh DATETIME,
    CCCD CHAR(12),
    SDT CHAR(10),
    Email VARCHAR(100),
    QueQuan NVARCHAR(50),
    SoXe INT NOT NULL,
    MaPhong INT,
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);
GO

-- Tạo bảng HopDong
CREATE TABLE HopDong(
    MaHDong INT IDENTITY(1,1) PRIMARY KEY,
    NgayThang DATETIME,
    TienCoc INT,
    MaPhong INT,
    MaKH INT,
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);
GO

-- Tạo bảng HoaDon
CREATE TABLE HoaDon(
    MaHDon INT IDENTITY(1,1) PRIMARY KEY,
    PhiDV INT,
    SoDien INT,
    NgayThang DATETIME,
    MaHDong INT,
    FOREIGN KEY (MaHDong) REFERENCES HopDong(MaHDong)
);
GO

-- Tạo bảng ChuVuNV
CREATE TABLE ChuVuNV(
    MaCV INT IDENTITY(1,1) PRIMARY KEY,
    TenCV NVARCHAR(50)
);
GO

-- Tạo bảng NhanSu
CREATE TABLE NhanSu(
    MaNS INT IDENTITY(1,1) PRIMARY KEY,
    Ho NVARCHAR(50),
    Ten NVARCHAR(50),
    NamSinh DATETIME,
    CCCD CHAR(12),
    SDT CHAR(10),
    Email VARCHAR(100),
    DiaChi NVARCHAR(100),
    MaCV INT,
    FOREIGN KEY (MaCV) REFERENCES ChuVuNV(MaCV)
);
GO

-- Tạo bảng Admin
CREATE TABLE Admin(
    MaTk INT IDENTITY(1,1) PRIMARY KEY,
    TaiKhoan VARCHAR(50),
    MatKhau VARCHAR(30),
    MaNS INT,
    FOREIGN KEY (MaNS) REFERENCES NhanSu(MaNS)
);
GO

-- Tạo bảng ThongKe
CREATE TABLE ThongKe(
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenTang CHAR(10),
    TenPhong CHAR(10),
    ThangTK INT,
    NamTK INT,
    GiaTri INT
);
GO

-- Chèn dữ liệu vào bảng Tang
INSERT INTO Tang (TenTang) VALUES
('Tang 1'),
('Tang 2'),
('Tang 3'),
('Tang 4'),
('Tang 5'),
('Tang 6'),
('Tang 7'),
('Tang 8'),
('Tang 9'),
('Tang 10');
GO

-- Chèn dữ liệu vào bảng SoPhong
INSERT INTO SoPhong (TenPhong) VALUES
('001'),
('002'),
('003'),
('004'),
('005'),
('006'),
('007'),
('008'),
('009'),
('010'),
('011'),
('012'),
('013'),
('014'),
('015'),
('016'),
('017'),
('018'),
('019'),
('020');
GO

-- Chèn dữ liệu vào bảng LoaiPhong
INSERT INTO LoaiPhong (TenLP, GiaTien) VALUES
('Phong Co Ban', 3000000),
('Phong Plus', 3400000),
('Phong Full Noi That', 4000000);
GO

-- Chèn dữ liệu vào bảng ChuVuNV
INSERT INTO ChuVuNV (TenCV) VALUES
('Chu nha'),
('Nhan vien');
GO

-- Chèn dữ liệu vào bảng NhanSu
INSERT INTO NhanSu (Ho, Ten, NamSinh, CCCD, SDT, Email, DiaChi, MaCV) VALUES
('Nguyen', 'Thanh Lam', '1999-04-26', '123456789012', '0909123456', 'vanlam.nguyen@gmail.com', 'Phuong 1, Quan 1, HCM', 2),
('Tran', 'Thi Bich Ngan', '2000-11-20', '987654321098', '0912345678', 'thibichngan.tran@gmail.com', 'Phuong 2, Quan 2, HCM', 2),
('Le Hoang', 'Tan', '2003-02-23', '087203015405', '0769887973', 'tanlhouhcm03@gmail.com', 'Binh Tri Dong A, Binh Tan, HCM', 1);
GO


GO

-- Chèn dữ liệu vào bảng ChiTietPhong
INSERT INTO ChiTietPhong (SoDien, SoXe, SoNguoi, MaPhong) VALUES
(0,0,0,1);
GO

-- Chèn dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
('Lam Minh', 'Dat', '2000-12-18', '357203269156', '0912741365', 'datlam.dm@gmail.com', 'Tien Giang', 1, 1),
('Le Minh', 'Tai', '2000-12-12', '087203015407', '0937993590', 'lmtai.1212@gmail.com', 'Kien Giang', 1, 1),
('Le Van', 'Thanh', '1998-09-23', '087213115407', '0912742167', 'lhanhth.22@gmail.com', 'Dong Thap', 1, 1);
GO

-- Chèn dữ liệu vào bảng Admin
INSERT INTO Admin (TaiKhoan, MatKhau, MaNS) VALUES
('admin', '123', 3);
GO

-- Xóa dữ liệu trong bảng ChiTietPhong
DELETE FROM ChiTietPhong;
GO

-- Xóa dữ liệu trong bảng Phong
DELETE FROM Phong;
GO
-- Chèn dữ liệu vào bảng Phong Tầng 1
INSERT INTO Phong (TrangThai, MaLP, MaSP, MaTang) VALUES
(0,1,1,1),
(0,3,2,1),
(0,2,3,1),
(0,1,4,1),
(0,1,5,1),
(0,3,6,1),
(0,3,7,1),
(0,2,8,1),
(0,1,9,1),
(0,2,10,1),
(0,2,11,1),
(0,3,12,1),
(0,1,13,1),
(0,1,14,1),
(0,2,15,1),
(0,3,16,1),
(0,2,17,1),
(0,1,18,1),
(0,3,19,1),
(0,1,20,1);
-- Chèn dữ liệu vào bảng Phong cho các tầng tiếp theo
-- Tầng 2
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(2, 0, 1, 3),
(2, 0, 2, 1),
(2, 0, 3, 2),
(2, 0, 4, 3),
(2, 0, 5, 2),
(2, 0, 6, 1),
(2, 0, 7, 3),
(2, 0, 8, 1),
(2, 0, 9, 2),
(2, 0, 10, 3),
(2, 0, 11, 2),
(2, 0, 12, 3),
(2, 0, 13, 1),
(2, 0, 14, 2),
(2, 0, 15, 3),
(2, 0, 16, 1),
(2, 0, 17, 2),
(2, 0, 18, 3),
(2, 0, 19, 1),
(2, 0, 20, 2);
GO

-- Tầng 3
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(3, 0, 1, 3),
(3, 0, 2, 1),
(3, 0, 3, 2),
(3, 0, 4, 3),
(3, 0, 5, 2),
(3, 0, 6, 1),
(3, 0, 7, 3),
(3, 0, 8, 1),
(3, 0, 9, 2),
(3, 0, 10, 3),
(3, 0, 11, 2),
(3, 0, 12, 3),
(3, 0, 13, 1),
(3, 0, 14, 2),
(3, 0, 15, 3),
(3, 0, 16, 1),
(3, 0, 17, 2),
(3, 0, 18, 3),
(3, 0, 19, 1),
(3, 0, 20, 2);
GO

-- Tầng 4
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(4, 0, 1, 3),
(4, 0, 2, 1),
(4, 0, 3, 2),
(4, 0, 4, 3),
(4, 0, 5, 2),
(4, 0, 6, 1),
(4, 0, 7, 3),
(4, 0, 8, 1),
(4, 0, 9, 2),
(4, 0, 10, 3),
(4, 0, 11, 2),
(4, 0, 12, 3),
(4, 0, 13, 1),
(4, 0, 14, 2),
(4, 0, 15, 3),
(4, 0, 16, 1),
(4, 0, 17, 2),
(4, 0, 18, 3),
(4, 0, 19, 1),
(4, 0, 20, 2);
GO

-- Tầng 5
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(5, 0, 1, 3),
(5, 0, 2, 1),
(5, 0, 3, 2),
(5, 0, 4, 3),
(5, 0, 5, 2),
(5, 0, 6, 1),
(5, 0, 7, 3),
(5, 0, 8, 1),
(5, 0, 9, 2),
(5, 0, 10, 3),
(5, 0, 11, 2),
(5, 0, 12, 3),
(5, 0, 13, 1),
(5, 0, 14, 2),
(5, 0, 15, 3),
(5, 0, 16, 1),
(5, 0, 17, 2),
(5, 0, 18, 3),
(5, 0, 19, 1),
(5, 0, 20, 2);
GO

-- Tầng 6
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(6, 0, 1, 3),
(6, 0, 2, 1),
(6, 0, 3, 2),
(6, 0, 4, 3),
(6, 0, 5, 2),
(6, 0, 6, 1),
(6, 0, 7, 3),
(6, 0, 8, 1),
(6, 0, 9, 2),
(6, 0, 10, 3),
(6, 0, 11, 2),
(6, 0, 12, 3),
(6, 0, 13, 1),
(6, 0, 14, 2),
(6, 0, 15, 3),
(6, 0, 16, 1),
(6, 0, 17, 2),
(6, 0, 18, 3),
(6, 0, 19, 1),
(6, 0, 20, 2);
GO

-- Tầng 7
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(7, 0, 1, 3),
(7, 0, 2, 1),
(7, 0, 3, 2),
(7, 0, 4, 3),
(7, 0, 5, 2),
(7, 0, 6, 1),
(7, 0, 7, 3),
(7, 0, 8, 1),
(7, 0, 9, 2),
(7, 0, 10, 3),
(7, 0, 11, 2),
(7, 0, 12, 3),
(7, 0, 13, 1),
(7, 0, 14, 2),
(7, 0, 15, 3),
(7, 0, 16, 1),
(7, 0, 17, 2),
(7, 0, 18, 3),
(7, 0, 19, 1),
(7, 0, 20, 2);
GO

-- Tầng 8
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(8, 0, 1, 3),
(8, 0, 2, 1),
(8, 0, 3, 2),
(8, 0, 4, 3),
(8, 0, 5, 2),
(8, 0, 6, 1),
(8, 0, 7, 3),
(8, 0, 8, 1),
(8, 0, 9, 2),
(8, 0, 10, 3),
(8, 0, 11, 2),
(8, 0, 12, 3),
(8, 0, 13, 1),
(8, 0, 14, 2),
(8, 0, 15, 3),
(8, 0, 16, 1),
(8, 0, 17, 2),
(8, 0, 18, 3),
(8, 0, 19, 1),
(8, 0, 20, 2);
GO

-- Tầng 9
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(9, 0, 1, 3),
(9, 0, 2, 1),
(9, 0, 3, 2),
(9, 0, 4, 3),
(9, 0, 5, 2),
(9, 0, 6, 1),
(9, 0, 7, 3),
(9, 0, 8, 1),
(9, 0, 9, 2),
(9, 0, 10, 3),
(9, 0, 11, 2),
(9, 0, 12, 3),
(9, 0, 13, 1),
(9, 0, 14, 2),
(9, 0, 15, 3),
(9, 0, 16, 1),
(9, 0, 17, 2),
(9, 0, 18, 3),
(9, 0, 19, 1),
(9, 0, 20, 2);
GO

-- Tầng 10
INSERT INTO Phong (MaTang, TrangThai, MaSP, MaLP) VALUES
(10, 0, 1, 3),
(10, 0, 2, 1),
(10, 0, 3, 2),
(10, 0, 4, 3),
(10, 0, 5, 2),
(10, 0, 6, 1),
(10, 0, 7, 3),
(10, 0, 8, 1),
(10, 0, 9, 2),
(10, 0, 10, 3),
(10, 0, 11, 2),
(10, 0, 12, 3),
(10, 0, 13, 1),
(10, 0, 14, 2),
(10, 0, 15, 3),
(10, 0, 16, 1),
(10, 0, 17, 2),
(10, 0, 18, 3),
(10, 0, 19, 1),
(10, 0, 20, 2);
GO

INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Thị', N'Mai', '1999-05-14', '011203869420', '0912456789', 'nguyenmai@mail.com', N'An Giang', 1, 1),
(N'Trần Văn', N'Cường', '1985-06-30', '061203859420', '0932456789', 'lhtan12a3.21@gmail.com', N'Long An', 0, 1),
(N'Phạm Thị', N'Hoa', '1992-11-11', '092203658407', '0902456789', 'phamhoa@mail.com', N'Vĩnh Long', 1, 1);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Vũ Văn', N'An', '1987-03-25', '051203748420', '0942356789', '2151050394tan@ou.edu.vn', N'Bến Tre', 0, 2),
(N'Hoàng Thị', N'Linh', '1995-07-17', '081203951407', '0913356789', 'linhhoang@gmail.com', N'Trà Vinh', 1, 2),
(N'Nguyễn Văn', N'Đức', '1988-12-05', '072203654407', '0934456789', 'ducnguyen@gmail.com', N'Tây Ninh', 0, 2);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Mai Thị', N'Thu', '1993-10-10', '081203675420', '0904556789', 'thu.mai@mail.com', N'Hồ Chí Minh', 1, 3),
(N'Lê Thị', N'Hồng', '1997-09-15', '091203754407', '0915656789', 'hongle@gmail.com', N'Cần Thơ', 0, 3),
(N'Trịnh Thị', N'Hằng', '1996-04-22', '083203647420', '0926756789', 'hangtrinh@gmail.com', N'Sóc Trăng', 1, 3);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Vũ Thị', N'Quyên', '1994-08-09', '075203681407', '0907856789', 'quyenvu@mail.com', N'Kiên Giang', 0, 4),
(N'Trần Thị', N'Thảo', '1991-01-29', '097203752420', '0938956789', 'thaotran@gmail.com', N'Bạc Liêu', 1, 4),
(N'Hồ Thị', N'Tâm', '1990-06-06', '051203689420', '0949056789', 'tamho@gmail.com', N'Hậu Giang', 0, 4);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Thị', N'Cẩm', '1998-11-21', '087203648420', '0919456789', 'camnguyen@mail.com', N'Tiền Giang', 1, 5),
(N'Phạm Thị', N'Dung', '1984-12-30', '071203654407', '0902156789', 'dungpham@gmail.com', N'Bến Tre', 0, 5),
(N'Vũ Thị', N'Mai', '1999-05-17', '061203658420', '0943056789', 'maivu@gmail.com', N'Long An', 1, 5);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Thị', N'Yến', '1997-07-29', '092203647407', '0934156789', 'yennguyen@gmail.com', N'Vĩnh Long', 0, 6),
(N'Lê Thị', N'Thu', '1996-10-15', '075203658420', '0905356789', 'thule@gmail.com', N'Hồ Chí Minh', 1, 6),
(N'Trần Thị', N'Bảo', '1989-04-12', '091203675420', '0946456789', 'baotran@gmail.com', N'Sóc Trăng', 0, 6);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Hồ Thị', N'Tú', '1992-08-23', '031203648420', '0917556789', 'tuhothi@mail.com', N'Hậu Giang', 1, 7),
(N'Nguyễn Thị', N'Trang', '1994-12-10', '062203751407', '0908656789', 'trangnguyen@gmail.com', N'Tiền Giang', 0, 7),
(N'Phạm Thị', N'Lan', '1995-07-19', '083203689420', '0919756789', 'lanpham@gmail.com', N'Cần Thơ', 1, 7);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Vũ Thị', N'My', '1993-11-05', '074203674420', '0920856789', 'mivu@gmail.com', N'Long An', 0, 8),
(N'Nguyễn Thị', N'Thảo', '1991-06-25', '091203678420', '0901956789', 'thaonguyen@mail.com', N'Tây Ninh', 1, 8),
(N'Trần Thị', N'Hạnh', '1989-04-12', '081203654407', '0932456789', 'hanhtran@gmail.com', N'Vĩnh Long', 0, 8);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Hoàng Thị', N'Thủy', '1990-09-15', '061203748420', '0901256789', 'thuyhoang@gmail.com', N'Bạc Liêu', 1, 9),
(N'Nguyễn Văn', N'Phúc', '1986-02-12', '071203679420', '0933456789', 'phucnguyen@gmail.com', N'Đồng Tháp', 0, 9),
(N'Phạm Thị', N'Trinh', '1994-11-21', '092203645420', '0905356789', 'trinhpham@gmail.com', N'Tiền Giang', 1, 9);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Vũ Thị', N'Mai', '1995-12-15', '087203658420', '0932556789', 'maivu@gmail.com', N'Kiên Giang', 0, 10),
(N'Nguyễn Thị', N'Trang', '1993-05-17', '082203641407', '0904356789', 'trangnguyen@mail.com', N'Vĩnh Long', 1, 10),
(N'Trần Thị', N'Dao', '1992-04-11', '091203687420', '0947456789', 'daotran@gmail.com', N'Bến Tre', 0, 10);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Thị', N'Mai', '1995-04-01', '021203685420', '0912001234', 'mainguyen@gmail.com', N'Hà Nội', 1, 12),
(N'Trần Văn', N'Hạnh', '1988-11-15', '021205875430', '0932551234', 'hanhtran@gmail.com', N'Quảng Ninh', 0, 12),
(N'Phạm Thị', N'Hương', '1991-02-27', '011203698420', '0912004567', 'huongpham@gmail.com', N'Hải Phòng', 1, 12);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Phạm Văn', N'Triều', '1990-09-20', '071203654780', '0912001111', 'trieupham@mail.com', N'Hải Dương', 1, 13),
(N'Trần Thị', N'Thu', '1992-12-02', '081203754320', '0902221111', 'thutran@gmail.com', N'Nghệ An', 0, 13),
(N'Nguyễn Văn', N'Nam', '1993-07-14', '091203654880', '0933331111', 'namnguyen@gmail.com', N'Thái Bình', 1, 13);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Vũ Văn', N'Hiếu', '1991-03-11', '061203654920', '0912442222', 'hieuvu@gmail.com', N'Thái Nguyên', 0, 14),
(N'Hoàng Thị', N'Bích', '1989-06-20', '071203754720', '0902552222', 'bichhoang@gmail.com', N'Lạng Sơn', 1, 14),
(N'Phan Thị', N'Hạnh', '1994-11-12', '081203654520', '0932662222', 'hanhphan@gmail.com', N'Bắc Giang', 0, 14);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Thị', N'Lan', '1995-10-05', '021203754120', '0912773333', 'lannguyen@mail.com', N'Hà Nam', 1, 15),
(N'Phạm Văn', N'Hoàng', '1992-05-21', '011203654420', '0902883333', 'hoangpham@gmail.com', N'Nam Định', 0, 15),
(N'Lê Văn', N'Bảo', '1988-01-15', '061203654720', '0932993333', 'baole@gmail.com', N'Hà Tĩnh', 1, 15);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Trần Văn', N'Hưng', '1993-09-11', '071203654530', '0912114444', 'hungtran@gmail.com', N'Quảng Bình', 0, 16),
(N'Nguyễn Thị', N'Hương', '1991-03-09', '081203654630', '0902444444', 'huongnguyen@mail.com', N'Hà Tĩnh', 1, 16),
(N'Phạm Văn', N'Dũng', '1989-08-19', '091203654920', '0932444444', 'dungpham@gmail.com', N'Quảng Trị', 0, 16);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Lê Thị', N'Bích', '1992-07-17', '021203754820', '0912555555', 'bichle@gmail.com', N'Huế', 1, 17),
(N'Nguyễn Văn', N'Khoa', '1990-12-21', '061203654520', '0902665555', 'khoanguyen@mail.com', N'Đà Nẵng', 0, 17),
(N'Phạm Thị', N'Trâm', '1994-05-30', '071203754920', '0932775555', 'trampham@gmail.com', N'Quảng Nam', 1, 17);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Trần Thị', N'Hoa', '1993-01-29', '021203754620', '0912886666', 'hoatran@mail.com', N'Quảng Ngãi', 0, 18),
(N'Lê Văn', N'Hải', '1991-04-22', '071203654420', '0902996666', 'hail@gmail.com', N'Bình Định', 1, 18),
(N'Phạm Văn', N'Sơn', '1995-02-15', '061203654620', '0932116666', 'sonpham@gmail.com', N'Phú Yên', 0, 18);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Thị', N'Yến', '1992-11-05', '011203654920', '0912337777', 'yennguyen@mail.com', N'Nha Trang', 1, 19),
(N'Trần Văn', N'Phước', '1989-07-23', '031203754920', '0902447777', 'phuoctran@gmail.com', N'Khánh Hòa', 0, 19),
(N'Lê Thị', N'Thu', '1994-06-17', '081203654420', '0932557777', 'thule@gmail.com', N'Ninh Thuận', 1, 19);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Phạm Văn', N'Tiến', '1990-12-03', '041203654820', '0912118888', 'tienpham@gmail.com', N'Bình Thuận', 0, 20),
(N'Nguyễn Thị', N'Hà', '1991-09-12', '051203754920', '0902228888', 'hanguyen@mail.com', N'Bình Dương', 1, 20),
(N'Trần Thị', N'Liên', '1993-10-09', '021203654620', '0932448888', 'lientran@gmail.com', N'Bình Phước', 0, 20);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Văn', N'Tùng', '1992-03-15', '041203654123', '0912341111', 'tungnguyen@mail.com', N'Hà Nội', 1, 21),
(N'Trần Thị', N'Thuý', '1994-07-19', '051203754321', '0902351111', 'thuytran@gmail.com', N'Hải Phòng', 0, 21),
(N'Lê Văn', N'Minh', '1990-08-05', '061203654124', '0932361111', 'minhle@gmail.com', N'Quảng Ninh', 1, 21);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Phạm Thị', N'Phương', '1989-06-10', '071203754654', '0912372222', 'phuongpham@gmail.com', N'Hòa Bình', 1, 22),
(N'Nguyễn Văn', N'Đạt', '1991-11-12', '081203654345', '0902382222', 'datnguyen@mail.com', N'Sơn La', 0, 22),
(N'Trần Thị', N'Lan', '1993-02-14', '091203754876', '0932392222', 'lantran@gmail.com', N'Lai Châu', 1, 22);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Văn', N'Hùng', '1990-04-07', '021203654567', '0912303333', 'hungnguyen@mail.com', N'Bắc Ninh', 0, 23),
(N'Phạm Thị', N'Vân', '1995-05-23', '031203754678', '0902313333', 'vanpham@gmail.com', N'Bắc Giang', 1, 23);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Phạm Văn', N'Quân', '1993-08-13', '051203654987', '0912334444', 'quanpham@mail.com', N'Yên Bái', 1, 24),
(N'Nguyễn Thị', N'Hạnh', '1991-01-25', '061203754432', '0902344444', 'hanhnguyen@gmail.com', N'Lào Cai', 0, 24),
(N'Lê Thị', N'Phượng', '1992-12-01', '071203654321', '0932354444', 'phuongle@gmail.com', N'Tuyên Quang', 1, 24);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Trần Văn', N'Hoàng', '1994-06-18', '081203654654', '0912365555', 'hoangtran@mail.com', N'Phú Thọ', 0, 25),
(N'Phạm Văn', N'Nam', '1990-10-30', '091203754765', '0902375555', 'nampham@gmail.com', N'Hòa Bình', 1, 25),
(N'Nguyễn Thị', N'Tuyết', '1995-11-06', '021203654234', '0932385555', 'tuyetnguyen@gmail.com', N'Thái Nguyên', 0, 25);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Lê Thị', N'Giang', '1992-02-22', '031203654098', '0912396666', 'giangle@mail.com', N'Cao Bằng', 1, 26),
(N'Trần Văn', N'Quyết', '1991-03-14', '041203754109', '0902406666', 'quyettran@gmail.com', N'Lạng Sơn', 0, 26),
(N'Nguyễn Văn', N'Vinh', '1993-07-30', '051203654210', '0932416666', 'vinhnguyen@gmail.com', N'Tuyên Quang', 1, 26);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Phạm Văn', N'Duy', '1989-11-20', '061203654321', '0912427777', 'duypham@mail.com', N'Lào Cai', 0, 27),
(N'Nguyễn Thị', N'Hoa', '1995-05-29', '071203754432', '0902437777', 'hoanguyen@gmail.com', N'Lai Châu', 1, 27),
(N'Lê Văn', N'Tuấn', '1992-09-16', '081203654543', '0932447777', 'tuanle@gmail.com', N'Điện Biên', 0, 27);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Trần Thị', N'Hiền', '1990-04-04', '091203654876', '0912458888', 'hientran@mail.com', N'Sơn La', 1, 28),
(N'Nguyễn Văn', N'Tiến', '1993-07-01', '021203754987', '0902468888', 'tiennguyen@gmail.com', N'Bắc Kạn', 0, 28),
(N'Phạm Văn', N'Khánh', '1992-08-23', '031203654432', '0932478888', 'khanhpham@gmail.com', N'Yên Bái', 1, 28);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Lê Văn', N'Phong', '1989-10-27', '041203654321', '0912489999', 'phongle@mail.com', N'Phú Thọ', 0, 29),
(N'Nguyễn Thị', N'Nhung', '1994-01-15', '051203754432', '0902499999', 'nhungnguyen@gmail.com', N'Tuyên Quang', 1, 29),
(N'Trần Văn', N'Hòa', '1995-06-11', '061203654543', '0932509999', 'hoatran@gmail.com', N'Lạng Sơn', 0, 29);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Phạm Thị', N'Hương', '1990-03-05', '071203654876', '0912510000', 'huongpham@mail.com', N'Cao Bằng', 1, 30),
(N'Nguyễn Văn', N'Khải', '1991-09-13', '081203754654', '0902520000', 'khai.nguyen@gmail.com', N'Lào Cai', 0, 30),
(N'Lê Thị', N'Ngọc', '1993-12-07', '091203654765', '0932530000', 'ngocle@gmail.com', N'Lai Châu', 1, 30);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Trần Văn', N'Phong', '1990-01-01', '301203654321', '0912311000', 'phongtran@mail.com', N'Hà Nội', 0, 31),
(N'Nguyễn Thị', N'Lan', '1992-03-02', '301203754432', '0902321000', 'lannguyen@gmail.com', N'Hải Phòng', 1, 31),
(N'Lê Văn', N'Thắng', '1989-07-23', '301203654543', '0932331000', 'thangle@gmail.com', N'Bắc Ninh', 1, 31);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Văn', N'Tú', '1991-04-10', '301203654654', '0912342000', 'tunguyen@mail.com', N'Lào Cai', 1, 32),
(N'Phạm Thị', N'Mai', '1993-05-12', '301203754765', '0902352000', 'maipham@gmail.com', N'Sơn La', 0, 32),
(N'Trần Văn', N'Trung', '1988-08-08', '301203654876', '0932362000', 'trungtran@gmail.com', N'Hòa Bình', 0, 32);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Văn', N'Tuấn', '1988-04-10', '301203123456', '0902001111', 'tuannguyen@mail.com', N'Hà Nội', 0, 33),
(N'Trần Thị', N'Thảo', '1991-06-22', '301203123789', '0903002222', 'thaotran@gmail.com', N'Hải Phòng', 1, 33),
(N'Phạm Văn', N'Thắng', '1995-08-30', '301203456123', '0934003333', 'thangpham@mail.com', N'Ninh Bình', 1, 33);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Lê Văn', N'Tú', '1990-09-15', '301203654789', '0915004444', 'tule@gmail.com', N'Hà Nam', 0, 45),
(N'Nguyễn Thị', N'Hà', '1992-10-05', '301203789654', '0906005555', 'hanguyen@mail.com', N'Lào Cai', 1, 45),
(N'Trần Văn', N'Bảo', '1985-12-10', '301203321654', '0937006666', 'baotran@gmail.com', N'Bắc Giang', 1, 45);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Phạm Văn', N'Tùng', '1993-05-11', '301203654321', '0901007777', 'tungpham@gmail.com', N'Thái Bình', 1, 68),
(N'Nguyễn Thị', N'Hồng', '1991-08-17', '301203876543', '0918008888', 'hongnguyen@mail.com', N'Thái Nguyên', 0, 68),
(N'Trần Văn', N'Sơn', '1994-11-20', '301203987654', '0939009999', 'sontran@mail.com', N'Bắc Kạn', 0, 68);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Lê Thị', N'Hoa', '1987-03-03', '301203234567', '0912010101', 'hoale@gmail.com', N'Hà Nội', 1, 102),
(N'Nguyễn Văn', N'Hoàng', '1990-07-25', '301203345678', '0902020202', 'hoangnguyen@mail.com', N'Hải Dương', 0, 102),
(N'Trần Văn', N'Trường', '1995-12-12', '301203456789', '0932030303', 'truongtran@gmail.com', N'Quảng Ninh', 1, 102);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Thị', N'Mai', '1991-04-04', '301203567890', '0912040404', 'mainguyen@gmail.com', N'Hưng Yên', 0, 156),
(N'Phạm Văn', N'Tuấn', '1989-06-06', '301203678901', '0902050505', 'tuanpham@gmail.com', N'Hà Tĩnh', 1, 156),
(N'Trần Thị', N'Lan', '1993-08-08', '301203789012', '0932060606', 'lantran@gmail.com', N'Hà Nội', 0, 156);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Nguyễn Văn', N'Hùng', '1990-02-14', '301203890123', '0912070707', 'hungnguyen@mail.com', N'Bắc Ninh', 0, 175),
(N'Phạm Thị', N'Tuyết', '1988-10-10', '301203901234', '0902080808', 'tuyetpham@gmail.com', N'Hòa Bình', 1, 175),
(N'Trần Văn', N'Phúc', '1992-12-12', '301203012345', '0932090909', 'phuctran@gmail.com', N'Thái Bình', 1, 175);
INSERT INTO KhachHang (Ho, Ten, NamSinh, CCCD, SDT, Email, QueQuan, SoXe, MaPhong) VALUES
(N'Lê Thị', N'Minh', '1991-11-11', '301203123098', '0912101010', 'minhle@gmail.com', N'Hải Phòng', 0, 198),
(N'Nguyễn Văn', N'Phong', '1993-09-09', '301203234109', '0902111111', 'phongnguyen@mail.com', N'Bắc Giang', 1, 198),
(N'Trần Thị', N'Bích', '1990-01-01', '301203345210', '0932121212', 'bichtran@gmail.com', N'Nam Định', 0, 198);
