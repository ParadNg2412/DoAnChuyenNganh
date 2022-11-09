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
	MaCV varchar(5) primary key NOT NULL,
	TenCV nvarchar(50) NULL,
	Luong int
)

create table NHANVIEN(
	MaNV varchar(5) primary key NOT NULL,
	MaCV varchar(5) NULL,
	TenNV nvarchar(50) NULL,
	DiaChi nvarchar(50) NULL,
	SDT varchar(13) NULL,
	GioiTinh nvarchar(5) NULL,
	NgaySinh date NULL,
	Username varchar(20) NULL,
	MatKhau varchar(8) NULL,
	LoaiTK nvarchar(50) NULL
)
alter table NHANVIEN
add constraint FK_NHANVIEN_CHUCVU foreign key (MaCV) references CHUCVU(MaCV)

--khach hang
create table KHACHHANG(
	MaKH varchar(5) primary key NOT NULL,
	TenKH nvarchar(50) NULL,
	NgaySinh date NULL,
	GioiTinh nvarchar(5) NULL,
	DiaChi nvarchar(50) NULL,
	SDT varchar(10) NULL,
	DiemTichLuy int NULL
)

--san pham
create table NHACUNGCAP(
	MaNCC varchar(5) primary key NOT NULL,
	TenNCC nvarchar(50) NULL,
	SDT varchar(12) NULL,
	DiaChi nvarchar(50) NULL
)

create table NHOMSANPHAM(
	MaNhom varchar(5) primary key NOT NULL,
	TenNhom nvarchar(50) NULL
	
)
--PTTang int NULL
create table SANPHAM(
	MaSP varchar(5) primary key NOT NULL,
	MaNhom varchar(5) NULL,
	TenSP nvarchar(50) NULL,
	PicSP image NULL,
	DonViTinh nvarchar(50) NULL,
	SLTon int NULL,
	GiaBan int NULL,
	GiaNhap int NULL,
	MaNCC varchar(5) NULL
)
alter table SANPHAM
add constraint FK_SANPHAM_NHOMSANPHAM foreign key (MaNhom) references NHOMSANPHAM(MaNhom)
alter table SANPHAM
add constraint FK_SANPHAM_NHACUNGCAP foreign key (MaNCC) references NHACUNGCAP(MaNCC)

--nhap hang
create table PHIEUNHAP(
	MaPN varchar(5) primary key NOT NULL,
	MaNCC varchar(5) NULL,
	MaNV varchar(5) NULL,
	NgayNhap date NULL,
	TongTienNhap int NULL
)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHACUNGCAP foreign key (MaNCC) references NHACUNGCAP(MaNCC)
alter table PHIEUNHAP
add constraint FK_PHIEUNHAP_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV)

create table CHITIETPHIEUNHAP(
	MaPN varchar(5) NOT NULL,
	MaSP varchar(5) NOT NULL,
	SLNhap int NULL,
	DonGiaNhap int NULL,
	ThanhTienNhap int NULL,
	primary key (MaPN, MaSP)
)
alter table CHITIETPHIEUNHAP
add constraint FK_CHITIETPHIEUNHAP_PHIEUNHAP foreign key (MaPN) references PHIEUNHAP(MaPN)
alter table CHITIETPHIEUNHAP
add constraint FK_CHITIETPHIEUNHAP_SANPHAM foreign key (MaSP) references SANPHAM(MaSP)

--hoa don
create table HOADON(
	MaHD varchar(5) primary key NOT NULL,
	MaNV varchar(5) NULL,
	MaKH varchar(5) NULL,
	NgayBan date NULL,
	TongTienBan int NULL
)
alter table HOADON
add constraint FK_HOADON_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH)
alter table HOADON
add constraint FK_HOADON_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV)

create table CHITIETHOADON(
	MaHD varchar(5) NOT NULL,
	MaSP varchar(5) NOT NULL,
	SLBan int NULL,
	NgayBan date NULL,
	DonGiaBan int NULL,
	ThanhTienBan int NULL,
	primary key (MaHD, MaSP)
)
alter table CHITIETHOADON
add constraint FK_CHITIETHOADON_HOADON foreign key (MaHD) references HOADON(MaHD)
alter table CHITIETHOADON
add constraint FK_CHITIETHOADON_SANPHAM foreign key (MaSP) references SANPHAM(MaSP)

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
insert into CHUCVU(MaCV, TenCV, Luong) values('CV001', N'Quản lý', 20000000)
insert into CHUCVU(MaCV, TenCV, Luong) values('CV002', N'Nhân viên bán hàng', 10000000)
insert into CHUCVU(MaCV, TenCV, Luong) values('CV003', N'Thu kho', 10000000)

