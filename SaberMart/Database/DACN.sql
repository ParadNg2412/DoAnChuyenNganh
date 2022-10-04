--Tạo db
create database DACN

--Mở db
use DACN

--Xóa db
drop database DACN

set dateformat DMY

--Tao bang
--nhan vien
create table CHUCVU(
	MaCV nvarchar(50) primary key NOT NULL,
	TenCV nvarchar(50) NULL,
	Luong int
)

create table NHANVIEN(
	MaNV nvarchar(50) primary key NOT NULL,
	MaCV nvarchar(50) NULL,
	TenNV nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	SDT varchar(13) NULL,
	GioiTinh nvarchar(50) NULL,
	NgaySinh datetime NULL,
	Username nvarchar(50) NULL,
	MatKhau nvarchar(8) NULL,
	LoaiTK nvarchar(50) NULL
)
alter table NHANVIEN add constraint FK_NHANVIEN_CHUCVU foreign key (MaCV) references CHUCVU(MaCV)

--khach hang
create table KHACHHANG(
	MaKH nvarchar(50) primary key NOT NULL,
	TenKH nvarchar(50) NULL,
	NgaySinh datetime NULL,
	GioiTinh nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	SDT varchar(12) NULL,
	DiemTichLuy int NULL
)

--san pham
create table NHACUNGCAP(
	MaNCC nvarchar(50) primary key NOT NULL,
	TenNCC nvarchar(50) NULL,
	SDT varchar(13) NULL,
	DiaChi nvarchar(50) NULL
)

create table NHOMSANPHAM(
	MaNhom nvarchar(50) primary key NOT NULL,
	TenNhom nvarchar(50) NULL,
	PTTang int NULL
)

create table SANPHAM(
	MaSP nvarchar(50) primary key NOT NULL,
	MaNhom nvarchar(50) NULL,
	TenSP nvarchar(50) NULL,
	DonViTinh nvarchar(50) NULL,
	SLTon int NULL,
	GiaBan int NULL,
	GiaNhap int NULL,
	MaNCC nvarchar(50) NULL
)
alter table SANPHAM add constraint FK_SANPHAM_NHOMSANPHAM foreign key (MaNhom) references NHOMSANPHAM(MaNhom)
alter table SANPHAM add constraint FK_SANPHAM_NHACUNGCAP foreign key (MaNCC) references NHACUNGCAP(MaNCC)

--nhap hang
create table PHIEUNHAP(
	MaPN nvarchar(50) primary key NOT NULL,
	MaNCC nvarchar(50) NULL,
	MaNV nvarchar(50) NULL,
	NgayNhap datetime NULL,
	TongTienNhap int NULL
)
alter table PHIEUNHAP add constraint FK_PHIEUNHAP_NHACUNGCAP foreign key (MaNCC) references NHACUNGCAP(MaNCC)
alter table PHIEUNHAP add constraint FK_PHIEUNHAP_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV)

create table CHITIETPHIEUNHAP(
	MaPN nvarchar(50) NOT NULL,
	MaSP nvarchar(50) NOT NULL,
	SLNhap int NULL,
	DonGiaNhap int NULL,
	ThanhTienNhap int NULL,
	primary key (MaPN, MaSP)
)
alter table CHITIETPHIEUNHAP add constraint FK_CHITIETPHIEUNHAP_PHIEUNHAP foreign key (MaPN) references PHIEUNHAP(MaPN)
alter table CHITIETPHIEUNHAP add constraint FK_CHITIETPHIEUNHAP_SANPHAM foreign key (MaSP) references SANPHAM(MaSP)

--hoa don
create table HOADON(
	MaHD nvarchar(50) primary key NOT NULL,
	MaNV nvarchar(50) NULL,
	MaKH nvarchar(50) NULL,
	NgayBan datetime NULL,
	TongTienBan int NULL
)
alter table HOADON add constraint FK_HOADON_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH)
alter table HOADON add constraint FK_HOADON_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV)

