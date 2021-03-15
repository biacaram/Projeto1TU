using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto1TU.Models;
using Projeto1TU.Service;

namespace Projeto1TU.Controllers
{
    public class ContatosController : Controller
    {

        public IList<Contato> ListaContato = new List<Contato>{
                new Contato(){  ID = 1,
                                Nome = "Beatriz",
                                Apelido = "Bia",
                                Cpf = "99999999600",
                                Sexo = "F",
                                Telefone = "31999231447",
                                Email = "biacaram@hotmail.com",
                                Cep = "30170081",
                                Endereco = "Rua Santa Catarina",
                                Numero = "1447",
                                Complemento = "701",
                                Bairro = "Lourdes",
                                Cidade = "BH",
                                EstadoID = "1",
                                Ativo = true
                              },
            };

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
            return View();
        }

        // GET: Contatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        [HttpPost]
        public ActionResult Create(ContatoViewModel model)
        {
            if (ModelState.IsValid)
            {
                //db.ListaContato.Add(contato);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int id)
        {
            // var cnt = contatoList.Where(c => c.ID == id).FirstOrDefault();
            return View(/*cnt*/);
        }

        // POST: Contatos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Contatos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