insert into NHANVIEN(MaNV, MaCV, TenNV, DiaChi, SDT, GioiTinh, NgaySinh, Username, MatKhau, LoaiTK)
values('NV001', 'CV001', N'Đỗ Hoàng Long Vũ', N'Tp.HCM', '0946222412', N'Nam', '24/12/2001', 'longvu2412', '2412@Vu1', N'Admin')
insert into NHANVIEN(MaNV, MaCV, TenNV, DiaChi, SDT, GioiTinh, NgaySinh, Username, MatKhau, LoaiTK)
values('NV002', 'CV002', N'Huỳnh Gia Bảo', N'Tp.HCM', '0947236431', N'Nam', '12/04/2001', 'giabao1204', '1204@Bao', N'Nhân viên')
insert into NHANVIEN(MaNV, MaCV, TenNV, DiaChi, SDT, GioiTinh, NgaySinh, Username, MatKhau, LoaiTK)
values('NV003', 'CV003', N'Nguyễn Vũ Duy Khương', N'Tp.HCM', '03578356634', N'Nam', '12/04/2001', null, null, null)

select * from CHUCVU
select * from NHANVIEN

delete from CHUCVU
delete from NHANVIEN

--khach hang
insert into KHACHHANG(MaKH, TenKH, NgaySinh, GioiTinh, DiaChi, SDT, DiemTichLuy)
values('KH001', N'Nguyễn Văn A', '02/09/2000', N'Nam', N'Tp.HCM', '0638652362', 1)
insert into KHACHHANG(MaKH, TenKH, NgaySinh, GioiTinh, DiaChi, SDT, DiemTichLuy)
values('KH002', N'Lê Trần B', '17/06/2001', N'Nữ', N'Đồng Nai', '0176437323', 2)
insert into KHACHHANG(MaKH, TenKH, NgaySinh, GioiTinh, DiaChi, SDT, DiemTichLuy)
values('KH003', N'Trần Thị C', '20/10/2002', N'Nữ', N'Thủ Đức', '0824653643', 4)
insert into KHACHHANG(MaKH, TenKH, NgaySinh, GioiTinh, DiaChi, SDT, DiemTichLuy)
values('KH004', N'Nguyễn Quốc D', '25/09/2001', N'Nam', N'Tp.HCM', '0935164875', 2)

select * from KHACHHANG

delete from KHACHHANG

