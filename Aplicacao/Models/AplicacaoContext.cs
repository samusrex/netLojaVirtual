using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aplicacao.Models
{
    public class AplicacaoContext : DbContext
    {
        
        public AplicacaoContext() : base("name=AplicacaoContext")
        {
        }

        public System.Data.Entity.DbSet<Aplicacao.Models.Tester> Testers { get; set; }
    }
}
