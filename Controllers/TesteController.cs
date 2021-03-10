using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto1TU.Models;
using Projeto1TU.Service;

namespace Projeto1TU.Controllers
{
    public class TesteController : Controller
    {

        public ActionResult Index(string query = null)
        {
            var tela = new TesteViewModel();
            var testeService = new TesteService();
            tela.ListaTeste = testeService.PesquisaAll(query);
            tela.Titulo = "Teste Bruna";
            return View(tela);
        }
    }
}