using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dental_White.DAL.Entity.Exame
{
    public class EntityExame
    {
        public int IdExame { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataRealizacao { get; set; }
        public DateTime DataValidade { get; set; }
        public int IdPaciente { get; set; }
        public int IdDependente { get; set; }
    }
}