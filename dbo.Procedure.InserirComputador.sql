CREATE PROCEDURE InserirComputador

@id int,
@Nome VARCHAR(100),
@Fabr VARCHAR(100),
@Descr VARCHAR(MAX),
@Val DECIMAL,
@Qtde INTEGER,
@Img VARCHAR(MAX),
@Setor INTEGER,
@Model VARCHAR(100),
@Tam INTEGER,
@CatgInfo INTEGER,
@Processador VARCHAR(100),
@Memoria INTEGER,
@Armaz INTEGER,
@TipoArm INTEGER

AS
BEGIN

INSERT INTO PRODUTO(ProdutoId,Nome,Fabricante,Descricao,Valor,Quantidade,Imagem,Setor,Modelo,Tamanho,CatgInfo,Processador,Memoria,Armazenamento,TipoArmazenamento) 
VALUES (
@id,
@Nome,
@Fabr,
@Descr,
@Val,
@Qtde,
@Img,
'2',
@Model,
@Tam,
@CatgInfo,
@Processador,
@Memoria,
@Armaz,
@TipoArm
)

END
