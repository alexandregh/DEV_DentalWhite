using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dental_White.DAL.Entity.Dentista;

namespace Dental_White.DAL.Entity.Telefone
{
    public class EntityTelefone
    {
        public int IdTelefone { get; set; }
        public string TipoTelefone { get; set; }
        public string Operadora { get; set; }
        public Int16 DDD { get; set; }
        public Int32 Numero { get; set; }
        public int IdDentista { get; set; }
    }
}