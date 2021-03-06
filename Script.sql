USE [Hydrocarbons_BD]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/05/2020 2:54:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Line_Hydrocarbons]    Script Date: 11/05/2020 2:54:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Line_Hydrocarbons](
	[Id_LineHydrocarbon] [int] IDENTITY(1,1) NOT NULL,
	[Name_Line] [nvarchar](max) NOT NULL,
	[Length_Line] [decimal](18, 2) NOT NULL,
	[Diameter_Line] [decimal](18, 2) NOT NULL,
	[InstalationDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Line_Hydrocarbons] PRIMARY KEY CLUSTERED 
(
	[Id_LineHydrocarbon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