create table CHITIETHOADON(
	MaHD nvarchar(50) NOT NULL,
	MaSP nvarchar(50) NOT NULL,
	SLBan int NULL,
	DonGiaBan int NULL,
	ThanhTienBan int NULL,
	primary key (MaHD, MaSP)
)
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_HOADON foreign key (MaHD) references HOADON(MaHD)
alter table CHITIETHOADON add constraint FK_CHITIETHOADON_SANPHAM foreign key (MaSP) references SANPHAM(MaSP)

--Xoa bang
drop table CHUCVU
drop table NHANVIEN
drop table KHACHHANG
drop table NHACUNGCAP
drop table NHOMSANPHAM
drop table SANPHAM
drop table PHIEUNHAP
drop table CHITIETPHIEUNHAP
drop table HOADON
drop table CHITIETHOADON

--Nhap du lieu
--nhan vien
insert into CHUCVU(MaCV, TenCV, Luong) values(N'CV01', N'Quản lý', 20000000)
insert into CHUCVU(MaCV, TenCV, Luong) values(N'CV02', N'Nhân viên bán hàng', 10000000)
insert into CHUCVU(MaCV, TenCV, Luong) values(N'CV03', N'Thu kho', 10000000)

insert into NHANVIEN(MaNV, MaCV, TenNV, DiaChi, SDT, GioiTinh, NgaySinh, Username, MatKhau, LoaiTK)
values(N'NV01', N'CV01', N'Đỗ Hoàng Long Vũ', N'Tp.HCM', '0946222412', N'Nam', '24/12/2001', N'longvu2412', N'2412@Vu1', N'Admin')
insert into NHANVIEN(MaNV, MaCV, TenNV, DiaChi, SDT, GioiTinh, NgaySinh, Username, MatKhau, LoaiTK)
values(N'NV02', N'CV02', N'Huỳnh Gia Bảo', N'Tp.HCM', '0947236431', N'Nam', '12/04/2001', N'giabao1204', N'1204@Bao', N'Nhân viên')
insert into NHANVIEN(MaNV, MaCV, TenNV, DiaChi, SDT, GioiTinh, NgaySinh, Username, MatKhau, LoaiTK)
values(N'NV03', N'CV03', N'Nguyễn Vũ Duy Khương', N'Tp.HCM', '03578356634', N'Nam', '12/04/2001', null, null, N'Thu kho')

select * from CHUCVU
select * from NHANVIEN

delete from CHUCVU
delete from NHANVIEN

--khach hang
insert into KHACHHANG(MaKH, TenKH, NgaySinh, DiaChi, SDT, DiemTichLuy, GioiTinh)
values(N'KH001', N'Nguyễn Văn A', '02/09/2000', N'Tp.HCM', '0638652362', 1, N'Nam')
insert into KHACHHANG(MaKH, TenKH, NgaySinh, DiaChi, SDT, DiemTichLuy, GioiTinh)
values(N'KH002', N'Lê Trần B', '17/06/2001', N'Đồng Nai', '0176437323', 2, N'Nữ')
insert into KHACHHANG(MaKH, TenKH, NgaySinh, DiaChi, SDT, DiemTichLuy, GioiTinh)
values(N'KH003', N'Trần Thị C', '20/10/2002', N'Thủ Đức', '0824653643', 4, N'Nữ')
insert into KHACHHANG(MaKH, TenKH, NgaySinh, DiaChi, SDT, DiemTichLuy, GioiTinh)
values(N'KH004', N'Nguyễn Quốc D', '25/09/2001', N'Tp.HCM', '0935164875', 2, N'Nam')

select * from KHACHHANG

delete from KHACHHANG

