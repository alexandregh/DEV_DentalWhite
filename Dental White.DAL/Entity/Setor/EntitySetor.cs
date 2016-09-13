using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dental_White.DAL.Entity.Dentista;

namespace Dental_White.DAL.Entity.Setor
{
    public class EntitySetor
    {
        public int IdSetor { get; set; }
        public int Sigla { get; set; }
        public string Nome { get; set; }
        public DateTime DataGerencia { get; set; }

        //public EntityDentista IdDentistaGerente { get; set; }
        public int IdDentistaGerente { get; set; }
    }
}