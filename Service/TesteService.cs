using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto1TU.Models;
using Projeto1TU.Data;

namespace Projeto1TU.Service
{
    public class TesteService
    {
        public IList<Teste> PesquisaAll(string query)
        {
            var result = new TesteRepository();
            return result.PesquisaAll(query);
        }
    }
}