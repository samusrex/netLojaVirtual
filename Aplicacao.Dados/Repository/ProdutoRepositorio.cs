using Aplicacao.Dados.Repository.Interface;
using Aplicacao.Loja.Loja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Dados.Repository
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        public void Add(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Produto entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Produto> FindBy(System.Linq.Expressions.Expression<Func<Produto, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
