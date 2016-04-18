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
LAB: 03 
NGAY:  20/5/2014
----------------------------------------------------------*/ 
IF OBJECT_ID ('dbo.SP_SEL_NHANVIEN') IS NOT NULL
	DROP PROCEDURE dbo.SP_SEL_NHANVIEN
GO
CREATE PROCEDURE dbo.SP_SEL_NHANVIEN
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	OPEN SYMMETRIC KEY [AES256MYKEY]
    DECRYPTION BY CERTIFICATE [cert_keyProtection];


	SELECT
		NV.MANV AS MaNV,
		NV.HOTEN AS HoTen,
		NV.EMAIL AS Email,
		CONVERT(VARCHAR(10), DecryptByKey(NV.LUONG)) AS Luong
		
	FROM [QLSV].[dbo].[NHANVIEN] AS NV

	CLOSE SYMMETRIC KEY [AES256MYKEY];

END
GO
