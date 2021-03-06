using System;
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
            
            if (query == null)
            {
               return db.Fetch<Contato>("Select * FROM contatosbandre");
            } 
            else
            {
               return db.Fetch<Contato>("Select * FROM contatosbandre WHERE nome like '%' + @query + '%' or cpf like '%' + @query + '%' or estadoid = @query", new { query });
            }
        }

        public void Insert(Contato novoContato)
        {
            Database db = new PetaPoco.Database("PRWDEV");
            db.Insert("contatosbandre", "ID", novoContato);
        }

        public Contato Find(int id)
        {
            Database db = new PetaPoco.Database("PRWDEV");
            var contato = db.First<Contato>("Select * from contatosbandre where ID=@0", id);

            return contato;
        }

        public void Update(Contato contato)
        {
            Database db = new PetaPoco.Database("PRWDEV");
            db.Update("contatosbandre", "ID", contato);
        }

        public void Delete(Contato contato)
        {
            Database db = new PetaPoco.Database("PRWDEV");
            db.Delete("contatosbandre", "ID", contato);
        }

    }
}