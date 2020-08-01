USE [master]
GO
/****** Object:  Database [pventa1]    Script Date: 25/07/2020 03:33:05 p. m. ******/
CREATE DATABASE [pventa1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pventa1', FILENAME = N'C:\bdata\pventa1.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'pventa1_log', FILENAME = N'C:\bdata\pventa1_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [pventa1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pventa1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pventa1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pventa1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pventa1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pventa1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pventa1] SET ARITHABORT OFF 
GO
ALTER DATABASE [pventa1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [pventa1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [pventa1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pventa1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pventa1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pventa1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pventa1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pventa1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pventa1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pventa1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pventa1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pventa1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pventa1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pventa1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pventa1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pventa1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pventa1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pventa1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pventa1] SET RECOVERY FULL 
GO
ALTER DATABASE [pventa1] SET  MULTI_USER 
GO
ALTER DATABASE [pventa1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pventa1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pventa1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pventa1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [pventa1]
GO
/****** Object:  User [agm]    Script Date: 25/07/2020 03:33:06 p. m. ******/
CREATE USER [agm] FOR LOGIN [agm] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[articulo]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[articulo](
	[ar_clave] [varchar](14) NOT NULL,
	[ar_nombre] [varchar](45) NOT NULL,
	[ar_grupo] [tinyint] NOT NULL,
	[ar_precioventa] [numeric](8, 2) NOT NULL,
	[ar_preciocosto] [numeric](8, 2) NOT NULL,
	[ar_existencia] [numeric](6, 2) NOT NULL,
	[ar_estatus] [tinyint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[cl_clave] [smallint] NOT NULL,
	[cl_nombre] [varchar](50) NOT NULL,
	[cl_domicilio] [varchar](40) NOT NULL,
	[cl_localidad] [varchar](35) NOT NULL,
	[cl_telefono] [varchar](10) NOT NULL,
	[cl_email] [varchar](50) NOT NULL,
	[cl_tipo] [tinyint] NOT NULL,
	[cl_estatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[cl_clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[grupos]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[grupos](
	[gr_clave] [tinyint] NOT NULL,
	[gr_nombre] [varchar](10) NOT NULL,
	[gr_estatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_grupos] PRIMARY KEY CLUSTERED 
(
	[gr_clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[materias]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[materias](
	[ma_clave] [varchar](5) NOT NULL,
	[ma_nombre] [varchar](45) NOT NULL,
	[ma_semestre] [tinyint] NOT NULL,
 CONSTRAINT [PK_materias] PRIMARY KEY CLUSTERED 
(
	[ma_clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedores](
	[pr_clave] [smallint] NOT NULL,
	[pr_nombre] [varchar](50) NOT NULL,
	[pr_domicilio] [varchar](40) NOT NULL,
	[pr_localidad] [varchar](35) NOT NULL,
	[pr_telefono] [varchar](10) NOT NULL,
	[pr_email] [varchar](55) NOT NULL,
	[pr_twiter] [varchar](50) NOT NULL,
	[pr_estatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_proveedores] PRIMARY KEY CLUSTERED 
(
	[pr_clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[us_login] [varchar](10) NOT NULL,
	[us_password] [varchar](10) NOT NULL,
	[us_nivel] [tinyint] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ventagen]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventagen](
	[vg_folio] [int] NOT NULL,
	[vg_fecha] [smalldatetime] NOT NULL,
	[vg_cliente] [smallint] NOT NULL,
	[vg_tipo] [tinyint] NOT NULL,
	[vg_estatus] [tinyint] NOT NULL,
	[vg_total] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_ventagen] PRIMARY KEY CLUSTERED 
(
	[vg_folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ventasdet]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ventasdet](
	[vd_folio] [int] NOT NULL,
	[vd_codigo] [varchar](14) NOT NULL,
	[vd_cantidad] [numeric](6, 2) NOT NULL,
	[vd_precio] [numeric](8, 2) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[articulosgrupo]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[articulosgrupo]
AS
SELECT TOP 100 ar_clave AS Clave,
ar_nombre AS Nombre,
ar_grupo AS Grupo,
gr_nombre AS "Nombre del grupo",
ar_precioventa * ar_existencia AS "Total venta",
ar_preciocosto AS "Precio de costo",
ar_preciocosto * ar_existencia AS " Total costo",
ar_existencia AS Existencia 
FROM articulo
INNER JOIN GRUPOS ON AR_GRUPO=GR_CLAVE
WHERE AR_ESTATUS=1
ORDER BY AR_NOMBRE
GO
/****** Object:  View [dbo].[CLIENTESPORclave]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CLIENTESPORclave]
AS
SELECT TOP 100
CL_CLAVE AS CLAVE ,
CL_NOMBRE AS NOMBRE,
CL_DOMICILIO AS DOMICILIO,
cl_localidad AS LOCALIDAD,
cl_telefono AS TELEFONO,
cl_tipo AS "tipo ClIENTE"
 FROM CLIENTES where cl_estatus=1 ORDER BY cl_clave

GO
/****** Object:  View [dbo].[CLIENTESPORnombre]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CLIENTESPORnombre]
AS
SELECT TOP 100
CL_CLAVE AS CLAVE ,
CL_NOMBRE AS NOMBRE,
CL_DOMICILIO AS DOMICILIO,
cl_localidad AS LOCALIDAD,
cl_telefono AS TELEFONO,
cl_tipo AS "tipo ClIENTE"
 FROM CLIENTES where cl_estatus=1 ORDER BY cl_nombre
GO
/****** Object:  View [dbo].[gruposporclave]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gruposporclave]
AS
SELECT TOP 100
gr_CLAVE AS CLAVE ,
gr_NOMBRE AS NOMBRE
 FROM grupos where gr_estatus=1 ORDER BY gr_clave
GO
/****** Object:  View [dbo].[grupospornombre]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW [dbo].[grupospornombre]
AS
SELECT TOP 100
gr_CLAVE AS CLAVE ,
gr_NOMBRE AS NOMBRE
 FROM grupos where gr_estatus=1 ORDER BY gr_nombre
GO
/****** Object:  View [dbo].[VCLIENTEPORNOMBRE2]    Script Date: 25/07/2020 03:33:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VCLIENTEPORNOMBRE2]
as 
select top 100
cl_clave as Cave,
cl_nombre as Nombre,
cl_domicilio as Domicilio,
cl_localidad as Localidad,
cl_telefono as Telefono,
cl_email as Email,
case cl_tipo
	when 1 then 'Menudeo'
	when 2 then'Mayoreo'
	when 0 then 'Error'
end as "tipo cliente",
case cl_estatus	
	when 0 then 'Baja'
	when 1 then'Activo'
end as estatus
from clientes
order by cl_nombre
GO
INSERT [dbo].[articulo] ([ar_clave], [ar_nombre], [ar_grupo], [ar_precioventa], [ar_preciocosto], [ar_existencia], [ar_estatus]) VALUES (N'123', N'JABON', 1, CAST(15.00 AS Numeric(8, 2)), CAST(15.00 AS Numeric(8, 2)), CAST(4.00 AS Numeric(6, 2)), 1)
INSERT [dbo].[clientes] ([cl_clave], [cl_nombre], [cl_domicilio], [cl_localidad], [cl_telefono], [cl_email], [cl_tipo], [cl_estatus]) VALUES (1, N'eduardo', N'los pinitos', N'guasave', N'644258155', N'edu@gmail.com', 0, 0)
INSERT [dbo].[clientes] ([cl_clave], [cl_nombre], [cl_domicilio], [cl_localidad], [cl_telefono], [cl_email], [cl_tipo], [cl_estatus]) VALUES (2, N'AZUCENA', N'chuparrosa', N'guasave', N'6871234501', N'ale_e@gmail.com', 1, 0)
INSERT [dbo].[clientes] ([cl_clave], [cl_nombre], [cl_domicilio], [cl_localidad], [cl_telefono], [cl_email], [cl_tipo], [cl_estatus]) VALUES (3, N'ALBERTOO', N'agua blanca', N'guasave', N'6871542589', N'alber@gmail.com', 1, 1)
INSERT [dbo].[clientes] ([cl_clave], [cl_nombre], [cl_domicilio], [cl_localidad], [cl_telefono], [cl_email], [cl_tipo], [cl_estatus]) VALUES (4, N'isabel', N'san antonio', N'guasave', N'6871032630', N'isaa@gmail.com', 0, 0)
INSERT [dbo].[clientes] ([cl_clave], [cl_nombre], [cl_domicilio], [cl_localidad], [cl_telefono], [cl_email], [cl_tipo], [cl_estatus]) VALUES (5, N'chuparrosa', N'guasave', N'EEEE', N'6871234501', N'ale_e@gmail.com', 1, 0)
INSERT [dbo].[clientes] ([cl_clave], [cl_nombre], [cl_domicilio], [cl_localidad], [cl_telefono], [cl_email], [cl_tipo], [cl_estatus]) VALUES (6, N'chuparrosa', N'guasave', N'ASS', N'6871234501', N'ale_e@gmail.com', 1, 0)
INSERT [dbo].[clientes] ([cl_clave], [cl_nombre], [cl_domicilio], [cl_localidad], [cl_telefono], [cl_email], [cl_tipo], [cl_estatus]) VALUES (7, N'cubilte', N'guasave', N'AXEL', N'7263535', N'xhsb_@', 0, 0)
INSERT [dbo].[grupos] ([gr_clave], [gr_nombre], [gr_estatus]) VALUES (1, N'GRASAS', 0)
INSERT [dbo].[grupos] ([gr_clave], [gr_nombre], [gr_estatus]) VALUES (2, N'vegetales', 1)
INSERT [dbo].[grupos] ([gr_clave], [gr_nombre], [gr_estatus]) VALUES (3, N'higiene', 1)
INSERT [dbo].[grupos] ([gr_clave], [gr_nombre], [gr_estatus]) VALUES (4, N'farmacia', 0)
INSERT [dbo].[grupos] ([gr_clave], [gr_nombre], [gr_estatus]) VALUES (7, N'dulceria', 0)
INSERT [dbo].[grupos] ([gr_clave], [gr_nombre], [gr_estatus]) VALUES (8, N'', 0)
INSERT [dbo].[materias] ([ma_clave], [ma_nombre], [ma_semestre]) VALUES (N'', N'', 0)
INSERT [dbo].[materias] ([ma_clave], [ma_nombre], [ma_semestre]) VALUES (N'1', N'1', 0)
INSERT [dbo].[materias] ([ma_clave], [ma_nombre], [ma_semestre]) VALUES (N'2', N'AZUU', 3)
INSERT [dbo].[materias] ([ma_clave], [ma_nombre], [ma_semestre]) VALUES (N'3', N'EDUARDO', 6)
INSERT [dbo].[proveedores] ([pr_clave], [pr_nombre], [pr_domicilio], [pr_localidad], [pr_telefono], [pr_email], [pr_twiter], [pr_estatus]) VALUES (1, N'LOMASS', N'GUASAVE', N'AZU', N'687123', N'ale_azu@', N'@azugm', 0)
INSERT [dbo].[proveedores] ([pr_clave], [pr_nombre], [pr_domicilio], [pr_localidad], [pr_telefono], [pr_email], [pr_twiter], [pr_estatus]) VALUES (2, N'EDBERTXXXXXXX', N'MARGARITAS', N'GUASAVE', N'6871033456', N'ed_bert@', N'@edbert', 1)
INSERT [dbo].[proveedores] ([pr_clave], [pr_nombre], [pr_domicilio], [pr_localidad], [pr_telefono], [pr_email], [pr_twiter], [pr_estatus]) VALUES (3, N'XXXXXXX', N'XXXX', N'XXXXX', N'444444', N'xxxx', N'xxxxx', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'maria', N'123', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'juan', N'123', 2)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'PEPE', N'4322', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'1', N'Mayoreo', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'azucena', N'321', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'azucena', N'321', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'2', N'Menudeo', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'1', N'Mayoreo', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'2', N'Menudeo', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'1', N'Mayoreo', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'2', N'Menudeo', 2)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'1', N'Mayoreo', 1)
INSERT [dbo].[usuarios] ([us_login], [us_password], [us_nivel]) VALUES (N'2', N'Menudeo', 1)
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1- Administrador. 2-operador. 3-invitado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'usuarios', @level2type=N'COLUMN',@level2name=N'us_nivel'
GO
USE [master]
GO
ALTER DATABASE [pventa1] SET  READ_WRITE 
GO
