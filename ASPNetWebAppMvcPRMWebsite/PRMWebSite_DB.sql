USE [master]
GO
/****** Object:  Database [PRMWebSite_DB]    Script Date: 21/10/2023 21:36:23 ******/
CREATE DATABASE [PRMWebSite_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PRMWebSite_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019EXPRESS\MSSQL\DATA\PRMWebSite_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PRMWebSite_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019EXPRESS\MSSQL\DATA\PRMWebSite_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PRMWebSite_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PRMWebSite_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PRMWebSite_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PRMWebSite_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PRMWebSite_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PRMWebSite_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PRMWebSite_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PRMWebSite_DB] SET  MULTI_USER 
GO
ALTER DATABASE [PRMWebSite_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PRMWebSite_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PRMWebSite_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PRMWebSite_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PRMWebSite_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PRMWebSite_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PRMWebSite_DB] SET QUERY_STORE = OFF
GO
USE [PRMWebSite_DB]
GO
/****** Object:  Table [dbo].[Apartments]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apartments](
	[ApartmentId] [int] NOT NULL,
	[BuldingId] [int] NOT NULL,
	[OwnerId] [int] NOT NULL,
	[PropertyManagerId] [int] NOT NULL,
	[ApartmentUnitNumber] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Size] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Apartments] PRIMARY KEY CLUSTERED 
(
	[ApartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentId] [int] NOT NULL,
	[ApartmentId] [int] NOT NULL,
	[TenantId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Buildings]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buildings](
	[BuildingId] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[UnitNumber] [int] NOT NULL,
	[Location] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Buildings_1] PRIMARY KEY CLUSTERED 
(
	[BuildingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[EventId] [int] NOT NULL,
	[ApartmentId] [int] NOT NULL,
	[EventText] [nvarchar](500) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[MessageId] [int] NOT NULL,
	[ApartmentId] [int] NOT NULL,
	[MessageText] [nvarchar](500) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[TenantId] [int] NOT NULL,
	[SendBy] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OwnerEvents]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OwnerEvents](
	[EventId] [int] NOT NULL,
	[OwnerId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[PropertyManagerId] [int] NOT NULL,
 CONSTRAINT [PK_OwnerEvents] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC,
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Owners]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Owners](
	[OwnerId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Owners_1] PRIMARY KEY CLUSTERED 
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyManagerAppointments]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyManagerAppointments](
	[AppointmentId] [int] NOT NULL,
	[PropertyManagerId] [int] NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[TenantId] [int] NOT NULL,
 CONSTRAINT [PK_PropertyManagerAppointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC,
	[PropertyManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyManagerMessages]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyManagerMessages](
	[MessageId] [int] NOT NULL,
	[PropertyManagerId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[TenantId] [int] NOT NULL,
 CONSTRAINT [PK_PropertyManagerMessages_1] PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC,
	[PropertyManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyManagers]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyManagers](
	[PropertyManagerId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PropertyManagers_1] PRIMARY KEY CLUSTERED 
(
	[PropertyManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScheduleAppointments]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScheduleAppointments](
	[ScheduleAppointmentId] [int] NOT NULL,
	[PropertyManagerId] [int] NOT NULL,
	[TenantId] [int] NOT NULL,
	[ScheduleAppointmentDate] [datetime] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ScheduleAppointments] PRIMARY KEY CLUSTERED 
(
	[ScheduleAppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tenants]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tenants](
	[TenantId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Email] [nchar](100) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Tenants_1] PRIMARY KEY CLUSTERED 
(
	[TenantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 21/10/2023 21:36:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Apartments]  WITH CHECK ADD  CONSTRAINT [FK_Apartments_Buildings1] FOREIGN KEY([BuldingId])
REFERENCES [dbo].[Buildings] ([BuildingId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Apartments] CHECK CONSTRAINT [FK_Apartments_Buildings1]
GO
ALTER TABLE [dbo].[Apartments]  WITH CHECK ADD  CONSTRAINT [FK_Apartments_Owners] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Owners] ([OwnerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Apartments] CHECK CONSTRAINT [FK_Apartments_Owners]
GO
ALTER TABLE [dbo].[Apartments]  WITH CHECK ADD  CONSTRAINT [FK_Apartments_PropertyManagers] FOREIGN KEY([PropertyManagerId])
REFERENCES [dbo].[PropertyManagers] ([PropertyManagerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Apartments] CHECK CONSTRAINT [FK_Apartments_PropertyManagers]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Apartments] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartments] ([ApartmentId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Apartments]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Tenants] FOREIGN KEY([TenantId])
REFERENCES [dbo].[Tenants] ([TenantId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Tenants]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Apartments] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartments] ([ApartmentId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Apartments]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Apartments1] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartments] ([ApartmentId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Apartments1]
GO
ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Tenants] FOREIGN KEY([TenantId])
REFERENCES [dbo].[Tenants] ([TenantId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Tenants]
GO
ALTER TABLE [dbo].[ScheduleAppointments]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleAppointments_PropertyManagers] FOREIGN KEY([PropertyManagerId])
REFERENCES [dbo].[PropertyManagers] ([PropertyManagerId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ScheduleAppointments] CHECK CONSTRAINT [FK_ScheduleAppointments_PropertyManagers]
GO
ALTER TABLE [dbo].[ScheduleAppointments]  WITH CHECK ADD  CONSTRAINT [FK_ScheduleAppointments_Tenants] FOREIGN KEY([TenantId])
REFERENCES [dbo].[Tenants] ([TenantId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ScheduleAppointments] CHECK CONSTRAINT [FK_ScheduleAppointments_Tenants]
GO
USE [master]
GO
ALTER DATABASE [PRMWebSite_DB] SET  READ_WRITE 
GO
