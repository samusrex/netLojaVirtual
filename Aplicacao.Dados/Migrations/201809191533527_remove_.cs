namespace Aplicacao.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_ : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Produto", "CaracteriticasAdicionais");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "CaracteriticasAdicionais", c => c.String());
        }
    }
}
