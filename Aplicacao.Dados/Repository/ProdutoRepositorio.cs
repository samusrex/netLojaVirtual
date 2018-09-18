using Aplicacao.Dados.LojaContext;
using Aplicacao.Dados.Repository.Interface;
using Aplicacao.Loja.Loja;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Aplicacao.Dados.Repository
{
    public class ProdutoRepositorio : IRepositorio<Produto>,IDisposable
    {
		LojaDbContext db = new LojaDbContext();

		public void Adicione(Produto entity)
        {
			db.Produto.Add(entity);   
        }

        public void Remova(Produto entity)
        {
			db.Produto.Remove(entity);
        }

        public void Atualize(Produto entity)
        {
			db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IQueryable<Produto> EncontrePor(Expression<Func<Produto, bool>> predicate)
        {
			IQueryable<Produto> query = db.Set<Produto>().Where(predicate);
			return query;
		}

        public IQueryable<Produto> ObterTodos()
        {
			IQueryable<Produto> todos = db.Produto;

			return todos;
        }

        public void Registre()
        {
            db.SaveChanges();
        }

		public void Dispose()
		{
			db.Dispose();
		}
	}
}
