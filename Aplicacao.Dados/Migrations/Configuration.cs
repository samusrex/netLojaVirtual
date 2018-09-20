namespace Aplicacao.Dados.Migrations
{
	using Aplicacao.Loja.Loja;
	using Aplicacao.Loja.Loja.Items;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Aplicacao.Dados.LojaContext.LojaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = true;
        }

		protected override void Seed(LojaContext.LojaDbContext context)
		{

			context.Produto.AddOrUpdate(x => x.ProdutoId,
			new Eletronico()
			{

				Fabricante = "LG",
				Descricao = "Smart TV 49' LED Full HD LG 49LK5750PSA Entradas 2 HDMI 1 USB 60 Hz",
				Modelo = "49LK5750PSA",
				Nome = "Smart TV 49' LED Full HD LG ",
				Quantidade = 5,
				Tamanho = 49,
				CatgEletron = Eletronico.CategoriaEletronico.TV,
				Valor = 2499.50

			},

			new Computador()
			{

				Setor = Produto.Categoria.INFORMATICA,
				CatgInfo = Computador.CategoriaInformatica.PC,
				Nome = "PC POSITIVO ",
				Memoria = 2,
				Processador = "Dual Core Intel Atom",
				Armazenamento = 500,
				Fabricante = "POSITIVO",
				TipoArmazenamento = Computador.Disco.HD,
				Descricao = "Computador Positivo Intel Celeron Dual Core J1800",
				Quantidade = 15,
				Valor = 1352.00,

			},

			new Computador()
			{

				Setor = Produto.Categoria.INFORMATICA,
				CatgInfo = Computador.CategoriaInformatica.PC,
				Nome = "PC POSITIVO X3 ",
				Memoria = 8,
				Processador = "Quad Core Intel Atom",
				Armazenamento = 1000,
				Fabricante = "POSITIVO",
				TipoArmazenamento = Computador.Disco.SSD,
				Descricao = "Computador Positivo Intel I5¨7G",
				Quantidade = 15,
				Valor = 3352.00,

			},

			new Eletronico()
			{


				Fabricante = "LG",
				Descricao = "Smart TV 32' LED Full HD LG 39LK5750PSA Entradas 2 HDMI 2 USB 60 Hz",
				Modelo = "32LK5750PSA",
				Nome = "Smart TV 32' LED Full HD LG ",
				Quantidade = 5,
				Tamanho = 32,
				CatgEletron = Eletronico.CategoriaEletronico.TV,
				Valor = 1499.50


			},

			new Jogo()
			{
				Setor = Produto.Categoria.GAMES,
				CatgGame = Jogo.CategoriaGame.RPG,
				Nome = "The Witcher 3",
				Descricao = "The Witcher For PS4 HD",
				Fabricante = "CD RED PROJECT",
				Quantidade = 5,
				Valor = 115.00
			},

			new Jogo()
			{
				Setor = Produto.Categoria.GAMES,
				CatgGame = Jogo.CategoriaGame.LUTA,
				Nome = "Dragon Ball Super FIghters",
				Descricao = "Dragon Ball Super FIghters For PS4 HD",
				Fabricante = "BANDAI",
				Quantidade = 5,
				Valor = 175.00
			},

			new Eletronico()
			{

				Fabricante = "TRANSIRE",
				Descricao = " A920 terminal de pagamentos com o SO Android.",
				Modelo = "A920",
				Nome = "A920 - SMART POS",
				Quantidade = 50,
				Tamanho = 30,
				CatgEletron = Eletronico.CategoriaEletronico.TERMINAIS,
				Valor = 9499.50

			}






			);

		}
	}
}
