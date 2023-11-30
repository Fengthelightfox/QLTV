create database QLTV
use QLTV
go
CREATE TABLE Sach (
    Ma_sach VARCHAR(255) PRIMARY KEY,
    Ten_sach NVARCHAR(255),
    The_loai NVARCHAR(255),
    So_luong int,
    Tinh_trang NVARCHAR(255),
    Thoi_gian_nhap_kho DATE,
    Mo_ta NVARCHAR(255)
);

CREATE TABLE Thong_tin_doc_gia (
	Ma_doc_gia varchar(255) PRIMARY KEY,
	Ten_tai_khoan varchar(255),
	Mat_khau varchar(255),
	Ho_ten nvarchar(255),
	So_dien_thoai text,
	Phuong_Xa nvarchar(255),
	Quan_huyen nvarchar(255),
	Tinh nvarchar(255),
	Email nvarchar(255)
);

CREATE TABLE Nguoi_muon (
	Ma_doc_gia varchar(255),
	Ma_sach VARCHAR(255),
	Ngay_muon date,
	Ngay_tra date,
	FOREIGN KEY (Ma_doc_gia) REFERENCES Thong_tin_doc_gia(Ma_doc_gia),
	FOREIGN KEY (Ma_sach) REFERENCES Sach(Ma_sach)
);

/*INSERT INTO Nguoi_muon (Ma_doc_gia, Ma_sach, Ngay_muon, Ngay_tra) Values ('MD001', 'MS001', GETDATE(), '2023/10/15');*/
	
create table TK_QL (
	Ten_tai_khoan varchar(255),
	Mat_khau varchar(255)
);

INSERT INTO Sach (Ma_sach, Ten_sach, The_loai, So_luong, Tinh_trang, Thoi_gian_nhap_kho, Mo_ta)
VALUES
    ('MS001', N'Dấu chân trên cát', N'Tiểu thuyết', 6, N'Mới', GETDATE(), NULL),
    ('MS002', N'To Kill a Mockingbird', N'Tiểu thuyết', 4, N'Mới', GETDATE(), NULL),
    ('MS003', N'Harry Potter và hòa bình', N'Tiểu thuyết kỳ ảo', 8, N'Cũ', GETDATE(), NULL),
    ('MS004', N'Tâm lý học đám đông', N'Tâm lý học', 3, N'Mới', GETDATE(), NULL),
    ('MS005', N'Sherlock Holmes', N'Trinh thám', 5, N'Mới', GETDATE(), NULL),
    ('MS006', N'Người về từ sao Hỏa', N'Khoa học viễn tưởng', 2, N'Mới', GETDATE(), NULL),
    ('MS007', N'Bí kíp làm giàu', N'Phát triển cá nhân', 6, N'Cũ', GETDATE(), NULL),
    ('MS008', N'Đại cương về hóa học', N'Hóa học', 5, N'Mới', GETDATE(), NULL),
    ('MS009', N'Dấu ấn tình yêu', N'Tiểu thuyết lãng mạn', 7, N'Mới', GETDATE(), NULL),
    ('MS010', N'Nhật ký Malcolm X', N'Hồi ký', 3, N'Cũ', GETDATE(), NULL),
    ('MS011', N'Chinh phục đỉnh Everest', N'Hồi ký', 2, N'Mới', GETDATE(), NULL),
    ('MS012', N'Homo Deus: Lịch sử tương lai', N'Triết học', 4, N'Mới', GETDATE(), NULL),
    ('MS013', N'Chiến lược dành cho người cận thị', N'Hồi ký', 1, N'Cũ', GETDATE(), NULL),
    ('MS014', N'Truyện Kiều', N'Thơ', 6, N'Mới', GETDATE(), NULL),
    ('MS015', N'Cẩm nang thương trường', N'Quản lý kinh doanh', 5, N'Cũ', GETDATE(), NULL);

INSERT INTO Thong_tin_doc_gia(Ma_doc_gia, Ten_tai_khoan, Mat_khau, Ho_ten, So_dien_thoai, Phuong_Xa, Quan_huyen, Tinh)
VALUES
    ('MD001', 'nguoimuon1', 'matkhau1', N'Người Mượn 1', '0123456789', N'Phường Bùi Thị Xuân', N'Quận Thành phố Quy Nhơn', N'Bình Định'),
    ('MD002', 'nguoimuon2', 'matkhau2', N'Người Mượn 2', '0987654321', N'Phường Đống Đa', N'Quận Thành phố Quy Nhơn', N'Bình Định'),
    ('MD003', 'nguoimuon3', 'matkhau3', N'Người Mượn 3', '0369847201', N'Phường Ghềnh Ráng', N'Quận Thành phố Quy Nhơn', N'Bình Định'),
    ('MD004', 'nguoimuon4', 'matkhau4', N'Người Mượn 4', '0321654987', N'Phường Hải Cảng', N'Quận Thành phố Quy Nhơn', N'Bình Định'),
    ('MD005', 'nguoimuon5', 'matkhau5', N'Người Mượn 5', '0765432109', N'Phường Lê Hồng Phong', N'Quận Thành phố Quy Nhơn', N'Bình Định'),
    ('MD006', 'nguoimuon6', 'matkhau6', N'Người Mượn 6', '0918273645', N'Phường Lê Lợi', N'Quận Thành phố Quy Nhơn', N'Bình Định'),
    ('MD007', 'nguoimuon7', 'matkhau7', N'Người Mượn 7', '0587963210', N'Phường Lý Thường Kiệt', N'Quận Thành phố Quy Nhơn', N'Bình Định');

INSERT INTO TK_QL (Ten_tai_khoan, Mat_khau) values ('admin', '123');

