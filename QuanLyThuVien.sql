use master
go

drop database QLTVsoftware
go

create database QLTVsoftware
go 

use QLTVsoftware
go


create table DOC_GIA (
So_The char(15) primary key,
Ho_Ten nvarchar(80),
Nam_Sinh int,
Ngay_Cap date,
Nghe_Nghiep nvarchar(60),
Dia_Chi nvarchar(200),
SDT char(12)
)

create table NHAN_VIEN (
Ma_NV char(15) primary key,
Ho_Ten nvarchar(80),
Nam_Sinh int,
Gioi_Tinh nvarchar(3) check (Gioi_Tinh in (N'Nam',N'Nữ')),
Dia_Chi nvarchar(200),
SDT nvarchar(12)
)

create table NXB (
Ma_NXB char(15) primary key,
Ten_NXB nvarchar(60)
)

create table VI_TRI (
Ma_VT char(15) primary key,
Ten_VT nvarchar(60),
Mo_Ta nvarchar(100)
) 

create table THE_LOAI (
Ma_TL char(15) primary key,
Ten_TL nvarchar(10) check (Ten_TL in (N'Tạp chí',N'Giáo Trình')),
Ma_VT char(15) foreign key references VI_TRI (Ma_VT)
)

create table TAC_GIA (
Ma_TG char(15) primary key,
Ten_TG nvarchar(80),
Nam_Sinh int,
Ghi_Chu nvarchar(100) NULL
)

create table SACH (
Ma_Sach char(15) primary key,
Ten_Sach nvarchar(120),
Ma_TL char(15) foreign key references THE_LOAI(Ma_TL),
Ma_NXB char(15) foreign key references NXB(Ma_NXB),
Ma_TG char(15) foreign key references TAC_GIA(Ma_TG),
Ngon_Ngu nvarchar(40),
Gia_Bia real,
So_Trang int,
Nam_XB int,
So_Lg int,
Ghi_Chu nvarchar(100)
)

create table PHIEU_MUON_TRA (
MaPH_MT char(15) primary key,
So_The char(15) foreign key references DOC_GIA(So_The),
Ngay_Muon date,
Ngay_Tra date,
Ma_NV char(15) foreign key references NHAN_VIEN(Ma_NV)
)

create table CT_PHIEU_MUON_TRA (
MaPH_MT char(15),
Ma_Sach char(15),
So_Luong int,
Trang_Thai nvarchar(8) check (Trang_Thai in (N'Đã trả',N'Chưa trả')),
constraint PK_CTPHMT primary key(MaPH_MT,Ma_Sach)
)

alter table CT_PHIEU_MUON_TRA add constraint fk1_CTPHMT foreign key (MaPH_MT) references PHIEU_MUON_TRA(MaPH_MT)
alter table CT_PHIEU_MUON_TRA add constraint fk2_CTPHMT foreign key (Ma_Sach) references SACH(Ma_Sach)

create table PHIEU_DK_MUON (
MaPH_DK char(15) primary key,
So_The char(15) foreign key references DOC_GIA(So_The),
NgayDK_Muon date,
Ma_NV char(15) foreign key references NHAN_VIEN(Ma_NV)
)

create table CT_PHIEU_DK_MUON (
MaPH_DK char(15),
Ma_Sach char(15),
So_Luong_DK int,
Ghi_Chu nchar(50),
constraint PK_CTPHDK primary key(MaPH_DK,Ma_Sach)
)

alter table CT_PHIEU_DK_MUON add constraint fk1_PHDK foreign key (MaPH_DK) references PHIEU_DK_MUON(MaPH_DK)
alter table CT_PHIEU_DK_MUON add constraint fk2_PHDK foreign key (Ma_Sach) references SACH(Ma_Sach)

create table PHIEU_NOP_PHAT (
MaPH_NP char(15) primary key,
So_The char(15) foreign key references DOC_GIA(So_The),
Ly_Do_Phat nvarchar(100),
Hinh_Thuc_Phat nvarchar(40),
Ngay_Nop date,
Trang_Thai_Phat nvarchar(14) check (Trang_Thai_Phat in (N'Đã nộp phạt',N'Chưa nộp phạt')),
Ngay_Mo_The date
)

create table NHAP_SACH (
MaPN char(15) primary key,
TenPN nchar(50),
Ma_NXB char(15) foreign key references NXB(Ma_NXB),
Ma_NV char(15) foreign key references NHAN_VIEN(Ma_NV),
)

