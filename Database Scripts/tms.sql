USE [master]
GO
/****** Object:  Database [TMS]    Script Date: 11/25/2022 2:17:11 AM ******/
CREATE DATABASE [TMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMS_log.ldf' , SIZE = 2624KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TMS] SET RECOVERY FULL 
GO
ALTER DATABASE [TMS] SET  MULTI_USER 
GO
ALTER DATABASE [TMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TMS', N'ON'
GO
USE [TMS]
GO
/****** Object:  Table [dbo].[Rolemaster]    Script Date: 11/25/2022 2:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rolemaster](
	[Roleid] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NULL,
	[IsAdmin] [int] NULL,
	[createdate] [datetime] NULL,
	[modifydate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 11/25/2022 2:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[EmpName] [nvarchar](500) NULL,
	[Roleid] [int] NULL,
	[Password] [nvarchar](500) NULL,
	[Createddate] [datetime] NULL,
	[Modifydate] [datetime] NULL,
	[Isactive] [bit] NULL,
	[empid] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Pic] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserMaster] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[Userdetails]    Script Date: 11/25/2022 2:17:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Userdetails]
AS
SELECT        dbo.Rolemaster.RoleName, dbo.Rolemaster.IsAdmin, dbo.UserMaster.Password, dbo.UserMaster.Createddate, dbo.UserMaster.Modifydate, dbo.UserMaster.Pic, dbo.UserMaster.Email, dbo.UserMaster.Remark, 
                         dbo.UserMaster.empid, dbo.UserMaster.Isactive, dbo.UserMaster.EmpName, dbo.Rolemaster.Roleid
FROM            dbo.UserMaster INNER JOIN
                         dbo.Rolemaster ON dbo.UserMaster.Roleid = dbo.Rolemaster.Roleid

GO
SET IDENTITY_INSERT [dbo].[Rolemaster] ON 

INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (1, N'Admin', 1, CAST(0x0000AF5500011CDF AS DateTime), CAST(0x0000AF5500011CDF AS DateTime))
INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (2, N'Manager', 1, CAST(0x0000AF55000133A2 AS DateTime), CAST(0x0000AF55000133A2 AS DateTime))
INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (3, N'Employee', 1, CAST(0x0000AF550001559C AS DateTime), CAST(0x0000AF550001559C AS DateTime))
SET IDENTITY_INSERT [dbo].[Rolemaster] OFF
INSERT [dbo].[UserMaster] ([EmpName], [Roleid], [Password], [Createddate], [Modifydate], [Isactive], [empid], [Remark], [Email], [Pic]) VALUES (N'Rajesh', 1, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(0x0000AF55000F4C68 AS DateTime), CAST(0x0000AF57017C29E0 AS DateTime), 1, N'184877', N'Admin and SOM Activity', N'184877@nttdata.com', N'184877.jpg')
ALTER TABLE [dbo].[Rolemaster] ADD  CONSTRAINT [DF_Rolemaster_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[Rolemaster] ADD  CONSTRAINT [DF_Rolemaster_modifydate]  DEFAULT (getdate()) FOR [modifydate]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[5] 2[41] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "UserMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 228
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Rolemaster"
            Begin Extent = 
               Top = 6
               Left = 335
               Bottom = 191
               Right = 509
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Userdetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Userdetails'
GO
USE [master]
GO
ALTER DATABASE [TMS] SET  READ_WRITE 
GO
