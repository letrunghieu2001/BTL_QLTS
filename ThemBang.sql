use BTL_QLtuyensinh

insert into ChuyenNganh values('N1','Cong nghe thong tin','A1');
insert into ChuyenNganh values('N2','Khoa học máy tính','A1');

insert into ChiTietTruong values('TR1','Dai hoc Kinh te quoc dan','N1','A1');
insert into ChiTietTruong values('TR2','Dai hoc Bách Khoa','N2','A1');

insert into DoiTuongUuTien values('UT1','Ngheo');
insert into DoiTuongUuTien values('UT2','Rat Ngheo');
insert into DoiTuongUuTien values('UT3','Khong uu tien');

insert into ChiTietDVDK values('DVDK','HaNoi');
insert into ChiTietDVDK values('DVDK1','HaiPhong');

insert into SBDTenPhong values('01','Nguyen Van A','2001-1-1','P101','Cau Giay');
insert into SBDTenPhong values('02','Nguyen Van B','2001-2-1','P102','Cau Giay');

insert into MonPhachSBD values('01','Phach1','Toan');
insert into MonPhachSBD values('02','Phach1','Vat ly');

insert into MonPhachDiem values('Phach1','Toan',10);
insert into MonPhachDiem values('Phach2','Vatly',9);

insert into KetQua values('HS1','01','Nguyen Van A','2001/1/1','Toan',10,0.5,0.5,10);
insert into KetQua values('HS2','02','Nguyen Van B','2001/2/1','Vat ly',9,0,0,9);
select *from KetQua
insert into HoSoTuyenSinh values('HS1','TR1','Dai hoc Kinh te quoc dan','01','Nguyen Van A','2001/1/1','UT1','Ngheo','DVDK')
insert into HoSoTuyenSinh values('HS2','TR2','Dai hoc Bach Khoa','02','Nguyen Van B','2001/2/1','UT3','Khong uu tien','DVDK1')

create table LOGIN(
	user_id char(20) primary key,
	password nvarchar(50) 
)
drop table LOGIN
insert into LOGIN values('admin','1')