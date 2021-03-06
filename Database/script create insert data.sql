USE [SNEAKERSHOP]
GO
SET IDENTITY_INSERT [dbo].[CATALOGY] ON 

GO
INSERT [dbo].[CATALOGY] ([ID_CATALOGY], [NAME]) VALUES (1, N'GIÀY NAM')
GO
INSERT [dbo].[CATALOGY] ([ID_CATALOGY], [NAME]) VALUES (2, N'GIÀY NỮ')
GO
INSERT [dbo].[CATALOGY] ([ID_CATALOGY], [NAME]) VALUES (3, N'PHỤ KIỆN')
GO
SET IDENTITY_INSERT [dbo].[CATALOGY] OFF
GO
SET IDENTITY_INSERT [dbo].[NHASX] ON 

GO
INSERT [dbo].[NHASX] ([ID_NHASX], [NAME]) VALUES (1, N'ADIDAS')
GO
INSERT [dbo].[NHASX] ([ID_NHASX], [NAME]) VALUES (2, N'ASISC')
GO
INSERT [dbo].[NHASX] ([ID_NHASX], [NAME]) VALUES (3, N'CONVERSE')
GO
INSERT [dbo].[NHASX] ([ID_NHASX], [NAME]) VALUES (4, N'NIKE')
GO
INSERT [dbo].[NHASX] ([ID_NHASX], [NAME]) VALUES (5, N'PUMA')
GO
INSERT [dbo].[NHASX] ([ID_NHASX], [NAME]) VALUES (6, N'REEBOK')
GO

SET IDENTITY_INSERT [dbo].[NHASX] OFF
GO
SET IDENTITY_INSERT [dbo].[SIZE] ON 

GO
INSERT [dbo].[SIZE] ([ID_SIZE], [SIZE1], [NAME]) VALUES (1, N'35', N'Rất nhỏ')
GO
INSERT [dbo].[SIZE] ([ID_SIZE], [SIZE1], [NAME]) VALUES (2, N'38', N'Nhỏ')
GO
INSERT [dbo].[SIZE] ([ID_SIZE], [SIZE1], [NAME]) VALUES (3, N'40', N'Vừa')
GO
INSERT [dbo].[SIZE] ([ID_SIZE], [SIZE1], [NAME]) VALUES (4, N'42', N'Lớn')
GO
INSERT [dbo].[SIZE] ([ID_SIZE], [SIZE1], [NAME]) VALUES (5, N'45', N'Rất Lớn')
GO
SET IDENTITY_INSERT [dbo].[SIZE] OFF
GO
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

