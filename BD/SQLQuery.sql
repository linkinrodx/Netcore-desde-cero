USE [Atomo]
GO
/****** Object:  Table [Flow].[Echadura]    Script Date: 28/10/2019 11:36:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Flow].[Echadura](
	[EchaduraId] [int] IDENTITY(1,1) NOT NULL,
	[AnioId] [int] NOT NULL,
	[CampaniaId] [int] NOT NULL,
	[Descripcion] [nvarchar](250) NOT NULL,
	[NroPaginas] [int] NOT NULL,
	[Eliminado] [bit] NOT NULL,
	[UsuarioIdCreacion] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaCreacionUtc] [datetime] NOT NULL,
	[UsuarioIdModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[FechaModificacionUtc] [datetime] NULL,
 CONSTRAINT [PK_Echadura] PRIMARY KEY CLUSTERED 
(
	[EchaduraId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [DATA]
) ON [DATA]
GO
/****** Object:  Table [Flow].[Pagina]    Script Date: 28/10/2019 11:36:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Flow].[Pagina](
	[PaginaId] [int] NOT NULL,
	[EchaduraPaisId] [int] NOT NULL,
	[MarcaId] [int] NOT NULL,
	[NroPagina] [int] NOT NULL,
	[TipoPaginaId] [int] NOT NULL,
	[EsDoble] [bit] NOT NULL,
	[EsPar] [bit] NOT NULL,
	[PlantillaId] [int] NOT NULL,
	[Comentario] [varchar](250) NULL,
	[Eliminado] [bit] NOT NULL,
	[UsuarioIdCreacion] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaCreacionUtc] [datetime] NOT NULL,
	[UsuarioIdModificacion] [int] NULL,
	[FechaModificacion] [datetime] NULL,
	[FechaModificacionUtc] [datetime] NULL,
 CONSTRAINT [PK_Pagina] PRIMARY KEY CLUSTERED 
(
	[PaginaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [DATA]
) ON [DATA]
GO
SET IDENTITY_INSERT [Flow].[Echadura] ON 
GO
INSERT [Flow].[Echadura] ([EchaduraId], [AnioId], [CampaniaId], [Descripcion], [NroPaginas], [Eliminado], [UsuarioIdCreacion], [FechaCreacion], [FechaCreacionUtc], [UsuarioIdModificacion], [FechaModificacion], [FechaModificacionUtc]) VALUES (1, 1, 1, N'PRUEBA', 48, 0, 0, CAST(N'2019-08-27T18:11:23.857' AS DateTime), CAST(N'2019-08-27T23:11:23.857' AS DateTime), 0, CAST(N'2019-08-27T18:11:23.857' AS DateTime), CAST(N'2019-08-27T23:11:23.857' AS DateTime))
GO
SET IDENTITY_INSERT [Flow].[Echadura] OFF
GO
ALTER TABLE [Flow].[Pagina]  WITH CHECK ADD  CONSTRAINT [FK_Pagina_EchaduraPais] FOREIGN KEY([EchaduraPaisId])
REFERENCES [Flow].[EchaduraPais] ([EchaduraPaisId])
GO
ALTER TABLE [Flow].[Pagina] CHECK CONSTRAINT [FK_Pagina_EchaduraPais]
GO
