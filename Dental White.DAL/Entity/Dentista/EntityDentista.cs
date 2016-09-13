using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dental_White.DAL.Entity.Telefone;
using Dental_White.DAL.Entity.Sexo;
using Dental_White.DAL.Entity.EstadoCivil;
using Dental_White.DAL.Entity.RG;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Entity.Setor;

namespace Dental_White.DAL.Entity.Dentista
{
    public class EntityDentista
    {
        public int IdDentista { get; set; }
        public int CPF { get; set; }
        public EntityRG RG { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public EntityTelefone Telefone { get; set; }
        public EnumSexo Sexo { get; set; }
        public EnumEstadoCivil EstadoCivil { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal SalarioLiquido { get; set; }
        public string CRO { get; set; }
        public float HorasTrabalhadas { get; set; }
        public int IdAssistente { get; set; }
        public EntityEndereco Endereco { get; set; }

    }
}