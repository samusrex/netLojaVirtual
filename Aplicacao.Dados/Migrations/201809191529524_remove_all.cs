namespace Aplicacao.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_all : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "CaracteriticasAdicionais", c => c.String());
            DropColumn("dbo.Produto", "CaracteristicasAdicionais");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produto", "CaracteristicasAdicionais", c => c.String());
            DropColumn("dbo.Produto", "CaracteriticasAdicionais");
        }
    }
}
