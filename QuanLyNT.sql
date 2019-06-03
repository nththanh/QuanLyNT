USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLNT')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNT') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNT]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLNT]
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblChucVu]    Script Date: 5/15/2019 12:37:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChucVu](
	[macv] [int] NOT NULL,
	[tenchucvu] [nvarchar](50) NOT NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChucVu] PRIMARY KEY CLUSTERED 
(
	[macv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblChucVu](macv, tenchucvu, ghichu) VALUES (1,N'QuanLy',N'')
INSERT INTO [dbo].[tblChucVu](macv, tenchucvu, ghichu) VALUES (2,N'NhanVien',N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblLoaiThuoc]    Script Date: 5/15/2019 12:38:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiThuoc](
	[maloaithuoc] [int] NOT NULL,
	[tenloaithuoc] [nvarchar](50) NULL,
	[thanhphan] [nvarchar](50) NULL,
	[chucnang] [nvarchar](50) NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiThuoc] PRIMARY KEY CLUSTERED 
(
	[maloaithuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblLoaiThuoc](maloaithuoc, tenloaithuoc, thanhphan, chucnang, ghichu) VALUES (1,N'vitaminC',N'vitaminC',N'bo sung vitaminC', N'')
INSERT INTO [dbo].[tblLoaiThuoc](maloaithuoc, tenloaithuoc, thanhphan, chucnang, ghichu) VALUES (2,N'vitaminB',N'vitaminB',N'bo sung vitaminB', N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblDonViTinh]    Script Date: 5/15/2019 12:39:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDonViTinh](
	[madvt] [int] NOT NULL,
	[dvt] [nvarchar](50) NOT NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDonViTinh] PRIMARY KEY CLUSTERED 
(
	[madvt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblDonViTinh](madvt, dvt, ghichu) VALUES (1,N'vien', N'')
INSERT INTO [dbo].[tblDonViTinh](madvt, dvt, ghichu) VALUES (2,N'chai', N'')
INSERT INTO [dbo].[tblDonViTinh](madvt, dvt, ghichu) VALUES (3,N'hop', N'')
INSERT INTO [dbo].[tblDonViTinh](madvt, dvt, ghichu) VALUES (4,N'cai', N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblThuoc]    Script Date: 5/15/2019 12:38:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblThuoc](
	[mathuoc] [int] NOT NULL,
	[maloaithuoc] [int] NOT NULL,
	[tenthuoc] [nvarchar](50) NOT NULL,
	[madvt] [int] NOT NULL,
	[noisanxuat] [nvarchar](50) NOT NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblThuoc] PRIMARY KEY CLUSTERED 
(
	[mathuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblThuoc]  WITH CHECK ADD  CONSTRAINT [FK_tblThuoc_tblDonViTinh] FOREIGN KEY([madvt])
REFERENCES [dbo].[tblDonViTinh] ([madvt])
GO

ALTER TABLE [dbo].[tblThuoc] CHECK CONSTRAINT [FK_tblThuoc_tblDonViTinh]
GO

ALTER TABLE [dbo].[tblThuoc]  WITH CHECK ADD  CONSTRAINT [FK_tblThuoc_tblLoaiThuoc] FOREIGN KEY([maloaithuoc])
REFERENCES [dbo].[tblLoaiThuoc] ([maloaithuoc])
GO

ALTER TABLE [dbo].[tblThuoc] CHECK CONSTRAINT [FK_tblThuoc_tblLoaiThuoc]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblThuoc]([mathuoc], [maloaithuoc],[tenthuoc], [madvt], [noisanxuat], [ghichu]) VALUES (1, 1,N'C Plus', 2, N'Dai Loan', N'')
INSERT INTO [dbo].[tblThuoc]([mathuoc], [maloaithuoc],[tenthuoc], [madvt], [noisanxuat], [ghichu]) VALUES (2, 2,N'VITAMIN B1', 3, N'Viet Nam', N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblThietBi]    Script Date: 5/15/2019 12:39:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblThietBi](
	[mathietbi] [int] NOT NULL,
	[tenthietbi] [nvarchar](50) NULL,
	[chucnang] [nvarchar](50) NULL,
	[noisanxuat] [nvarchar](50) NULL,
	[madvt] [int] NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblThietBi] PRIMARY KEY CLUSTERED 