create table CT_NHAP_SACH (
MaPN char(15),
Ma_Sach char(15),
So_Luong_Nhap int,
Ngay_Nhap date,
constraint PK_CTNS primary key (MaPN,Ma_Sach)
)

alter table CT_NHAP_SACH add constraint fk1_NS foreign key (MaPN) references NHAP_SACH(MaPN)
alter table CT_NHAP_SACH add constraint fk2_NS foreign key (Ma_Sach) references SACH(Ma_Sach)

create table DK_ADMIN (
Ten_DN char(50) primary key,
Mat_Khau nvarchar(50),
Ho_Ten nvarchar(60),
Ngay_Sinh date,
Gioi_Tinh nvarchar(3) check (Gioi_Tinh in (N'Nam',N'Nữ')),
Email nvarchar(40),
SDT nvarchar(12)
)


insert into DOC_GIA values ('SV11202217',N'Nguyễn Thị Linh',2002,'03/29/2020',N'Sinh viên',N'207 Giải Phóng, quận Hai Bà Trưng, Hà Nội','01234567891')
insert into DOC_GIA values ('GV21323445',N'Hoàng Thị Thúy Lan',1978,'04/07/2018',N'Giảng viên',N'Phường Phúc Xá, Quận Ba Đình, Hà Nội','129830123823')
insert into DOC_GIA values ('TD28397199',N'Trần Quốc Tuấn',1988,'09/07/2020',N'Kinh doanh',N'Thị trấn Phú Xuyên, Huyện Phú Xuyên, Hà Nội','01923981234')
insert into DOC_GIA values ('SV11190329',N'Trần Mai Hưng',2000,'12/11/2019',N'Sinh viên',N'Phường Hòa Thọ Đông, Quận Cẩm Lệ, Đà Nẵng','092837345')
insert into DOC_GIA values ('GV21389849',N'Nguyễn Minh Tân',1977,'12/29/2018',N'Giảng Viên',N'Phường 24, Quận Bình Thạnh, Hồ Chí Minh','0912939824')
insert into DOC_GIA values ('SH28471294',N'Hoàng Thị Thắm',1987,'11/27/2021',N'Nhân viên văn phòng',N'Phường Tân Phong, Thành phố Biên Hòa, Đồng Nai','0921388473')
insert into DOC_GIA values ('HS32849837',N'Trương Thị Hảo',2005,'09/18/2021',N'Học sinh',N'Số nhà 250, Xóm Thượng, Xã Cổ Loa, Huyện Đông Anh, Hà Nội','091123443445')
insert into DOC_GIA values ('SV11182034',N'Nguyễn Văn Đạt',2001,'11/23/2020',N'Sinh viên',N'Thôn Đức Hậu, Xã Đức Hòa, Huyện Sóc Sơn, Hà Nội','08213726422')
insert into DOC_GIA values ('SV11172913',N'Vũ Quang Huy',2002,'09/09/2020',N'Sinh viên',N'LK 19, khu đô thị Vĩnh Hoàng, Phường Vĩnh Hưng, Quận Hoàng Mai, Hà Nội','091538729392')
insert into DOC_GIA values ('GV12387476',N'Mai Thị Mỹ Anh',1965,'09/12/2017',N'Giảng viên',N'Ngõ 125 đường Cổ Loa, Xã Cổ Loa, Huyện Đông Anh, Hà Nội','09812377724')
insert into DOC_GIA values ('TD28137233',N'Nguyễn Như Quỳnh',2003,'05/12/2019',N'Kinh doanh tự do',N'Thôn Phương Nhị, Xã Liên Ninh, Huyện Thanh Trì, Hà Nội','091232767246')

