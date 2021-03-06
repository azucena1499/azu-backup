USE [master]
GO
/****** Object:  Database [BIBLIOTECA]    Script Date: 25/07/2020 03:34:38 p. m. ******/
CREATE DATABASE [BIBLIOTECA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BIBLIOTECA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER2\MSSQL\DATA\BIBLIOTECA.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BIBLIOTECA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER2\MSSQL\DATA\BIBLIOTECA_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BIBLIOTECA] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BIBLIOTECA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BIBLIOTECA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET ARITHABORT OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BIBLIOTECA] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [BIBLIOTECA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BIBLIOTECA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BIBLIOTECA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BIBLIOTECA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BIBLIOTECA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BIBLIOTECA] SET  MULTI_USER 
GO
ALTER DATABASE [BIBLIOTECA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BIBLIOTECA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BIBLIOTECA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BIBLIOTECA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BIBLIOTECA]
GO
/****** Object:  User [agm]    Script Date: 25/07/2020 03:34:38 p. m. ******/
CREATE USER [agm] FOR LOGIN [agm] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  StoredProcedure [dbo].[spautoress]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[spautoress]
 @op tinyint,
 @id int,
 @Nombre varchar(100) = NULL
 as 
 begin
	if @op=  1
	begin
	 select * from Autores where id=@id
	end
	if @op = 2
	begin
		if exists(select * from Autores where id=@id)
		begin
			update Autores set id=@id,Nombre=@Nombre 	
			where id=@id
		end
		else
		begin
	  insert into Autores(id,Nombre)
	  values((select isnull(max(id),0)+1 from Autores),@Nombre)
	 end
	end
	if @op = 3
	  begin
		delete from Autores where id=@id 
	end