(
	[mathietbi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblThietBi]  WITH CHECK ADD  CONSTRAINT [FK_tblThietBi_tblDonViTinh] FOREIGN KEY([madvt])
REFERENCES [dbo].[tblDonViTinh] ([madvt])
GO

ALTER TABLE [dbo].[tblThietBi] CHECK CONSTRAINT [FK_tblThietBi_tblDonViTinh]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblThietBi]([mathietbi], [tenthietbi], [chucnang], [noisanxuat],[madvt], [ghichu]) VALUES (1, N'nhiet ke', N'Do nhiet do', N'Dai Loan',4, N'')
INSERT INTO [dbo].[tblThietBi]([mathietbi], [tenthietbi], [chucnang], [noisanxuat],[madvt], [ghichu]) VALUES (2, N'tu', N'trung bay thuoc', N'Viet Nam',4, N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 5/15/2019 12:59:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblNhanVien](
	[manv] [int] NOT NULL,
	[tennhanvien] [nvarchar](50) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[namsinh] [datetime2](7) NOT NULL,
	[gioitinh] [nvarchar](50) NOT NULL,
	[noilamviec] [nvarchar](50) NOT NULL,
	[machucvu] [int] NOT NULL,
	[trinhdochuyenmon] [nvarchar](50) NOT NULL,
	[namcapbang_noicap] [nvarchar](50) NOT NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblChucVu] FOREIGN KEY([machucvu])
REFERENCES [dbo].[tblChucVu] ([macv])
GO

ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblChucVu]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblNhanVien]([manv],[tennhanvien],[diachi],[namsinh],[gioitinh],[noilamviec],[machucvu],[trinhdochuyenmon],[namcapbang_noicap],[ghichu]) VALUES (1,N'Nguyen Van A',N'TP.HCM', convert(datetime,'12/30/2017 00:00:00',101),N'Nam',N'TP.HCM',1,N'Duoc Si',N'1996, Can Tho',N'')
INSERT INTO [dbo].[tblNhanVien]([manv],[tennhanvien],[diachi],[namsinh],[gioitinh],[noilamviec],[machucvu],[trinhdochuyenmon],[namcapbang_noicap],[ghichu]) VALUES (2,N'Nguyen Tan',N'TP.HCM', convert(datetime,'12/30/2017 00:00:00',101),N'Nu',N'TP.HCM',1,N'Trung cap',N'1996, Can Tho',N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 5/15/2019 12:59:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblNhaCungCap](
	[mancc] [int] NOT NULL,
	[tenncc] [nvarchar](50) NOT NULL,
	[diachincc] [nvarchar](50) NULL,
	[sdtncc] [nvarchar](50) NULL,
	[manv] [int] NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblNhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_tblNhaCungCap_tblNhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[tblNhanVien] ([manv])
GO

ALTER TABLE [dbo].[tblNhaCungCap] CHECK CONSTRAINT [FK_tblNhaCungCap_tblNhanVien]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblNhaCungCap]([mancc], [tenncc], [diachincc], [sdtncc], [manv], [ghichu]) VALUES (1, N'Spharm', N'Ha Noi', N'0301874719', 1,N'')
INSERT INTO [dbo].[tblNhaCungCap]([mancc], [tenncc], [diachincc], [sdtncc], [manv], [ghichu]) VALUES (2, N'Traphaco', N'Ha Noi', N'0924022425', 1,N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 5/15/2019 1:00:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKhachHang](
	[makh] [int] NOT NULL,
	[tenkhachhang] [nvarchar](50) NOT NULL,
	[sdt] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblKhachHang]([makh], [tenkhachhang], [sdt], [diachi], [gioitinh], [ghichu]) VALUES (1, N'Tran Van', N'0301874719', N'Ha Noi',N'Nam',N'')
INSERT INTO [dbo].[tblKhachHang]([makh], [tenkhachhang], [sdt], [diachi], [gioitinh], [ghichu]) VALUES (2, N'Tra Vien',N'0924022425', N'Ha Noi', N'Nu',N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblLoHang]    Script Date: 5/15/2019 1:07:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoHang](
	[malohang] [nvarchar](50) NOT NULL,
	[mancc] [int] NULL,
	[manv] [int] NULL,
	[ngaynhap] [datetime2](7) NULL,
	[thanhtien] [int] NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLoHang] PRIMARY KEY CLUSTERED 
