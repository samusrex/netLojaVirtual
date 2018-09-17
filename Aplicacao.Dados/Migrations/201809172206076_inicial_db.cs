namespace Aplicacao.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial_db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Valor = c.Double(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        Imagem = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
