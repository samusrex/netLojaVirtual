USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spInserirProdutoCategoriaEletronicos]    Script Date: 20/09/2018 13:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Halyson Mendonca
-- Create date: 2018-09-20
-- Description:	INSERT DE PRODUTOS
-- =============================================
ALTER PROCEDURE [dbo].[spInserirProdutoCategoriaEletronicos]

	@NOME NVARCHAR(MAX),
	@FABR NVARCHAR(MAX),
	@DESC NVARCHAR(MAX),
	@VALOR FLOAT,
	@QTDE INT,
	@IMG NVARCHAR(MAX),
	@SETOR INT =0,
	@CATINFO INT =NULL,
	@PROCESS NVARCHAR(MAX)='',
	@MEM INT=NULL,
	@ARMZ INT=NULL,
	@TPARMZ INT=NULL,
	@MODEL NVARCHAR(MAX),
	@TAM INT=1,
	@CATELTR INT,
	@CATGME INT=NULL
		
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO dbo.Produto(Nome,
	Fabricante,
	Descricao,
	Valor,
	Quantidade,
	Imagem,
	Setor,
	CatgInfo,
	Processador,
	Memoria,
	Armazenamento,
	TipoArmazenamento,
	Modelo,
	Tamanho,
	CatgEletron,
	CatgGame,
	Discriminator) VALUES (@NOME,
	@FABR,
	@DESC,
	@VALOR,
	@QTDE,
	@IMG,
	@SETOR,
	@CATINFO,
	@PROCESS,
	@MEM,
	@ARMZ,
	@TPARMZ,
	@MODEL,
	@TAM,
	@CATELTR,
	@CATGME,
	'eletronico'
	)
    
END