(
	[malohang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblLoHang]  WITH CHECK ADD  CONSTRAINT [FK_tblLoHang_tblNhaCungCap] FOREIGN KEY([mancc])
REFERENCES [dbo].[tblNhaCungCap] ([mancc])
GO

ALTER TABLE [dbo].[tblLoHang] CHECK CONSTRAINT [FK_tblLoHang_tblNhaCungCap]
GO

ALTER TABLE [dbo].[tblLoHang]  WITH CHECK ADD  CONSTRAINT [FK_tblLoHang_tblNhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[tblNhanVien] ([manv])
GO

ALTER TABLE [dbo].[tblLoHang] CHECK CONSTRAINT [FK_tblLoHang_tblNhanVien]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblLoHang]([malohang], [mancc], [manv], [ngaynhap], [thanhtien], [ghichu]) VALUES (N'11', 1, 1, convert(datetime,'12/30/2017 00:00:00',101), 600000,N'')
INSERT INTO [dbo].[tblLoHang]([malohang], [mancc], [manv], [ngaynhap], [thanhtien], [ghichu]) VALUES (N'12', 2, 1, convert(datetime,'12/30/2017 00:00:00',101), 1000000,N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblChiTietLoHang]    Script Date: 5/15/2019 1:11:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietLoHang](
	[malohang] [nvarchar](50) NOT NULL,
	[mathuoc_mathietbi] [int] NOT NULL,
	[solo] [nvarchar](50) NULL,
	[ngaysanxuat] [datetime2](7) NULL,
	[hansudung] [datetime2](7) NULL,
	[soluong] [int] NULL,
	[dongia] [int] NULL,
 CONSTRAINT [PK_tblChiTietLoHang] PRIMARY KEY CLUSTERED 
(
	[malohang] ASC,
	[mathuoc_mathietbi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietLoHang]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietLoHang_tblLoHang] FOREIGN KEY([malohang])
REFERENCES [dbo].[tblLoHang] ([malohang])
GO

ALTER TABLE [dbo].[tblChiTietLoHang] CHECK CONSTRAINT [FK_tblChiTietLoHang_tblLoHang]
GO

ALTER TABLE [dbo].[tblChiTietLoHang]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietLoHang_tblThuoc] FOREIGN KEY([mathuoc_mathietbi])
REFERENCES [dbo].[tblThuoc] ([mathuoc])
GO

ALTER TABLE [dbo].[tblChiTietLoHang] CHECK CONSTRAINT [FK_tblChiTietLoHang_tblThuoc]
GO



USE [QLNT]
GO

