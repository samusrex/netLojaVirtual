using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Dados.Repository.Interface
{
    public interface IRepositorio<T> where T:class
    {
        IQueryable<T> ObterTodos();
        IQueryable<T> EncontrePor(Expression<Func<T, bool>> predicate);
        void Adicione(T entity);
        void Remova(T entity);
        void Atualize(T entity);
        void Registre();
    }
}