insert into NHAN_VIEN values ('NV00001',N'Trương Như Quỳnh',1997,N'Nữ',N'Số 264 đường Âu Cơ, Phường Nhật Tân, Quận Tây Hồ, Hà Nội','0912376134')
insert into NHAN_VIEN values ('NV00002',N'Nguyễn Văn Tuấn',1980,N'Nam',N'Số 1C Vạn Phúc, Phường Ngọc Khánh, Quận Ba Đình, Hà Nội','01238724873')
insert into NHAN_VIEN values ('NV00003',N'Nguyễn Thị Tường Vân',1999,N'Nữ',N'Thôn Bạch Trữ, xã Tiến Thắng, Huyện Mê Linh, Hà Nội','01238872743')
insert into NHAN_VIEN values ('NV00004',N'Nguyễn Văn Thắng',1989,N'Nam',N'TDP Đình, Phương Nam Tiến, Thành Phố Phổ Yên, Thái Nguyên','0219328748')
insert into NHAN_VIEN values ('NV00005',N'Trần Đình Trọng',1998,N'Nam',N'Quận Tân Phú, Thành Phố Hồ Chí Minh','10233482343')
insert into NHAN_VIEN values ('NV00006',N'Nguyễn Phương Mai',1999,N'Nữ',N'Phường Thổ Quan, Quận Đống Đa, Hà Nội','08274623743')

insert into NXB values ('NXB0001',N'Giáo dục Việt Nam')
insert into NXB values ('NXB0002',N'Nhã Nam')
insert into NXB values ('NXB0003',N'Hà Nội Edu')
insert into NXB values ('NXB0004',N'Vì tri thức Việt')
insert into NXB values ('NXB0005',N'Education NEU')
insert into NXB values ('NXB0006',N'Kinh tế giáo dục')

insert into VI_TRI values ('VT/LE/001',N'Dãy 3, kệ 2, tầng 1',N'Gần cửa ra vào kho sách')
insert into VI_TRI values ('VT/RI/002',N'Dãy 4, kệ 1, tầng 2',N'Góc trong cùng bên trái tính từ cửa ra vào')
insert into VI_TRI values ('VT/LE/003',N'Dãy 5, kệ 9, tầng 5',N'Góc ngoài bên phải tính từ cửa ra vào')
insert into VI_TRI values ('VT/LE/004',N'Dãy 10, kệ 1, tầng 2',N'Từ cửa đi vào dãy thứ 10 khoảng 2 mét')
insert into VI_TRI values ('VT/RI/005',N'Dãy 4, kệ 10, tầng 5',N'Gần cửa ra vào phía tay trái')

insert into THE_LOAI values ('TL01',N'Giáo trình','VT/LE/001')
insert into THE_LOAI values ('TL02',N'Tạp chí','VT/RI/005')

insert into TAC_GIA values ('TG001',N'Nguyễn Minh Hiếu',1970,N'Là giảng viên trường N')
insert into TAC_GIA values ('TG002',N'Nguyễn Thị Tuyết',1978,N'Là PGS.TS của học viện Ngân Hàng')
insert into TAC_GIA values ('TG003',N'Lê Trường Chính',1990,N'Nghiên cứu sinh của học viện Ngoại Giao')
insert into TAC_GIA values ('TG004',N'Phan Thị Bích Thảo',1967,N'Là giảng viên của đại học Bách Khoa Hà Nội từ 2010 đến nay')
insert into TAC_GIA values ('TG005',N'Mai Duy Hùng',1969,N'Tiến sĩ ngành Tài Chính của Đại học Quốc Gia Hà Nội')
insert into TAC_GIA values ('TG007',N'S',1975,N'Giảng viên ngành ngôn ngữ học của Đại học Harvard, Mỹ từ 2008 đến nay')

insert into SACH values ('GT001',N'Việt Nam thời kỳ chuyển đổi số','TL01','NXB0001','TG002',N'Tiếng Việt',200000, 256, 2015,200,N'Một vài cuốn không còn sử dụng được nữa')
insert into SACH values ('GT002',N'Tất tần tật về quản lý dự án','TL01','NXB0002','TG005',N'Tiếng Việt',1500000,200, 2010, 50, null)
insert into SACH values ('TC003',N'Trump ở nhà trắng','TL02','NXB0003','TG001',N'Tiếng Việt',300000,300,2019, 60, null)
insert into SACH values ('TC004',N'Digital Marketing','TL02','NXB0002','TG002',N'Tiếng Anh',169000, 140, 2020, 100, null)
insert into SACH values ('GT005',N'Tài chính doanh nghiệp','TL01','NXB0006','TG003',N'Tiếng Việt',100000,350, 2008, 225, null)
insert into SACH values ('GT006',N'Quản trị kinh doanh','TL01','NXB0003','TG004',N'Tiếng Việt',160000,400,2011, 230, null)
insert into SACH values ('TC007',N'Điều kỳ diệu ở Phố Wall','TL02','NXB0004','TG005',N'Tiếng Anh',400000,450,2018, 95, null)

