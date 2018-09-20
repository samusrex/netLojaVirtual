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
    public class GamesController : Controller
    {
        ProdutoRepositorio db = new ProdutoRepositorio();

        // GET: Games
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

        // GET: Games/Details/5
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

        // GET: Games/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdutoId,Nome,Fabricante,Descricao,Valor,Quantidade,Imagem,Setor,CatgGame")] Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                jogo.Setor = Produto.Categoria.GAMES;
                db.Adicione(jogo);
                db.Registre();

                TempData["Success"] = true;

                return RedirectToAction("Index");
            }

            return View(jogo);
        }

        // GET: Games/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Games/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Jogo jogo)
        {
            if (ModelState.IsValid)
            {
                db.Atualize(jogo);
                db.Registre();
                return RedirectToAction("Index");
            }
            return View(jogo);
        }

        // GET: Games/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Games/Delete/5
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
