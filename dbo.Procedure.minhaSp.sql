CREATE PROCEDURE minhaSP
@id int
AS
BEGIN

SELECT * FROM dbo.Produto WHERE ProdutoId=@id

END
