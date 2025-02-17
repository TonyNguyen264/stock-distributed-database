USE [master]
GO
/****** Object:  Database [CHUNGKHOAN]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE DATABASE [CHUNGKHOAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CHUNGKHOAN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER\MSSQL\DATA\CHUNGKHOAN.mdf' , SIZE = 50368KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CHUNGKHOAN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SERVER\MSSQL\DATA\CHUNGKHOAN_log.ldf' , SIZE = 70976KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE SQL_Latin1_General_CP1_CI_AS
GO
ALTER DATABASE [CHUNGKHOAN] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CHUNGKHOAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CHUNGKHOAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CHUNGKHOAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CHUNGKHOAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CHUNGKHOAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CHUNGKHOAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET RECOVERY FULL 
GO
ALTER DATABASE [CHUNGKHOAN] SET  MULTI_USER 
GO
ALTER DATABASE [CHUNGKHOAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CHUNGKHOAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CHUNGKHOAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CHUNGKHOAN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CHUNGKHOAN] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CHUNGKHOAN', N'ON'
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [nvsogd1]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [nvsogd1] WITH PASSWORD=N'SÒP`1¿YÚð~£Xñ
ã_³ôm¡@ÝÛúÇ?', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER LOGIN [nvsogd1] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [nvct2cn1]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [nvct2cn1] WITH PASSWORD=N'JëM¸O¼ Z×Ä¶ef¾¿Í.XãÖTk3â-¸×e¶', DEFAULT_DATABASE=[CHUNGKHOAN], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [nvct2cn1] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [nvcongty5]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [nvcongty5] WITH PASSWORD=N'nMrKàtzsI{Ö¯:e£¿gúöLÃ¢%Në', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER LOGIN [nvcongty5] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [nvcongty1]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [nvcongty1] WITH PASSWORD=N'Þ¼²¬5¦Øswý.#^ òì7Õ{Å', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER LOGIN [nvcongty1] DISABLE
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLAgent$SERVER]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [NT SERVICE\SQLAgent$SERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\ReportServer$SERVER]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [NT SERVICE\ReportServer$SERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQL$SERVER]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [NT Service\MSSQL$SERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [ndt2]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [ndt2] WITH PASSWORD=N'ÿ]bxÂÿ*¼­ì°ÌeÅcÏ³\sNn', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER LOGIN [ndt2] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [HTKN]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [HTKN] WITH PASSWORD=N'rÃ]3ÆûÃ¸0ÇÛbtTÉ6½Z_¹¢Ûlõ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER LOGIN [HTKN] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [distributor_admin]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [distributor_admin] WITH PASSWORD=N'^EshJbBÇeó¾ö%®Cà{ÀSé/»öôÛÓ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [distributor_admin] DISABLE
GO
/****** Object:  Login [DESKTOP-JN8NVTU\nguye]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [DESKTOP-JN8NVTU\nguye] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'XÔÆ9vä¼ô\}Ü+Q\
ûe¶#ò5¢éNy', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'Éº_3·Êaç®ä{$Ö<%9¶üù$0sÙÊ{ï', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER AUTHORIZATION ON DATABASE::[CHUNGKHOAN] TO [sa]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [nvsogd1]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [nvct2cn1]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [nvcongty5]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [nvcongty1]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLAgent$SERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQL$SERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [distributor_admin]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [DESKTOP-JN8NVTU\nguye]
GO
USE [CHUNGKHOAN]
GO
/****** Object:  User [san1]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE USER [san1] FOR LOGIN [nvsogd1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [HTKN]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE USER [HTKN] FOR LOGIN [HTKN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ct5]    Script Date: 11/28/2023 11:02:25 PM ******/
CREATE USER [ct5] FOR LOGIN [nvcongty5] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ct2]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE USER [ct2] FOR LOGIN [nvct2cn1] WITH DEFAULT_SCHEMA=[ct2]
GO
/****** Object:  User [ct1]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE USER [ct1] FOR LOGIN [nvcongty1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [2]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE USER [2] FOR LOGIN [ndt2] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [1]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE USER [1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[nvsogd1]
GO
/****** Object:  DatabaseRole [SOGD]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE ROLE [SOGD]
GO
/****** Object:  DatabaseRole [NHADAUTU]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE ROLE [NHADAUTU]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [MSmerge_9D83EB3558C24B3286F779B124F7F58F]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE ROLE [MSmerge_9D83EB3558C24B3286F779B124F7F58F]
GO
/****** Object:  DatabaseRole [MSmerge_8B151E26E5B3442ABDA51EEE394D8A4D]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE ROLE [MSmerge_8B151E26E5B3442ABDA51EEE394D8A4D]
GO
/****** Object:  DatabaseRole [CONGTY]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE ROLE [CONGTY]
GO
ALTER AUTHORIZATION ON ROLE::[SOGD] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[NHADAUTU] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_PAL_role] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_9D83EB3558C24B3286F779B124F7F58F] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_8B151E26E5B3442ABDA51EEE394D8A4D] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[CONGTY] TO [dbo]
GO
ALTER ROLE [SOGD] ADD MEMBER [san1]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [san1]
GO
ALTER ROLE [db_datareader] ADD MEMBER [san1]
GO
ALTER ROLE [db_owner] ADD MEMBER [HTKN]
GO
ALTER ROLE [CONGTY] ADD MEMBER [ct5]
GO
ALTER ROLE [db_owner] ADD MEMBER [ct5]
GO
ALTER ROLE [CONGTY] ADD MEMBER [ct2]
GO
ALTER ROLE [db_owner] ADD MEMBER [ct2]
GO
ALTER ROLE [CONGTY] ADD MEMBER [ct1]
GO
ALTER ROLE [db_owner] ADD MEMBER [ct1]
GO
ALTER ROLE [NHADAUTU] ADD MEMBER [2]
GO
ALTER ROLE [db_datareader] ADD MEMBER [2]
GO
ALTER ROLE [SOGD] ADD MEMBER [1]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [1]
GO
ALTER ROLE [db_datareader] ADD MEMBER [1]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [SOGD]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SOGD]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NHADAUTU]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_9D83EB3558C24B3286F779B124F7F58F]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_8B151E26E5B3442ABDA51EEE394D8A4D]
GO
ALTER ROLE [db_owner] ADD MEMBER [CONGTY]
GO
GRANT CONNECT TO [1] AS [dbo]
GO
GRANT CONNECT TO [2] AS [dbo]
GO
GRANT CONNECT TO [ct1] AS [dbo]
GO
GRANT CONNECT TO [ct2] AS [dbo]
GO
GRANT CONNECT TO [ct5] AS [dbo]
GO
GRANT CONNECT TO [HTKN] AS [dbo]
GO
GRANT CONNECT TO [san1] AS [dbo]
GO
/****** Object:  Schema [ct2]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE SCHEMA [ct2] AUTHORIZATION [ct2]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE SCHEMA [MSmerge_PAL_role] AUTHORIZATION [MSmerge_PAL_role]
GO
/****** Object:  Schema [nvsogd1]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE SCHEMA [nvsogd1] AUTHORIZATION [1]
GO
/****** Object:  Table [dbo].[ChiTietQuyDinhCongTy]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietQuyDinhCongTy](
	[MaQuyDinh] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaNhanVien] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayApDung] [datetime] NOT NULL,
	[GiaTri] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_15813F8060834A3CA64426563A8B6C14]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_ChiTietQuyDinhCongTy] PRIMARY KEY CLUSTERED 
(
	[MaQuyDinh] ASC,
	[MaNhanVien] ASC,
	[NgayApDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[ChiTietQuyDinhCongTy] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[ChiTietQuyDinhSan]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietQuyDinhSan](
	[MaQuyDinh] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaNhanVien] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayApDung] [datetime] NOT NULL,
	[GiaTri] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_BB6E8FCEF17D475BA2F1FD7E475DD3FE]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_ChiTietQuyDinhSan] PRIMARY KEY CLUSTERED 
(
	[MaQuyDinh] ASC,
	[MaNhanVien] ASC,
	[NgayApDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[ChiTietQuyDinhSan] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[CongTyCK]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTyCK](
	[MaCongTy] [nchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenCongTy] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_16BA3AF269FC41E1804D83B54F6B10C0]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CongTyCK] PRIMARY KEY CLUSTERED 
(
	[MaCongTy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[CongTyCK] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[CoPhieu]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoPhieu](
	[MaCoPhieu] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenCongTy] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Email] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Fax] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoDienThoai] [nvarchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Website] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_79C21D61D770452988F8FF13999AA433]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_CoPhieu] PRIMARY KEY CLUSTERED 
(
	[MaCoPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[CoPhieu] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[LenhDat]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LenhDat](
	[IDLenhDat] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Gia] [money] NULL,
	[LoaiGiaoDich] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoLuong] [int] NULL,
	[ThoiGian] [date] NOT NULL CONSTRAINT [df_ThoiGian]  DEFAULT (getdate()),
	[MaCoPhieu] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaLoaiLenh] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaTrangThai] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoTaiKhoan] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_CFF7310D834341CE8B86FAB370ED97B5]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LenhDat] PRIMARY KEY CLUSTERED 
(
	[IDLenhDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[LenhDat] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[LenhKhop]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LenhKhop](
	[IDLenhKhop] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[Gia] [money] NULL,
	[SoLuong] [int] NULL,
	[ThoiGian] [date] NOT NULL,
	[IDLenhDat] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_6E5309B7D4A74D22A127E11AC72006C0]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LenhKhop] PRIMARY KEY CLUSTERED 
(
	[IDLenhKhop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[LenhKhop] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[LichSuGia]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuGia](
	[MaCoPhieu] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[GiaDongCua] [money] NULL,
	[GiaMoCua] [money] NULL,
	[GiaThamChieu] [money] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_42483481136645F18192D3D431F55785]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LichSuGia] PRIMARY KEY CLUSTERED 
(
	[MaCoPhieu] ASC,
	[Ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[LichSuGia] TO  SCHEMA OWNER 
GO
GRANT ALTER ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT CONTROL ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT DELETE ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT INSERT ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT REFERENCES ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT SELECT ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT TAKE OWNERSHIP ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT UPDATE ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT VIEW DEFINITION ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
GRANT VIEW CHANGE TRACKING ON [dbo].[LichSuGia] TO [SOGD] WITH GRANT OPTION  AS [dbo]
GO
/****** Object:  Table [dbo].[LoaiLenh]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiLenh](
	[MaLoaiLenh] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenLoaiLenh] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_5EFA92E12A404883A7D32484A923A1C2]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_TLoaiLenh] PRIMARY KEY CLUSTERED 
(
	[MaLoaiLenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[LoaiLenh] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[NganHang]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganHang](
	[MaNganHang] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenNganHang] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_EA9FE6821F80433CBABEDB7E49E59B0B]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NganHang] PRIMARY KEY CLUSTERED 
(
	[MaNganHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[NganHang] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[NhaDauTu]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaDauTu](
	[MaNDT] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ho] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ten] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Phai] [nvarchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Email] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoDT] [nvarchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CMND_Passport] [nvarchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[QuocTich] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MatKhauGiaoDich] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MatKhauDatLenh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_5600BA8B78E4489C90DF3449B3868895]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NhaDauTu] PRIMARY KEY CLUSTERED 
(
	[MaNDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[NhaDauTu] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[NhanVienCongTy]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVienCongTy](
	[MaNhanVien] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ho] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ten] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgaySinh] [date] NULL,
	[Phai] [nvarchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoDT] [nvarchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TrangThaiXoa] [int] NULL,
	[MaCongTy] [nchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_2BE29D9B63E3481FAB63DAABCF142C53]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NhanVienCongTy] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[NhanVienCongTy] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[NhanVienSan]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVienSan](
	[MaNhanVien] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ho] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ten] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgaySinh] [date] NULL,
	[Phai] [nvarchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DiaChi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoDT] [nvarchar](15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TrangThaiXoa] [int] NULL,
	[TenSan] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_D5A3901D46AB49BEB1D77A4E53120730]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_NhanVienSan] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[NhanVienSan] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[PhatHanh]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhatHanh](
	[MaCoPhieu] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[SoLuongPhatHanh] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_6F913C8242A34B5A9ADC26AF948C9005]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_PhatHanh] PRIMARY KEY CLUSTERED 
(
	[MaCoPhieu] ASC,
	[Ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[PhatHanh] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[QuyDinhCongTy]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhCongTy](
	[MaQuyDinh] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenQuyDinh] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_QuyDinhCongTy] PRIMARY KEY CLUSTERED 
(
	[MaQuyDinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[QuyDinhCongTy] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[QuyDinhSan]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhSan](
	[MaQuyDinh] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenQuyDinh] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_F49E9E80529044B19C2B9AFE7176E231]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_QuyDinhSan] PRIMARY KEY CLUSTERED 
(
	[MaQuyDinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[QuyDinhSan] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[SoHuu]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoHuu](
	[MaCoPhieu] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaNDT] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoLuong] [int] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A430E4D97B434D959202BF4B06516FAF]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_SoHuu] PRIMARY KEY CLUSTERED 
(
	[MaCoPhieu] ASC,
	[MaNDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[SoHuu] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[TaiKhoanGiaoDich]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanGiaoDich](
	[MaTKGD] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaCongTy] [nchar](3) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[NgayMoTaiKhoan] [datetime] NOT NULL,
	[MaNDT] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_C7C8924CB2534998876884EB220C5E10]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_TaiKhoanGiaoDich] PRIMARY KEY CLUSTERED 
(
	[MaTKGD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[TaiKhoanGiaoDich] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[TaiKhoanNganHang]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanNganHang](
	[SoTaiKhoan] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[SoDu] [money] NOT NULL,
	[MaNganHang] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MaNDT] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_39162E1C4712444EB7D9C8AB1F4ABB95]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_TaiKhoanNganHang] PRIMARY KEY CLUSTERED 
(
	[SoTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[TaiKhoanNganHang] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[MaTrangThai] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[TenTrangThai] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_901D87BEB32E441793DDB7A13AF954CE]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_TrangThai] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[TrangThai] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[view_DanhSachPhanManh]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_DanhSachPhanManh]
AS
	SELECT TENCN=PUBS.description, TENSERVER=subscriber_server
	 FROM sysmergepublications  PUBS, sysmergesubscriptions SUBS
 	WHERE PUBS.pubid = SUBS.pubid AND  publisher <> subscriber_server

GO
ALTER AUTHORIZATION ON [dbo].[view_DanhSachPhanManh] TO  SCHEMA OWNER 
GO
INSERT [dbo].[ChiTietQuyDinhCongTy] ([MaQuyDinh], [MaNhanVien], [NgayApDung], [GiaTri], [rowguid]) VALUES (N'CN01                ', N'ct1                 ', CAST(N'2023-12-02 00:00:00.000' AS DateTime), N'1', N'3ecc0f82-ca82-ee11-b627-909c4ac96a5a')
INSERT [dbo].[ChiTietQuyDinhSan] ([MaQuyDinh], [MaNhanVien], [NgayApDung], [GiaTri], [rowguid]) VALUES (N'PHIGD               ', N'1                   ', CAST(N'2023-11-02 00:00:00.000' AS DateTime), N'5', N'934f20c4-b884-ee11-b627-909c4ac96a5a')
INSERT [dbo].[ChiTietQuyDinhSan] ([MaQuyDinh], [MaNhanVien], [NgayApDung], [GiaTri], [rowguid]) VALUES (N'PHIGD               ', N'1                   ', CAST(N'2023-11-17 00:00:00.000' AS DateTime), N'10', N'ccb418d3-b884-ee11-b627-909c4ac96a5a')
INSERT [dbo].[CongTyCK] ([MaCongTy], [TenCongTy], [DiaChi], [rowguid]) VALUES (N'010', N'Công ty Cổ phần Chứng khoán FPT', N'Công ty Cổ phần Chứng khoán FPT', N'a3c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[CongTyCK] ([MaCongTy], [TenCongTy], [DiaChi], [rowguid]) VALUES (N'020', N'	Công ty cổ phần Chứng khoán Dầu khí', N'Số 1-5 Lê Duẩn, Quận 1, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh', N'a4c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[CoPhieu] ([MaCoPhieu], [TenCongTy], [Email], [Fax], [SoDienThoai], [Website], [rowguid]) VALUES (N'AAV                 ', N'CTCP AAV Group', N'AVV@gmail.com', N'12', N'84-320.6266066', N'avv.com', N'a5c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[CoPhieu] ([MaCoPhieu], [TenCongTy], [Email], [Fax], [SoDienThoai], [Website], [rowguid]) VALUES (N'ADC                 ', N'Công ty cổ phần Mĩ thuật và Truyền thông', N'adc@gmail.com', N'13', N'0102365521', N'adc.com', N'a6c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[CoPhieu] ([MaCoPhieu], [TenCongTy], [Email], [Fax], [SoDienThoai], [Website], [rowguid]) VALUES (N'CMC                 ', N'CTCP Đầu tư CMC', N'cmc@gmail.com', N'14', N'04 36810237', N'cmc.com', N'a7c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[CoPhieu] ([MaCoPhieu], [TenCongTy], [Email], [Fax], [SoDienThoai], [Website], [rowguid]) VALUES (N'CPC                 ', N'CTCP Thuốc sát trùng Cần Thơ', N'cpc@gmail.com', N'15', N'04 36810239', N'cpc.com', N'a8c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[CoPhieu] ([MaCoPhieu], [TenCongTy], [Email], [Fax], [SoDienThoai], [Website], [rowguid]) VALUES (N'DNC                 ', N'	CTCP Điện nước lắp máy Hải Phòng', N'dnc@gmail.com', N'16', N'04 36810210', N'dnc.com', N'a9c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[CoPhieu] ([MaCoPhieu], [TenCongTy], [Email], [Fax], [SoDienThoai], [Website], [rowguid]) VALUES (N'FPT                 ', N'FPT compamy', N'fpt@gmail.com', N'12', N'42424443', N'fpt.com', N'242cbc64-4785-ee11-b627-909c4ac96a5a')
INSERT [dbo].[CoPhieu] ([MaCoPhieu], [TenCongTy], [Email], [Fax], [SoDienThoai], [Website], [rowguid]) VALUES (N'MGW                 ', N'Thế giới di động', N'MGW@gmail.com', N'123223', N'1212', N'121212', N'7feb185c-7f85-ee11-b627-909c4ac96a5a')
SET IDENTITY_INSERT [dbo].[LenhDat] ON 

INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (1, 50000.0000, N'Mua                 ', 100, CAST(N'2023-11-16' AS Date), N'AAV                 ', N'LO                  ', N'KHOPHET             ', N'1                   ', N'bb5275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (2, 60000.0000, N'Ban                 ', 50, CAST(N'2023-11-16' AS Date), N'ADC                 ', N'MB                  ', N'CHOKHOP             ', N'1                   ', N'bc5275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (3, 5000.0000, N'Mua                 ', 65, CAST(N'2023-11-15' AS Date), N'AAV                 ', N'LO                  ', N'DAHUY               ', N'2                   ', N'bd5275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (4, 5000.0000, N'Ban                 ', 20, CAST(N'2023-11-17' AS Date), N'ADC                 ', N'LO                  ', N'CHUAKHOP            ', N'1                   ', N'be5275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (5, 50000.0000, N'Ban                 ', 15, CAST(N'2023-11-18' AS Date), N'AAV                 ', N'MB                  ', N'KHOPHET             ', N'3                   ', N'bf5275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (6, 70000.0000, N'Mua                 ', 10, CAST(N'2023-11-17' AS Date), N'AAV                 ', N'LO                  ', N'DAHUY               ', N'3                   ', N'c05275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (7, 35000.0000, N'Mua                 ', 15, CAST(N'2023-11-16' AS Date), N'ADC                 ', N'MB                  ', N'CHUAKHOP            ', N'3                   ', N'c15275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (8, 110000.0000, N'Ban                 ', 25, CAST(N'2023-11-14' AS Date), N'AAV                 ', N'MB                  ', N'KHOPHET             ', N'1                   ', N'c25275ed-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (49, 5000.0000, N'Mua                 ', 20, CAST(N'2023-11-17' AS Date), N'ADC                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'3                   ', N'd2f6750d-4c85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (50, 15000.0000, N'Ban                 ', 150, CAST(N'2023-11-17' AS Date), N'AAV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'1                   ', N'35fb9f92-5d85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (51, 15000.0000, N'Ban                 ', 120, CAST(N'2023-11-11' AS Date), N'aaV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'1                   ', N'4b12a88a-5e85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (52, 1500.0000, N'Ban                 ', 120, CAST(N'2023-11-11' AS Date), N'aaV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'1                   ', N'4fdc7de2-5e85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (53, 1500.0000, N'Ban                 ', 120, CAST(N'2023-11-11' AS Date), N'aaV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'1                   ', N'e95e4542-5f85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (54, 1500.0000, N'Ban                 ', 120, CAST(N'2023-11-11' AS Date), N'aaV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'1                   ', N'20ee9c65-5f85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (68002, 110000.0000, N'Mua                 ', 25, CAST(N'2023-11-17' AS Date), N'AAV                 ', N'MB                  ', N'CHOKHOP             ', N'1                   ', N'd20e3e06-4a85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (68003, 1500.0000, N'Mua                 ', 120, CAST(N'2023-11-17' AS Date), N'AAV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'1                   ', N'dfc90837-6085-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (68004, 1500.0000, N'Mua                 ', 120, CAST(N'2023-11-17' AS Date), N'AAV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'2                   ', N'0d9aa496-6085-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (68005, 1500.0000, N'Mua                 ', 120, CAST(N'2023-11-17' AS Date), N'AAV                 ', N'LO                  ', N'KHOPMOTPHAN         ', N'2                   ', N'6f9666bb-6085-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhDat] ([IDLenhDat], [Gia], [LoaiGiaoDich], [SoLuong], [ThoiGian], [MaCoPhieu], [MaLoaiLenh], [MaTrangThai], [SoTaiKhoan], [rowguid]) VALUES (68006, 1500.0000, N'Mua                 ', 120, CAST(N'2023-11-18' AS Date), N'AAV                 ', N'LO                  ', N'KHOPHET             ', N'1                   ', N'8dbd1d7e-ae85-ee11-b628-909c4ac96a5a')
SET IDENTITY_INSERT [dbo].[LenhDat] OFF
SET IDENTITY_INSERT [dbo].[LenhKhop] ON 

INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (1, 50000.0000, 60, CAST(N'2023-09-04' AS Date), 1, N'd2fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (2, 60000.0000, 50, CAST(N'2022-03-11' AS Date), 1, N'd3fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (3, 70000.0000, 20, CAST(N'2023-11-12' AS Date), 2, N'd4fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (4, 65000.0000, 10, CAST(N'2023-09-10' AS Date), 3, N'd5fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (5, 80000.0000, 15, CAST(N'2023-11-16' AS Date), 4, N'd6fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (6, 90000.0000, 5, CAST(N'2023-04-05' AS Date), 5, N'd7fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (7, 100000.0000, 30, CAST(N'2023-06-09' AS Date), 6, N'd8fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (8, 45000.0000, 15, CAST(N'2023-09-09' AS Date), 7, N'd9fd28e6-f083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (40, 150.0000, 100, CAST(N'2023-11-17' AS Date), 68005, N'40b4a654-6285-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (68002, 1500.0000, 30, CAST(N'2023-11-17' AS Date), 51, N'e0c90837-6085-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (68003, 1500.0000, 30, CAST(N'2023-11-17' AS Date), 51, N'0e9aa496-6085-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LenhKhop] ([IDLenhKhop], [Gia], [SoLuong], [ThoiGian], [IDLenhDat], [rowguid]) VALUES (68004, 1500.0000, 30, CAST(N'2023-11-17' AS Date), 51, N'709666bb-6085-ee11-b627-909c4ac96a5a')
SET IDENTITY_INSERT [dbo].[LenhKhop] OFF
INSERT [dbo].[LichSuGia] ([MaCoPhieu], [Ngay], [GiaDongCua], [GiaMoCua], [GiaThamChieu], [rowguid]) VALUES (N'AAV                 ', CAST(N'2023-01-23 00:00:00.000' AS DateTime), 1000.0000, 1200.0000, 900.0000, N'130d9454-ef83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LichSuGia] ([MaCoPhieu], [Ngay], [GiaDongCua], [GiaMoCua], [GiaThamChieu], [rowguid]) VALUES (N'ADC                 ', CAST(N'2023-11-02 00:00:00.000' AS DateTime), 900.0000, 800.0000, 700.0000, N'6ab550c0-4685-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LichSuGia] ([MaCoPhieu], [Ngay], [GiaDongCua], [GiaMoCua], [GiaThamChieu], [rowguid]) VALUES (N'CMC                 ', CAST(N'2023-11-03 00:00:00.000' AS DateTime), 1100.0000, 1000.0000, 800.0000, N'844075e1-4685-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LichSuGia] ([MaCoPhieu], [Ngay], [GiaDongCua], [GiaMoCua], [GiaThamChieu], [rowguid]) VALUES (N'CPC                 ', CAST(N'2023-03-12 00:00:00.000' AS DateTime), 2000.0000, 1200.0000, 1600.0000, N'c03ef3ed-4685-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LichSuGia] ([MaCoPhieu], [Ngay], [GiaDongCua], [GiaMoCua], [GiaThamChieu], [rowguid]) VALUES (N'DNC                 ', CAST(N'2023-04-02 00:00:00.000' AS DateTime), 1500.0000, 1240.0000, 1400.0000, N'57a80d02-4785-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LoaiLenh] ([MaLoaiLenh], [TenLoaiLenh], [rowguid]) VALUES (N'LO                  ', N'Lệnh đặt giới hạn', N'baffc0a3-eb83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[LoaiLenh] ([MaLoaiLenh], [TenLoaiLenh], [rowguid]) VALUES (N'MB                  ', N'Lệnh thị trường', N'bbffc0a3-eb83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[NganHang] ([MaNganHang], [TenNganHang], [rowguid]) VALUES (N'ACB                 ', N'Ngân hàng thương mại cổ phần Á Châu', N'aac3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NganHang] ([MaNganHang], [TenNganHang], [rowguid]) VALUES (N'MB                  ', N'Ngân hàng Quân đội', N'abc3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NganHang] ([MaNganHang], [TenNganHang], [rowguid]) VALUES (N'VCB                 ', N'Ngân hàng thương mại cổ phần Ngoại thương Việt Nam', N'acc3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [NgaySinh], [NoiSinh], [Phai], [DiaChi], [Email], [SoDT], [CMND_Passport], [QuocTich], [MatKhauGiaoDich], [MatKhauDatLenh], [rowguid]) VALUES (N'1                   ', N'Nguyễn', N'Văn Anh', CAST(N'2001-01-01' AS Date), N'Kiên Giang', N'nu', N'40A Lã Xuân Oai', N'Nguyen@gmail.com', N'0123456789', N'123456789', N'Việt Nam', N'1234', N'1234', N'afc3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [NgaySinh], [NoiSinh], [Phai], [DiaChi], [Email], [SoDT], [CMND_Passport], [QuocTich], [MatKhauGiaoDich], [MatKhauDatLenh], [rowguid]) VALUES (N'2                   ', N'Nguyễn ', N'Thanh Thõa', CAST(N'2001-02-12' AS Date), N'Hà Nội', N'Nu', N'60 Lê Văn Việt', N'Thoa@gmail.com', N'0123456789', N'12323', N'Campuchia', N'1234', N'1234', N'aec3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [NgaySinh], [NoiSinh], [Phai], [DiaChi], [Email], [SoDT], [CMND_Passport], [QuocTich], [MatKhauGiaoDich], [MatKhauDatLenh], [rowguid]) VALUES (N'3                   ', N'Trần', N'Kim Trọng', CAST(N'1965-09-03' AS Date), N'Đà Nẵng', N'Nam', N'40 Lê văn việt', N'Trong@gmail.com', N'0909099', N'0689212212', N'Việt Nam', N'123', N'123', N'adc3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [NgaySinh], [NoiSinh], [Phai], [DiaChi], [Email], [SoDT], [CMND_Passport], [QuocTich], [MatKhauGiaoDich], [MatKhauDatLenh], [rowguid]) VALUES (N'4                   ', N'Phạm', N'Gia Hân', CAST(N'2001-12-12' AS Date), N'Kiên Giang', N'Nu', N'114 Mạc Cửu', N'Han@gmail.com', N'080808', N'4', N'Việt Nam', N'123', N'123', N'b0c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [NgaySinh], [NoiSinh], [Phai], [DiaChi], [Email], [SoDT], [CMND_Passport], [QuocTich], [MatKhauGiaoDich], [MatKhauDatLenh], [rowguid]) VALUES (N'5                   ', N'323', N'3232', CAST(N'2021-11-27' AS Date), N'sdsd', N'nu', N'123cs', N'nguyen tuan', NULL, N'2332', N'2323', N'2323', N'2332', N'2129aa56-3083-ee11-b627-909c4ac96a5a')
INSERT [dbo].[NhaDauTu] ([MaNDT], [Ho], [Ten], [NgaySinh], [NoiSinh], [Phai], [DiaChi], [Email], [SoDT], [CMND_Passport], [QuocTich], [MatKhauGiaoDich], [MatKhauDatLenh], [rowguid]) VALUES (N'9                   ', N'Tuấb', N'abnh', CAST(N'2023-12-04' AS Date), N'âs', N'nam', N'sấ', N'âs', NULL, N'12212', N'asa', N'1234', N'1234', N'abbd969a-8385-ee11-b627-909c4ac96a5a')
INSERT [dbo].[NhanVienCongTy] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [Phai], [DiaChi], [SoDT], [TrangThaiXoa], [MaCongTy], [rowguid]) VALUES (N'ct1                 ', N'Lê', N'Bá', CAST(N'1999-12-11' AS Date), N'Nam', N'1245 Ma Thiện', N'012345', 0, N'010', N'b2c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhanVienCongTy] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [Phai], [DiaChi], [SoDT], [TrangThaiXoa], [MaCongTy], [rowguid]) VALUES (N'ct2                 ', N'Trần', N'Ngọc', CAST(N'1997-12-14' AS Date), N'Nu', N'123 Man  Thiện', N'012345', 0, N'020', N'b3c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhanVienCongTy] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [Phai], [DiaChi], [SoDT], [TrangThaiXoa], [MaCongTy], [rowguid]) VALUES (N'ct3                 ', N'Phạm', N'Thị', CAST(N'1990-01-01' AS Date), N'Nu', N'2 Phạm Uẩn', N'123456', 0, N'010', N'b4c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhanVienCongTy] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [Phai], [DiaChi], [SoDT], [TrangThaiXoa], [MaCongTy], [rowguid]) VALUES (N'ct4                 ', N'Nguyễn', N'Ngọc Ngạn', CAST(N'1995-01-05' AS Date), N'Nam', N'3 Nguyễn Văn Tuân', N'1234567', 0, N'020', N'b5c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[NhanVienCongTy] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [Phai], [DiaChi], [SoDT], [TrangThaiXoa], [MaCongTy], [rowguid]) VALUES (N'ct5                 ', N'quốc ngọc', N'ưqqw', CAST(N'2023-10-30' AS Date), N'nam', N'123 nam', N'123', 1, N'010', N'3f3fdf3c-cd82-ee11-b627-909c4ac96a5a')
INSERT [dbo].[NhanVienSan] ([MaNhanVien], [Ho], [Ten], [NgaySinh], [Phai], [DiaChi], [SoDT], [TrangThaiXoa], [TenSan], [rowguid]) VALUES (N'san1                ', N'Lê', N'Anh Nuôi', CAST(N'2002-01-01' AS Date), N'Nam', N'1 Phạm Văn Đồng', N'012346332', 0, N'HNX', N'b1c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[PhatHanh] ([MaCoPhieu], [Ngay], [SoLuongPhatHanh], [rowguid]) VALUES (N'ADC                 ', CAST(N'2023-01-23 00:00:00.000' AS DateTime), 1000, N'4e96b76b-ed83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[PhatHanh] ([MaCoPhieu], [Ngay], [SoLuongPhatHanh], [rowguid]) VALUES (N'ADC                 ', CAST(N'2023-02-02 00:00:00.000' AS DateTime), 1000, N'b221897c-ed83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[PhatHanh] ([MaCoPhieu], [Ngay], [SoLuongPhatHanh], [rowguid]) VALUES (N'CMC                 ', CAST(N'1905-05-16 00:00:00.000' AS DateTime), 200, N'fe063ac6-8185-ee11-b627-909c4ac96a5a')
INSERT [dbo].[PhatHanh] ([MaCoPhieu], [Ngay], [SoLuongPhatHanh], [rowguid]) VALUES (N'CMC                 ', CAST(N'2023-11-28 21:00:00.000' AS DateTime), 1000, N'5061ba98-2a83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[PhatHanh] ([MaCoPhieu], [Ngay], [SoLuongPhatHanh], [rowguid]) VALUES (N'CPC                 ', CAST(N'2023-11-11 00:00:00.000' AS DateTime), 1000, N'8d62ff13-2683-ee11-b627-909c4ac96a5a')
INSERT [dbo].[PhatHanh] ([MaCoPhieu], [Ngay], [SoLuongPhatHanh], [rowguid]) VALUES (N'DNC                 ', CAST(N'1905-06-26 00:00:00.000' AS DateTime), 1000, N'5b85e1a5-2983-ee11-b627-909c4ac96a5a')
INSERT [dbo].[PhatHanh] ([MaCoPhieu], [Ngay], [SoLuongPhatHanh], [rowguid]) VALUES (N'MGW                 ', CAST(N'2023-11-16 02:42:28.357' AS DateTime), 300, N'b6f2627a-8185-ee11-b627-909c4ac96a5a')
INSERT [dbo].[QuyDinhSan] ([MaQuyDinh], [TenQuyDinh], [rowguid]) VALUES (N'PHIGD               ', N'Phí giao dịch', N'35966fb0-b884-ee11-b627-909c4ac96a5a')
INSERT [dbo].[SoHuu] ([MaCoPhieu], [MaNDT], [SoLuong], [rowguid]) VALUES (N'AAV                 ', N'1                   ', 100, N'305a72c3-a67d-ee11-b623-909c4ac96a5a')
INSERT [dbo].[SoHuu] ([MaCoPhieu], [MaNDT], [SoLuong], [rowguid]) VALUES (N'AAV                 ', N'2                   ', 200, N'75952f7c-4a85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[SoHuu] ([MaCoPhieu], [MaNDT], [SoLuong], [rowguid]) VALUES (N'ADC                 ', N'1                   ', 150, N'd2f8a0d1-a67d-ee11-b623-909c4ac96a5a')
INSERT [dbo].[SoHuu] ([MaCoPhieu], [MaNDT], [SoLuong], [rowguid]) VALUES (N'CMC                 ', N'2                   ', 300, N'e26bf30c-4b85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TaiKhoanGiaoDich] ([MaTKGD], [MaCongTy], [NgayMoTaiKhoan], [MaNDT], [rowguid]) VALUES (N'1                   ', N'010', CAST(N'2023-01-01 00:00:00.000' AS DateTime), N'1                   ', N'b6c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[TaiKhoanGiaoDich] ([MaTKGD], [MaCongTy], [NgayMoTaiKhoan], [MaNDT], [rowguid]) VALUES (N'2                   ', N'020', CAST(N'2022-09-12 00:00:00.000' AS DateTime), N'2                   ', N'b7c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[TaiKhoanGiaoDich] ([MaTKGD], [MaCongTy], [NgayMoTaiKhoan], [MaNDT], [rowguid]) VALUES (N'3                   ', N'010', CAST(N'1900-01-01 00:00:00.000' AS DateTime), N'3                   ', N'76d1aa09-8485-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TaiKhoanGiaoDich] ([MaTKGD], [MaCongTy], [NgayMoTaiKhoan], [MaNDT], [rowguid]) VALUES (N'4                   ', N'010', CAST(N'1900-01-01 00:00:00.000' AS DateTime), N'4                   ', N'083a8ecf-9983-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TaiKhoanGiaoDich] ([MaTKGD], [MaCongTy], [NgayMoTaiKhoan], [MaNDT], [rowguid]) VALUES (N'5                   ', N'010', CAST(N'2023-11-11 00:00:00.000' AS DateTime), N'5                   ', N'b4868262-9683-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TaiKhoanNganHang] ([SoTaiKhoan], [SoDu], [MaNganHang], [MaNDT], [rowguid]) VALUES (N'1                   ', 11770000.0000, N'MB                  ', N'1                   ', N'303975d1-5385-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TaiKhoanNganHang] ([SoTaiKhoan], [SoDu], [MaNganHang], [MaNDT], [rowguid]) VALUES (N'2                   ', 50000000.0000, N'ACB                 ', N'1                   ', N'b9c3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[TaiKhoanNganHang] ([SoTaiKhoan], [SoDu], [MaNganHang], [MaNDT], [rowguid]) VALUES (N'3                   ', 30000000.0000, N'VCB                 ', N'2                   ', N'bac3287f-0b70-ee11-b61b-909c4ac96a5a')
INSERT [dbo].[TaiKhoanNganHang] ([SoTaiKhoan], [SoDu], [MaNganHang], [MaNDT], [rowguid]) VALUES (N'4                   ', 40000000.0000, N'VCB                 ', N'1                   ', N'0cc0640d-1c85-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TaiKhoanNganHang] ([SoTaiKhoan], [SoDu], [MaNganHang], [MaNDT], [rowguid]) VALUES (N'5                   ', 10000000.0000, N'MB                  ', N'1                   ', N'7a65fe38-8485-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TaiKhoanNganHang] ([SoTaiKhoan], [SoDu], [MaNganHang], [MaNDT], [rowguid]) VALUES (N'6                   ', 100000000.0000, N'VCB                 ', N'1                   ', N'b6fb2762-8485-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [rowguid]) VALUES (N'CHOKHOP             ', N'Chờ khớp', N'9cffc0a3-eb83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [rowguid]) VALUES (N'CHUAKHOP            ', N'Chưa khớp', N'9dffc0a3-eb83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [rowguid]) VALUES (N'DAHUY               ', N'Đã hủy', N'9effc0a3-eb83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [rowguid]) VALUES (N'KHOPHET             ', N'Khớp hết', N'9fffc0a3-eb83-ee11-b627-909c4ac96a5a')
INSERT [dbo].[TrangThai] ([MaTrangThai], [TenTrangThai], [rowguid]) VALUES (N'KHOPMOTPHAN         ', N'Khớp một phần', N'a0ffc0a3-eb83-ee11-b627-909c4ac96a5a')
/****** Object:  Index [MSmerge_index_245575913]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_245575913] ON [dbo].[ChiTietQuyDinhCongTy]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_277576027]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_277576027] ON [dbo].[ChiTietQuyDinhSan]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_309576141]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_309576141] ON [dbo].[CongTyCK]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_341576255]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_341576255] ON [dbo].[CoPhieu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_373576369]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_373576369] ON [dbo].[LenhDat]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_405576483]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_405576483] ON [dbo].[LenhKhop]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_437576597]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_437576597] ON [dbo].[LichSuGia]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_469576711]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_469576711] ON [dbo].[LoaiLenh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_501576825]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_501576825] ON [dbo].[NganHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_NhaDauTu]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_NhaDauTu] ON [dbo].[NhaDauTu]
(
	[CMND_Passport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1909581841]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1909581841] ON [dbo].[NhaDauTu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_565577053]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_565577053] ON [dbo].[NhanVienCongTy]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_597577167]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_597577167] ON [dbo].[NhanVienSan]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_629577281]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_629577281] ON [dbo].[PhatHanh]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_661577395]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_661577395] ON [dbo].[QuyDinhCongTy]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_693577509]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_693577509] ON [dbo].[QuyDinhSan]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_725577623]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_725577623] ON [dbo].[SoHuu]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_TaiKhoanGiaoDich]    Script Date: 11/28/2023 11:02:26 PM ******/
