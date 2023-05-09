﻿create database QLKhachSan;	
use QLKhachSan;
create table KhachHang(
    CMND varchar(10),
    DiaChiKH nvarchar(50),
    EmailKH VARCHAR(30),
    HoTenKH NVARCHAR(30),
    NgaySinhKH date,
    SdtKH char(10),
    SoFAX char(10),

    MaDoan INT,
    constraint pk_khachhang
    primary key (CMND)
);

create table KhachDat(
    CMND varchar(10),
    MaPhongDat INT,
    KhungGio date,

    constraint pk_khachdat
    primary key (CMND,MaPhongDat,KhungGio)
);

create table NhanVien(
    MaNV INT IDENTITY(1,1),
    Loai int,
    HoTenNV nvarchar(30),
	DiaChiNV nvarchar(50),
	EmailNV VARCHAR(30),
	SdtNV char(10),
    constraint pk_nhanvien
    primary key (MaNV)

);

create table Phong(
    MaPhong INT,
    LoaiPhong CHAR(10),
    TrangThaiDat varchar(10),
    GiaPhong float,
	TrangThaiVS varchar(10),
	SoLuongNguoi int,
    constraint pk_phong
    PRIMARY key (MaPhong)
);

create table Doan(
    MaDoan INT IDENTITY(1,1), 
    TenDoan nvarchar(30),
    NguoiDaiDien varchar(10),
    SoLuong int,

    constraint pk_doan
    primary key (MaDoan)
);


create table DichVu(
    MaDV INT,
    LoaiDV int,
    TenDichVu varchar(30),
    GiaDV float,
	KhuyenMai int,
    Mota nvarchar(30),

    constraint pk_dichvu
    primary key (MaDV)
);

create table ThanhToan(
	MaTT INT IDENTITY(1,1),
	CMND varchar(10),
	MaNV INT,
	NgayTT date,
	SoTienTT int,
	PhuongThucTT varchar(10),
	
	constraint pk_ThanhToan
	primary key (MaTT)
);

create table PhieuDangKyCheckIn(
    MAPDKC INT IDENTITY(1,1),

    CMND varchar(10),
    MaNV INT,
    Yeucau nvarchar(100),
    NgayNhanPhong date,
    VanChuyen int,

    MaDP INT,
    constraint pk_PhieuDangKyCheckIn
    primary key (MAPDKC)
);

create table DVPhong(
    MaPhong INT,
    MaDV INT,

	constraint pk_DVPhong
	primary key (MaPhong,MaDV)
);
create table PhieuDangKyDichVu (
    MAPDKDV INT IDENTITY(1,1),
    CMND varchar(10),
    MaNV INT,
    PhiTamThoi float,
	NgayDangKy date,

    constraint pk_phieudkdichvu
    PRIMARY key (MAPDKDV)
);

create table ChiTietDichVuDangKy(
    MAPDKDV INT,
    MaDV INT,
	GiaDV int,

	constraint pk_ChiTietDichVuDangKy
    PRIMARY key (MAPDKDV,MaDV)
);

create table TraPhong (
    MATP INT IDENTITY(1,1),
    MaPhong INT,
    TinhTrangPhong nvarchar (50),
    NgayTraPhong date,
    MaNV INT,

    DanhGia nvarchar(50),
    MaPCI INT,
    CMND varchar(10), 
	TongTien float,

    constraint pk_TraPhong
    primary key (MATP)
);

create table DatPhong (
    MaDP INT IDENTITY(1,1),
    MaPhong INT,
    CMND varchar(10),
	MaNV INT,
	BaoGia int,
    NgayDP date,
    SoDemLuuTru int,
    YeuCauDatBiet nvarchar(100),
    MaDoan INT,
    SoLuongNguoi int,
    TienCoc int,

    constraint pk_datphong
    PRIMARY key (MaDP)
);

create table HoaDon (
    MaHD INT IDENTITY(1,1),
    CMND varchar(10),
    MaNV INT,
    TienThanhToan float,
    MaDP INT,
    MATP INT,
    MAPDKDV INT,

    constraint pk_hoadon
    PRIMARY key (MaHD)
);
alter table KhachHang
add constraint fk_khachhang_doan
    FOREIGN key (MaDoan) REFERENCES Doan(MaDoan);

alter table Doan
add constraint fk_doan_khachhang
    FOREIGN key (NguoiDaiDien) REFERENCES KhachHang(CMND);

alter table ThanhToan
add constraint fk_thanhtoan_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang(CMND) ,
    constraint fk_thanhtoan_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien(MaNV) ;

