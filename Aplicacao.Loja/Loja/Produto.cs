using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Loja.Loja
{
	public abstract class Produto
	{

		public enum Categoria {

			ELETRONICOS,
			GAMES,
			INFORMATICA

		};

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProdutoId { get; set; }
		public string Nome { get; set; }
		public string Fabricante { get; set; }
		public string Descricao { get; set; }
		public double Valor { get; set; }
		public int Quantidade { get; set; }
		public string Imagem { get; set; }
		public Categoria Setor { get; set; }


	}
}
