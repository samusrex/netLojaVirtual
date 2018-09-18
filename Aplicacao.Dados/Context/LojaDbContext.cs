using Aplicacao.Loja.Loja;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
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

		public DbSet<Loja.Loja.Items.Eletronico> Eletronicos { get; set; }

		public DbSet<Loja.Loja.Items.Jogo> Jogos { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          
        }

        public System.Data.Entity.DbSet<Aplicacao.Loja.Loja.Items.Computador> Computadors { get; set; }
    }
}