ALTER TABLE [dbo].[TaiKhoanGiaoDich] ADD  CONSTRAINT [IX_TaiKhoanGiaoDich] UNIQUE NONCLUSTERED 
(
	[MaNDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1845581613]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1845581613] ON [dbo].[TaiKhoanGiaoDich]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_789577851]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_789577851] ON [dbo].[TaiKhoanNganHang]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_805577908]    Script Date: 11/28/2023 11:02:26 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_805577908] ON [dbo].[TrangThai]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[QuyDinhCongTy] ADD  CONSTRAINT [MSmerge_df_rowguid_02F93FB73F4743E988BEB967E12358D5]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LichSuGia]  WITH CHECK ADD  CONSTRAINT [FK_LichSuGia_CoPhieu] FOREIGN KEY([MaCoPhieu])
REFERENCES [dbo].[CoPhieu] ([MaCoPhieu])
GO
ALTER TABLE [dbo].[LichSuGia] CHECK CONSTRAINT [FK_LichSuGia_CoPhieu]
GO
ALTER TABLE [dbo].[NhanVienCongTy]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienCongTy_CongTyCK] FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[CongTyCK] ([MaCongTy])
GO
ALTER TABLE [dbo].[NhanVienCongTy] CHECK CONSTRAINT [FK_NhanVienCongTy_CongTyCK]
GO
ALTER TABLE [dbo].[PhatHanh]  WITH CHECK ADD  CONSTRAINT [FK_PhatHanh_CoPhieu] FOREIGN KEY([MaCoPhieu])
REFERENCES [dbo].[CoPhieu] ([MaCoPhieu])
GO
ALTER TABLE [dbo].[PhatHanh] CHECK CONSTRAINT [FK_PhatHanh_CoPhieu]
GO
ALTER TABLE [dbo].[SoHuu]  WITH CHECK ADD  CONSTRAINT [FK_SoHuu_CoPhieu] FOREIGN KEY([MaCoPhieu])
REFERENCES [dbo].[CoPhieu] ([MaCoPhieu])
GO
ALTER TABLE [dbo].[SoHuu] CHECK CONSTRAINT [FK_SoHuu_CoPhieu]
GO
ALTER TABLE [dbo].[SoHuu]  WITH CHECK ADD  CONSTRAINT [FK_SoHuu_NhaDauTu] FOREIGN KEY([MaNDT])
REFERENCES [dbo].[NhaDauTu] ([MaNDT])
GO
ALTER TABLE [dbo].[SoHuu] CHECK CONSTRAINT [FK_SoHuu_NhaDauTu]
GO
ALTER TABLE [dbo].[TaiKhoanGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanGiaoDich_CongTyCK] FOREIGN KEY([MaCongTy])
REFERENCES [dbo].[CongTyCK] ([MaCongTy])
GO
ALTER TABLE [dbo].[TaiKhoanGiaoDich] CHECK CONSTRAINT [FK_TaiKhoanGiaoDich_CongTyCK]
GO
ALTER TABLE [dbo].[TaiKhoanGiaoDich]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanGiaoDich_NhaDauTu] FOREIGN KEY([MaNDT])
REFERENCES [dbo].[NhaDauTu] ([MaNDT])
GO
ALTER TABLE [dbo].[TaiKhoanGiaoDich] CHECK CONSTRAINT [FK_TaiKhoanGiaoDich_NhaDauTu]
GO
ALTER TABLE [dbo].[TaiKhoanNganHang]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNganHang_NganHang] FOREIGN KEY([MaNganHang])
REFERENCES [dbo].[NganHang] ([MaNganHang])
GO
ALTER TABLE [dbo].[TaiKhoanNganHang] CHECK CONSTRAINT [FK_TaiKhoanNganHang_NganHang]
GO
ALTER TABLE [dbo].[TaiKhoanNganHang]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNganHang_NhaDauTu] FOREIGN KEY([MaNDT])
REFERENCES [dbo].[NhaDauTu] ([MaNDT])
GO
ALTER TABLE [dbo].[TaiKhoanNganHang] CHECK CONSTRAINT [FK_TaiKhoanNganHang_NhaDauTu]
GO
ALTER TABLE [dbo].[ChiTietQuyDinhCongTy]  WITH CHECK ADD  CONSTRAINT [CK_ChiTietQuyDinhCongTy] CHECK  (([Giatri]>(0)))
GO
ALTER TABLE [dbo].[ChiTietQuyDinhCongTy] CHECK CONSTRAINT [CK_ChiTietQuyDinhCongTy]
GO
ALTER TABLE [dbo].[ChiTietQuyDinhSan]  WITH CHECK ADD  CONSTRAINT [CK_ChiTietQuyDinhSan] CHECK  (([GiaTri]>(0)))
GO
ALTER TABLE [dbo].[ChiTietQuyDinhSan] CHECK CONSTRAINT [CK_ChiTietQuyDinhSan]
GO
ALTER TABLE [dbo].[LenhDat]  WITH CHECK ADD  CONSTRAINT [CK_LenhDat] CHECK  (([soluong]>(0)))
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [CK_LenhDat]
GO
ALTER TABLE [dbo].[LenhDat]  WITH CHECK ADD  CONSTRAINT [CK_LenhDat_1] CHECK  (([gia]>(0)))
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [CK_LenhDat_1]
GO
ALTER TABLE [dbo].[LenhDat]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_D6D6488E_269B_43F4_BB64_ABF1967A0F60] CHECK NOT FOR REPLICATION (([IDLenhDat]>=(1) AND [IDLenhDat]<=(1001) OR [IDLenhDat]>(1001) AND [IDLenhDat]<=(2001)))
GO
ALTER TABLE [dbo].[LenhDat] CHECK CONSTRAINT [repl_identity_range_D6D6488E_269B_43F4_BB64_ABF1967A0F60]
GO
ALTER TABLE [dbo].[LenhKhop]  WITH CHECK ADD  CONSTRAINT [CK_LenhKhop] CHECK  (([gia]>(0)))
GO
ALTER TABLE [dbo].[LenhKhop] CHECK CONSTRAINT [CK_LenhKhop]
GO
ALTER TABLE [dbo].[LenhKhop]  WITH CHECK ADD  CONSTRAINT [CK_LenhKhop_1] CHECK  (([soluong]>(0)))
GO
ALTER TABLE [dbo].[LenhKhop] CHECK CONSTRAINT [CK_LenhKhop_1]
GO
ALTER TABLE [dbo].[LenhKhop]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_7B860A60_487A_4277_B0F0_A2302AC9E94B] CHECK NOT FOR REPLICATION (([IDLenhKhop]>=(1) AND [IDLenhKhop]<=(1001) OR [IDLenhKhop]>(1001) AND [IDLenhKhop]<=(2001)))
GO
ALTER TABLE [dbo].[LenhKhop] CHECK CONSTRAINT [repl_identity_range_7B860A60_487A_4277_B0F0_A2302AC9E94B]
GO
ALTER TABLE [dbo].[LichSuGia]  WITH CHECK ADD  CONSTRAINT [CK_LichSuGia] CHECK  (([Giadongcua]>(0)))
GO
ALTER TABLE [dbo].[LichSuGia] CHECK CONSTRAINT [CK_LichSuGia]
GO
ALTER TABLE [dbo].[LichSuGia]  WITH CHECK ADD  CONSTRAINT [CK_LichSuGia_1] CHECK  (([GiaMoCua]>(0)))
GO
ALTER TABLE [dbo].[LichSuGia] CHECK CONSTRAINT [CK_LichSuGia_1]
GO
ALTER TABLE [dbo].[LichSuGia]  WITH CHECK ADD  CONSTRAINT [CK_LichSuGia_2] CHECK  (([GiaThamChieu]>(0)))
GO
ALTER TABLE [dbo].[LichSuGia] CHECK CONSTRAINT [CK_LichSuGia_2]
GO
ALTER TABLE [dbo].[NhaDauTu]  WITH CHECK ADD  CONSTRAINT [CK_NhaDauTu] CHECK  (([Phai]='Nam' OR [Phai]='Nu'))
GO
ALTER TABLE [dbo].[NhaDauTu] CHECK CONSTRAINT [CK_NhaDauTu]
GO
ALTER TABLE [dbo].[PhatHanh]  WITH CHECK ADD  CONSTRAINT [CK_PhatHanh] CHECK  (([soluongphathanh]>(0)))
GO
ALTER TABLE [dbo].[PhatHanh] CHECK CONSTRAINT [CK_PhatHanh]
GO
ALTER TABLE [dbo].[SoHuu]  WITH CHECK ADD  CONSTRAINT [CK_SoHuu] CHECK  (([soluong]>(0)))
GO
ALTER TABLE [dbo].[SoHuu] CHECK CONSTRAINT [CK_SoHuu]
GO
ALTER TABLE [dbo].[TaiKhoanNganHang]  WITH CHECK ADD  CONSTRAINT [CK_TKNH_SoDu] CHECK  (([SoDu]>(0)))
GO
ALTER TABLE [dbo].[TaiKhoanNganHang] CHECK CONSTRAINT [CK_TKNH_SoDu]
GO
/****** Object:  StoredProcedure [dbo].[DatLenhBan]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DatLenhBan]
	@LoaiGiaoDich Nvarchar(10),
    @GiaBan int,
    @SoLuongBan INT,
    @ThoiGian DATETIME,
    @MaCoPhieu NVARCHAR(10),
    @MaLoaiLenh NVARCHAR(2),
    @MaTrangThai NVARCHAR(10) output,
    @SoTaiKhoan NVARCHAR(20)
AS
BEGIN
	  DECLARE @GiaMua int ;
            DECLARE @SoLuongMua INT;

            SELECT TOP 1
                @GiaMua = Gia,
                @SoLuongMua = SoLuong
            FROM
                LenhDat
            WHERE
                MaCoPhieu = @MaCoPhieu
                AND LoaiGiaoDich = 'Mua'
            ORDER BY
                Gia DESC;
		-- SET @MaTrangThai = 'CHOKHOP';
    -- Kiểm tra loại giao dịch là bán
    IF @LoaiGiaoDich = 'Ban'
    BEGIN
		
		
        -- Kiểm tra nếu là lệnh LO
        IF @MaLoaiLenh = 'LO'
        BEGIN
           -- Lấy thông tin về giá mua và số lượng mua
          

            IF @GiaBan % 100 = 0 AND @SoLuongBan >= 100
            BEGIN
                IF @GiaBan <= @GiaMua AND @SoLuongBan > @SoLuongMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Ban', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPMOTPHAN', @SoTaiKhoan);
					  SET @MaTrangThai = 'KHOPMOTPHAN';
					UPDATE  TaiKhoanNganhang set SoDu= (SoDu + @GiaBan*(@SoLuongBan-@SoLuongMua)) Where SoTaiKhoan= @SoTaiKhoan
					INSERT INTO LenhKhop (Gia, SoLuong, ThoiGian, IDLenhDat )
                    VALUES (@GiaBan,(@SoLuongMua-@SoLuongBan) , @ThoiGian, (SELECT TOP 1 IDLenhDat FROM LenhDat ORDER BY ThoiGian));
                END
                ELSE IF @SoLuongBan <= @SoLuongMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Ban', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPHET', @SoTaiKhoan);
					 SET @MaTrangThai = 'KHOPHET';
					 UPDATE  TaiKhoanNganhang set SoDu= (SoDu + @GiaBan*@SoLuongBan) Where SoTaiKhoan= @SoTaiKhoan
                END
                ELSE IF @GiaBan > @GiaMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Ban', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'CHOKHOP', @SoTaiKhoan);
					 SET @MaTrangThai = 'CHOKHOP';
                END
            END
           
END
		IF @MaLoaiLenh = 'MB'
    BEGIN
        -- Lấy thông tin về giá tham chiếu từ Stored Procedure
        DECLARE @GiaThamChieu FLOAT;

        SELECT TOP 1
                @GiaBan = Gia,
                @SoLuongBan = SoLuong
            FROM
                LenhDat
            WHERE
                MaCoPhieu = @MaCoPhieu
                AND LoaiGiaoDich = 'Mua'
				and MaLoaiLenh='LO'
            ORDER BY
                Gia ASC;
        -- Lấy thông tin về giá tham chiếu từ Stored Procedure
        
		SET @GiaBan = (SELECT TOP 1
              Gia   FROM LenhDat
            WHERE
                MaCoPhieu = @MaCoPhieu
                AND LoaiGiaoDich = 'Mua'
				and MaLoaiLenh='LO'
            ORDER BY
                Gia ASC)
        -- Kiểm tra điều kiện và thực hiện lệnh insert
         IF @GiaBan <= @GiaMua AND @SoLuongBan > @SoLuongMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Ban', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPMOTPHAN', @SoTaiKhoan);
					 SET @MaTrangThai = 'KHOPMOTPHAN';
					 UPDATE  TaiKhoanNganhang set SoDu= (SoDu + @GiaBan*(@SoLuongBan-@SoLuongMua)) Where SoTaiKhoan= @SoTaiKhoan
					 INSERT INTO LenhKhop (Gia, SoLuong, ThoiGian, IDLenhDat )
                    VALUES (@GiaBan,(@SoLuongMua-@SoLuongBan) , @ThoiGian, (SELECT TOP 1 IDLenhDat FROM LenhDat ORDER BY ThoiGian));
                END
                ELSE IF @SoLuongBan <= @SoLuongMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Ban', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPHET', @SoTaiKhoan);
					 SET @MaTrangThai = 'KHOPHET';
					 UPDATE  TaiKhoanNganhang set SoDu= (SoDu + @GiaBan*@SoLuongBan) Where SoTaiKhoan= @SoTaiKhoan
                END
                ELSE IF @GiaBan > @GiaMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Ban', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'CHOKHOP', @SoTaiKhoan);
					 SET @MaTrangThai = 'CHOKHOP';
                END
        END
    END
	SELECT	@MaTrangThai as N'@MaTrangThai'
End;

--Đặt lệnh mua:

GO
ALTER AUTHORIZATION ON [dbo].[DatLenhBan] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[DatLenhMua]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DatLenhMua]
	@LoaiGiaoDich Nvarchar(10),
    @GiaMua int,
    @SoLuongMua INT,
    @ThoiGian DATETIME,
    @MaCoPhieu NVARCHAR(10),
    @MaLoaiLenh NVARCHAR(2),
    @MaTrangThai NVARCHAR(10) output,
    @SoTaiKhoan NVARCHAR(20)
AS
BEGIN
	  DECLARE @GiaBan int ;
            DECLARE @SoLuongBan INT;

           
		 SET @MaTrangThai = 'CHOKHOP';
    -- Kiểm tra loại giao dịch là mua
    IF @LoaiGiaoDich = 'Mua'
    BEGIN
		
		
        -- Kiểm tra nếu là lệnh LO
        IF @MaLoaiLenh = 'LO'
        BEGIN
		 SELECT TOP 1
                @GiaBan = Gia,
                @SoLuongBan = SoLuong
            FROM
                LenhDat
            WHERE
                MaCoPhieu = @MaCoPhieu
                AND LoaiGiaoDich = 'Ban'
            ORDER BY
                Gia ASC;
           -- Lấy thông tin về giá bán và số lượng bán
          

            IF @GiaMua % 100 = 0 AND @SoLuongMua >= 100
            BEGIN
                IF @GiaBan <= @GiaMua AND @SoLuongMua > @SoLuongBan
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Mua', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPMOTPHAN', @SoTaiKhoan);
					  SET @MaTrangThai = 'KHOPMOTPHAN';
					  UPDATE  TaiKhoanNganhang set SoDu= (SoDu + @GiaBan*(@SoLuongMua-@SoLuongBan)) Where SoTaiKhoan= @SoTaiKhoan;
					   INSERT INTO LenhKhop (Gia, SoLuong, ThoiGian, IDLenhDat )
                    VALUES (@GiaBan,(@SoLuongMua-@SoLuongBan) , @ThoiGian, (SELECT TOP 1 IDLenhDat FROM LenhDat ORDER BY ThoiGian));
                END
                ELSE IF @GiaBan <= @GiaMua AND @SoLuongMua <= @SoLuongBan
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Mua', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPHET', @SoTaiKhoan);
					 SET @MaTrangThai = 'KHOPHET';
					 UPDATE  TaiKhoanNganhang set SoDu= (SoDu - @GiaMua*@SoLuongMua) Where SoTaiKhoan= @SoTaiKhoan
                END
                ELSE IF @GiaBan > @GiaMua or @GiaBan < @GiaMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Mua', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'CHOKHOP', @SoTaiKhoan);
					 SET @MaTrangThai = 'CHOKHOP';
                END
            END
           
END
		IF @MaLoaiLenh = 'MB'
		BEGIN
		SELECT TOP 1
                @GiaBan = Gia,
                @SoLuongBan = SoLuong
            FROM
                LenhDat
            WHERE
                MaCoPhieu = @MaCoPhieu
                AND LoaiGiaoDich = 'Ban'
				and MaLoaiLenh='LO'
            ORDER BY
                Gia ASC;
        -- Lấy thông tin về giá tham chiếu từ Stored Procedure
        DECLARE @GiaThamChieu FLOAT;
		SET @GiaMua = (SELECT TOP 1
              Gia   FROM LenhDat
            WHERE
                MaCoPhieu = @MaCoPhieu
                AND LoaiGiaoDich = 'Ban'
				and MaLoaiLenh='LO'
            ORDER BY
                Gia ASC)
        SELECT TOP 1 @GiaThamChieu = GiaDongCua
        FROM LichSuGia
        WHERE MaCoPhieu = @MaCoPhieu
        ORDER BY Ngay DESC;
		
        -- Kiểm tra điều kiện và thực hiện lệnh insert
         IF @GiaMua % 100 =0  AND @SoLuongMua >=100
                BEGIN
                IF @GiaBan<=@GiaMua AND @SoLuongMua > @SoLuongBan
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Mua', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPMOTPHAN', @SoTaiKhoan);
					  SET @MaTrangThai = 'KHOPMOTPHAN';
					  UPDATE  TaiKhoanNganhang set SoDu= (SoDu - @GiaBan*(@SoLuongMua-@SoLuongBan)) Where SoTaiKhoan= @SoTaiKhoan
					  INSERT INTO LenhKhop (Gia, SoLuong, ThoiGian, IDLenhDat )
                    VALUES (@GiaBan,(@SoLuongMua-@SoLuongBan) , @ThoiGian, (SELECT  TOP 1 IDLenhDat FROM LenhDat ORDER BY ThoiGian));
                END
                ELSE IF @GiaBan<=@GiaMua and @SoLuongMua <= @SoLuongBan
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Mua', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'KHOPHET', @SoTaiKhoan);
					 SET @MaTrangThai = 'KHOPHET';
					 UPDATE  TaiKhoanNganhang set SoDu= (SoDu - @GiaMua*@SoLuongMua) Where SoTaiKhoan= @SoTaiKhoan
                END
                ELSE IF @GiaBan > @GiaMua or @GiaBan < @GiaMua
                BEGIN
                    INSERT INTO LenhDat (Gia, LoaiGiaoDich, SoLuong, ThoiGian, MaCoPhieu, MaLoaiLenh, MaTrangThai, SoTaiKhoan)
                    VALUES (@GiaBan, 'Mua', @SoLuongBan, @ThoiGian, @MaCoPhieu, @MaLoaiLenh, 'CHOKHOP', @SoTaiKhoan);
					 SET @MaTrangThai = 'CHOKHOP';

                END
            END
        END
    END
	SELECT	@MaTrangThai as N'@MaTrangThai'
End;



GO
ALTER AUTHORIZATION ON [dbo].[DatLenhMua] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[LietKeChiTietKhopLenh]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LietKeChiTietKhopLenh]
    @MaNDT NCHAR(20),
    @MaCP NVARCHAR(10)
AS
BEGIN
    WITH ChiTietKhopLenh AS (
        SELECT
            lk.ThoiGian AS NgayGioKhop,
            lk.SoLuong AS SoLuongKhop,
            lk.Gia AS GiaKhop
        FROM
            LenhKhop lk
        JOIN LenhDat ld ON lk.IDLenhDat = ld.IDLenhDat
        JOIN TaiKhoanNganHang tknh ON ld.SoTaiKhoan = tknh.SoTaiKhoan
        WHERE
            tknh.MaNDT = @MaNDT
            AND ld.MaCoPhieu = @MaCP
    )
    SELECT
        NgayGioKhop,
        SoLuongKhop,
        GiaKhop
    FROM ChiTietKhopLenh;
END;


GO
ALTER AUTHORIZATION ON [dbo].[LietKeChiTietKhopLenh] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_HienThiNDT]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_HienThiNDT]
AS
BEGIN
select MaNDT,HO, TEN, PHAI,SODT FROM LINK0.CHUNGKHOAN.dbo.NhaDauTu 
EXCEPT
select ndt.MaNDT as MaNDT, HO, TEN, PHAI,SODT FROM LINK0.CHUNGKHOAN.dbo.NhaDauTu as ndt inner join LINK0.CHUNGKHOAN.dbo.TaiKhoanGiaoDich as tk
on ndt.MaNDT=tk.MaNDT
END
GO
ALTER AUTHORIZATION ON [dbo].[sp_HienThiNDT] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_Kiem_Tra_Xoa_CoPhieu]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Kiem_Tra_Xoa_CoPhieu]
	@MaCoPhieu NVARCHAR(10)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.Phathanh as PH where PH.MaCoPhieu = @MaCoPhieu)
		return 1; -- ma cổ phiếu đã phát hành
	return 0; --cổ phiếu chưa phát hành
end
GO
ALTER AUTHORIZATION ON [dbo].[sp_Kiem_Tra_Xoa_CoPhieu] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_Kiem_Tra_Xoa_NhaDauTu_TaiKhoan]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Kiem_Tra_Xoa_NhaDauTu_TaiKhoan]
	@MaNhaDauTu NCHAR(10)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.TAIKHOANGIAODICH as TK where TK.MaNDT = @MaNhaDauTu)
		return 1; -- ndt có tải khoản không thể xóa
	return 0; -- nhân viên có tải khoản không thể xóa
end
GO
ALTER AUTHORIZATION ON [dbo].[sp_Kiem_Tra_Xoa_NhaDauTu_TaiKhoan] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_Kiem_Tra_Xoa_NhanVien_quydinh]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Kiem_Tra_Xoa_NhanVien_quydinh]
	@MaNhanVien NCHAR(10)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.CHITIETQUYDINHCONGTY as QD where QD.MaNhanVien = @MaNhanVien)
		return 1; -- ma nhan vien thêm quy định
	return 0; -- ma nhan vien khong thêm quy định
end
GO
ALTER AUTHORIZATION ON [dbo].[sp_Kiem_Tra_Xoa_NhanVien_quydinh] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraTonTaiNDT]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROC [dbo].[SP_KiemTraTonTaiNDT]
@MaNDT NCHAR(20)
as
begin
	if exists( select * from CHUNGKHOAN.DBO.NhaDauTu as NDT where NDT.MaNDT = @MaNDT)
		return 1; -- NDT ton tai
	return 0; -- STK khong ton tai
end

GO
ALTER AUTHORIZATION ON [dbo].[SP_KiemTraTonTaiNDT] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraXoaTaiKhoanNganHang]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_KiemTraXoaTaiKhoanNganHang]
	@SoTaiKhoan NVARCHAR(20)
as
begin
		if exists( select * from LINK0.CHUNGKHOAN.DBO.LenhDat as DL where DL.SoTaiKhoan = @Sotaikhoan)
		return 1; -- Số tài khoản đã đặt lệnh
	return 0; -- số tài khoản chưa đặt lệnh
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_KiemTraXoaTaiKhoanNganHang] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_Lay_Thong_Tin_Tu_Login]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_Lay_Thong_Tin_Tu_Login] @TENLOGIN NVARCHAR(100) AS
BEGIN
	DECLARE @UID INT
	DECLARE @MA NVARCHAR(100)
	SELECT @UID= uid , @MA= NAME FROM sys.sysusers 
	WHERE sid = SUSER_SID(@TENLOGIN)

	IF  (SELECT NAME FROM sys.sysusers WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@UID))= 'NHADAUTU' 
		SELECT MaNDT = @MA, HOTEN = (SELECT HO + ' ' + TEN FROM NhaDauTu WHERE MaNDT=@MA ), TENNHOM=NAME
		FROM sys.sysusers
		WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@UID)

	ELSE IF(SELECT NAME FROM sys.sysusers WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@UID))= 'CONGTY' 
		IF (SELECT TrangThaiXoa FROM NhanVienCongTy WHERE MaNhanVien = @MA) = 1 -- ĐĂNG NHẬP BẰNG TÀI KHOẢN NHÂN VIÊN ĐÃ NGHỈ
			SELECT MANV = ''
		ELSE	SELECT MANV = @MA, HOTEN = (SELECT HO + ' ' + TEN FROM dbo.NhanVienCongTy WHERE MaNhanVien=@MA ), TENNHOM=NAME
			FROM sys.sysusers
			WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
	ELSE 
		SELECT MANV = @MA, HOTEN = (SELECT HO + ' ' + TEN FROM dbo.NhanVienSan WHERE MaNhanVien=@MA ), TENNHOM=NAME
				FROM sys.sysusers
				WHERE UID = (SELECT groupuid FROM sys.sysmembers WHERE memberuid=@uid)
END

GO
ALTER AUTHORIZATION ON [dbo].[SP_Lay_Thong_Tin_Tu_Login] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_sllk_theothoigian_ndt]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_sllk_theothoigian_ndt]
@MaNDT nvarchar(20),
@TuNgay datetime,
@DenNgay datetime
as
begin

select LDNDT.MaCoPhieu, LDNDT.LoaiGiaoDich, LDNDT.MaLoaiLenh, LK.SoLuong, Lk.Gia, LK.ThoiGian  from LenhKhop lk,(SELECT LD.MaCoPhieu, LD.LoaiGiaoDich, LD.MaLoaiLenh, LD.IDLenhDat, LD.ThoiGian
							from LenhDat LD, (select SoTaiKhoan
							from TaiKhoanNganHang where TaiKhoanNganHang.MaNDT=@MaNDT )as TKNH
							where LD.SoTaiKhoan=TKNH.SoTaiKhoan) as LDNDT
							where LDNDT.IDLenhDat=LK.IDLenhDat and lk.ThoiGian>=@TuNgay and lk.ThoiGian<=@DenNgay
							order by lk.ThoiGian
end
GO
ALTER AUTHORIZATION ON [dbo].[sp_sllk_theothoigian_ndt] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_sohuu]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_sohuu]
@mNDT NCHAR(20)
AS
BEGIN 
    WITH LichSuGiaLatest AS (
        SELECT
            lg.MaCoPhieu,
            lg.ngay AS ngay_gan_nhat,
            lg.giathamchieu AS gia_tham_chieu,
            ROW_NUMBER() OVER (PARTITION BY lg.MaCoPhieu ORDER BY lg.ngay DESC) AS RowNum
        FROM dbo.LichSuGia lg
    ),
    SoHuuLatest AS (
        SELECT
            sh.MaCoPhieu,
            sh.MaNDT,
            sh.SoLuong
        FROM dbo.SoHuu sh
        WHERE sh.MaNDT = @mNDT  -- Lọc theo mã nhà đầu tư
    ),
    CombinedData AS (
        SELECT
            s.MaCoPhieu,
            s.MaNDT,
            s.SoLuong,
            lg.gia_tham_chieu
        FROM SoHuuLatest s
        LEFT JOIN LichSuGiaLatest lg ON s.MaCoPhieu = lg.MaCoPhieu AND lg.RowNum = 1
    )
    SELECT
        cd.MaCoPhieu,
        cd.MaNDT,
        cd.SoLuong,
        cd.gia_tham_chieu,
        cd.gia_tham_chieu * cd.SoLuong AS tri_gia
    FROM CombinedData cd;
END


GO
ALTER AUTHORIZATION ON [dbo].[SP_sohuu] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoLogin_NV]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_TaoLogin_NV] @LGNAME VARCHAR(10), @PASS VARCHAR(20), @USERNAME VARCHAR(10), @ROLE VARCHAR(10)
AS
BEGIN
	DECLARE @RET INT
	EXEC @RET= sp_addlogin @LGNAME, @PASS, 'CHUNGKHOAN'
	IF (@RET = 1)  -- LOGIN NAME BI TRUNG
	BEGIN
		RAISERROR('Login name bị trùng', 16, 1)
		RETURN 1
	END
 
	EXEC @RET= sp_grantdbaccess @LGNAME, @USERNAME
	IF (@RET = 1)  -- USER NAME BI TRUNG
	BEGIN
		EXEC SP_DROPLOGIN @LGNAME
		RAISERROR('User name bị trùng', 16, 1)
		RETURN 2
	END

	EXEC sp_addrolemember @ROLE, @USERNAME
	EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
	RETURN 0  -- THANH CONG
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_TaoLogin_NV] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaCP]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraCuu_KiemTraMaCP]
	@MACP NVARCHAR(20)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.CoPhieu as CP where CP.MaCoPhieu = @MACP)
		return 1; -- ma cp tồn tại
	return 0; -- ma cp khả thi
end
GO
ALTER AUTHORIZATION ON [dbo].[sp_TraCuu_KiemTraMaCP] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaNDT]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraCuu_KiemTraMaNDT]
	@MANDT NVARCHAR(20)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.NhaDauTu as NDT where NDT.MaNDT = @MANDT)
		return 1; -- ma nhan vien ton tai
	return 0; -- ma nhan vien khong ton tai
end
GO
ALTER AUTHORIZATION ON [dbo].[sp_TraCuu_KiemTraMaNDT] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaNhanVien_congty]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraCuu_KiemTraMaNhanVien_congty]
	@MANHANVIEN NVARCHAR(20)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.Nhanviencongty as NV where NV.MANHANVIEN = @MANHANVIEN)
		return 1; -- ma nhan vien ton tai
	return 0; -- ma nhan vien khong ton tai
end
GO
ALTER AUTHORIZATION ON [dbo].[sp_TraCuu_KiemTraMaNhanVien_congty] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemtramaTKGD]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraCuu_KiemtramaTKGD]
	@MATKGD NVARCHAR(20)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.TaiKhoanGiaodich as TKGD where TKGD.MaTKGD = @MATKGD)
		return 1; -- ma nhan vien ton tai
	return 0; -- ma nhan vien khong ton tai
end


GO
ALTER AUTHORIZATION ON [dbo].[sp_TraCuu_KiemtramaTKGD] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemtramaTKNH]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TraCuu_KiemtramaTKNH]
	@sotaikhoan NVARCHAR(20)
as
begin
	if exists( select * from LINK0.CHUNGKHOAN.DBO.TaiKhoanNganHang as TKNH where TKNH.SoTaiKhoan = @sotaikhoan)
		return 1; -- stkn ton tai
	return 0; -- stk khong ton tai
end


GO
ALTER AUTHORIZATION ON [dbo].[sp_TraCuu_KiemtramaTKNH] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_tracuusodu_ndt]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_tracuusodu_ndt] @MaNDT nvarchar(20)
as begin

declare @phantramphi float
set @phantramphi= (select top 1 GiaTri from ChiTietQuyDinhSan ctqds where ctqds.MaQuyDinh='PHIGD' order by NgayApDung )
--select @phantramphi/100
--chọn phí mới nhất

declare @ngay datetime = getdate()
if datepart("W",@ngay)=1 --thứ 2
		set @ngay=@ngay-4;
else if DATEPART("W",@ngay)=7 --chủ nhật
	set @ngay=@ngay-3;
else						  --các ngày còn lại trong tuần lùi 2 ngày 
	set @ngay=@ngay-2; 

CREATE TABLE #chuathanhtoan (
sotaikhoan NVARCHAR(20),
chuathanhtoan float,
phigiaodich float
);
Create Table #SoDu(
SoTaiKhoan nvarchar(20),
SoDu float,
chuathanhtoan float,
phigiaodich float,
);
insert into #chuathanhtoan

select LDW.SoTaiKhoan, chuathanhtoan=sum(LK.Gia), Phigiaodich=sum(LK.Gia)*@phantramphi/100
			from (select LD.IDLenhDat,LD.SoTaiKhoan from LenhDat LD where LD.SoTaiKhoan in 
			(select SoTaiKhoan from TaiKhoanNganHang where MaNDT=@MaNDT)
				and LD.LoaiGiaoDich='Mua' and LD.ThoiGian>=@ngay) as LDW, LenhKhop Lk
				where LK.IDLenhDat=LDW.IDLenhDat
				Group by SoTaiKhoan
insert into #SoDu
select tk.SoTaiKhoan, tk.SoDu,Chuathanhtoan=case when ctt.chuathanhtoan is null then 0 else ctt.chuathanhtoan end,
							 PhiGiaoDich=case when ctt.phigiaodich is null then 0 else ctt.phigiaodich end
			from (select SoTaiKhoan, SoDu from TaiKhoanNganHang where MaNDT=@MaNDT) as tk
			left join #chuathanhtoan ctt  on tk.SoTaiKhoan=ctt.sotaikhoan 
select *,DuocGiaoDich=case when (SoDu-chuathanhtoan-phigiaodich)<0 then 0 else (SoDu-chuathanhtoan-phigiaodich) end from #SoDu
DROP TABLE #chuathanhtoan,#SoDu;
End
GO
ALTER AUTHORIZATION ON [dbo].[sp_tracuusodu_ndt] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_Xoa_Login]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[sp_Kiem_Tra_Xoa_NhanVien]    Script Date: 11/14/2023 4:08:02 PM ******/
create PROC [dbo].[SP_Xoa_Login]
@TENUSER NVARCHAR (50)
AS
BEGIN
	DECLARE @GROUP NVARCHAR(50)
	DECLARE @LOGIN NVARCHAR(50)
	SELECT  @GROUP=NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					 FROM SYS.SYSMEMBERS 
					   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										  WHERE NAME=@TENUSER)) --tìm tên nhóm từ mãnv
		if exists (select loginname FROM sys.syslogins as l  
		where l.sid=(select sid from sys.sysusers where name=@TENUSER))--tìm login name từ mãnv
