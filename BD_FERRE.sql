USE [master]
GO
/****** Object:  Database [FerreteriaNeyte]    Script Date: 8/11/2023 18:23:31 ******/
CREATE DATABASE [FerreteriaNeyte]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FerreteriaNeyte', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FerreteriaNeyte.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FerreteriaNeyte_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FerreteriaNeyte_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FerreteriaNeyte] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FerreteriaNeyte].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FerreteriaNeyte] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET ARITHABORT OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FerreteriaNeyte] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FerreteriaNeyte] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FerreteriaNeyte] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FerreteriaNeyte] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FerreteriaNeyte] SET  MULTI_USER 
GO
ALTER DATABASE [FerreteriaNeyte] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FerreteriaNeyte] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FerreteriaNeyte] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FerreteriaNeyte] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FerreteriaNeyte] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FerreteriaNeyte] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FerreteriaNeyte] SET QUERY_STORE = ON
GO
ALTER DATABASE [FerreteriaNeyte] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FerreteriaNeyte]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdProveedor] [int] NULL,
	[TipoDocumento] [varchar](50) NULL,
	[NroDocumento] [varchar](50) NULL,
	[MontoTotal] [varchar](50) NULL,
	[FechaRegistro] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[IdPermiso] [int] NULL,
	[IdRol] [int] NULL,
	[NombreMenu] [varchar](50) NULL,
	[FechaRegistro] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[IdCategoria] [int] NULL,
	[Stock] [int] NOT NULL,
	[PrecioCompra] [decimal](10, 2) NULL,
	[PrecioVenta] [decimal](10, 2) NULL,
	[Estado] [bit] NULL,
	[FechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NUsuario] [varchar](50) NULL,
	[NroDocumento] [varchar](50) NULL,
	[NombreCompleto] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[FechaAlta] [date] NULL,
	[FechaBaja] [date] NULL,
	[IdRol] [int] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] NULL,
	[IdUsuario] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((0)) FOR [PrecioCompra]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT ((0)) FOR [PrecioVenta]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARCATEGORIA]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARCATEGORIA](
@IdCategoria int,
@Descripcion varchar(50),
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado = 1
	IF NOT EXISTS(select * from Categoria
					where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
		update Categoria set
		Descripcion = @Descripcion
		where IdCategoria = @IdCategoria
	
	ELSE
	begin
	set @Resultado = 0
	set @Mensaje = 'No se puede repetir la descripcion de una categoria'
end
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARUSUARIO]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARUSUARIO](
@IdUsuario int,
@NUsuario varchar(50),
@NroDocumento varchar(50),
@NombreCompleto varchar(100),
@Email varchar(50),
@Clave varchar(50),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)

as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists( select * from  Usuario where NroDocumento = @NroDocumento and IdUsuario != @IdUsuario)
	begin
		 update usuario set		 
		 NUsuario = @NUsuario,
		 NroDocumento = @NroDocumento, 
		 NombreCompleto = @NombreCompleto,
		 Email = @Email,
		 Clave = @Clave,
		 IdRol = @IdRol,
		 Estado = @Estado
		 where IdUsuario = @IdUsuario
		  		 
		 set @Respuesta = 1

	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARCATEGORIA]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARCATEGORIA](
@IdCategoria int,
@Descripcion varchar(50),
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado = 1
	IF EXISTS(select * from Categoria C
				inner join Producto P on p.IdCategoria = c.IdCategoria
					where c.IdCategoria = @IdCategoria
					)
	begin 
		delete top (1) from Categoria where IdCategoria = @IdCategoria
	end

	ELSE
	begin
	set @Resultado = 0
	set @Mensaje = 'La categoria se encuentra relacionada a un producto'
end
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARUSUARIO]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARUSUARIO](
@IdUsuario int,
@Respuesta bit output,
@Mensaje varchar(500) output
)

as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	IF EXISTS(select * from compra C
				inner join Usuario U on U.IdUsuario = C.IdUsuario
				where u.IdUsuario = @IdUsuario)

	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
	set @Mensaje = @Mensaje +  'El usuario se encuentra relacionado a una compra\n'

	END

	IF EXISTS(select * from Venta V
				inner join Usuario U on U.IdUsuario = V.IdUsuario
				where u.IdUsuario = @IdUsuario)

	BEGIN
		set @pasoreglas = 0
		set @Respuesta = 0
	set @Mensaje = @Mensaje +  'El usuario se encuentra relacionado a una venta\n'

	END
	
	IF(@pasoreglas = 1)
	BEGIN
		DELETE FROM Usuario where IdUsuario = @IdUsuario
		set @Respuesta = 1
	END

end
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARCATEGORIA]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARCATEGORIA](
@Descripcion varchar(50),
@Resultado int output,
@Mensaje varchar(500) output
)as
begin
	set @Resultado = 0
	IF EXISTS(select * from Categoria
					where Descripcion = @Descripcion)

	BEGIN
		insert into Categoria(Descripcion) values(@Descripcion)
		set @Resultado = SCOPE_IDENTITY()
		
	end
	ELSE
	set @Mensaje = 'No se puede repetir la descripcion de una categoria'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARUSUARIO]    Script Date: 8/11/2023 18:23:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARUSUARIO](
@NUsuario varchar(50),
@NroDocumento varchar(50),
@NombreCompleto varchar(100),
@Email varchar(50),
@Clave varchar(50),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)

as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''

	if not exists( select * from  Usuario where NroDocumento = @NroDocumento)
	begin
		 insert into usuario(NUsuario, NroDocumento, NombreCompleto, Email, Clave, IdRol, Estado) values
		 (@NUsuario, @NroDocumento, @NombreCompleto, @Email, @Clave, @IdRol, @Estado)
		 
		 set @IdUsuarioResultado = SCOPE_IDENTITY()

	end
	else
		set @Mensaje = 'No se puede repetir el documento para más de un usuario'

end
GO
USE [master]
GO
ALTER DATABASE [FerreteriaNeyte] SET  READ_WRITE 
GO
