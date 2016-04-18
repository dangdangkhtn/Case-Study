-- ================================================

-- ================================================
USE [QLSV]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Trần Hải Đăng - 1112072
-- Create date: 24-05-2014
-- Description:	Insert (Thông tin nhân viên - đã được client mã hóa) vào CSDL.
-- =============================================
IF OBJECT_ID ('dbo.SP_INS_ENCRYPT_NHANVIEN') IS NOT NULL
	DROP PROCEDURE SP_INS_ENCRYPT_NHANVIEN
GO
CREATE PROCEDURE SP_INS_ENCRYPT_NHANVIEN
	-- Add the parameters for the stored procedure here
	@MANV VARCHAR (20),
	@HOTEN NVARCHAR(100),
	@EMAIL VARCHAR (20),  
	@E_LUONG VARBINARY(MAX),  
	@TENDN NVARCHAR(100),
	@E_MATKHAU VARBINARY(MAX)
AS
IF NOT EXISTS (SELECT*FROM [QLSV].[dbo].[NHANVIEN] WHERE MANV=@MANV)
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 
	
	INSERT INTO [QLSV].[dbo].[NHANVIEN]
	(
		MANV,
		HOTEN,
		EMAIL,  
		LUONG,  
		TENDN,
		MATKHAU
	)
	VALUES
	(
		@MANV,
		@HOTEN,
		@EMAIL,  
		@E_LUONG,
		@TENDN,
		@E_MATKHAU
	)	
END
GO
