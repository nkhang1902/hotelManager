create database QLKhachSan;	
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