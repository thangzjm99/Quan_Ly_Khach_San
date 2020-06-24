USE [QLKhachSan]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDV] [int] NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[DVT] [nvarchar](50) NULL,
	[GiaTien] [int] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] NOT NULL,
	[HoTenKH] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[CMND] [int] NULL,
	[SDT] [int] NULL,
	[QuocTich] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] NOT NULL,
	[HoTenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SDT] [int] NULL,
	[NgayVaoLam] [date] NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [int] NOT NULL,
	[LoaiPhong] [nvarchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[GiaTien] [int] NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SDDichVu]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SDDichVu](
	[ID_MaDV] [int] NOT NULL,
	[ID_MaPhong] [int] NOT NULL,
	[ID_MaHDThuePhong] [int] NOT NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANHTOAN]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANHTOAN](
	[MaThanhToan] [int] NOT NULL,
	[ID_MaHDThuePhong] [int] NULL,
	[ID_MaNV] [int] NULL,
	[NgayThanhToan] [date] NULL,
	[TienPhong] [int] NULL,
 CONSTRAINT [PK_THANHTOAN] PRIMARY KEY CLUSTERED 
(
	[MaThanhToan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUEPHONG]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUEPHONG](
	[MaHDThuePhong] [int] NOT NULL,
	[ID_MaNV] [int] NULL,
	[NgayThue] [date] NULL,
	[NgayTra] [date] NULL,
	[ID_MaKH] [int] NULL,
	[ID_MaPhong] [int] NULL,
 CONSTRAINT [PK_THUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MaHDThuePhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANGTHIETBI]    Script Date: 3/26/2020 7:40:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHIETBI](
	[MaTTB] [int] NOT NULL,
	[TenTTB] [nvarchar](50) NULL,
	[ID_MaPhong] [int] NULL,
	[SoLuong] [int] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[GiaTri] [int] NULL,
 CONSTRAINT [PK_TRANGTHIETBI] PRIMARY KEY CLUSTERED 
(
	[MaTTB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DVT], [GiaTien]) VALUES (0, N'eeeee', N'cai', 222222)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DVT], [GiaTien]) VALUES (1, N'bia hà nội', N'lon', 10000)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DVT], [GiaTien]) VALUES (2, N'cơm cháy', N'gói', 30000)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DVT], [GiaTien]) VALUES (3, N'hát', N'tiếng', 200000)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DVT], [GiaTien]) VALUES (4, N'tắm bùn', N'vé', 200000)
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [DVT], [GiaTien]) VALUES (5, N'masage', N'vé', 500000)
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [GioiTinh], [DiaChi], [CMND], [SDT], [QuocTich]) VALUES (1, N'Vũ Minh Hiếu', N'nữ', N'Khánh Hòa', 174567834, 1234567890, N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [GioiTinh], [DiaChi], [CMND], [SDT], [QuocTich]) VALUES (2, N'Thạch Thọ Hiếu', N'nam', N'Khánh Hòa', 134563424, 1214356433, N'Thái')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [GioiTinh], [DiaChi], [CMND], [SDT], [QuocTich]) VALUES (3, N'Nguyễn Văn Vũ', N'nam', N'Hà Nội', 134524653, 1678906543, N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [GioiTinh], [DiaChi], [CMND], [SDT], [QuocTich]) VALUES (4, N'Nguyễn Sơn Nam', N'nam', N'Hà Nội', 123432345, 1243908970, N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [GioiTinh], [DiaChi], [CMND], [SDT], [QuocTich]) VALUES (5, N'Nguyễn Văn Dũng', N'nữ', N'Hà Nội', 189080932, 1126545099, N'Việt Nam')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [ChucVu]) VALUES (1, N'Cao Minh Đức', CAST(N'1999-11-06' AS Date), N'nữ', N'Hà Nội', 123456789, CAST(N'1999-12-30' AS Date), N'Quản lý')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [ChucVu]) VALUES (2, N'Phạm Trung Hiếu', CAST(N'1999-11-12' AS Date), N'nam', N'Hải Phòng', 345678903, CAST(N'1999-06-01' AS Date), N'Lễ tân')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [ChucVu]) VALUES (3, N'Nguyễn Tư Tỉnh', CAST(N'1999-04-05' AS Date), N'nam', N'Hà Nội', 435674357, CAST(N'1999-12-22' AS Date), N'Lau dọn')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [ChucVu]) VALUES (4, N'Vũ Hoàng Trung', CAST(N'1999-09-08' AS Date), N'nam', N'Hải Phòng', 974356748, CAST(N'1999-10-29' AS Date), N'Sủa chữa')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayVaoLam], [ChucVu]) VALUES (5, N'Nguyễn Minh Hiếu', CAST(N'1999-11-16' AS Date), N'nam', N'Hà Nội', 976544558, CAST(N'1999-11-07' AS Date), N'Bảo vệ')
INSERT [dbo].[PHONG] ([MaPhong], [LoaiPhong], [TinhTrang], [GiaTien]) VALUES (1, N'Đơn-Thường', N'trống', 300000)
INSERT [dbo].[PHONG] ([MaPhong], [LoaiPhong], [TinhTrang], [GiaTien]) VALUES (2, N'Đôi-Thường', N'trống', 400000)
INSERT [dbo].[PHONG] ([MaPhong], [LoaiPhong], [TinhTrang], [GiaTien]) VALUES (3, N'Đôi-Vip', N'trống', 500000)
INSERT [dbo].[PHONG] ([MaPhong], [LoaiPhong], [TinhTrang], [GiaTien]) VALUES (4, N'Đôi-Thường', N'trống', 400000)
INSERT [dbo].[PHONG] ([MaPhong], [LoaiPhong], [TinhTrang], [GiaTien]) VALUES (5, N'Đôi-Thường', N'trống', 400000)
INSERT [dbo].[SDDichVu] ([ID_MaDV], [ID_MaPhong], [ID_MaHDThuePhong], [SoLuong]) VALUES (1, 1, 1, 2)
INSERT [dbo].[SDDichVu] ([ID_MaDV], [ID_MaPhong], [ID_MaHDThuePhong], [SoLuong]) VALUES (2, 2, 2, 2)
INSERT [dbo].[THANHTOAN] ([MaThanhToan], [ID_MaHDThuePhong], [ID_MaNV], [NgayThanhToan], [TienPhong]) VALUES (1, 1, 2, CAST(N'2020-09-15' AS Date), NULL)
INSERT [dbo].[THANHTOAN] ([MaThanhToan], [ID_MaHDThuePhong], [ID_MaNV], [NgayThanhToan], [TienPhong]) VALUES (2, 2, 2, CAST(N'2020-11-20' AS Date), NULL)
INSERT [dbo].[THANHTOAN] ([MaThanhToan], [ID_MaHDThuePhong], [ID_MaNV], [NgayThanhToan], [TienPhong]) VALUES (3, 3, 2, CAST(N'2020-08-29' AS Date), NULL)
INSERT [dbo].[THANHTOAN] ([MaThanhToan], [ID_MaHDThuePhong], [ID_MaNV], [NgayThanhToan], [TienPhong]) VALUES (4, 4, 2, CAST(N'2020-07-30' AS Date), NULL)
INSERT [dbo].[THANHTOAN] ([MaThanhToan], [ID_MaHDThuePhong], [ID_MaNV], [NgayThanhToan], [TienPhong]) VALUES (5, 5, 2, CAST(N'2020-08-09' AS Date), NULL)
INSERT [dbo].[THUEPHONG] ([MaHDThuePhong], [ID_MaNV], [NgayThue], [NgayTra], [ID_MaKH], [ID_MaPhong]) VALUES (1, 2, CAST(N'2020-09-08' AS Date), CAST(N'2020-09-15' AS Date), 1, 1)
INSERT [dbo].[THUEPHONG] ([MaHDThuePhong], [ID_MaNV], [NgayThue], [NgayTra], [ID_MaKH], [ID_MaPhong]) VALUES (2, 2, CAST(N'2020-11-16' AS Date), CAST(N'2020-11-20' AS Date), 2, 2)
INSERT [dbo].[THUEPHONG] ([MaHDThuePhong], [ID_MaNV], [NgayThue], [NgayTra], [ID_MaKH], [ID_MaPhong]) VALUES (3, 2, CAST(N'2020-08-22' AS Date), CAST(N'2020-08-29' AS Date), 3, 3)
INSERT [dbo].[THUEPHONG] ([MaHDThuePhong], [ID_MaNV], [NgayThue], [NgayTra], [ID_MaKH], [ID_MaPhong]) VALUES (4, 2, CAST(N'2020-07-26' AS Date), CAST(N'2020-07-30' AS Date), 4, 4)
INSERT [dbo].[THUEPHONG] ([MaHDThuePhong], [ID_MaNV], [NgayThue], [NgayTra], [ID_MaKH], [ID_MaPhong]) VALUES (5, 2, CAST(N'2020-08-03' AS Date), CAST(N'2020-08-09' AS Date), 5, 5)
INSERT [dbo].[TRANGTHIETBI] ([MaTTB], [TenTTB], [ID_MaPhong], [SoLuong], [TinhTrang], [GiaTri]) VALUES (1, N'giường', 1, 1, N'tốt', 5000000)
INSERT [dbo].[TRANGTHIETBI] ([MaTTB], [TenTTB], [ID_MaPhong], [SoLuong], [TinhTrang], [GiaTri]) VALUES (2, N'ghế tựa', 1, 1, N'tốt', 1000000)
INSERT [dbo].[TRANGTHIETBI] ([MaTTB], [TenTTB], [ID_MaPhong], [SoLuong], [TinhTrang], [GiaTri]) VALUES (3, N'tủ lạnh', 1, 1, N'tốt', 3000000)
INSERT [dbo].[TRANGTHIETBI] ([MaTTB], [TenTTB], [ID_MaPhong], [SoLuong], [TinhTrang], [GiaTri]) VALUES (4, N'tivi', 1, 1, N'tốt', 5000000)
INSERT [dbo].[TRANGTHIETBI] ([MaTTB], [TenTTB], [ID_MaPhong], [SoLuong], [TinhTrang], [GiaTri]) VALUES (5, N'tivi', 2, 1, N'tốt', 5000000)
ALTER TABLE [dbo].[SDDichVu]  WITH CHECK ADD  CONSTRAINT [FK_SDDichVu_DICHVU] FOREIGN KEY([ID_MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SDDichVu] CHECK CONSTRAINT [FK_SDDichVu_DICHVU]
GO
ALTER TABLE [dbo].[SDDichVu]  WITH CHECK ADD  CONSTRAINT [FK_SDDichVu_PHONG] FOREIGN KEY([ID_MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SDDichVu] CHECK CONSTRAINT [FK_SDDichVu_PHONG]
GO
ALTER TABLE [dbo].[SDDichVu]  WITH CHECK ADD  CONSTRAINT [FK_SDDichVu_THUEPHONG] FOREIGN KEY([ID_MaHDThuePhong])
REFERENCES [dbo].[THUEPHONG] ([MaHDThuePhong])
GO
ALTER TABLE [dbo].[SDDichVu] CHECK CONSTRAINT [FK_SDDichVu_THUEPHONG]
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_THANHTOAN_NHANVIEN] FOREIGN KEY([ID_MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[THANHTOAN] CHECK CONSTRAINT [FK_THANHTOAN_NHANVIEN]
GO
ALTER TABLE [dbo].[THANHTOAN]  WITH CHECK ADD  CONSTRAINT [FK_THANHTOAN_THUEPHONG] FOREIGN KEY([ID_MaHDThuePhong])
REFERENCES [dbo].[THUEPHONG] ([MaHDThuePhong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[THANHTOAN] CHECK CONSTRAINT [FK_THANHTOAN_THUEPHONG]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_THUEPHONG_KHACHHANG] FOREIGN KEY([ID_MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_THUEPHONG_KHACHHANG]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_THUEPHONG_NHANVIEN] FOREIGN KEY([ID_MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_THUEPHONG_NHANVIEN]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_THUEPHONG_PHONG] FOREIGN KEY([ID_MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_THUEPHONG_PHONG]
GO
ALTER TABLE [dbo].[TRANGTHIETBI]  WITH CHECK ADD  CONSTRAINT [FK_TRANGTHIETBI_PHONG] FOREIGN KEY([ID_MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TRANGTHIETBI] CHECK CONSTRAINT [FK_TRANGTHIETBI_PHONG]
GO
