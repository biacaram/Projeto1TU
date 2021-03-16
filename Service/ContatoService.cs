using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto1TU.Models;
using Projeto1TU.Data;

namespace Projeto1TU.Service
{
    public class ContatoService
    {
        public IList<Contato> PesquisaAll(string query)
        {
            var result = new ContatoRepository();
            return result.PesquisaAll(query);
        }

        public void Insert(Contato novoContato)
        {
            var result = new ContatoRepository();
            result.Insert(novoContato);
        }

        public void Update(Contato contato)
        {
            var result = new ContatoRepository();
            result.Update(contato);
        }
    }
}