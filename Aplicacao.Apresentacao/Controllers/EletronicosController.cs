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
using Aplicacao.Apresentacao.ViewModel;

namespace Aplicacao.Apresentacao.Controllers
{
    public class EletronicosController : Controller
    {
        ProdutoRepositorio db = new ProdutoRepositorio();
        private int Ver { get; set; }
        // GET: Eletronicos
        public ActionResult Index()
        {
            ViewBag.Title = "Loja Virtual";

            var listaEletronicos = new List<Eletronico>();

            foreach (Eletronico item in db.ObterTodos().Where(c => c.Setor == Produto.Categoria.ELETRONICOS))
            {
                listaEletronicos.Add(item);
            }

            return View(listaEletronicos);
        }

        // GET: Eletronicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto eletronicos = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            if (eletronicos == null)
            {
                return HttpNotFound();
            }
            return View(eletronicos);
        }

        // GET: Eletronicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eletronicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdutoId,Modelo,Tamanho,CatgEletron,Nome,Fabricante,Descricao,Valor,Quantidade,Imagem")] Eletronico eletronicos)
        {
            if (ModelState.IsValid)
            {
                eletronicos.Setor = Produto.Categoria.ELETRONICOS;
                // db.Adicione(eletronicos);
                //db.Registre();
                db.RegistreUsandoStoreProcedure(eletronicos);

                TempData["Success"] = true;

                return RedirectToAction("Index");
            }

            return View(eletronicos);
        }

        // GET: Eletronicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto eletronicos = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            if (eletronicos == null)
            {
                return HttpNotFound();
            }
            return View(eletronicos);
        }

        // POST: Eletronicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Eletronico eletronicos)
        {
            if (ModelState.IsValid)
            {
                db.Atualize(eletronicos);
                db.Registre();
                return RedirectToAction("Index");
            }
            return View(eletronicos);
        }

        // GET: Eletronicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto eletronicos = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            if (eletronicos == null)
            {
                return HttpNotFound();
            }
            return View(eletronicos);
        }

        // POST: Eletronicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto eletronicos = db.EncontrePor(c => c.ProdutoId == id).FirstOrDefault();
            db.Remova(eletronicos);
            db.Registre();
            return RedirectToAction("Index");
        }

        [HttpGet, ActionName("Escolher")]

       


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
