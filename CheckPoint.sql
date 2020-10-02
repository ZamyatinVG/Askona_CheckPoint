USE [master]
GO
/****** Object:  Database [CheckPoint]    Script Date: 03/25/2020 09:03:08 ******/
CREATE DATABASE [CheckPoint] ON  PRIMARY 
( NAME = N'CheckPoint', FILENAME = N'd:\Data\CheckPoint.mdf' , SIZE = 106496KB , MAXSIZE = 1048576KB , FILEGROWTH = 10240KB )
 LOG ON 
( NAME = N'CheckPoint_log', FILENAME = N'd:\Log\CheckPoint_log.ldf' , SIZE = 81608KB , MAXSIZE = 1048576KB , FILEGROWTH = 10240KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CheckPoint].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CheckPoint] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CheckPoint] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CheckPoint] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CheckPoint] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CheckPoint] SET ARITHABORT OFF
GO
ALTER DATABASE [CheckPoint] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CheckPoint] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CheckPoint] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CheckPoint] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CheckPoint] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CheckPoint] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CheckPoint] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CheckPoint] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CheckPoint] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CheckPoint] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CheckPoint] SET  DISABLE_BROKER
GO
ALTER DATABASE [CheckPoint] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CheckPoint] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CheckPoint] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CheckPoint] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CheckPoint] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CheckPoint] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [CheckPoint] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CheckPoint] SET  READ_WRITE
GO
ALTER DATABASE [CheckPoint] SET RECOVERY FULL
GO
ALTER DATABASE [CheckPoint] SET  MULTI_USER
GO
ALTER DATABASE [CheckPoint] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CheckPoint] SET DB_CHAINING OFF
GO
USE [CheckPoint]
GO
/****** Object:  User [NT SERVICE\HealthService]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [NT SERVICE\HealthService] FOR LOGIN [NT SERVICE\HealthService] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [HCASKONA\checkpoint_warehouse]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [HCASKONA\checkpoint_warehouse] FOR LOGIN [HCASKONA\checkpoint_warehouse]
GO
/****** Object:  User [HCASKONA\checkpoint_user]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [HCASKONA\checkpoint_user] FOR LOGIN [HCASKONA\checkpoint_user]
GO
/****** Object:  User [HCASKONA\checkpoint_staff]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [HCASKONA\checkpoint_staff] FOR LOGIN [HCASKONA\checkpoint_staff]
GO
/****** Object:  User [HCASKONA\checkpoint_sec]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [HCASKONA\checkpoint_sec] FOR LOGIN [HCASKONA\checkpoint_sec]
GO
/****** Object:  User [GW-AD\checkpoint_warehouse]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [GW-AD\checkpoint_warehouse] FOR LOGIN [GW-AD\checkpoint_warehouse]
GO
/****** Object:  User [GW-AD\checkpoint_user]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [GW-AD\checkpoint_user] FOR LOGIN [GW-AD\checkpoint_user]
GO
/****** Object:  User [GW-AD\checkpoint_staff]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [GW-AD\checkpoint_staff] FOR LOGIN [GW-AD\checkpoint_staff]
GO
/****** Object:  User [GW-AD\checkpoint_sec]    Script Date: 03/25/2020 09:03:08 ******/
CREATE USER [GW-AD\checkpoint_sec] FOR LOGIN [GW-AD\checkpoint_sec]
GO
/****** Object:  Role [Users]    Script Date: 03/25/2020 09:03:08 ******/
CREATE ROLE [Users] AUTHORIZATION [dbo]
GO
/****** Object:  Table [dbo].[Request]    Script Date: 03/25/2020 09:03:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[FID] [int] IDENTITY(1,1) NOT NULL,
	[FDESCR] [nvarchar](50) NOT NULL,
	[FCREATEDATE] [datetime] NOT NULL,
	[FGUESTFIO] [nvarchar](255) NOT NULL,
	[FGUESTJOB] [nvarchar](255) NULL,
	[FAUTOMARK] [nvarchar](128) NULL,
	[FAUTONUMBER] [nvarchar](128) NULL,
	[FLOCATION] [nvarchar](128) NULL,
	[FPURPOSE] [nvarchar](255) NULL,
	[FDATEBEGIN] [datetime] NOT NULL,
	[FDATEEND] [datetime] NOT NULL,
	[FMEETFIO] [nvarchar](128) NULL,
	[FMEETTABNUMBER] [nvarchar](20) NULL,
	[FFACTDATEBEGIN] [datetime] NULL,
	[FFACTDATEEND] [datetime] NULL,
	[FSTATUS] [nvarchar](128) NOT NULL,
	[FPHONE] [nvarchar](128) NULL,
	[FUTVDATE] [datetime] NULL,
	[FWHDATEBEGIN] [datetime] NULL,
	[FWHDATEEND] [datetime] NULL,
	[FWHCOMMENT] [nvarchar](128) NULL,
	[FWHPERSON] [nvarchar](128) NULL,
	[FNREC] [nvarchar](16) NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[FID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Request] ON [dbo].[Request] 
(
	[FID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InOut]    Script Date: 03/25/2020 09:03:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InOut](
	[FFACTDATEBEGIN] [datetime] NOT NULL,
	[FWHDATEBEGIN] [datetime] NULL,
	[FWHDATEEND] [datetime] NULL,
	[FFACTDATEEND] [datetime] NULL,
	[FID] [int] NOT NULL,
 CONSTRAINT [PK_FID_FFACTDATEBEGIN] PRIMARY KEY NONCLUSTERED 
(
	[FID] ASC,
	[FFACTDATEBEGIN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Request_FDATE]    Script Date: 03/25/2020 09:03:09 ******/
ALTER TABLE [dbo].[Request] ADD  CONSTRAINT [DF_Request_FDATE]  DEFAULT (getdate()) FOR [FCREATEDATE]
GO
/****** Object:  ForeignKey [FK_InOut_Request]    Script Date: 03/25/2020 09:03:09 ******/
ALTER TABLE [dbo].[InOut]  WITH CHECK ADD  CONSTRAINT [FK_InOut_Request] FOREIGN KEY([FID])
REFERENCES [dbo].[Request] ([FID])
GO
ALTER TABLE [dbo].[InOut] CHECK CONSTRAINT [FK_InOut_Request]
GO
