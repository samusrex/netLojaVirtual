using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Loja.Loja.Items
{
	public class Eletronico:Produto
	{
		public enum CategoriaEletronico {

			TV,
			VIDEOGAMES,
            TERMINAIS
          

		}

		public string Modelo { get; set; }
		public int Tamanho { get; set; }
		public CategoriaEletronico CatgEletron { get; set; }
	}
}
