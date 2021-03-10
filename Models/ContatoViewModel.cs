using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto1TU.Models
{
    public class ContatoViewModel
    {
        public IList<Contato> ListaContato { get; set; }
        public string Titulo { get; set; }
    }
}