GO
INSERT [dbo].[SANPHAM] ([ID_SANPHAM], [ID_CATALOGY], [ID_NHASX], [TENSP], [ID_SIZE], [GIA], [SALE], [MAUSAC], [MOTA], [IMAGE1], [IMAGE2], [IMAGE3], [IMAGE4], [SOLUONG], [NGAY], [TAGS]) VALUES (12, 1, 1, N'Giày nam', 3, CAST(400000 AS Decimal(18, 0)), CAST(200000 AS Decimal(18, 0)), N'Đen', N'mo ta', N'1(18).jpg', N'1(14).jpg', N'1(14).jpg', N'1(14).jpg', 2, CAST(N'1900-01-01 00:00:00.000' AS DateTime), N'1')
GO
INSERT [dbo].[SANPHAM] ([ID_SANPHAM], [ID_CATALOGY], [ID_NHASX], [TENSP], [ID_SIZE], [GIA], [SALE], [MAUSAC], [MOTA], [IMAGE1], [IMAGE2], [IMAGE3], [IMAGE4], [SOLUONG], [NGAY], [TAGS]) VALUES (13, 1, 1, N'Giay the thao 2', 1, CAST(420000 AS Decimal(18, 0)), CAST(20000 AS Decimal(18, 0)), NULL, NULL, N'2(14).jpg', N'2(14).jpg', N'2(14).jpg', N'2(14).jpg', 2, CAST(N'2019-01-24 00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[SANPHAM] ([ID_SANPHAM], [ID_CATALOGY], [ID_NHASX], [TENSP], [ID_SIZE], [GIA], [SALE], [MAUSAC], [MOTA], [IMAGE1], [IMAGE2], [IMAGE3], [IMAGE4], [SOLUONG], [NGAY], [TAGS]) VALUES (14, 2, 4, N'Giay hotgirl', 1, CAST(220000 AS Decimal(18, 0)), CAST(100000 AS Decimal(18, 0)), N'cam', NULL, N'16.jpg', N'16.jpg', N'16.jpg', N'16.jpg', 3, CAST(N'2019-01-24 00:00:00.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
GO
SET IDENTITY_INSERT [dbo].[USERS] ON 

GO
INSERT [dbo].[USERS] ([ID_USER], [LOGINNAME], [PASS], [USERNAME], [DT], [DIACHI], [EMAIL]) VALUES (1, N'user2', N'ee11cbb19052e40b07aac0ca060c23ee', N'user2', N'0529525252', N'TP.HCM', N'TP.HCM')
GO
SET IDENTITY_INSERT [dbo].[USERS] OFF
GO
SET IDENTITY_INSERT [dbo].[DATHANG] ON 

GO
INSERT [dbo].[DATHANG] ([ID_ODER], [USRERNAME], [ADDRESS], [PHONE], [EMAIL], [ISACTIVE]) VALUES (1, N'user', N'TP.HCM', N'0988908908', N'user@yahoo.com.vn', 1)
GO
INSERT [dbo].[DATHANG] ([ID_ODER], [USRERNAME], [ADDRESS], [PHONE], [EMAIL], [ISACTIVE]) VALUES (2, N'jghj', N'gjg', N'897', N'jghj', 0)
GO
SET IDENTITY_INSERT [dbo].[DATHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[CT_DATHANG] ON 

GO
INSERT [dbo].[CT_DATHANG] ([ID_CTDH], [ID_ODER], [ID_SANPHAM], [SOLUONG]) VALUES (1, 1, 12, 2)
GO
INSERT [dbo].[CT_DATHANG] ([ID_CTDH], [ID_ODER], [ID_SANPHAM], [SOLUONG]) VALUES (2, 2, 12, 1)
GO
INSERT [dbo].[CT_DATHANG] ([ID_CTDH], [ID_ODER], [ID_SANPHAM], [SOLUONG]) VALUES (3, 2, 13, 1)
GO
SET IDENTITY_INSERT [dbo].[CT_DATHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[GIOITHIEU] ON 

GO
INSERT [dbo].[GIOITHIEU] ([ID_GT], [TIEUDE], [NOIDUNG]) VALUES (1, N'Giới thiệu web giày dép', N'Tphcm là trung tâm của các loại giày xuất khẩu cho cả nam và nữ với nguồi hàng chủ yếu từ các nhà máy ở Bình Dương, Đồng Nai và 1 phần từ Cambodia về. Nắm bắt được nhu cầu lựa chọn 1 đôi giày có chất lượng tốt với giá phải chăng chúng tôi liên tục cập nhật các mẫu giày mới nhất của các bộ sưu tập giày thời trang hàng hiệu.

Được thành lập từ năm 2007. Cho tới nay chúng tôi đã có gần 10 năm kinh nghiệm trong việc bán giày thời trang nam xuất khẩu. Chúng tôi hiểu những nhu cầu của khách hàng đối với 1 đôi giày đúng nghĩa dành cho người trưởng thành.

Chúng tôi tự tin cung cấp các thông tin về nguồn gốc hàng hóa cùng cách tư vấn bài bản trong việc sử dụng và kết hợp đồ thời trang phù hợp cho đối tượng khách hàng là thanh niên và trung niên.

Đối với việc lựa chọn 1 đôi giày thì vẻ đẹp từ chất lượng là vẻ đẹp quan trọng nhất đối với nam giới. Web chúng tôi luôn hiểu điều đó

Bên cạnh đó là sự phối hợp với các loại đồ với loại giày khác nhau từ đồ đi chơi, đi làm cho đến đồ dự tiệc là việc rất quan trọng. Chúng tôi bán giày và có trách nhiệm tư vấn cho khách hàng những vấn đề như vậy.')
GO
SET IDENTITY_INSERT [dbo].[GIOITHIEU] OFF
GO
SET IDENTITY_INSERT [dbo].[SLIDEPHOTO] ON 

GO
INSERT [dbo].[SLIDEPHOTO] ([ID_SLIDE], [TIEUDE], [LINKIMAGES], [LienKet], [MOTA]) VALUES (1, N'tieu de 1', N'1.jpg', N'#', N'mo ta')
GO
INSERT [dbo].[SLIDEPHOTO] ([ID_SLIDE], [TIEUDE], [LINKIMAGES], [LienKet], [MOTA]) VALUES (2, N'tieu de 2', N'2.jpg', N'#', N'mo ta 2')
GO
SET IDENTITY_INSERT [dbo].[SLIDEPHOTO] OFF
GO
SET IDENTITY_INSERT [dbo].[TINTUC] ON 

GO
INSERT [dbo].[TINTUC] ([ID_TT], [TIEUDE], [IMAGES], [NOIDUNGTOMTAT], [NOIDUNG]) VALUES (1, N'tieu de 1', NULL, N'noi dung', N'noi dung dai')
GO
SET IDENTITY_INSERT [dbo].[TINTUC] OFF
GO
