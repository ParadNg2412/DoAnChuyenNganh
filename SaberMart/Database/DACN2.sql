select * from SANPHAM
select * from CHITIETHOADON
alter table CHITIETHOADON drop column NgayBan

insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, PicSP, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP001', 'NSP02', N'Coca-Cola thường chai 600ml', N'Chai 600ml', 'D:\Đồ án chuyên nghành\DoAnChuyenNganh\SaberMart\Database\PicSP\CocaThuongChaiLon.png', 50, 11000, 15000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, PicSP, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP002', 'NSP02', N'Coca-Cola không đường chai 600ml', N'Chai 600ml', 'D:\Đồ án chuyên nghành\DoAnChuyenNganh\SaberMart\Database\PicSP\CocaKhongDuongChaiLon.png', 50, 11000, 15000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, PicSP, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP003', 'NSP02', N'Coca-Cola thường chai 500ml', N'Chai 500ml', 'D:\Đồ án chuyên nghành\DoAnChuyenNganh\SaberMart\Database\PicSP\CocaThuongChaiNho.png', 50, 9000, 10000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, PicSP, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP004', 'NSP02', N'Coca-Cola không đường chai 500ml', N'Chai 500ml', 'D:\Đồ án chuyên nghành\DoAnChuyenNganh\SaberMart\Database\PicSP\CocaKhongDuongChaiNho.png', 50, 9000, 10000, 'NCC03')
insert into SANPHAM(MaSP, MaNhom, TenSP, DonViTinh, PicSP, SLTon, GiaBan, GiaNhap, MaNCC)
values('SP005', 'NSP02', N'Coca-Cola thường chai 2.25 lit', N'Chai 2.25 lit', 'D:\Đồ án chuyên nghành\DoAnChuyenNganh\SaberMart\Database\PicSP\CocaKhongDuongChaiNho.png', 50, 9000, 10000, 'NCC03')