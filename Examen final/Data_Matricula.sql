USE [master]
GO
/****** Object:  Database [Matricula]    Script Date: 17/12/2018 20:32:51 ******/
CREATE DATABASE [Matricula]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Matricula', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Matricula.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Matricula_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Matricula_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Matricula] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Matricula].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Matricula] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Matricula] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Matricula] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Matricula] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Matricula] SET ARITHABORT OFF 
GO
ALTER DATABASE [Matricula] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Matricula] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Matricula] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Matricula] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Matricula] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Matricula] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Matricula] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Matricula] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Matricula] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Matricula] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Matricula] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Matricula] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Matricula] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Matricula] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Matricula] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Matricula] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Matricula] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Matricula] SET RECOVERY FULL 
GO
ALTER DATABASE [Matricula] SET  MULTI_USER 
GO
ALTER DATABASE [Matricula] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Matricula] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Matricula] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Matricula] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Matricula] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Matricula] SET QUERY_STORE = OFF
GO
USE [Matricula]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Matricula]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[AlumnoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Direccion] [varchar](90) NULL,
	[Sexo] [char](1) NULL,
	[FechNacimiento] [datetime] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[AlumnoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[CursoID] [int] IDENTITY(1,1) NOT NULL,
	[GradoID] [int] NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[CursoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grado]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grado](
	[GradoID] [int] IDENTITY(1,1) NOT NULL,
	[Nivel] [varchar](30) NULL,
 CONSTRAINT [PK_Grado] PRIMARY KEY CLUSTERED 
(
	[GradoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matricula]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matricula](
	[MatriculaID] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[GradoID] [int] NULL,
	[SeccionID] [int] NULL,
	[AlumnoID] [int] NULL,
 CONSTRAINT [PK_Matricula] PRIMARY KEY CLUSTERED 
(
	[MatriculaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notas]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notas](
	[NotaID] [int] IDENTITY(1,1) NOT NULL,
	[AlumnoID] [int] NULL,
	[Nota] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Notas] PRIMARY KEY CLUSTERED 
(
	[NotaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seccion]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seccion](
	[SeccionID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](40) NULL,
	[GradoID] [int] NULL,
 CONSTRAINT [PK_Seccion] PRIMARY KEY CLUSTERED 
(
	[SeccionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[Login] [nvarchar](10) NULL,
	[Password] [nvarchar](10) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([AlumnoID], [Nombres], [Apellidos], [Direccion], [Sexo], [FechNacimiento]) VALUES (1, N'JUAN CARLOS', N'ZORRILLA LLERENA', N'AV. JAVIER PRADO 2158 DPTO:1002 SAN ISIDRO', N'M', CAST(N'1970-02-24T00:00:00.000' AS DateTime))
INSERT [dbo].[Alumno] ([AlumnoID], [Nombres], [Apellidos], [Direccion], [Sexo], [FechNacimiento]) VALUES (2, N'GLADYS MERCEDES', N'ASTO VARGAS', N'AV. JAVIER PRADO 2158 DPTO:1002 SAN ISIDRO', N'F', CAST(N'1972-09-27T00:00:00.000' AS DateTime))
INSERT [dbo].[Alumno] ([AlumnoID], [Nombres], [Apellidos], [Direccion], [Sexo], [FechNacimiento]) VALUES (3, N'FABIANA ANDREA', N'ZORRILLA ASTO', N'AV. JAVIER PRADO 2158 DPTO:1002 SAN ISIDRO', N'F', CAST(N'2004-09-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Alumno] ([AlumnoID], [Nombres], [Apellidos], [Direccion], [Sexo], [FechNacimiento]) VALUES (4, N'CHRISTIAN ', N'INTOR VELASQUEZ', N'AV. LOS CONDORES 191', N'M', CAST(N'1970-02-24T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Alumno] OFF
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([CursoID], [GradoID], [Nombre]) VALUES (4, 1, N'VISUAL STUDIO FUNDAMENTEAL')
INSERT [dbo].[Curso] ([CursoID], [GradoID], [Nombre]) VALUES (5, 2, N'VISUAL STUDIO DEVELOPER')
INSERT [dbo].[Curso] ([CursoID], [GradoID], [Nombre]) VALUES (6, 3, N'VISUAL WEB DEVELOPER')
SET IDENTITY_INSERT [dbo].[Curso] OFF
SET IDENTITY_INSERT [dbo].[Grado] ON 

INSERT [dbo].[Grado] ([GradoID], [Nivel]) VALUES (1, N'BASICO')
INSERT [dbo].[Grado] ([GradoID], [Nivel]) VALUES (2, N'MEDIO')
INSERT [dbo].[Grado] ([GradoID], [Nivel]) VALUES (3, N'AVANZADO')
SET IDENTITY_INSERT [dbo].[Grado] OFF
SET IDENTITY_INSERT [dbo].[Matricula] ON 

INSERT [dbo].[Matricula] ([MatriculaID], [Fecha], [GradoID], [SeccionID], [AlumnoID]) VALUES (1, NULL, 1, 1, 1)
INSERT [dbo].[Matricula] ([MatriculaID], [Fecha], [GradoID], [SeccionID], [AlumnoID]) VALUES (3, NULL, 1, 4, 4)
INSERT [dbo].[Matricula] ([MatriculaID], [Fecha], [GradoID], [SeccionID], [AlumnoID]) VALUES (4, NULL, 1, 2, 3)
INSERT [dbo].[Matricula] ([MatriculaID], [Fecha], [GradoID], [SeccionID], [AlumnoID]) VALUES (5, CAST(N'2018-12-17T18:40:25.437' AS DateTime), 1, 3, 2)
INSERT [dbo].[Matricula] ([MatriculaID], [Fecha], [GradoID], [SeccionID], [AlumnoID]) VALUES (6, CAST(N'2018-12-17T20:13:55.767' AS DateTime), 2, 4, 4)
INSERT [dbo].[Matricula] ([MatriculaID], [Fecha], [GradoID], [SeccionID], [AlumnoID]) VALUES (7, CAST(N'2018-12-17T20:29:45.403' AS DateTime), 2, 2, 4)
SET IDENTITY_INSERT [dbo].[Matricula] OFF
SET IDENTITY_INSERT [dbo].[Seccion] ON 

INSERT [dbo].[Seccion] ([SeccionID], [Nombre], [GradoID]) VALUES (1, N'SEDE CENTRAL', 1)
INSERT [dbo].[Seccion] ([SeccionID], [Nombre], [GradoID]) VALUES (2, N'COLEGIO SOPHIANUM', 1)
INSERT [dbo].[Seccion] ([SeccionID], [Nombre], [GradoID]) VALUES (3, N'SEDE SURCO', 2)
INSERT [dbo].[Seccion] ([SeccionID], [Nombre], [GradoID]) VALUES (4, N'CENTRO DE LIMA', 3)
SET IDENTITY_INSERT [dbo].[Seccion] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Email], [Login], [Password]) VALUES (1, N'JUAN CARLOS', N'ZORRILLA LLERENA', N'jczll@msn.com', N'JCZLL', N'12345')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Matricula] ADD  CONSTRAINT [DFF_Matricula_Fecha]  DEFAULT (sysdatetime()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Grado] FOREIGN KEY([GradoID])
REFERENCES [dbo].[Grado] ([GradoID])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Grado]
GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Alumno] FOREIGN KEY([AlumnoID])
REFERENCES [dbo].[Alumno] ([AlumnoID])
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Alumno]
GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Grado] FOREIGN KEY([GradoID])
REFERENCES [dbo].[Grado] ([GradoID])
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Grado]
GO
ALTER TABLE [dbo].[Matricula]  WITH CHECK ADD  CONSTRAINT [FK_Matricula_Seccion] FOREIGN KEY([SeccionID])
REFERENCES [dbo].[Seccion] ([SeccionID])
GO
ALTER TABLE [dbo].[Matricula] CHECK CONSTRAINT [FK_Matricula_Seccion]
GO
ALTER TABLE [dbo].[Notas]  WITH CHECK ADD  CONSTRAINT [FK_Notas_Alumno] FOREIGN KEY([AlumnoID])
REFERENCES [dbo].[Alumno] ([AlumnoID])
GO
ALTER TABLE [dbo].[Notas] CHECK CONSTRAINT [FK_Notas_Alumno]
GO
ALTER TABLE [dbo].[Seccion]  WITH CHECK ADD  CONSTRAINT [FK_Seccion_Grado] FOREIGN KEY([GradoID])
REFERENCES [dbo].[Grado] ([GradoID])
GO
ALTER TABLE [dbo].[Seccion] CHECK CONSTRAINT [FK_Seccion_Grado]
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarAlumnoMatriculado]    Script Date: 17/12/2018 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE procedure [dbo].[sp_BuscarAlumnoMatriculado] 
@GradoID int,
@SeccionID int,
@AlumnoID int
as
begin 
select MatriculaID from Matricula where GradoID=@GradoID and SeccionID=@SeccionID and AlumnoID=@AlumnoID 
end
GO
USE [master]
GO
ALTER DATABASE [Matricula] SET  READ_WRITE 
GO
