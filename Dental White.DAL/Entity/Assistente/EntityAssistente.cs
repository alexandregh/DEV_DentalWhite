using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dental_White.DAL.Entity.RG;

namespace Dental_White.DAL.Entity.Assistente
{
    public class EntityAssistente
    {
        public int IdAssistente { get; set; }
        public int CPF { get; set; }
        public EntityRG RG { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal SalarioLiquido { get; set; }
        public float HorasTrabalhadas { get; set; }
    }
}