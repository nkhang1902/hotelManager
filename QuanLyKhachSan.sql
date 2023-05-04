create database QLKhachSan;	
use QLKhachSan;
create table KhachHang(
    CMND varchar(10), --PK
    DiaChiKH nvarchar(50),
    EmailKH VARCHAR(30),
    HoTenKH NVARCHAR(30),
    NgaySinhKH date,
    SdtKH char(10),
    SoFAX char(10),

    MaDoan varchar(6), --FK
    constraint pk_khachhang
    primary key (CMND)
);

create table NhanVien(
    MaNV varchar(6),--PK
    Loai int,
    HoTenNV nvarchar(30),
	DiaChiNV nvarchar(50),
	EmailNV VARCHAR(30),
	SdtNV char(10),
    constraint pk_nhanvien
    primary key (MaNV)

);

create table Phong(
    MaPhong varchar(6),--PK
    LoaiPhong int,
    TrangThaiDat varchar(10), --'co nguoi', 'chua don', 'da dat', 'san sang'
    GiaPhong float,
	TrangThaiVS varchar(10),
	SoLuongNguoi int,
    constraint pk_phong
    PRIMARY key (MaPhong)
);

create table Doan(
    MaDoan varchar(6), --PK
    TenDoan nvarchar(30),
    NguoiDaiDien varchar(10),--FK
    SoLuong int

    constraint pk_doan
    primary key (MaDoan)
);


create table DichVu(
    MaDV varchar(6), --PK
    LoaiDV int,
    TenDichVu varchar(30),
    GiaDV float,
	KhuyenMai int,
    Mota nvarchar(30),

    constraint pk_dichvu
    primary key (MaDV)
);

create table ThanhToan(
	MaTT varchar(6),
	CMND varchar(10),
	MaNV varchar(6),
	NgayTT date,
	SoTienTT int,
	PhuongThucTT varchar(10)
	
	constraint pk_ThanhToan
	primary key (MaTT)
);

create table PhieuDangKyCheckIn(
    MAPDKC varchar(6),--PK

    CMND varchar(10),--FK
    MaNV varchar(6),--FK
    Yeucau nvarchar(100),
    NgayNhanPhong date,
    VanChuyen int, --1: co, 0: khong van chuyen

    MaDP varchar(6),--FK
    constraint pk_PhieuDangKyCheckIn
    primary key (MAPDKC)
);

create table DVPhong(
    MaPhong varchar(6),--pK
    MaDV varchar(6)--pK

	constraint pk_DVPhong
	primary key (MaPhong,MaDV)
);
create table PhieuDangKyDichVu (
    MAPDKDV varchar(6),--PK
    CMND varchar(10),--FK
    MaNV varchar(6),--FK
    PhiTamThoi float,
	NgayDangKy date

    constraint pk_phieudkdichvu
    PRIMARY key (MAPDKDV)
);

create table ChiTietDichVuDangKy(
    MAPDKDV varchar(6),--FK
    MaDV varchar(6),--FK
	GiaDV int

	constraint pk_ChiTietDichVuDangKy
    PRIMARY key (MAPDKDV,MaDV)
);

create table TraPhong (
    MATP varchar(6),--PK
    MaPhong varchar(6),--FK
    TinhTrangPhong nvarchar (50),
    NgayTraPhong date,
    MaNV varchar(6),

    DanhGia nvarchar(50),
    MaPCI varchar(6),--FK
    CMND varchar(10), --FK
	TongTien float

    constraint pk_TraPhong
    primary key (MATP)
);

create table DatPhong (
    MaDP varchar(6),--PK
    MaPhong varchar(6),--FK
    CMND varchar(10),--FK
	MaNV varchar(6),
	BaoGia int,
    NgayDP date,
    SoDemLuuTru int,
    YeuCauDatBiet nvarchar(100),
    MaDoan varchar(6),--FK
    SoLuongNguoi int,
    TienCoc int,

    constraint pk_datphong
    PRIMARY key (MaDP)
);

create table HoaDon (
    MaHD varchar(6),--PK
    CMND varchar(10),--FK
    MaNV varchar(6),--FK
    TienThanhToan float,
    MaDP varchar(6),--FK
    MATP varchar(6),--FK
    MAPDKDV varchar(6) --FK

    constraint pk_hoadon
    PRIMARY key (MaHD)
);
alter table KhachHang
add 
    constraint fk_khachhang_doan
    FOREIGN key (MaDoan) REFERENCES Doan

alter table Doan
add 
    constraint fk_doan_khachhang
    FOREIGN key (NguoiDaiDien) REFERENCES KhachHang

alter table ThanhToan
add 
    constraint fk_thanhtoan_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    constraint fk_thanhtoan_nhanvien
    FOREIGN key (MANV) REFERENCES NhanVien

alter table PhieuDangKyCheckIn
add 
    constraint fk_CI_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    constraint fk_CI_nhanvien
    FOREIGN key (MANV) REFERENCES NhanVien,

    constraint fk_CI_datphong
    FOREIGN key (MaDP) REFERENCES DatPhong

alter table DVPhong
add 
    constraint fk_DVPhong_phong
    FOREIGN key (MaPhong) REFERENCES phong,

    constraint fk_CI_dichvu
    FOREIGN key (MaDV) REFERENCES DichVu

alter table PhieuDangKyDichVu
add 
    constraint fk_PhieuDangKyDichVu_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien,

    constraint fk_PhieuDangKyDichVu_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang

alter table ChiTietDichVuDangKy
add 
    constraint fk_ChiTietDichVuDangKy_dichvu
    FOREIGN key (MaDV) REFERENCES DichVu

alter table TraPhong
add 
    constraint fk_TraPhong_phong
    FOREIGN key (MaPhong) REFERENCES Phong,

    constraint fk_TraPhong_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

	constraint fk_TraPhong_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien,

	constraint fk_TraPhong_PhieuDangKyCheckIn
    FOREIGN key (MaPCI) REFERENCES PhieuDangKyCheckIn


alter table DatPhong
add 
    constraint fk_DatPhong_phong
    FOREIGN key (MaPhong) REFERENCES Phong,

    constraint fk_chitietdichvudangky_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    constraint fk_chitietdichvudangky_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien,

    constraint fk_chitietdichvudangky_doan
    FOREIGN key (MaDoan) REFERENCES Doan

alter table HoaDon
add 
    constraint fk_HoaDon_PhieuDangKyDichVu
    FOREIGN key (MAPDKDV) REFERENCES PhieuDangKyDichVu,

    constraint fk_HoaDon_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    constraint fk_HoaDon_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien,

    constraint fk_chitietdichvudangky_datphong
    FOREIGN key (MaDP) REFERENCES DatPhong,

    constraint fk_chitietdichvudangky_TraPhong
    FOREIGN key (MATP) REFERENCES TraPhong

--Tu Sinh Ma KhachHang ( chưa hoàn thành)
drop function KhachHang_MaPhong

create function KhachHang_MaPhong()
returns varchar(6)
as
begin
	declare @ma_next varchar(6)
	declare @max int

	select @max=count(MaPhong) from Phong where MaPhong like 'PH'
	set @ma_next='PH' + RIGHT('0' + cast (@max as varchar(4)),4)

	while(exists(select MaPhong from Phong where MaPhong=@ma_next))
	begin
		set @max=@max+1
		set @ma_next='PH' + RIGHT('0' + cast (@max as varchar(6)),1)
	end
	return @ma_next
end;

declare @temp varchar(6)
exec @temp = dbo.KhachHang_MaPhong
print @temp
