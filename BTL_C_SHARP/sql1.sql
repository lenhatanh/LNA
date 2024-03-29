CREATE DATABASE [QuanLiLopTinHoc]
GO

USE [QuanLiLopTinHoc]
GO
/****** Object:  Table [dbo].[tblCaHoc]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCaHoc](
	[MaCa] [nchar](10) NOT NULL,
	[TenCa] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblCaHoc] PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChucDanh]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucDanh](
	[MaChucDanh] [nchar](10) NOT NULL,
	[TenChucDanh] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChucDanh] PRIMARY KEY CLUSTERED 
(
	[MaChucDanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChuyenMon]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChuyenMon](
	[MaChuyenMon] [nchar](10) NOT NULL,
	[TenChuyenMon] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChuyenMon] PRIMARY KEY CLUSTERED 
(
	[MaChuyenMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCoQuan]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCoQuan](
	[MaCQ] [nchar](10) NOT NULL,
	[TenCQ] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nchar](15) NULL,
 CONSTRAINT [PK_tblCoQuan] PRIMARY KEY CLUSTERED 
(
	[MaCQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien](
	[MaGV] [nchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nchar](10) NULL,
	[DienThoai] [nchar](15) NULL,
	[MaChucDanh] [nchar](10) NULL,
	[MaChuyenMon] [nchar](10) NULL,
	[MaCQ] [nchar](10) NULL,
	[MaTrinhDo] [nchar](10) NULL,
	[Anh] [image] NULL,
 CONSTRAINT [PK_tblGiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiaoVien-MonHoc]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien-MonHoc](
	[MaGV] [nchar](10) NOT NULL,
	[MaMon] [nchar](10) NOT NULL,
	[XepLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblGiaoVien-MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHocVien]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHocVien](
	[MaHocVien] [nchar](10) NOT NULL,
	[TenHocVien] [nvarchar](50) NULL,
	[MaLop] [nchar](10) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaNghe] [nchar](10) NULL,
	[Dienthoai] [nchar](15) NULL,
	[NgayNopHP] [date] NULL,
	[Diem] [float] NULL,
	[MaXepLoai] [nchar](10) NULL,
 CONSTRAINT [PK_tblHocVien] PRIMARY KEY CLUSTERED 
(
	[MaHocVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLopHoc]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopHoc](
	[MaLop] [nchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaMon] [nchar](10) NULL,
	[MaGV] [nchar](10) NULL,
	[NgayBD] [date] NULL,
	[NgayKT] [date] NULL,
	[MaCa] [nchar](10) NULL,
	[MaThoiGian] [nchar](10) NULL,
	[MaPhong] [nchar](10) NULL,
	[SiSo] [int] NULL,
 CONSTRAINT [PK_tblLopHoc] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonHoc](
	[MaMon] [nchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[HocPhi] [float] NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNgheNghiep]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNgheNghiep](
	[MaNghe] [nchar](10) NOT NULL,
	[TenNghe] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNgheNghiep] PRIMARY KEY CLUSTERED 
(
	[MaNghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[MaPhong] [nchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThoiGian]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThoiGian](
	[MaThoiGian] [nchar](10) NOT NULL,
	[TenThoiGian] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblThoiGian] PRIMARY KEY CLUSTERED 
(
	[MaThoiGian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTrinhDo]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTrinhDo](
	[MaTrinhDo] [nchar](10) NOT NULL,
	[TenTrinhDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTrinhDo] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblXepLoai]    Script Date: 10/29/2019 6:18:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXepLoai](
	[MaXepLoai] [nchar](10) NOT NULL,
	[TenXepLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblXepLoai] PRIMARY KEY CLUSTERED 
(
	[MaXepLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien_tblChucDanh] FOREIGN KEY([MaChucDanh])
REFERENCES [dbo].[tblChucDanh] ([MaChucDanh])
GO
ALTER TABLE [dbo].[tblGiaoVien] CHECK CONSTRAINT [FK_tblGiaoVien_tblChucDanh]
GO
ALTER TABLE [dbo].[tblGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien_tblChuyenMon] FOREIGN KEY([MaChuyenMon])
REFERENCES [dbo].[tblChuyenMon] ([MaChuyenMon])
GO
ALTER TABLE [dbo].[tblGiaoVien] CHECK CONSTRAINT [FK_tblGiaoVien_tblChuyenMon]
GO
ALTER TABLE [dbo].[tblGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien_tblCoQuan] FOREIGN KEY([MaCQ])
REFERENCES [dbo].[tblCoQuan] ([MaCQ])
GO
ALTER TABLE [dbo].[tblGiaoVien] CHECK CONSTRAINT [FK_tblGiaoVien_tblCoQuan]
GO
ALTER TABLE [dbo].[tblGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien_tblTrinhDo] FOREIGN KEY([MaTrinhDo])
REFERENCES [dbo].[tblTrinhDo] ([MaTrinhDo])
GO
ALTER TABLE [dbo].[tblGiaoVien] CHECK CONSTRAINT [FK_tblGiaoVien_tblTrinhDo]
GO
ALTER TABLE [dbo].[tblGiaoVien-MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien-MonHoc_tblGiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[tblGiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[tblGiaoVien-MonHoc] CHECK CONSTRAINT [FK_tblGiaoVien-MonHoc_tblGiaoVien]
GO
ALTER TABLE [dbo].[tblGiaoVien-MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien-MonHoc_tblMonHoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[tblGiaoVien-MonHoc] CHECK CONSTRAINT [FK_tblGiaoVien-MonHoc_tblMonHoc]
GO
ALTER TABLE [dbo].[tblHocVien]  WITH CHECK ADD  CONSTRAINT [FK_tblHocVien_tblLopHoc] FOREIGN KEY([MaLop])
REFERENCES [dbo].[tblLopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[tblHocVien] CHECK CONSTRAINT [FK_tblHocVien_tblLopHoc]
GO
ALTER TABLE [dbo].[tblHocVien]  WITH CHECK ADD  CONSTRAINT [FK_tblHocVien_tblNgheNghiep] FOREIGN KEY([MaNghe])
REFERENCES [dbo].[tblNgheNghiep] ([MaNghe])
GO
ALTER TABLE [dbo].[tblHocVien] CHECK CONSTRAINT [FK_tblHocVien_tblNgheNghiep]
GO
ALTER TABLE [dbo].[tblHocVien]  WITH CHECK ADD  CONSTRAINT [FK_tblHocVien_tblXepLoai] FOREIGN KEY([MaXepLoai])
REFERENCES [dbo].[tblXepLoai] ([MaXepLoai])
GO
ALTER TABLE [dbo].[tblHocVien] CHECK CONSTRAINT [FK_tblHocVien_tblXepLoai]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHoc_tblCaHoc] FOREIGN KEY([MaCa])
REFERENCES [dbo].[tblCaHoc] ([MaCa])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblLopHoc_tblCaHoc]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHoc_tblGiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[tblGiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblLopHoc_tblGiaoVien]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHoc_tblPhong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tblPhong] ([MaPhong])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblLopHoc_tblPhong]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHoc_tblThoiGian] FOREIGN KEY([MaThoiGian])
REFERENCES [dbo].[tblThoiGian] ([MaThoiGian])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblLopHoc_tblThoiGian]
GO
