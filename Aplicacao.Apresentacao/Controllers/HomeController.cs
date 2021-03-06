﻿using Aplicacao.Apresentacao.ViewModel;
using Aplicacao.Dados.Repository;
using Aplicacao.Loja.Loja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacao.Apresentacao.Controllers
{
    public class HomeController : Controller
    {
        ProdutoRepositorio db = new ProdutoRepositorio();
        public ActionResult Index()
        {
         return View(db.ObterTodos().ToList().OrderBy(s=>s.Setor));
        }

        

        [HttpGet]
        public ActionResult Escolher()
        {
            var tipo = new Dictionary<int, string>();
            foreach (var item in Enum.GetValues(typeof(Produto.Categoria)))
            {
                tipo.Add((int)item, item.ToString());

            }

            var pev = new ProdutoEscolhaViewModel()
            {
                CategoriasDoProduto = new SelectList(tipo, "Key", "Value")
            };

            return View(pev);
        }

        [HttpPost]
        public ActionResult Escolher(ProdutoEscolhaViewModel p)
        {
            if (p.Escolha == 0)
            {
                return RedirectToAction("Create", "Eletronicos");
            }
            else if (p.Escolha == 1)
            {
                return RedirectToAction("Create", "Games");
            }
            else if (p.Escolha == 2)
            {
                return RedirectToAction("Create", "Computadores");
            }
            else
            {
                return View("Index");
            }
        }

    }
}