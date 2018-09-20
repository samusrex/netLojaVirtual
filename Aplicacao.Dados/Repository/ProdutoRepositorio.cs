using Aplicacao.Dados.LojaContext;
using Aplicacao.Dados.Repository.Interface;
using Aplicacao.Loja.Loja;
using Aplicacao.Loja.Loja.Items;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Aplicacao.Dados.Repository
{
    public class ProdutoRepositorio : IRepositorio<Produto>, IDisposable
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

        // Exemplo de Insert com Procedure.
        public void RegistreUsandoStoreProcedure(Eletronico p)
        {

            int padrao = 0;

            var resultado = new SqlParameter("@ultimoregistroId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };

            var exec = @"EXEC dbo.spInserirProdutoCategoriaEletronicos
            @ultimoregistroId,
            @NOME,
            @FABR ,
            @DESC ,
            @VALOR ,
            @QTDE ,

            @IMG ,
            @SETOR,
            @CATINFO ,
            @PROCESS ,
            @MEM,
            @ARMZ ,

            @TPARMZ ,
            @MODEL ,
            @TAM ,
            @CATELTR ,
            @CATGME";



            db.Database.ExecuteSqlCommand(exec,

                                   new SqlParameter("@NOME", p.Nome),
                                   new SqlParameter("@FABR", p.Fabricante),
                                   new SqlParameter("@DESC", p.Descricao),
                                   new SqlParameter("@VALOR", p.Valor),
                                   new SqlParameter("@QTDE", p.Quantidade),
                                   new SqlParameter("@IMG", p.Imagem),
                                   new SqlParameter("@SETOR", p.Setor),
                                   new SqlParameter("@CATINFO", padrao),
                                   new SqlParameter("@PROCESS", padrao),
                                   new SqlParameter("@MEM", padrao),
                                   new SqlParameter("@ARMZ", padrao),
                                   new SqlParameter("@TPARMZ", padrao),
                                   new SqlParameter("@MODEL", p.Nome),
                                   new SqlParameter("@TAM", padrao),
                                   new SqlParameter("@CATELTR", p.CatgEletron),
                                   new SqlParameter("@CATGME", padrao),
                                   resultado


                               );
            

            Console.WriteLine("resultado é {0}", resultado);

        }
    }
}
