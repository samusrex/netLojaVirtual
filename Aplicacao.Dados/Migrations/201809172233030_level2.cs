namespace Aplicacao.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class level2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "teste", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "teste");
        }
    }
}
