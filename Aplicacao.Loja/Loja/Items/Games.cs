using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Loja.Loja.Items
{
	public class Game : Produto
	{
		public enum CategoriaGame
		{
			AÇÂO,
			RPG,
			LUTA,
			FPS,

		}

		public CategoriaGame CatgGame { get; set; }

	}
}
