USE [Technical]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 8/2/2023 12:35:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[HoTen] [nvarchar](100) NULL,
	[NamSinh] [date] NULL,
	[Email] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Employees_Delete]    Script Date: 8/2/2023 12:35:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Employees_Delete] (
	@ID int
)
As
BEgin
	Delete Employees Where ID = @ID
end
GO
/****** Object:  StoredProcedure [dbo].[Employees_insert]    Script Date: 8/2/2023 12:35:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Employees_insert] (
	@MaNV nvarchar(50),
	@HoTen nvarchar(100),
	@NamSinh date,
	@Email nvarchar(50),
	@DienThoai nvarchar(20),
	@DiaChi nvarchar(50)
)
As
BEgin
	insert into Employees (MaNV, HoTen, NamSinh, Email, DienThoai, DiaChi)
	Values(@MaNV, @HoTen, @NamSinh, @Email, @DienThoai, @DiaChi)
end
GO
/****** Object:  StoredProcedure [dbo].[Employees_searchByID]    Script Date: 8/2/2023 12:35:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Employees_searchByID]
	@ID int
AS
BEGIN
	SELECT * FROM Employees WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[Employees_update]    Script Date: 8/2/2023 12:35:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Employees_update] (
	@ID int,
	@MaNV nvarchar(50),
	@HoTen nvarchar(100),
	@NamSinh date,
	@Email nvarchar(50),
	@DienThoai nvarchar(20),
	@DiaChi nvarchar(50)
)
As
BEgin
	update Employees SET MaNV = @MaNV, HoTen = @HoTen, NamSinh = @NamSinh, Email = @Email, DienThoai = @DienThoai, DiaChi=@DiaChi Where ID = @ID
end
GO
