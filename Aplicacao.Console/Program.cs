using Aplicacao.Dados.Repository;
using Aplicacao.Loja.Loja;
using Aplicacao.Loja.Loja.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Console
{
	class Program
	{
		static void Main(string[] args)
		{

			var RepositorioProduto = new ProdutoRepositorio();


			var PCPositivo = new Informatica()
			{
				Setor = Produto.Categoria.INFORMATICA,
				CatgInfo = Informatica.CategoriaInformatica.PC,
				Nome = "PC POSITIVO ",
				Memoria = 2,
				Processador = "Dual Core Intel Atom",
				Armazenamento = 500,
				Fabricante = "POSITIVO",
				TipoArmazenamento = Informatica.Disco.HD,
				Descricao = "Computador Positivo Intel Celeron Dual Core J1800",
				Quantidade = 15,
				Valor = 1352.00,
				
			};


			var TheWitcher3 = new Game()
			{
				Setor = Produto.Categoria.GAMES,
				CatgGame = Game.CategoriaGame.RPG,
				Nome = "The Witcher 3",
				Descricao = "The Witcher For PS4 HD",
				Fabricante = "CD RED PROJECT",
				Quantidade = 5,
				Valor = 115.00
			};

			var TDBZSuper = new Game()
			{
				Setor = Produto.Categoria.GAMES,
				CatgGame = Game.CategoriaGame.LUTA,
				Nome = "Dragon Ball Super FIghters",
				Descricao = "Dragon Ball Super FIghters For PS4 HD",
				Fabricante = "BANDAI",
				Quantidade = 5,
				Valor = 175.00
			};


			//Registrar uma TV.
			var TVLG49 = new Eletronicos()
			{
				Fabricante = "LG",
				Descricao = "Smart TV 49' LED Full HD LG 49LK5750PSA Entradas 2 HDMI 1 USB 60 Hz",
				Modelo = "49LK5750PSA",
				Nome = "Smart TV 49' LED Full HD LG ",
				Quantidade = 5,
				Tamanho = 49,
				CatgEletron = Eletronicos.CategoriaEletronico.TV,
				Valor = 2499.50
			};


			var TVLG32 = new Eletronicos()
			{
				Fabricante = "LG",
				Descricao = "Smart TV 32' LED Full HD LG 39LK5750PSA Entradas 2 HDMI 2 USB 60 Hz",
				Modelo = "32LK5750PSA",
				Nome = "Smart TV 32' LED Full HD LG ",
				Quantidade = 5,
				Tamanho = 32,
				CatgEletron = Eletronicos.CategoriaEletronico.TV,
				Valor = 1499.50
			};


			//TVS
			RepositorioProduto.Adicione(TVLG32);
			RepositorioProduto.Adicione(TVLG49);
			//GAMES
			RepositorioProduto.Adicione(TheWitcher3);
			RepositorioProduto.Adicione(TDBZSuper);
			//PC
			RepositorioProduto.Adicione(PCPositivo);

			RepositorioProduto.Registre();






			#region MetodoParaRemoverTodosOsITemsDoBanco
			////Remova Todos.
			//int todos = RepositorioProduto.ObterTodos().ToList().OrderByDescending(c => c.ProdutoId).FirstOrDefault().ProdutoId;
			//System.Console.WriteLine(todos);

			//for (int i = 0; i <= todos; i++)
			//{

			//	Produto excluir = RepositorioProduto.EncontrePor(c => c.ProdutoId == i).FirstOrDefault();
			//	if (excluir != null)
			//	{

			//		RepositorioProduto.Remova(excluir);
			//		RepositorioProduto.Registre();

			//	}

			//}
			#endregion



			System.Console.ReadKey();

		}
	}
}
