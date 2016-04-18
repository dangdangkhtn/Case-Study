-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
USE [QLSV]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*---------------------------------------------------------- 
MASV: 1112072
HO TEN: Trần Hải Đăng
LAB: 04
NGAY:  20/5/2014
----------------------------------------------------------*/ 
IF OBJECT_ID ('dbo.SP_INS_SINHVIEN') IS NOT NULL
	DROP PROCEDURE SP_INS_SINHVIEN
GO
CREATE PROCEDURE SP_INS_SINHVIEN
	-- Add the parameters for the stored procedure here
	@MASV NVARCHAR(20),
	@HOTEN NVARCHAR(100),
	@NGAYSINH DATETIME,  
	@DIACHI NVARCHAR(200),  
	@MALOP VARCHAR (20),  
	@TENDN NVARCHAR(100),
	@MATKHAU NVARCHAR(50)
AS
IF NOT EXISTS(SELECT*FROM [QLSV].[dbo].[SINHVIEN] WHERE MASV=@MASV)
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	INSERT INTO [QLSV].[dbo].[SINHVIEN]
	(
		MASV,
		HOTEN,
		NGAYSINH,  
		DIACHI,  
		MALOP,  
		TENDN,
		MATKHAU
	)
	VALUES
	(
		@MASV,
		@HOTEN,
		@NGAYSINH,  
		@DIACHI,  
		@MALOP,  
		@TENDN,
		HASHBYTES('MD5',@MATKHAU)
	)
END
GO
