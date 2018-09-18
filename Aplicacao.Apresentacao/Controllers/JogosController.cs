using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplicacao.Dados.LojaContext;
using Aplicacao.Dados.Repository;
using Aplicacao.Loja.Loja;
using Aplicacao.Loja.Loja.Items;

namespace Aplicacao.Apresentacao.Controllers
{
    public class JogosController : Controller
    {
		ProdutoRepositorio db = new ProdutoRepositorio();

		// GET: Jogos
		public ActionResult Index()
        {
			ViewBag.Title = "Loja Virtual";

			var listaJogos = new List<Jogo>();

			foreach (Jogo item in db.ObterTodos().Where(c => c.Setor == Produto.Categoria.GAMES))
			{
				listaJogos.Add(item);
			}

			return View(listaJogos);
		}

        // GET: Jogos/Details/5
        public ActionResult Details(int? id)
        {
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Produto Jogo = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
			if (Jogo == null)
			{
				return HttpNotFound();
			}
			return View(Jogo);
		}

        // GET: Jogos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jogos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdutoId,CatgGame,Nome,Fabricante,Descricao,Valor,Quantidade,Imagem,Setor")] Jogo  jogo)
        {
			if (ModelState.IsValid)
			{
				db.Adicione(jogo);
				db.Registre();
				return RedirectToAction("Index");
			}

			return View(jogo);
		}

        // GET: Jogos/Edit/5
        public ActionResult Edit(int? id)
        {
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Produto jogo = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
			if (jogo == null)
			{
				return HttpNotFound();
			}
			return View(jogo);
		}

        // POST: Jogos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProdutoId,CatgGame,Nome,Fabricante,Descricao,Valor,Quantidade,Imagem,Setor")] Jogo jogo)
        {
			if (ModelState.IsValid)
			{
				db.Atualize(jogo);
				db.Registre();
				return RedirectToAction("Index");
			}
			return View(jogo);
		}

        // GET: Jogos/Delete/5
        public ActionResult Delete(int? id)
        {
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Produto jogo = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
			if (jogo == null)
			{
				return HttpNotFound();
			}
			return View(jogo);
		}

        // POST: Jogos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
			Produto jogo = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
			db.Remova(jogo);
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