alter table PhieuDangKyCheckIn
add constraint fk_CI_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang(CMND),

   constraint fk_CI_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien(MaNV),

   constraint fk_CI_datphong
    FOREIGN key (MaDP) REFERENCES DatPhong(MaDP);

alter table DVPhong
add 
    constraint fk_DVPhong_phong
    FOREIGN key (MaPhong) REFERENCES phong(MaPhong),

   constraint fk_CI_dichvu
    FOREIGN key (MaDV) REFERENCES DichVu(MaDV);

alter table PhieuDangKyDichVu
add 
    constraint fk_PhieuDangKyDichVu_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien(MaNV),

    constraint fk_PhieuDangKyDichVu_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang(CMND);

alter table ChiTietDichVuDangKy
add 
    constraint fk_ChiTietDichVuDangKy_dichvu
    FOREIGN key (MaDV) REFERENCES DichVu(MaDV);

alter table TraPhong
add 
    constraint fk_TraPhong_phong
    FOREIGN key (MaPhong) REFERENCES Phong(MaPhong),

    constraint fk_TraPhong_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang(CMND),

	constraint fk_TraPhong_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien(MaNV),

    constraint fk_TraPhong_PhieuDangKyCheckIn
    FOREIGN key (MaPCI) REFERENCES PhieuDangKyCheckIn( MAPDKC);


alter table DatPhong
add 
    constraint fk_DatPhong_phong
    FOREIGN key (MaPhong) REFERENCES Phong(MaPhong),

    constraint fk_chitietdichvudangky_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang(CMND),

    constraint fk_chitietdichvudangky_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien(MaNV),

    constraint fk_chitietdichvudangky_doan
    FOREIGN key (MaDoan) REFERENCES Doan(MaDoan);

alter table HoaDon
add 
    constraint fk_HoaDon_PhieuDangKyDichVu
    FOREIGN key (MAPDKDV) REFERENCES PhieuDangKyDichVu(MAPDKDV),

    constraint fk_HoaDon_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang(CMND),

    constraint fk_HoaDon_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien(MaNV),

    constraint fk_chitietdichvudangky_datphong
    FOREIGN key (MaDP) REFERENCES DatPhong(MaDP),

    constraint fk_chitietdichvudangky_TraPhong
    FOREIGN key (MATP) REFERENCES TraPhong(MaTP);
    
