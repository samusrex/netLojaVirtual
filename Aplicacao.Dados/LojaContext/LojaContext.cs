using Aplicacao.Loja.Loja;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Dados.LojaContext
{
    public class LojaContext:DbContext
    {
        public LojaContext() : base("name=LojaDb")
        {

        }

        

        DbSet<Produto> Produto { get; set; }


    }
}