/****** Object:  Table [dbo].[tblKhoHang]    Script Date: 5/15/2019 1:07:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKhoHang](
	[malohang] [nvarchar](50) NOT NULL,
	[mathuoc_mathietbi] [int] NOT NULL,
	[sl] [int] NULL,
	[giaban] [int] NULL,
 CONSTRAINT [PK_tblKhoHang] PRIMARY KEY CLUSTERED 
(
	[malohang] ASC,
	[mathuoc_mathietbi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblKhoHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhoHang_tblLoHang] FOREIGN KEY([malohang])
REFERENCES [dbo].[tblLoHang] ([malohang])
GO

ALTER TABLE [dbo].[tblKhoHang] CHECK CONSTRAINT [FK_tblKhoHang_tblLoHang]
GO

ALTER TABLE [dbo].[tblKhoHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhoHang_tblThuoc] FOREIGN KEY([mathuoc_mathietbi])
REFERENCES [dbo].[tblThuoc] ([mathuoc])
GO

ALTER TABLE [dbo].[tblKhoHang] CHECK CONSTRAINT [FK_tblKhoHang_tblThuoc]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblKhoHang]([malohang], [mathuoc_mathietbi], [sl], [giaban]) VALUES (N'11', 1, 500, 500)
INSERT INTO [dbo].[tblKhoHang]([malohang], [mathuoc_mathietbi], [sl], [giaban]) VALUES (N'12', 2, 200, 1000)
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 5/15/2019 1:10:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblTaiKhoan](
	[matk] [int] NOT NULL,
	[manv] [int] NOT NULL,
	[matkhau] [nvarchar](50) NOT NULL,
	[tinhtrang] [nvarchar](50) NOT NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[matk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaiKhoan_tblNhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[tblNhanVien] ([manv])
GO

ALTER TABLE [dbo].[tblTaiKhoan] CHECK CONSTRAINT [FK_tblTaiKhoan_tblNhanVien]
GO

USE [QLNT]
GO
INSERT INTO [dbo].[tblTaiKhoan]([matk], [manv], [matkhau], [tinhtrang], [ghichu]) VALUES (1, 1, N'123', N'1',N'')
INSERT INTO [dbo].[tblTaiKhoan]([matk], [manv], [matkhau], [tinhtrang], [ghichu]) VALUES (2, 2, N'1234', N'1',N'')
GO

USE [QLNT]
GO

/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 5/15/2019 1:12:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblHoaDon](
	[mahoadon] [int] NOT NULL,
	[manv] [int] NULL,
	[makh] [int] NULL,
	[ngaylap] [datetime2](7) NULL,
	[tongthanhtien] [int] NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblKhachHang] FOREIGN KEY([makh])
REFERENCES [dbo].[tblKhachHang] ([makh])
GO

ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblKhachHang]
GO

ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblNhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[tblNhanVien] ([manv])
GO

ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblNhanVien]
GO


USE [QLNT]
GO

/****** Object:  Table [dbo].[tblChiTietHoaDon]    Script Date: 5/15/2019 1:13:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietHoaDon](
	[mahoadon] [int] NOT NULL,
	[mathuoc_mathietbi] [int] NOT NULL,
	[malohang] [nvarchar](50) NULL,
	[sl] [int] NULL,
	[thanhtien] [int] NULL,
 CONSTRAINT [PK_tblChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[mathuoc_mathietbi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHoaDon_tblHoaDon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblHoaDon] ([mahoadon])
GO

ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_tblChiTietHoaDon_tblHoaDon]
GO

ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHoaDon_tblLoHang] FOREIGN KEY([malohang])
REFERENCES [dbo].[tblLoHang] ([malohang])
GO

ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_tblChiTietHoaDon_tblLoHang]
GO

ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHoaDon_tblThuoc] FOREIGN KEY([mathuoc_mathietbi])
REFERENCES [dbo].[tblThuoc] ([mathuoc])
GO

ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_tblChiTietHoaDon_tblThuoc]
GO


USE [QLNT]
GO

/****** Object:  Table [dbo].[tblDonTraHangNCC]    Script Date: 5/15/2019 1:15:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDonTraHangNCC](
	[matrahang] [int] NOT NULL,
	[mahoadon] [int] NULL,
	[manv] [int] NULL,
	[mancc] [int] NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDonTraHangNCC] PRIMARY KEY CLUSTERED 
(
	[matrahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblDonTraHangNCC]  WITH CHECK ADD  CONSTRAINT [FK_tblDonTraHangNCC_tblHoaDon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblHoaDon] ([mahoadon])
GO

ALTER TABLE [dbo].[tblDonTraHangNCC] CHECK CONSTRAINT [FK_tblDonTraHangNCC_tblHoaDon]
GO

ALTER TABLE [dbo].[tblDonTraHangNCC]  WITH CHECK ADD  CONSTRAINT [FK_tblDonTraHangNCC_tblNhaCungCap] FOREIGN KEY([mancc])
REFERENCES [dbo].[tblNhaCungCap] ([mancc])
GO

ALTER TABLE [dbo].[tblDonTraHangNCC] CHECK CONSTRAINT [FK_tblDonTraHangNCC_tblNhaCungCap]
GO

ALTER TABLE [dbo].[tblDonTraHangNCC]  WITH CHECK ADD  CONSTRAINT [FK_tblDonTraHangNCC_tblNhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[tblNhanVien] ([manv])
GO

ALTER TABLE [dbo].[tblDonTraHangNCC] CHECK CONSTRAINT [FK_tblDonTraHangNCC_tblNhanVien]
GO


USE [QLNT]
GO

/****** Object:  Table [dbo].[tblChiTietDonTraHangNCC]    Script Date: 5/15/2019 1:15:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietDonTraHangNCC](
	[mathuoc_mathietbi] [int] NOT NULL,
	[matrahang] [int] NOT NULL,
	[malohang] [nvarchar](50) NULL,
	[lydo] [nvarchar](50) NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChiTietDonTraHangNCC] PRIMARY KEY CLUSTERED 
(
	[mathuoc_mathietbi] ASC,
	[matrahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietDonTraHangNCC]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietDonTraHangNCC_tblDonTraHangNCC] FOREIGN KEY([matrahang])
REFERENCES [dbo].[tblDonTraHangNCC] ([matrahang])
GO

ALTER TABLE [dbo].[tblChiTietDonTraHangNCC] CHECK CONSTRAINT [FK_tblChiTietDonTraHangNCC_tblDonTraHangNCC]
GO

ALTER TABLE [dbo].[tblChiTietDonTraHangNCC]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietDonTraHangNCC_tblLoHang] FOREIGN KEY([malohang])
REFERENCES [dbo].[tblLoHang] ([malohang])
GO

ALTER TABLE [dbo].[tblChiTietDonTraHangNCC] CHECK CONSTRAINT [FK_tblChiTietDonTraHangNCC_tblLoHang]
GO

ALTER TABLE [dbo].[tblChiTietDonTraHangNCC]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietDonTraHangNCC_tblThuoc] FOREIGN KEY([mathuoc_mathietbi])
REFERENCES [dbo].[tblThuoc] ([mathuoc])
GO

ALTER TABLE [dbo].[tblChiTietDonTraHangNCC] CHECK CONSTRAINT [FK_tblChiTietDonTraHangNCC_tblThuoc]
GO


USE [QLNT]
GO

/****** Object:  Table [dbo].[tblDonTraHang]    Script Date: 5/15/2019 1:15:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDonTraHang](
	[madontrahang] [int] NOT NULL,
	[mahoadon] [int] NULL,
	[manv] [int] NULL,
	[ngaylap] [datetime2](7) NULL,
	[lydo] [nvarchar](50) NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDonTraHang] PRIMARY KEY CLUSTERED 
(
	[madontrahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblDonTraHang]  WITH CHECK ADD  CONSTRAINT [FK_tblDonTraHang_tblHoaDon] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblHoaDon] ([mahoadon])
GO

ALTER TABLE [dbo].[tblDonTraHang] CHECK CONSTRAINT [FK_tblDonTraHang_tblHoaDon]
GO

ALTER TABLE [dbo].[tblDonTraHang]  WITH CHECK ADD  CONSTRAINT [FK_tblDonTraHang_tblNhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[tblNhanVien] ([manv])
GO

ALTER TABLE [dbo].[tblDonTraHang] CHECK CONSTRAINT [FK_tblDonTraHang_tblNhanVien]
GO 


USE [QLNT]
GO

/****** Object:  Table [dbo].[tblChiTietDonTraHang]    Script Date: 5/15/2019 1:16:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblChiTietDonTraHang](
	[madontrahang] [int] NOT NULL,
	[mathuoc_mathietbi] [int] NOT NULL,
	[sl] [int] NULL,
	[dongiamua] [int] NULL,
	[ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChiTietDonTraHang] PRIMARY KEY CLUSTERED 
(
	[madontrahang] ASC,
	[mathuoc_mathietbi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tblChiTietDonTraHang]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietDonTraHang_tblDonTraHang] FOREIGN KEY([madontrahang])
REFERENCES [dbo].[tblDonTraHang] ([madontrahang])
GO

ALTER TABLE [dbo].[tblChiTietDonTraHang] CHECK CONSTRAINT [FK_tblChiTietDonTraHang_tblDonTraHang]
GO

ALTER TABLE [dbo].[tblChiTietDonTraHang]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietDonTraHang_tblThuoc] FOREIGN KEY([mathuoc_mathietbi])
REFERENCES [dbo].[tblThuoc] ([mathuoc])
GO

ALTER TABLE [dbo].[tblChiTietDonTraHang] CHECK CONSTRAINT [FK_tblChiTietDonTraHang_tblThuoc]
GO