insert into PHIEU_MUON_TRA values ('PHMT0001','SV11190329','10/02/2020','10/20/2020','NV00001')
insert into PHIEU_MUON_TRA values ('PHMT0002','GV21323445','06/05/2021','06/15/2021','NV00002')
insert into PHIEU_MUON_TRA values ('PHMT0003','GV12387476','03/29/2020','04/16/2021','NV00003')
insert into PHIEU_MUON_TRA values ('PHMT0004','SV11202217','04/09/2021','04/30/2021','NV00004')
insert into PHIEU_MUON_TRA values ('PHMT0005','TD28397199','11/11/2020','12/12/2022','NV00005')
insert into PHIEU_MUON_TRA values ('PHMT0006','SV11182034','04/09/2019','05/01/2019','NV00006')
insert into PHIEU_MUON_TRA values ('PHMT0007','SV11172913','12/01/2019','12/31/2019','NV00001')

insert into CT_PHIEU_MUON_TRA values ('PHMT0001','GT001',3,N'Đã trả')
insert into CT_PHIEU_MUON_TRA values ('PHMT0002','GT002',2,N'Chưa trả')
insert into CT_PHIEU_MUON_TRA values ('PHMT0003','GT005',1,N'Chưa trả')
insert into CT_PHIEU_MUON_TRA values ('PHMT0004','GT006',4,N'Đã trả')
insert into CT_PHIEU_MUON_TRA values ('PHMT0005','TC003',2,N'Đã trả')
insert into CT_PHIEU_MUON_TRA values ('PHMT0006','TC004',2,N'Chưa trả')
insert into CT_PHIEU_MUON_TRA values ('PHMT0007','GT006',3,N'Đã trả')
insert into CT_PHIEU_MUON_TRA values ('PHMT0001','TC007',2,N'Đã trả')

insert into PHIEU_DK_MUON values ('PHDK0001','GV12387476','09/09/2021','NV00001')
insert into PHIEU_DK_MUON values ('PHDK0002','SV11202217','03/29/2020','NV00004')
insert into PHIEU_DK_MUON values ('PHDK0003','SV11172913','04/09/2021','NV00002')
insert into PHIEU_DK_MUON values ('PHDK0004','TD28137233','12/12/2021','NV00003')
insert into PHIEU_DK_MUON values ('PHDK0005','SV11182034','11/29/2020','NV00001')
insert into PHIEU_DK_MUON values ('PHDK0006','SH28471294','10/03/2020','NV00006')
insert into PHIEU_DK_MUON values ('PHDK0007','HS32849837','07/17/2021','NV00005')

insert into CT_PHIEU_DK_MUON values ('PHDK0001','GT001',2,N'Đã cho mượn')      
insert into CT_PHIEU_DK_MUON values ('PHDK0002','GT002',3,N'Chưa cho mượn')       
insert into CT_PHIEU_DK_MUON values ('PHDK0003','GT005',1,N'Người đăng ký mượn hẹn lại ngày')      
insert into CT_PHIEU_DK_MUON values ('PHDK0004','GT001',1,N'Đã cho mượn')
insert into CT_PHIEU_DK_MUON values ('PHDK0005','TC003',2,N'Người mượn hủy đăng ký mượn trước')
insert into CT_PHIEU_DK_MUON values ('PHDK0006','TC004',3,N'Chưa cho mượn')      
insert into CT_PHIEU_DK_MUON values ('PHDK0007','GT002',4,N'Đã cho mượn')

insert into PHIEU_NOP_PHAT values  ('PHNP0001','GV12387476',N'Làm hư hỏng sách',N'Hoàn tiền tương đương giá trị sách','12/12/2020',N'Đã nộp phạt','12/20/2020')           
insert into PHIEU_NOP_PHAT values  ('PHNP0002','HS32849837',N'Làm mất sách',N'Mua sách thay thế','03/29/2020',N'Chưa nộp phạt',null)     
insert into PHIEU_NOP_PHAT values  ('PHNP0003','SV11190329',N'Làm mất bìa sách',N'Nộp tiền phạt tương đương 5% giá bìa','10/05/2019',N'Đã nộp phạt','10/10/2019')     
insert into PHIEU_NOP_PHAT values  ('PHNP0004','SV11202217',N'Làm mất sách',N'Hoàn tiền tương đương giá trị sách mượn','03/03/2020',N'Đã nộp phạt','04/01/2020')     
insert into PHIEU_NOP_PHAT values  ('PHNP0005','TD28137233',N'Làm rách một số trang sách',N'Nộp tiền phạt tương đương 10% giá bìa','01/02/2019',N'Chưa nộp phạt',null)     

