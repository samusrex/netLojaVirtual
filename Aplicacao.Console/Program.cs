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

            //Testar Registro de Produto Eletronico com Store Procedure.

            Produto terminalS920 = new Eletronico()
            {
                CatgEletron = Eletronico.CategoriaEletronico.TERMINAIS,
                Descricao = "S921 - Mobile POS"+ DateTime.Now.ToString("ddMMyyyyHHmmss"),
                Fabricante = "Transire",
                Imagem = "",
                Modelo = "S921",
                Nome = "Mobile POS",
                Quantidade = 1,
                Setor = Produto.Categoria.ELETRONICOS,
                Tamanho = 1,
                Valor = 9999


            };


            RepositorioProduto.RegistreUsandoStoreProcedure((Eletronico)terminalS920);
            System.Console.WriteLine("Cadastrado com sucesso");




            #region MetodoParaRemoverTodosOsITemsDoBanco
            //Remova Todos.
            //int todos = RepositorioProduto.ObterTodos().ToList().OrderByDescending(c => c.ProdutoId).FirstOrDefault().ProdutoId;
            //System.Console.WriteLine(todos);

            //for (int i = 0; i <= todos; i++)
            //{

            //    Produto excluir = RepositorioProduto.EncontrePor(c => c.ProdutoId == i).FirstOrDefault();
            //    if (excluir != null)
            //    {

            //        RepositorioProduto.Remova(excluir);
            //        RepositorioProduto.Registre();

            //    }

            //}
            #endregion



            System.Console.ReadKey();

		}
	}
}
