using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto1TU.Models;
using PetaPoco;

namespace Projeto1TU.Data
{
    public class TesteRepository
    {
        public IList<Teste> PesquisaAll(string query)
        {
            var db = new Database("PRWDEV");
            var result = db.Fetch<Teste>("Select Nome = nome FROM brunateste WHERE nome = '%@query%'", new { query });

            return result;
        }
    }
}