insert into NHAP_SACH values ('PN100000',N'Nhập sách quản trị kinh doanh','NXB0004','NV00002')
insert into NHAP_SACH values ('PN100001',N'Nhập sách lô sách mới','NXB0001','NV00001')
insert into NHAP_SACH values ('PN100002',N'Nhập sách chuyên ngành quản lý học','NXB0002','NV00001')
insert into NHAP_SACH values ('PN100003',N'Nhập lô sách thuộc bộ môn lý luận chính trị','NXB0005','NV00006')
insert into NHAP_SACH values ('PN100004',N'Nhập đợt sách bổ sung lần 2','NXB0001','NV00005')

insert into CT_NHAP_SACH values ('PN100000','GT006',60,'10/05/2018')
insert into CT_NHAP_SACH values ('PN100001','GT005',50,'06/01/2019')
insert into CT_NHAP_SACH values ('PN100002','GT002',100,'03/29/2020')
insert into CT_NHAP_SACH values ('PN100003','GT001',150,'12/12/2019')
insert into CT_NHAP_SACH values ('PN100004','TC004',75,'08/08/2019')

insert into DK_ADMIN values ('ntl123','Abc_123',N'Nguyễn Thị Hoài Thanh','03/03/1988',N'Nữ','hoaithanhneu@gmail.com','09112673992')
insert into DK_ADMIN values ('dtltptn','Dtl2002',N'Đặng Tiến Thành','04/09/1995',N'Nam','dangtthanh2002@gmail.com','09238721837')
insert into DK_ADMIN values ('nhsdhktqd','Dhkt2020',N'Phan Hoài Sơn','12/11/1990',N'Nam','sonneu90@gmail.com','09123728467')

select * from DOC_GIA
select * from NHAN_VIEN
select * from NXB
select * from VI_TRI
select * from THE_LOAI

select * from SACH
select * from PHIEU_MUON_TRA
select * from CT_PHIEU_MUON_TRA
select * from PHIEU_DK_MUON
select * from CT_PHIEU_DK_MUON
select * from PHIEU_NOP_PHAT
select * from NHAP_SACH
select * from CT_NHAP_SACH
select * from DK_ADMIN
	
--select * from them_sach	
drop trigger nhapsach2
create trigger nhaphang on CT_NHAP_SACH
after insert
as	
	begin
		update SACH
		set So_Lg= So_Lg + (select So_Luong_Nhap from inserted where inserted.Ma_Sach=SACH.Ma_Sach)
		
	end

insert into NHAP_SACH values ('PN100013',N'Nhập đợt sách bổ sung lần 2','NXB0001','NV00005')

insert into CT_NHAP_SACH values ('PN100013','GT006',60,'10/05/2018')


begin transaction 
 delete TAC_GIA where Ma_TG='TG006'
 rollback
begin transaction
begin
save transaction t1
delete TAC_GIA where Ma_TG ='TG007'
commit
end
begin
save transaction t2
delete TAC_GIA where Ma_TG='TG008'
end
rollback transaction t1
	select * from TAC_GIA		
	insert into TAC_GIA values ('TG007',N'S',1975,N'Giảng viên ngành ngôn ngữ học của Đại học Harvard, Mỹ từ 2008 đến nay')	
--select dg.So_The, s.Ma_Sach, tl.Ten_TL, tg.Ten_TG,  from DOC_GIA dg join PHIEU_MUON_TRA pmt on dg.So_The=pmt.So_The
--join CT_PHIEU_MUON_TRA ctpmt on pmt.MaPH_MT=ctpmt.MaPH_MT
--join SACH s on ctpmt.Ma_Sach=s.Ma_Sach
--join TAC_GIA tg on s.Ma_TG = tg.Ma_TG
--join THE_LOAI tl on s.Ma_TL = tl.Ma_TL
--join VI_TRI vt on tl.Ma_VT = vt.Ma_VT
--
DECLARE @PageSize INT = 10;
DECLARE @PageNumber INT = 1;

SELECT *
FROM YourTable
ORDER BY YourOrderByColumn
OFFSET (@PageNumber - 1) * @PageSize ROWS
FETCH NEXT @PageSize ROWS ONLY;
