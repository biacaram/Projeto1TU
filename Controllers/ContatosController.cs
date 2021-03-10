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

        //static IList<Student> studentList = new List<Student>{
        //        new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
        //        new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
        //        new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
        //        new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
        //        new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
        //        new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
        //        new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
        //    };

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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int id)
        {
            //var cnt = ListaContato.Where(c => c.ID == id).FirstOrDefault();
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