alter table KhachDat
add 
    constraint fk_KhackDat_Khach
    FOREIGN key (CMND) REFERENCES KhachHang(CMND),

    constraint fk_KhachDat_Phong
    FOREIGN key (MaPhongDat) REFERENCES Phong(MaPhong);

	INSERT INTO KhachHang(CMND, HoTenKH, EmailKH, SdtKH) VALUES ('43258671', 'Bao Khanh', 'bkhanh@gmail.com', '093233123');
	INSERT INTO KhachHang(CMND, HoTenKH, EmailKH, SdtKH) VALUES ('12345678', 'Nhat Khang', 'nkhang@gmail.com', '037819202');
	INSERT INTO Phong(MaPhong,LoaiPhong, SoLuongNguoi, TrangThaiDat, GiaPhong, TrangThaiVS) VALUES (103,'Vip',4,'0','129.99','0');
	INSERT INTO Phong(MaPhong,LoaiPhong, SoLuongNguoi, TrangThaiDat, GiaPhong, TrangThaiVS) VALUES (302,'Thuong',4,'0','129.99','0');
	INSERT INTO KhachDat(CMND,MaPhongDat,KhungGio) VALUES ('43258671', 102, '2002-02-19');
	
	--Linh
	insert into KhachHang 
	values(1111111111,'Nguyen Van A','TP HCM', 'NguyenVanA@gmail.com','11-12-2002','0937123456','87654321',Null)
	insert into KhachHang 
	values(1234567891,'Nguyen Van B','HA NOI', 'NguyenVanB@gmail.com','12-5-2002','0909999999','87123456',Null)
	insert into KhachHang 
	values(2222222222,'Nguyen Van C','DA NANG', 'NguyenVanC@gmail.com','5-3-2002','0909876543','87111111',Null)
	
	insert into Doan (TenDoan ,NguoiDaiDien ,SoLuong )
	values('Doan 2','1111111111', 20)
	insert into Doan (TenDoan ,NguoiDaiDien ,SoLuong )
	values('Doan 3','2222222222', 10)
	
	
	
	--Minh Nhat
	INSERT INTO Phong(MaPhong,LoaiPhong, SoLuongNguoi, TrangThaiDat, GiaPhong, TrangThaiVS) VALUES (103,'Vip',4,'0','129.99','0');
	INSERT INTO Phong(MaPhong,LoaiPhong, SoLuongNguoi, TrangThaiDat, GiaPhong, TrangThaiVS) VALUES (302,'Thuong',4,'0','129.99','0');
	INSERT INTO Phong(MaPhong,LoaiPhong, SoLuongNguoi, TrangThaiDat, GiaPhong, TrangThaiVS) VALUES (201,'Vip',4,'0','500','0');
	INSERT INTO Phong(MaPhong,LoaiPhong, SoLuongNguoi, TrangThaiDat, GiaPhong, TrangThaiVS) VALUES (202,'Thuong',4,'0','100','0');
	INSERT INTO KhachHang(CMND, HoTenKH, EmailKH, SdtKH) VALUES ('9999999999', 'Minh Nhat', 'mnhat@gmail.com', '0999999999');
	INSERT INTO KhachHang(CMND, HoTenKH, EmailKH, SdtKH) VALUES ('8888888888', 'Chi Linh', 'clinh@gmail.com', '0378888888');

	insert into DichVu(MaDV, LoaiDV, TenDichVu, GiaDV, KhuyenMai, MoTa) values (1,0,'Bar',50,5,'di bar free')
	insert into DichVu(MaDV, LoaiDV, TenDichVu, GiaDV, KhuyenMai, MoTa) values (2,0,'Goft',100,10,'choi golf')
	insert into DichVu(MaDV, LoaiDV, TenDichVu, GiaDV, KhuyenMai, MoTa) values (3,0,'Bowling',50,5,'choi bowling')
	insert into DichVu(MaDV, LoaiDV, TenDichVu, GiaDV, KhuyenMai, MoTa) values (4,1,'Nhay du',200,0,'Nhay du tren cao')
	insert into DichVu(MaDV, LoaiDV, TenDichVu, GiaDV, KhuyenMai, MoTa) values (5,1,'Dua xe',100,5,'Dua xe dien')
	insert into DichVu(MaDV, LoaiDV, TenDichVu, GiaDV, KhuyenMai, MoTa) values (6,1,'Du thuyen',500,0,'Thue du thuyen 5h')
	insert into DichVu(MaDV, LoaiDV, TenDichVu, GiaDV, KhuyenMai, MoTa) values (7,1,'Tham quan nui',100,0,'Leo nui')
	

	insert into DVPhong(MaPhong,MaDV) values(201,1)
	insert into DVPhong(MaPhong,MaDV) values(201,2)
	insert into DVPhong(MaPhong,MaDV) values(201,3)
	insert into DVPhong(MaPhong,MaDV) values(302,1)
	


	SET IDENTITY_INSERT NhanVien ON
	insert into NhanVien(MaNV,Loai,HoTenNV,DiaChiNV,EmailNV,SdtNV) values(1,1,'ABC','123 Nguyen Van Cu, HCM','abc@gmail.com','3824872384')
	insert into NhanVien(MaNV,Loai,HoTenNV,DiaChiNV,EmailNV,SdtNV) values(2,2,'DEF','456 Nguyen Trai, HCM',null,null)
	insert into NhanVien(MaNV,Loai,HoTenNV,DiaChiNV,EmailNV,SdtNV) values(3,1,'GHI','123 CMT8, HCM',null,null)
	SET IDENTITY_INSERT NhanVien OFF
	
	SET IDENTITY_INSERT DatPhong ON
	insert into DatPhong(MaDP,MaPhong,CMND,MaNV, BaoGia,NgayDP,SoDemLuuTru,YeuCauDatBiet,MaDoan,SoLuongNguoi,TienCoc) values (1,201,'9999999999',1,1500,null,3,null,null,1,200)
	insert into DatPhong(MaDP,MaPhong,CMND,MaNV, BaoGia,NgayDP,SoDemLuuTru,YeuCauDatBiet,MaDoan,SoLuongNguoi,TienCoc) values (2,302,'8888888888',1,260,'2022-11-30',2,null,null,1,100)

	SET IDENTITY_INSERT DatPhong OFF
	
	
	--function create ma phieu check in va phieu dang ky dich vu
	CREATE FUNCTION dbo.TaoMaPDKCheckIn()
RETURNS INT
AS
BEGIN
    DECLARE @maxID INT
    SELECT @maxID = MAX(MAPDKC) FROM PhieuDangKyCheckIn
    RETURN ISNULL(@maxID, 0) + 1
END


CREATE FUNCTION dbo.TaoMaPDKDichVu()
RETURNS INT
AS
BEGIN
    DECLARE @maxID INT
    SELECT @maxID = MAX(MAPDKDV) FROM PhieuDangKyDichVu
    RETURN ISNULL(@maxID, 0) + 1
END
