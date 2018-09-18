using Aplicacao.Loja.Loja;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Dados.LojaContext
{
    public class LojaDbContext:DbContext
    {
        public LojaDbContext() : base("name=LojaDb")
        {

        }

        

        public DbSet<Produto> Produto { get; set; }

		public System.Data.Entity.DbSet<Aplicacao.Loja.Loja.Items.Eletronico> Eletronicos { get; set; }

		public System.Data.Entity.DbSet<Aplicacao.Loja.Loja.Items.Eletronico> Games { get; set; }

		public System.Data.Entity.DbSet<Aplicacao.Loja.Loja.Items.Jogo> Jogoes { get; set; }
	}
}
