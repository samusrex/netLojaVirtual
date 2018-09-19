using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplicacao.Dados.LojaContext;
using Aplicacao.Loja.Loja.Items;
using Aplicacao.Dados.Repository;
using Aplicacao.Loja.Loja;

namespace Aplicacao.Apresentacao.Controllers
{
    public class ComputadoresController : Controller
    {
        ProdutoRepositorio db = new ProdutoRepositorio();

        // GET: Computadores
        public ActionResult Index()
        {
            ViewBag.Title = "Loja Virtual";

            var listaComputadores = new List<Computador>();

            foreach (Computador item in db.ObterTodos().Where(c => c.Setor == Produto.Categoria.INFORMATICA))
            {
                listaComputadores.Add(item);
            }

            return View(listaComputadores);
        }

        // GET: Computadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto Computador = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            if (Computador == null)
            {
                return HttpNotFound();
            }
            return View(Computador);
        }

        // GET: Computadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Computadores/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdutoId,CatgInfo,Processador,Memoria,Armazenamento,TipoArmazenamento,Nome,Fabricante,Descricao,Valor,Quantidade,Imagem,Setor")] Computador computador)
        {
            if (ModelState.IsValid)
            {
                computador.Setor = Produto.Categoria.INFORMATICA;                   
                db.Adicione(computador);
                db.Registre();
                return RedirectToAction("Index");
            }

            return View(computador);
        }

        // GET: Computadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto computador = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            if (computador == null)
            {
                return HttpNotFound();
            }
            return View(computador);
        }

        // POST: Computadores/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Computador computador)
        {
            if (ModelState.IsValid)
            {
                db.Atualize(computador);
                db.Registre();
                return RedirectToAction("Index");
            }
            return View(computador);
        }

        // GET: Computadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto computador = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            if (computador == null)
            {
                return HttpNotFound();
            }
            return View(computador);
        }

        // POST: Computadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto computador = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            db.Remova(computador);
            db.Registre();
            return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
