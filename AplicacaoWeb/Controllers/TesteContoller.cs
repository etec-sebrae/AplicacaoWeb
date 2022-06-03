using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWeb.Controllers
{
    public class TesteController : Controller
    {
        public string HomeIndex()
        {
            return "Teste HomeIndex controller";
        }

        public IActionResult Abrir()
        {
            return View();
        }

        
    }
}