--san pham
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values('NCC01', N'Công ty sữa Vinamilk', '02854155555', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values('NCC02', N'Công ty Acecook Việt Nam', '02838154064', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values('NCC03', N'Công ty Coca Cola Việt Nam', '02838961000', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values('NCC04', N'Công ty TNHH Thương mại & Sản xuất tra THP Plus', '0907963239', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values('NCC05', N'Công ty THNN Nestlé Việt Nam', '02839113737', N'Tp.HCM')
insert into NHACUNGCAP(MaNCC, TenNCC, SDT, DiaChi)
values('NCC06', N'Công ty TNHH MTV Cung Đình', '02854120700', N'Tp.HCM')

insert into NHOMSANPHAM(MaNhom, TenNhom) values (N'NSP01', N'Món ăn')
insert into NHOMSANPHAM(MaNhom, TenNhom) values (N'NSP02', N'Giải khát')
insert into NHOMSANPHAM(MaNhom, TenNhom) values (N'NSP03', N'Hàng hóa khác')

insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP001', 'NSP02', N'Coca-Cola không đường chai 600ml', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/CocaKhongDuongChaiLon.png', N'Chai', 50, 10000, 10000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP002', 'NSP02', N'Coca-Cola không đường chai 500ml', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/CocaKhongDuongChaiNho.png', N'Chai', 50, 9000, 9000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP003', 'NSP02', N'Coca-Cola thường chai 600ml', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/CocaThuongChaiLon.png', N'Chai', 50, 10000, 10000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP004', 'NSP02', N'Coca-Cola thường cahi 500ml', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/CocaThuongChaiNho.png', N'Chai', 50, 9000, 9000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP005', 'NSP01', N'Mì Modern Lẩu thái tôm', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/MiLyModernLauThaiTom.png', N'Ly', 50, 10000, 10000, 'NCC02')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP006', 'NSP01', N'Mỳ Cung Đình Lẩu tôm chua cay', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/MiLyCungDinh.png', N'Ly', 50, 10000, 10000, 'NCC06')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP007', 'NSP01', N'Mỳ Cung Đình Lẩu tôm chua cay', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/MiGoiCungDinh.png', N'Gói', 50, 10000, 10000, 'NCC06')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP008', 'NSP02', N'Trà Olong TEA+ PLUS', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/TraOlongTeaPlus.png', N'Chai', 50, 10000, 10000, 'NCC04')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP009', 'NSP02', N'Sữa Milo nắp vặn', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/MiloNapVan.png', N'Hộp', 50, 15000, 15000, 'NCC05')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP010', 'NSP02', N'Sữa Vinamilk tiệt trùng không đường', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/VinamilkKhongDuong.png', N'Hộp', 50, 11000, 11000, 'NCC01')
insert into SANPHAM(MaSP, MaNhom, TenSP, PicSP, DonViTinh, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP011', 'NSP02', N'Sữa Vinamilk tiệt trùng có đường', 'D:/Đồ án chuyên ngành/DoAnChuyenNganh/SaberMart/Database/PicSP/VinamilkCoDuong.png', N'Hộp', 50, 11000, 11000, 'NCC01')

select * from NHACUNGCAP
select * from NHOMSANPHAM
select * from SANPHAM

delete from NHACUNGCAP
delete from NHOMSANPHAM
delete from SANPHAM

--Nhap hang
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values('PN001', 'NCC01', 'NV003', '27/09/2022', 1100000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values('PN002', 'NCC02', 'NV003', '27/09/2022', 500000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values('PN003', 'NCC03', 'NV003', '27/09/2022', 3000000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values('PN004', 'NCC04', 'NV003', '27/09/2022', 500000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values('PN005', 'NCC05', 'NV003', '27/09/2022', 750000)
insert into PHIEUNHAP(MaPN, MaNCC, MaNV, NgayNhap, TongTienNhap)
values('PN006', 'NCC06', 'NV003', '27/09/2022', 1000000)

insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN001', 'SP010', 50, 11000, 550000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN001', 'SP011', 50, 11000, 550000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN002', 'SP005', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN003', 'SP001', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN003', 'SP002', 50, 9000, 450000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN003', 'SP003', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN003', 'SP004', 50, 9000, 450000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN004', 'SP008', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN005', 'SP009', 50, 15000, 750000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN006', 'SP006', 50, 10000, 500000)
insert into CHITIETPHIEUNHAP(MaPN, MaSP, SLNhap, DonGiaNhap, ThanhTienNhap)
values('PN006', 'SP007', 50, 10000, 500000)

select * from PHIEUNHAP
select * from CHITIETPHIEUNHAP

delete from PHIEUNHAP
delete from CHITIETPHIEUNHAP

--hoa don
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values('HD001', 'NV002', 'KH001', '27/09/2022', 10000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values('HD002', 'NV002', 'KH002', '27/09/2022', 20000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values('HD003', 'NV002', 'KH003', '27/09/2022', 19000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values('HD004', 'NV002', 'KH004', '27/09/2022', 10000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values('HD005', 'NV002', 'KH001', '30/09/2022', 20000)
insert into HOADON(MaHD, MaNV, MaKH, NgayBan, TongTienBan)
values('HD006', 'NV002', 'KH003', '01/10/2022', 9000)

insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD001', 'SP001', 1, 10000, 10000, '27/09/2022')
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD002', 'SP006', 1, 10000, 10000, '27/09/2022')
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD002', 'SP008', 1, 10000, 10000, '27/09/2022')
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD003', 'SP004', 1, 9000, 9000, '27/09/2022')
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD003', 'SP003', 1, 10000, 10000, '27/09/2022')
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD004', 'SP005', 1, 10000, 10000, '27/09/2022')
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD005', 'SP008', 2, 10000, 20000, '30/09/2022')
insert into CHITIETHOADON(MaHD, MaSP, SLBan, DonGiaBan, ThanhTienBan, NgayBan)
values('HD006', 'SP002', 1, 9000, 9000, '01/10/2022')

select * from HOADON
select * from CHITIETHOADON

delete from HOADON
delete from CHITIETHOADON

select H.MaHD as [Mã hóa đơn], sum(CT.ThanhTienBan) as [Tổng tiền]
from HOADON H, CHITIETHOADON CT
where H.MaHD = CT.MaHD 
group by H.MaHD
