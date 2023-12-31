USE [master]
GO
/****** Object:  Database [BDUSUARIO_LAB_HULE]    Script Date: 4/12/2018 00:32:17 ******/
CREATE DATABASE [BDUSUARIO_LAB_HULE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDUSUARIO_LAB_HULE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDUSUARIO_LAB_HULE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDUSUARIO_LAB_HULE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\BDUSUARIO_LAB_HULE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDUSUARIO_LAB_HULE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET  MULTI_USER 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET QUERY_STORE = OFF
GO
USE [BDUSUARIO_LAB_HULE]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BDUSUARIO_LAB_HULE]
GO
/****** Object:  Table [dbo].[TBJEFATURA]    Script Date: 4/12/2018 00:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBJEFATURA](
	[IDUSUARIO] [int] NOT NULL,
	[USUARIO] [varchar](20) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[DEPARTAMENTO] [varchar](100) NOT NULL,
	[EXTENSION] [int] NOT NULL,
	[EMAIL] [varchar](100) NOT NULL,
	[CONTRASENA] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBTECNICO]    Script Date: 4/12/2018 00:32:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBTECNICO](
	[IDUSUARIO] [int] NOT NULL,
	[USUARIO] [varchar](20) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[DEPARTAMENTO] [varchar](100) NOT NULL,
	[EXTENSION] [int] NOT NULL,
	[EMAIL] [varchar](100) NOT NULL,
	[CONTRASENA] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[TBJEFATURA] ([IDUSUARIO], [USUARIO], [NOMBRE], [DEPARTAMENTO], [EXTENSION], [EMAIL], [CONTRASENA]) VALUES (101, N'ADMIN', N'PRUEBA', N'LABORATORIO HULE', 111, N'PRUEBA@HULE.CO.CR', N'123456')
INSERT [dbo].[TBTECNICO] ([IDUSUARIO], [USUARIO], [NOMBRE], [DEPARTAMENTO], [EXTENSION], [EMAIL], [CONTRASENA]) VALUES (101, N'TECNIC', N'PRUEBA', N'LABORATORIO HULE', 111, N'PRUEBA@HULE.CO.CR', N'123456')
/****** Object:  StoredProcedure [dbo].[BUSCAR_JEFATURA]    Script Date: 4/12/2018 00:32:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_JEFATURA]
-- ADD THE PARAMETERS FOR THE STORED PROCEDURE HERE

@USUARIO VARCHAR (20),
@MSJ VARCHAR(100) OUT

AS
	BEGIN
		IF (NOT EXISTS(SELECT * FROM TBJEFATURA WHERE USUARIO=@USUARIO))
			SET @MSJ = 'Usuario incorrecto'
		ELSE
			BEGIN
				SELECT * FROM  TBJEFATURA WHERE USUARIO=@USUARIO
				SET @MSJ = 'Usuario ingresado correctamente'
			END
	END
GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_TECNICO]    Script Date: 4/12/2018 00:32:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_TECNICO]
-- ADD THE PARAMETERS FOR THE STORED PROCEDURE HERE

@USUARIO VARCHAR (20),
@MSJ VARCHAR(100) OUT

AS
	BEGIN
		IF (NOT EXISTS(SELECT * FROM TBTECNICO WHERE USUARIO=@USUARIO))
			SET @MSJ = 'Usuario incorrecto'
		ELSE
			BEGIN
				SELECT * FROM  TBTECNICO WHERE USUARIO=@USUARIO
				SET @MSJ = 'Usuario ingresado correctamente'
			END
	END
GO
USE [master]
GO
ALTER DATABASE [BDUSUARIO_LAB_HULE] SET  READ_WRITE 
GO
