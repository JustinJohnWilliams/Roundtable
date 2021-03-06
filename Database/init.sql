USE [master]
GO
/****** Object:  Database [RoundTable]    Script Date: 11/08/2013 10:29:23 ******/
CREATE DATABASE [RoundTable] ON  PRIMARY 
( NAME = N'RoundTable', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RoundTable.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RoundTable_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\RoundTable_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RoundTable] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RoundTable].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RoundTable] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [RoundTable] SET ANSI_NULLS OFF
GO
ALTER DATABASE [RoundTable] SET ANSI_PADDING OFF
GO
ALTER DATABASE [RoundTable] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [RoundTable] SET ARITHABORT OFF
GO
ALTER DATABASE [RoundTable] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [RoundTable] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [RoundTable] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [RoundTable] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [RoundTable] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [RoundTable] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [RoundTable] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [RoundTable] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [RoundTable] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [RoundTable] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [RoundTable] SET  DISABLE_BROKER
GO
ALTER DATABASE [RoundTable] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [RoundTable] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [RoundTable] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [RoundTable] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [RoundTable] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [RoundTable] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [RoundTable] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [RoundTable] SET  READ_WRITE
GO
ALTER DATABASE [RoundTable] SET RECOVERY FULL
GO
ALTER DATABASE [RoundTable] SET  MULTI_USER
GO
ALTER DATABASE [RoundTable] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [RoundTable] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'RoundTable', N'ON'
GO
USE [RoundTable]
GO

/****** Object:  Table [dbo].[Presenters]    Script Date: 11/08/2013 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presenters](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 11/08/2013 10:29:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Talks]    Script Date: 11/08/2013 10:35:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Talks](
	[Id] [uniqueidentifier] NOT NULL,
	[Topic] [nvarchar](100) NOT NULL,
	[PresenterId] [uniqueidentifier] NOT NULL,
	[LocationId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]

GO

/****** Object:  View [dbo].[vw_Talks]    Script Date: 11/08/2013 10:52:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_Talks]
AS

SELECT t.PresenterId, t.LocationId, t.Id as 'TalkId', l.Name as 'LocationName', p.FirstName, p.LastName, t.Topic
FROM dbo.Locations l
INNER JOIN dbo.Talks t 
ON l.Id = t.LocationId 
INNER JOIN dbo.Presenters p ON 
t.PresenterId = p.Id

GO