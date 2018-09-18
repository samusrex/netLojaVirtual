using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacao.Apresentacao.ViewModel
{
    public class ProdutoEscolhaViewModel
    {
        public int Escolha { get; set; }
        public SelectList CategoriasDoProduto;
    }
}