--san pham
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values(N'NCC1', N'Công ty sữa Vinamilk', N'02854155555', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values(N'NCC2', N'Công ty Acecook Việt Nam', N'02838154064', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values(N'NCC3', N'Công ty Coca Cola Việt Nam', N'02838961000', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values(N'NCC4', N'Công ty TNHH Thương mại & Sản xuất tra THP Plus', N'0907963239', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values(N'NCC5', N'Công ty THNN Nestlé Việt Nam', N'02839113737', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values(N'NCC6', N'Công ty TNHH MTV Cung Đình', N'02854120700', N'Tp.HCM')

insert into NHOMSANPHAM(MaNhom, TenNhom, PTTang) values (N'NSP1', N'Món ăn', 10)
insert into NHOMSANPHAM(MaNhom, TenNhom, PTTang) values (N'NSP2', N'Giải khát', 40)
insert into NHOMSANPHAM(MaNhom, TenNhom, PTTang) values (N'NSP3', N'Hàng hóa khác', 50)

insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP01', N'NSP2', N'Coca-Cola không đường', N'Chai lớn', 50, 10000, 10000, N'NCC3')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP02', N'NSP2', N'Coca-Cola không đường', N'Chai nhỏ', 50, 9000, 9000, N'NCC3')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP03', N'NSP2', N'Coca-Cola thường', N'Chai lớn', 50, 10000, 10000, N'NCC3')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP04', N'NSP2', N'Coca-Cola thường', N'Chai nhỏ', 50, 9000, 9000, N'NCC3')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP05', N'NSP1', N'Mỳ Modern Lẩu thái tôm', N'Ly', 50, 10000, 10000, N'NCC2')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP06', N'NSP1', N'Mỳ Cung Đình Lẩu tôm chua cay', N'Ly', 50, 10000, 10000, N'NCC6')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP07', N'NSP1', N'Mỳ Cung Đình Lẩu tôm chua cay', N'Gói', 50, 10000, 10000, N'NCC6')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP08', N'NSP2', N'Trà Olong TEA+ PLUS', N'Cai', 50, 10000, 10000, N'NCC4')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP09', N'NSP2', N'Sữa Milo', N'Hộp', 50, 15000, 15000, N'NCC5')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP10', N'NSP2', N'Sữa Vinamilk không đường', N'Hộp', 50, 11000, 11000, N'NCC1')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values(N'SP11', N'NSP2', N'Sữa Vinamilk có đường', N'Hộp', 50, 11000, 11000, N'NCC1')

select * from NHACUNGCAP
select * from NHOMSANPHAM
select * from SANPHAM

delete from NHACUNGCAP
delete from NHOMSANPHAM
delete from SANPHAM

--Nhap hang
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values(N'PN01', N'NCC1', N'NV03', '27/09/2022', 1100000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values(N'PN02', N'NCC2', N'NV03', '27/09/2022', 500000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values(N'PN03', N'NCC3', N'NV03', '27/09/2022', 3000000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values(N'PN04', N'NCC4', N'NV03', '27/09/2022', 500000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values(N'PN05', N'NCC5', N'NV03', '27/09/2022', 750000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values(N'PN06', N'NCC6', N'NV03', '27/09/2022', 1000000)

insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN01', N'SP10', 50, 11000, 550000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN01', N'SP11', 50, 11000, 550000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN02', N'SP05', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN03', N'SP01', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN03', N'SP02', 50, 9000, 450000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN03', N'SP03', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN03', N'SP04', 50, 9000, 450000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN04', N'SP08', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN05', N'SP09', 50, 15000, 750000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN06', N'SP06', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values(N'PN06', N'SP07', 50, 10000, 500000)

select * from PHIEUNHAP
select * from CHITIETPHIEUNHAP

delete from PHIEUNHAP
delete from CHITIETPHIEUNHAP

--hoa don
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values(N'HD01', N'NV02', N'KH001', '27/09/2022', 10000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values(N'HD02', N'NV02', N'KH002', '27/09/2022', 20000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values(N'HD03', N'NV02', N'KH003', '27/09/2022', 19000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values(N'HD04', N'NV02', N'KH004', '27/09/2022', 10000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values(N'HD05', N'NV02', N'KH001', '30/09/2022', 20000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values(N'HD06', N'NV02', N'KH003', '01/10/2022', 9000)

insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD01', 'SP01', 1, 10000, 10000)
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD02', 'SP06', 1, 10000, 10000)
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD02', 'SP08', 1, 10000, 10000)
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD03', 'SP04', 1, 9000, 9000)
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD03', 'SP03', 1, 10000, 10000)
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD04', 'SP05', 1, 10000, 10000)
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD05', 'SP08', 2, 10000, 10000)
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan)
values(N'HD06', 'SP02', 1, 9000, 9000)

select * from HOADON
select * from CHITIETHOADON

delete from HOADON
delete from CHITIETHOADON