﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto1TU.Models;
using PetaPoco;

namespace Projeto1TU.Data
{
    public class ContatoRepository
    {
        public IList<Contato> PesquisaAll(string query)
        {
            Database db = new PetaPoco.Database("PRWDEV");
            var result = db.Fetch<Contato>("Select Nome = nome FROM contatosbandre WHERE nome = '%@query%'", new { query });

            return result;
        }
    }
}