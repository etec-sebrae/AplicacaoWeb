using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWeb.Controllers
{
    public class ProdutoController : Controller
    {
        public String Index()
        {
            return "Teste Controller produto";
        }

        public IActionResult Abrir()
        {
            return View();
        }

        public String Adicionar(String nomeProduto,String tipoProduto)
        {

            //Chamar o banco para salvar o dado na base.

            return "Produto " + nomeProduto + " adicionado com sucesso!";
        }
    }
}
