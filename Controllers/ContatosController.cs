using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto1TU.Models;
using Projeto1TU.Service;
using PetaPoco;

namespace Projeto1TU.Controllers
{
    public class ContatosController : Controller
    {

        // GET: Contatos
        public ActionResult Index(string query = null)
        {
            var tela = new ContatoViewModel();
            var contatoService = new ContatoService();
            tela.ListaContato = contatoService.PesquisaAll(query);
            tela.Titulo = "Contatos";
            return View(tela);
            
        }

        // GET: Contatos/Details/5
        public ActionResult Details(int id)
        {
            var db = new PetaPoco.Database("PRWDEV");
            var contato = db.Single<Contato>("Select * from contatosbandre where ID=@0", id);
            return View(contato);
        }

        // GET: Contatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        [HttpPost]
        public ActionResult Create(Contato novoContato)
        {
            if (ModelState.IsValid)
            {
                var contatoService = new ContatoService();
                contatoService.Insert(novoContato);
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int id)
        {
            var tela = new ContatoViewModel();
            var contatoService = new ContatoService();
            tela.Cnt = contatoService.Edit(id);
            tela.Titulo = "Editar contato";
            return View(tela);

        }

        // POST: Contatos/Edit/5
        [HttpPost]
        public ActionResult Edit(Contato contato)
        {
            try
            {
                var contatoService = new ContatoService();
                contatoService.Update(contato);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contatos/Delete/5
        public ActionResult Delete(int id)
        {
            var db = new PetaPoco.Database("PRWDEV");
            var contato = db.Single<Contato>("Select * from contatosbandre where ID=@0", id);
            return View(contato);
        }

        // POST: Contatos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var db = new PetaPoco.Database("PRWDEV");
                db.Delete<Contato>(id);
                db.Save("contatosbandre", "ID", db);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