BEGIN
	select @LOGIN= loginname FROM sys.syslogins as l  where l.sid=(select sid from sys.sysusers where name=@TENUSER)

BEGIN
       exec sp_droplogin @LOGIN
	   exec sp_dropuser @TENUSER
    END

END
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_Xoa_Login] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[TinhToanGiaTheoMaCP]    Script Date: 11/28/2023 11:02:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TinhToanGiaTheoMaCP]
    @MaCoPhieu NVARCHAR(10)
AS
BEGIN
   WITH ThongTinGia AS (
    SELECT
        ls.MaCoPhieu,
        ls.GiaDongCua,
        COALESCE(qd.GiaTri, 0.3) AS BienDoGia, -- 0.3 nếu không có dữ liệu trong QuyDinhSan
        CASE
            WHEN EXISTS (SELECT 1 FROM LenhDat WHERE MaCoPhieu = @MaCoPhieu) THEN 0.1
            ELSE 0.3
        END AS BienDoLehDat
    FROM
        LichSuGia ls
    LEFT JOIN ChiTietQuyDinhSan qd ON ls.MaCoPhieu = qd.MaQuyDinh
    WHERE
        ls.MaCoPhieu = @MaCoPhieu
        AND ls.Ngay = (SELECT MAX(Ngay) FROM LichSuGia WHERE MaCoPhieu = @MaCoPhieu)
)
SELECT
    gt.MaCoPhieu,
    gt.GiaDongCua AS GiaThamChieu,
    gt.GiaDongCua - (gt.BienDoLehDat * gt.GiaDongCua) AS GiaSan,
    gt.GiaDongCua + (gt.BienDoLehDat * gt.GiaDongCua) AS GiaTran
FROM
    ThongTinGia gt;

END;
GO
ALTER AUTHORIZATION ON [dbo].[TinhToanGiaTheoMaCP] TO  SCHEMA OWNER 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'SoDu>0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TaiKhoanNganHang', @level2type=N'CONSTRAINT',@level2name=N'CK_TKNH_SoDu'
GO
USE [master]
GO
ALTER DATABASE [CHUNGKHOAN] SET  READ_WRITE 
GO
