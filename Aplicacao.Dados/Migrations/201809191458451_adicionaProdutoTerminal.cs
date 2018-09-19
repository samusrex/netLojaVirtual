namespace Aplicacao.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionaProdutoTerminal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "CaracteristicasAdicionais", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produto", "CaracteristicasAdicionais");
        }
    }
}
