using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Loja.Loja.Items
{
	public class Computador:Produto
	{
		public enum CategoriaInformatica{

			NOTEBOOK,
			PC

		}
		public enum Disco {

			HD,
			SSD
		}

		public CategoriaInformatica CatgInfo { get; set; }
		public string Processador { get; set; }
		public int Memoria { get; set; }
		public int Armazenamento { get; set; }
		public Disco TipoArmazenamento { get; set; }
	}
}
