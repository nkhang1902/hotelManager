create database QLKhachSan;
create table KhachHang(
    CMND varchar(10), --PK
    DiaChi nvarchar(50),
    Email VARCHAR(30),
    HoTenKH NVARCHAR(30),
    NgaySinh date,
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

    constraint pk_nhanvien
    primary key (MaNV)

);

create table Phong(
    MaPhong varchar(6),--PK
    LoaiPhong int, --toi da bao nhieu nguoi
    TrangThai nvarchar(10), --'co nguoi', 'chua don', 'da dat', 'san sang'
    GiaPhong float

    constraint pk_phong
    PRIMARY key (MaPhong)
);

create table Doan(
    MaDoan varchar(6), --PK
    TenDoan nvarchar(30),
    NguoiDaiDien varchar(6),--FK
    SoLuong int

    constraint pk_doan
    primary key (MaDoan)
);


create table DichVu(
    MaDV varchar(6), --PK
    LoaiDV int,
    TenDichVu varchar(30),
    GiaDV float,
    Mota nvarchar(30),

    constraint pk_dichvu
    primary key (MaDV)
);

create table Phieuvanchuyenhanhly(
    MaPhieuVC varchar(6),--PK
    MaNV varchar(6), --FK
    CMND varchar(10), --FK
    SoHanhLy int,
    MaPhong varchar(6) --FK

    constraint pk_phieuvanchuyen
    primary key(MaPhieuVC)
);


create table PhieuCheckIn(
    MaPCI varchar(6),--PK

    CMND varchar(10),--FK
    MaNV varchar(6),--FK
    Yeucau nvarchar(100),
    NgayNhanPhong date,
    HinhThucThanhToan varchar(4), --'cash' or 'card' or 'bank'

    MaDP varchar(6),--FK
    constraint pk_phieucheckin
    primary key (MaPCI)
);

create table DVPhong(
    MaPhong varchar(6),--FK
    MaDV varchar(6)--FK
);

create table PhieuDangKyDichVu (
    MAPDKDV varchar(6),--PK
    CMND varchar(10),--FK
    MaNV varchar(6),--FK
    TongTien float

    constraint pk_phieudkdichvu
    PRIMARY key (MAPDKDV)
);

create table ChiTietDichVuDangKy(
    MAPDKDV varchar(6),--FK
    MaDV varchar(6),--FK
);

create table PhieuCheckOut (
    MaPCO varchar(6),--PK
    MaPhong varchar(6),--FK
    TinhTrangPhong nvarchar (50),
    NgayTraPhong date,
    
    DanhGia nvarchar(50),
    MaPCI varchar(6),--FK
    CMND varchar(10), --FK
    PhiPhatSinh float

    constraint pk_phieucheckout
    primary key (MaPCO)
);

create table DatPhong (
    MaDP varchar(6),--PK
    MaPhong varchar(6),--FK
    CMND varchar(10),--FK
    NgayDen date,
    SoDemLuuTru int,
    LoaiPhong int,
    YeuCau nvarchar(100),
    MaDoan varchar(6),--FK
    SoLuong int,
    TienCoc float,
    Gia float

    constraint pk_datphong
    PRIMARY key (MaDP)
);

create table HoaDon (
    MaHD varchar(6),--PK
    CMND varchar(10),--FK
    MaNV varchar(6),--FK
    TenKhachHang nvarchar(30),
    TienThanhToan float,
    MaDP varchar(6),--FK
    MaPCO varchar(6),--FK
    MAPDKDV varchar(6) --FK

    constraint pk_hoadon
    PRIMARY key (MaHD)
);
alter table KhachHang
add 
    constraint fk_khachhang_doan
    FOREIGN key (MaDoan) REFERENCES Doan

alter table Phieuvanchuyenhanhly
add 
    CONSTRAINT fk_phieuvanchuyen_nhanvien 
    FOREIGN key (MaNV) REFERENCES NhanVien,

    CONSTRAINT fk_phieuvanchuyen_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    CONSTRAINT fk_phieuvanchuyen_phong 
    FOREIGN key (MaPhong) REFERENCES Phong


alter table PhieuCheckIn
add 
    constraint fk_phieucheckin_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien,

    constraint fk_phieucheckin_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    constraint fk_phieucheckin_datphong
    foreign key (MaDP) REFERENCES DatPhong

alter table DVPhong
add 
    constraint fk_dvphong_phong
    FOREIGN key (MaPhong) REFERENCES Phong,

    constraint fk_dvphong_dichvu
    FOREIGN key (MaDV) REFERENCES DichVu

alter table PhieuDangKyDichVu
add 
    constraint fk_pdkdv_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien,

    constraint fk_pdkdv_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang


alter table ChiTietDichVuDangKy
add 
    constraint fk_chitietdichvudangky_pdkdv
    FOREIGN key (MAPDKDV) REFERENCES PhieuDangKyDichVu,

    constraint fk_chitietdichvudangky_dichvu
    FOREIGN key (MaDV) REFERENCES DichVu

alter table PhieuCheckOut
add     
    constraint fk_pco_pci
    FOREIGN key (MaPCI) REFERENCES PhieuCheckIn,

    constraint fk_pco_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    constraint fk_pco_phong
    FOREIGN key (MaPhong) REFERENCES Phong

alter table DatPhong
add
    constraint fk_datphong_phong
    FOREIGN key (MaPhong) REFERENCES Phong,

    constraint fk_datphong_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    constraint fk_datphong_doan
    FOREIGN key (MaDoan) REFERENCES Doan

alter table HoaDon
add
    constraint fk_hoadon_datphong
    FOREIGN key (MaDP) REFERENCES DatPhong,

    constraint fk_hoadon_khachhang
    FOREIGN key (CMND) REFERENCES KhachHang,

    CONSTRAINT fk_hoadon_pco
    foreign key (MaPCO) REFERENCES PhieuCheckOut,

    constraint fk_hoadon_nhanvien
    FOREIGN key (MaNV) REFERENCES NhanVien,

    CONSTRAINT fk_hoadon_phieudangkydichvu
    FOREIGN key (MAPDKDV) REFERENCES PhieuDangKyDichVu

alter table ChiTietDoan
add 
    constraint fk_chitietdoan_doan
    foreign key (MaDoan) REFERENCES Doan