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
IF OBJECT_ID ('dbo.SP_INS_NHANVIEN') IS NOT NULL
	DROP PROCEDURE SP_INS_NHANVIEN
GO
CREATE PROCEDURE SP_INS_NHANVIEN
	-- Add the parameters for the stored procedure here
	@MANV VARCHAR (20),
	@HOTEN NVARCHAR(100),
	@EMAIL VARCHAR (20),  
	@LUONG VARCHAR(10),  
	@TENDN NVARCHAR(100),
	@MATKHAU NVARCHAR(MAX)
AS
IF NOT EXISTS (SELECT*FROM [QLSV].[dbo].[NHANVIEN] WHERE MANV=@MANV)
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	OPEN SYMMETRIC KEY [AES256MYKEY] 
    DECRYPTION BY CERTIFICATE [cert_keyProtection];
	
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
		ENCRYPTBYKEY(KEY_GUID('AES256MYKEY'), @LUONG), 
		@TENDN,
		HASHBYTES('SHA1',@MATKHAU)
	)	
	CLOSE SYMMETRIC KEY [AES256MYKEY];
END
GO