end
GO
/****** Object:  StoredProcedure [dbo].[spClientes]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spClientes]
 @op tinyint,
 @clave smallint,
 @Nombre varchar(50)=null,
 @Domicilio varchar(40)=null,
 @Localidad varchar(35)=null,
 @Telefono varchar(10)=null,
 @Email varchar(50)=null
 as 
 begin
	if @op=  1
	begin
	 select * from Clientes where clave=@clave
	end
	if @op = 2
	begin
		if exists(select * from Clientes where clave=@clave)
		begin
			update Clientes set clave=@clave,Nombre=@Nombre,Domicilio=@Domicilio,Localidad=@Localidad,Telefono=@Telefono,Email=@Email
			where clave=@clave
		end
		else
		begin
	  insert into Clientes(clave,Nombre,Domicilio,Localidad,Telefono,Email)
	  values((select isnull(max(clave),0)+1 from Clientes),@Nombre,@Domicilio,@Localidad,@Telefono,@Email)
	 end
	end
	if @op = 3
	  begin
		delete from Clientes where clave=@clave 
	end
end
GO
/****** Object:  StoredProcedure [dbo].[spEditoriales]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spEditoriales]
 @op tinyint,
 @id int,
 @Nombre varchar(100)=null
 as 
 begin
	if @op=  1
	begin
	 select * from Editoriales where id=@id
	end
	if @op = 2
	begin
		if exists(select * from Editoriales where id=@id)
		begin
			update Editoriales set id=@id,Nombre=@Nombre
			where id=@id
		end
		else
		begin
	  insert into Editoriales(id,Nombre)
	  values((select isnull(max(id),0)+1 from Editoriales),@Nombre)
	 end
	end
	if @op = 3
	  begin
		delete from Editoriales where id=@id
	end
end
GO
/****** Object:  StoredProcedure [dbo].[spGenero]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spGenero]
@op tinyint,
@id int,
@Descripcion varchar(100) = ''
as
begin
	if @op = 1
	begin 
		select * from GENERO where id = @id
	end
	if @op = 2
	begin
		if exists(select * from GENERO where id = @id)
		begin
			update GENERO set Descrpcion=@Descripcion where id = @id
		end
		else
		begin
			insert into GENERO(id,Descrpcion)
			values ((select isnull(Max(id),0) + 1 from GENERO),@Descripcion)
		end
	end
	if @op = 3
	begin
		delete from GENERO where id = @id
	end
end
GO
/****** Object:  StoredProcedure [dbo].[spLibros]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spLibros]
 @op tinyint,
 @id int,
 @ISBN varchar(13)=null,
 @Titulo varchar(100)=null,
 @idAutor int =-1,
 @idGenero int=-1,
 @FchaPublicacion date=null,
 @Editorial varchar(100) =null
 as 
 begin
	if @op=  1
	begin
	 select * from LIBROS where id=@id
	end
	if @op = 2
	begin
		if exists(select * from LIBROS where id=@id)
		begin
			update LIBROS set ISBN=@ISBN,Titulo=@Titulo,idAutor=@idAutor,idGenero=@idGenero,FechaPublicacion=@FchaPublicacion,Editorial=@Editorial
			where id=@id
		end
		else
		begin
	  insert into LIBROS(id,ISBN,Titulo,idAutor,idGenero,FechaPublicacion,Editorial)
	  values((select isnull(max(id),0)+1 from LIBROS),@ISBN,@Titulo,@idAutor,@idGenero,@FchaPublicacion,@Editorial)
	 end
	end
	if @op = 3
	  begin
		delete from LIBROS where id=@id
	end
end
GO
/****** Object:  Table [dbo].[Autores]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Autores](
	[id] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[clave] [smallint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Domicilio] [varchar](40) NOT NULL,
	[Localidad] [varchar](35) NOT NULL,
	[Telefono] [varchar](10) NOT NULL,
	[Email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Editoriales]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Editoriales](
	[id] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GENERO]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GENERO](
	[id] [int] NOT NULL,
	[Descrpcion] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LIBROS]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LIBROS](
	[id] [int] NOT NULL,
	[ISBN] [varchar](13) NOT NULL,
	[Titulo] [varchar](100) NOT NULL,
	[idAutor] [int] NOT NULL,
	[idGenero] [int] NOT NULL,
	[FechaPublicacion] [date] NOT NULL,
	[Editorial] [varchar](100) NOT NULL,
 CONSTRAINT [PK__LIBROS__3213E83F243D19A6] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[Vclientes]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Vclientes]
as
select c.clave,c.Nombre,c.Domicilio,c.localidad,c.Telefono,c.Email from Clientes c 

GO
/****** Object:  View [dbo].[Vlibros]    Script Date: 25/07/2020 03:34:38 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[Vlibros]
as
select l.id,l.ISBN,l.Titulo,a.Nombre as Autor,g.Descrpcion as
Genero,l.FechaPublicacion, l.idAutor, l.idGenero,l.Editorial from Libros l
inner join Autores a on a.id = l.idAutor
inner join GENERO g on g.id = l.idGenero
inner join Editoriales e on e.Nombre=Editorial

GO
INSERT [dbo].[Autores] ([id], [Nombre]) VALUES (1, N'Gabriel Garcia')
INSERT [dbo].[Autores] ([id], [Nombre]) VALUES (2, N'Ava Dellaira')
INSERT [dbo].[Autores] ([id], [Nombre]) VALUES (3, N'Rainbow Rowel')
INSERT [dbo].[Autores] ([id], [Nombre]) VALUES (4, N'Sthephen King')
INSERT [dbo].[Clientes] ([clave], [Nombre], [Domicilio], [Localidad], [Telefono], [Email]) VALUES (1, N'Azucenaa', N'La chuparrosa', N'Guasave', N'6871035450', N'ale_azu@gmail.com')
INSERT [dbo].[Clientes] ([clave], [Nombre], [Domicilio], [Localidad], [Telefono], [Email]) VALUES (2, N'Alejandra', N'Agua Blanca', N'Guasave', N'6871429230', N'alejanda_14@gmail.com')
INSERT [dbo].[Clientes] ([clave], [Nombre], [Domicilio], [Localidad], [Telefono], [Email]) VALUES (3, N'Juan', N'Cubilete', N'Guasave', N'6871326554', N'juan_alber@gmail.com')
INSERT [dbo].[Clientes] ([clave], [Nombre], [Domicilio], [Localidad], [Telefono], [Email]) VALUES (4, N'margarita', N'lomas', N'Guasave', N'687444444', N'asdfghjkl')
INSERT [dbo].[Clientes] ([clave], [Nombre], [Domicilio], [Localidad], [Telefono], [Email]) VALUES (5, N'Eduardo', N'los pinitos', N'Guasave', N'6442571555', N'eduardo@gmail.com')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (1, N'Anagramaa')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (2, N'Akal')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (3, N'Alba')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (4, N'Panorama')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (5, N'Austral')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (6, N'Booket')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (7, N'Espasa')
INSERT [dbo].[Editoriales] ([id], [Nombre]) VALUES (8, N'Esencia')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (1, N'Terror')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (2, N'Accion')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (3, N'Ficcion')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (4, N' Romántica')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (5, N'Poesia')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (6, N'infantil')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (8, N'')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (9, N'')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (10, N'Suspenso')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (11, N'Accion')
INSERT [dbo].[GENERO] ([id], [Descrpcion]) VALUES (12, N'')
INSERT [dbo].[LIBROS] ([id], [ISBN], [Titulo], [idAutor], [idGenero], [FechaPublicacion], [Editorial]) VALUES (2, N'956', N'Bajo la misma estrella', 1, 3, CAST(0xE3400B00 AS Date), N'Alba')
INSERT [dbo].[LIBROS] ([id], [ISBN], [Titulo], [idAutor], [idGenero], [FechaPublicacion], [Editorial]) VALUES (3, N'111', N'sssss', 2, 3, CAST(0xEA400B00 AS Date), N'Alba')
INSERT [dbo].[LIBROS] ([id], [ISBN], [Titulo], [idAutor], [idGenero], [FechaPublicacion], [Editorial]) VALUES (4, N'753', N'La ladrona de libros', 2, 3, CAST(0xF8400B00 AS Date), N'Panorama')
ALTER TABLE [dbo].[LIBROS]  WITH CHECK ADD  CONSTRAINT [FK_LIBROS_Autores] FOREIGN KEY([idAutor])
REFERENCES [dbo].[Autores] ([id])
GO
ALTER TABLE [dbo].[LIBROS] CHECK CONSTRAINT [FK_LIBROS_Autores]
GO
ALTER TABLE [dbo].[LIBROS]  WITH CHECK ADD  CONSTRAINT [FK_LIBROS_GENERO] FOREIGN KEY([idAutor])
REFERENCES [dbo].[GENERO] ([id])
GO
ALTER TABLE [dbo].[LIBROS] CHECK CONSTRAINT [FK_LIBROS_GENERO]
GO
USE [master]
GO
ALTER DATABASE [BIBLIOTECA] SET  READ_WRITE 
GO
