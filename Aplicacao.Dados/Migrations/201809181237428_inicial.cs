namespace Aplicacao.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Fabricante = c.String(),
                        Descricao = c.String(),
                        Valor = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Imagem = c.String(),
                        Setor = c.Int(nullable: false),
                        Modelo = c.String(),
                        Tamanho = c.Int(),
                        CatgEletron = c.Int(),
                        CatgGame = c.Int(),
                        CatgInfo = c.Int(),
                        Processador = c.String(),
                        Memoria = c.Int(),
                        Armazenamento = c.Int(),
                        TipoArmazenamento = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produto");
        }
    }
}
